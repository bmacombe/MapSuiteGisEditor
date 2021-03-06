/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    public class ImagePathToImageSourceConverter : ValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string valueStr = value as string;
            if (valueStr != null)
            {
                Stream ms = new MemoryStream();
                if (valueStr.StartsWith("pack://"))
                {
                    var streamInfo = Application.GetResourceStream(new Uri(valueStr, UriKind.RelativeOrAbsolute));
                    ms = streamInfo.Stream;
                }
                else
                {
                    using (Bitmap bitmap = new Bitmap(valueStr))
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                    }
                }
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();
                return bitmapImage;
            }
            return null;
        }
    }
}