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


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.586
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThinkGeo.MapSuite.GisEditor.Plugins.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class COGOExceptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal COGOExceptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThinkGeo.MapSuite.GisEditor.Plugins.Properties.COGOExceptions", typeof(COGOExceptions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The angle distance record in traverse file is not defined a correct format, please using the format like &quot;AD 10 100&quot; which means &quot;angle distance with 10 degree of offset and 100 unit of length&quot;.
        /// </summary>
        internal static string AngleDistanceCogoFileRecordIsValid {
            get {
                return ResourceManager.GetString("AngleDistanceCogoFileRecordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The angle format is not valid.
        /// </summary>
        internal static string AngleFormatUnknown {
            get {
                return ResourceManager.GetString("AngleFormatUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The arc and chord length cannot make a curve, make sure both of them are more than 0 and the arc length must longer than chord length..
        /// </summary>
        internal static string ArcAndChordLengthISValid {
            get {
                return ResourceManager.GetString("ArcAndChordLengthISValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arc length should be longer than chord length..
        /// </summary>
        internal static string ArcChordInvalid {
            get {
                return ResourceManager.GetString("ArcChordInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chord length should be shorter than twice of radius length..
        /// </summary>
        internal static string ChordRadiusInvalid {
            get {
                return ResourceManager.GetString("ChordRadiusInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The degree value is not valid, it must between 0.00 and 90.00 in the quadrant bearing and decimal degree.
        /// </summary>
        internal static string DegreeIsValidQuadrantBearing {
            get {
                return ResourceManager.GetString("DegreeIsValidQuadrantBearing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Degrees should be between 0.00 and 90.00.
        /// </summary>
        internal static string DegreesValueInValid {
            get {
                return ResourceManager.GetString("DegreesValueInValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The direction distance record in traverse file is not defined a correct format, please using the format like &quot;DD 10 100&quot; which means &quot;direction distance with 10 degree of offset and 100 unit of length.&quot;..
        /// </summary>
        internal static string DirectionDistanceCogoFileRecordIsValid {
            get {
                return ResourceManager.GetString("DirectionDistanceCogoFileRecordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start or end direction is invalid, make sure the quadrant bearing direction string is correct..
        /// </summary>
        internal static string DirectionIsValid {
            get {
                return ResourceManager.GetString("DirectionIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid direction value..
        /// </summary>
        internal static string DirectionParameterIsInValid {
            get {
                return ResourceManager.GetString("DirectionParameterIsInValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The direction type is invalid..
        /// </summary>
        internal static string DirectionTypeInvalid {
            get {
                return ResourceManager.GetString("DirectionTypeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The direction unit is invalid..
        /// </summary>
        internal static string DirectionUnitInvalid {
            get {
                return ResourceManager.GetString("DirectionUnitInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This value shouldn&apos;t be negative..
        /// </summary>
        internal static string DoubleIsNegative {
            get {
                return ResourceManager.GetString("DoubleIsNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of double cannot be NaN or Infinity..
        /// </summary>
        internal static string DoubleIsValid {
            get {
                return ResourceManager.GetString("DoubleIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid decimal degree number, decimal degrees must between 0.00 and 360.00..
        /// </summary>
        internal static string DoubleIsValidDecimalDegreeValue {
            get {
                return ResourceManager.GetString("DoubleIsValidDecimalDegreeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The line shape must have at least one vertex..
        /// </summary>
        internal static string LineShapeHasAtLeastOneVertex {
            get {
                return ResourceManager.GetString("LineShapeHasAtLeastOneVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The line shape must have at least two vertices..
        /// </summary>
        internal static string LineShapeIsValid {
            get {
                return ResourceManager.GetString("LineShapeIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter two items..
        /// </summary>
        internal static string NecessaryParametersNumberNotEnough {
            get {
                return ResourceManager.GetString("NecessaryParametersNumberNotEnough", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The non-tangent curve record in traverse file is not defined a correct format, please using the format like &quot;NC D 10 R 100 C 20 L&quot; which means &quot;non-tangent curve with 10 degree to the right of center angle, 100 unit of radius length, 20 degree of chord offset and curve to the left&quot;..
        /// </summary>
        internal static string NonTangentCurveCogoFileRecordIsValid {
            get {
                return ResourceManager.GetString("NonTangentCurveCogoFileRecordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The opacity is not valid, it must be between 0.0 and 1.0..
        /// </summary>
        internal static string OpacityIsValid {
            get {
                return ResourceManager.GetString("OpacityIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string cannot be empty or null..
        /// </summary>
        internal static string ParameterIsNotEmpty {
            get {
                return ResourceManager.GetString("ParameterIsNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object cannot be null..
        /// </summary>
        internal static string ParameterIsNotNull {
            get {
                return ResourceManager.GetString("ParameterIsNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The point record in traverse file is not defined a correct format, please using the format like &quot;SP 10 10&quot; or &quot;XY 10 10&quot; which means &quot;point with position of 10,10&quot;..
        /// </summary>
        internal static string PointCogoFileRecordIsValid {
            get {
                return ResourceManager.GetString("PointCogoFileRecordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string cannot be converted to a number, make sure it&apos;s a valid number string..
        /// </summary>
        internal static string StringCanConvertToDouble {
            get {
                return ResourceManager.GetString("StringCanConvertToDouble", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid decimal degree number, decimal degrees must between 0.00 and 360.00..
        /// </summary>
        internal static string StringIsValidDecimalDegreeValue {
            get {
                return ResourceManager.GetString("StringIsValidDecimalDegreeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The tangent curve record in traverse file is not defined a correct format, please using the format like &quot;TC D 10 R 100 L&quot; which means &quot;tangent curve&quot; with 10 degree to the right of center angle, 100 unit of radius length and curve to the left..
        /// </summary>
        internal static string TangentCurveCogoFileRecordIsValid {
            get {
                return ResourceManager.GetString("TangentCurveCogoFileRecordIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cogo direction unit is not valid..
        /// </summary>
        internal static string ValueCanNotEqualDecimalDegree {
            get {
                return ResourceManager.GetString("ValueCanNotEqualDecimalDegree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cogo direction unit is not valid..
        /// </summary>
        internal static string ValueCanNotEqualDMS {
            get {
                return ResourceManager.GetString("ValueCanNotEqualDMS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cogo direction unit is not valid..
        /// </summary>
        internal static string ValueCanNotEqualGradians {
            get {
                return ResourceManager.GetString("ValueCanNotEqualGradians", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cogo direction unit is not valid..
        /// </summary>
        internal static string ValueCanNotEqualRadians {
            get {
                return ResourceManager.GetString("ValueCanNotEqualRadians", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cogo direction unit is not valid..
        /// </summary>
        internal static string ValueIsCanNotEqualPolar {
            get {
                return ResourceManager.GetString("ValueIsCanNotEqualPolar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid degree or minute or second, the value must between 0 and 60..
        /// </summary>
        internal static string ValueIsValidDegreeOrMinuteOrSecond {
            get {
                return ResourceManager.GetString("ValueIsValidDegreeOrMinuteOrSecond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The map unit is not valid, it must be Decimal Degrees, Feet or Meters..
        /// </summary>
        internal static string ValueIsValidForSpecificedUnit {
            get {
                return ResourceManager.GetString("ValueIsValidForSpecificedUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid latitude for decimal degrees, the latitude must between -90.00 and 90.00..
        /// </summary>
        internal static string ValueIsValidLatitudeForDecimalDegreeUnit {
            get {
                return ResourceManager.GetString("ValueIsValidLatitudeForDecimalDegreeUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid longitude for decimal degrees, the longitude must between -180.00 and 180.00..
        /// </summary>
        internal static string ValueIsValidlongitudeForDecimalDegreeUnit {
            get {
                return ResourceManager.GetString("ValueIsValidlongitudeForDecimalDegreeUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The vertex count is not valid, it must be greater than 0..
        /// </summary>
        internal static string VertexCountIsValid {
            get {
                return ResourceManager.GetString("VertexCountIsValid", resourceCulture);
            }
        }
    }
}