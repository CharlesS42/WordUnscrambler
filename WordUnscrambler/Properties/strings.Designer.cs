﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordUnscrambler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WordUnscrambler.Properties.strings", typeof(strings).Assembly);
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
        ///   Looks up a localized string similar to The program will be terminated..
        /// </summary>
        internal static string CatchError {
            get {
                return ResourceManager.GetString("CatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Those are words that match:.
        /// </summary>
        internal static string DisplayMatchedWords {
            get {
                return ResourceManager.GetString("DisplayMatchedWords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is empty.
        /// </summary>
        internal static string EmptyString {
            get {
                return ResourceManager.GetString("EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you. The program is terminated..
        /// </summary>
        internal static string FinishedProgram {
            get {
                return ResourceManager.GetString("FinishedProgram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter scrambled word(s) manually or as a file: F - file / M - manual.
        /// </summary>
        internal static string FormatRequest {
            get {
                return ResourceManager.GetString("FormatRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter language of the program: E - english / F - français.
        /// </summary>
        internal static string LanguageIntro {
            get {
                return ResourceManager.GetString("LanguageIntro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter word(s) manually (separated by commas if multiple) in one line:.
        /// </summary>
        internal static string ManualRequest {
            get {
                return ResourceManager.GetString("ManualRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter full path including the file name: .
        /// </summary>
        internal static string PathRequest {
            get {
                return ResourceManager.GetString("PathRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to continue? Y/N.
        /// </summary>
        internal static string RepeatRequest {
            get {
                return ResourceManager.GetString("RepeatRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entered option was not recognized..
        /// </summary>
        internal static string WrongFormat {
            get {
                return ResourceManager.GetString("WrongFormat", resourceCulture);
            }
        }
    }
}
