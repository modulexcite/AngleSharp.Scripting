﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AngleSharp.Scripting.JavaScript.Generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ClassPrototype : ClassPrototypeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 5 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using ");
            
            #line 7 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\n    using Jint;\r\n    using Jint.Native;\r\n    using Jint.Native.Object;\r\n    us" +
                    "ing Jint.Runtime;\r\n    using Jint.Runtime.Descriptors;\r\n    using Jint.Runtime.I" +
                    "nterop;\r\n    using System;\r\n\r\n    sealed partial class ");
            
            #line 16 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype : ");
            
            #line 16 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance\r\n    {\r\n        public ");
            
            #line 18 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype(Engine engine)\r\n            : base(engine)\r\n        {\r\n        }\r\n\r\n   " +
                    "     public static ");
            
            #line 23 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype CreatePrototypeObject(EngineInstance engine, ");
            
            #line 23 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Constructor constructor)\r\n        {\r\n            var obj = new ");
            
            #line 25 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Prototype(engine.Jint)\r\n            {\r\n                Prototype = ");
            
            #line 27 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Prototype));
            
            #line default
            #line hidden
            this.Write(",\r\n                Extensible = true,\r\n            };\r\n            obj.FastAddPro" +
                    "perty(\"constructor\", constructor, true, false, true);\r\n            return obj;\r\n" +
                    "        }\r\n\r\n        public void Configure");
            
            #line 34 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            FastAddProperty(\"toString\", Engine.Wrap(ToString), tru" +
                    "e, true, true);\r\n");
            
            #line 37 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var method in Model.Methods) { 
            
            #line default
            #line hidden
            this.Write("            FastAddProperty(\"");
            
            #line 38 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(");
            
            #line 38 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("), true, true, true);\r\n");
            
            #line 39 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 40 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var property in Model.Properties) { 
            
            #line default
            #line hidden
            this.Write("            FastSetProperty(\"");
            
            #line 41 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(");
            
            #line 41 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.RefName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 41 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.RefName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 42 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 43 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var evt in Model.Events) { 
            
            #line default
            #line hidden
            this.Write("            FastSetProperty(\"");
            
            #line 44 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\", Engine.Wrap(Get");
            
            #line 44 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write(", Set");
            
            #line 44 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 45 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 47 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var method in Model.Methods.Distinct()) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ");
            
            #line 49 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue[] arguments)\r\n        {\r\n            var reference = th" +
                    "isObj.TryCast<");
            
            #line 51 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 51 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 52 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var parameter in method.Parameters) { 
            
            #line default
            #line hidden
            this.Write("            var ");
            
            #line 53 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 53 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Converter));
            
            #line default
            #line hidden
            this.Write("(arguments.At(");
            
            #line 53 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Index));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 54 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 55 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (method.IsVoid) { 
            
            #line default
            #line hidden
            this.Write("            reference.");
            
            #line 56 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 56 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Parameters.Stringify()));
            
            #line default
            #line hidden
            this.Write(");\r\n            return JsValue.Undefined;\r\n");
            
            #line 58 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            return Engine.Select(reference.");
            
            #line 59 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 59 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Parameters.Stringify()));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 60 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 62 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 63 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var property in Model.Properties.Distinct()) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ");
            
            #line 65 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj)\r\n        {\r\n");
            
            #line 67 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (property.Getter.IsVoid) { 
            
            #line default
            #line hidden
            this.Write("            return JsValue.Undefined;\r\n");
            
            #line 69 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            var reference = thisObj.TryCast<");
            
            #line 70 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 70 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalName));
            
            #line default
            #line hidden
            this.Write(";\r\n            return Engine.Select(reference.");
            
            #line 71 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Getter.OriginalName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 72 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        void ");
            
            #line 75 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue argument)\r\n        {\r\n");
            
            #line 77 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 if (!property.Setter.IsVoid) { 
            
            #line default
            #line hidden
            
            #line 78 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 var parameter = property.Setter.Parameters.First(); 
            
            #line default
            #line hidden
            this.Write("            var reference = thisObj.TryCast<");
            
            #line 79 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail).Ref");
            
            #line 79 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalName));
            
            #line default
            #line hidden
            this.Write(";\r\n            var ");
            
            #line 80 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 80 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Converter));
            
            #line default
            #line hidden
            this.Write("(argument);\r\n            reference.");
            
            #line 81 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Setter.OriginalName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 81 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 82 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 84 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            
            #line 85 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 foreach (var evt in Model.Events.Distinct()) { 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue Get");
            
            #line 87 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj)\r\n        {\r\n            var instance = thisObj.TryCast<");
            
            #line 89 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail);\r\n            return instance.Get(\"");
            
            #line 90 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n        }\r\n\r\n        void Set");
            
            #line 93 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(JsValue thisObj, JsValue argument)\r\n        {\r\n            var instance = thisOb" +
                    "j.TryCast<");
            
            #line 95 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance>(Fail);\r\n            var reference = instance.Ref");
            
            #line 96 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalName));
            
            #line default
            #line hidden
            this.Write(";\r\n            var existing = Get");
            
            #line 97 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.RefName));
            
            #line default
            #line hidden
            this.Write("(thisObj);\r\n\r\n            if (existing != JsValue.Undefined)\r\n            {\r\n    " +
                    "            var method = ");
            
            #line 101 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Converter));
            
            #line default
            #line hidden
            this.Write("(existing);\r\n                reference.");
            
            #line 102 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.OriginalName));
            
            #line default
            #line hidden
            this.Write(" -= method;\r\n            }\r\n\r\n            instance.Put(\"");
            
            #line 105 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\", argument, false);\r\n\r\n            if (argument != JsValue.Undefined)\r\n         " +
                    "   {\r\n                var method = ");
            
            #line 109 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Converter));
            
            #line default
            #line hidden
            this.Write("(argument);\r\n                reference.");
            
            #line 110 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.OriginalName));
            
            #line default
            #line hidden
            this.Write(" += method;\r\n            }\r\n        }\r\n");
            
            #line 113 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        JsValue ToString(JsValue thisObj, JsValue[] arguments)\r\n        {\r\n    " +
                    "        return \"[object ");
            
            #line 117 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassPrototype.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("]\";\r\n        }\r\n\r\n        void Fail(JsValue obsolete)\r\n        {\r\n            thr" +
                    "ow new JavaScriptException(Engine.TypeError);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class ClassPrototypeBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
