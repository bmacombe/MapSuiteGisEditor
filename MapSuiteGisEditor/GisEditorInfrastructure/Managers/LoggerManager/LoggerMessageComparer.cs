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
using System.Collections.Generic;

namespace ThinkGeo.MapSuite.GisEditor
{
    [Serializable]
    internal class LoggerMessageComparer : IEqualityComparer<LoggerMessage>
    {
        public bool Equals(LoggerMessage messageX, LoggerMessage messageY)
        {
            if (Object.ReferenceEquals(messageX, null) || Object.ReferenceEquals(messageY, null))
                return false;
            return messageX.LoggerLevel.ToString() == messageY.LoggerLevel.ToString()
                && messageX.Message == messageY.Message
                && messageX.Error.Source == messageY.Error.Source
                && messageX.Error.StackTrace == messageY.Error.StackTrace;
        }

        public int GetHashCode(LoggerMessage loggerMessage)
        {
            if (Object.ReferenceEquals(loggerMessage, null))
                return 0;

            return loggerMessage.Message.GetHashCode();
        }
    }
}