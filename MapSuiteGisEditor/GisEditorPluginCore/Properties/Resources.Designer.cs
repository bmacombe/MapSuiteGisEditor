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
//     Runtime Version:4.0.30319.42000
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThinkGeo.MapSuite.GisEditor.Plugins.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to //The code below shows how to write C# Script for MapSuite Explorer
        /////You can use &quot;map&quot; to access the WpfMap control
        ///using System;
        ///using System.Windows.Forms;
        ///using ThinkGeo.MapSuite.WpfDesktop;
        ///
        ///public class Script
        ///{
        ///    public static void ScriptMain(WpfMap map)
        ///    {
        ///        int count = 0;
        ///
        ///        Timer timer = new Timer();
        ///        timer.Interval = 600;
        ///        timer.Tick += (object sender, EventArgs e) =&gt;
        ///        {
        ///            count++;
        ///            if (count == 12)
        ///            {
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string sampleCSharpCode {
            get {
                return ResourceManager.GetString("sampleCSharpCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #The code below shows how to write Python Script for MapSuite Explorer
        ///#You can use &quot;Map&quot; to access the WpfMap control
        ///import clr
        ///clr.AddReference(&apos;System.Windows.Forms&apos;)
        ///from System.Windows.Forms import *
        ///
        ///count=0
        ///
        ///def timer_Tick(*args):
        ///	global count
        ///	count+=1
        ///	if count==12:
        ///		timer.Stop()
        ///		
        ///	if count%2==0:
        ///		Map.ZoomIn()
        ///	else:
        ///		Map.ZoomOut()
        ///
        ///timer=Timer()
        ///timer.Tick+=timer_Tick
        ///timer.Interval=600
        ///timer.Start().
        /// </summary>
        internal static string samplePythonCode {
            get {
                return ResourceManager.GetString("samplePythonCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #The code below shows how to write Ruby Script for MapSuite Explorer
        ///#You can use &quot;Map&quot; to access the WpfMap control
        ///
        ///load_assembly(&quot;System.Windows.Forms&quot;)
        ///
        ///count=0
        ///
        ///timer=System::Windows::Forms::Timer.new
        ///timer.Interval=600
        ///
        ///timer.Tick do |sender,e|
        ///	count+=1
        ///	if count==12
        ///		timer.Stop
        ///	end
        ///	
        ///	if count%2==0
        ///		Map.ZoomIn
        ///	else
        ///		Map.ZoomOut
        ///	end
        ///end
        ///
        ///timer.Start.
        /// </summary>
        internal static string sampleRubyCode {
            get {
                return ResourceManager.GetString("sampleRubyCode", resourceCulture);
            }
        }
    }
}