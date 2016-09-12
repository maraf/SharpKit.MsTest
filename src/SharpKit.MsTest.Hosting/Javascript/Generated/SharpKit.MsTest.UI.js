/* Generated by SharpKit 5 v5.4.4 */
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var SharpKit$MsTest$Metadata$TestAssemblyModel = {
    fullname: "SharpKit.MsTest.Metadata.TestAssemblyModel",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (name){
            this.classes = null;
            this._Name = null;
            System.Object.ctor.call(this);
            this.set_Name(name);
            this.classes = new System.Collections.Generic.List$1.ctor(SharpKit.MsTest.Metadata.TestClassModel.ctor);
        },
        Name$$: "System.String",
        get_Name: function (){
            return this._Name;
        },
        set_Name: function (value){
            this._Name = value;
        },
        Classes$$: "System.Collections.Generic.IReadOnlyList`1[[SharpKit.MsTest.Metadata.TestClassModel]]",
        get_Classes: function (){
            return this.classes;
        },
        AddClass: function (type){
            if (type == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("type"), new Error());
            this.classes.Add(type);
            return this;
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["System.String"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Metadata$TestAssemblyModel);
var SharpKit$MsTest$UI$CategoryView = {
    fullname: "SharpKit.MsTest.UI.CategoryView",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    },
    ctors: [{
        name: "ctor",
        parameters: []
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$CategoryView);
var SharpKit$MsTest$UI$ClassView = {
    fullname: "SharpKit.MsTest.UI.ClassView",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (root){
            this.root = null;
            this.methods = null;
            System.Object.ctor.call(this);
            this.root = root;
            this.methods = new System.Collections.Generic.List$1.ctor(SharpKit.MsTest.UI.MethodView.ctor);
        },
        Render: function (classes){
            var html = new System.Text.StringBuilder.ctor();
            var $it1 = classes.GetEnumerator();
            while ($it1.MoveNext()){
                var type = $it1.get_Current();
                html.AppendFormat$$String$$Object("<div class=\'{0}\'>", "mst-group");
                html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\'>{1}</div>", "mst-header", type.get_Type().get_Name());
                var $it2 = type.get_Methods().GetEnumerator();
                while ($it2.MoveNext()){
                    var method = $it2.get_Current();
                    var view = new SharpKit.MsTest.UI.MethodView.ctor(method);
                    view.Render(html);
                }
                html.Append$$String("</div>");
            }
            this.root.html(html.toString());
            var $it3 = this.methods.GetEnumerator();
            while ($it3.MoveNext()){
                var view = $it3.get_Current();
                view.Bind(this.root);
            }
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.jQuery.jQuery"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$ClassView);
var SharpKit$MsTest$UI$ClassView$CssClass = {
    fullname: "SharpKit.MsTest.UI.ClassView.CssClass",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.MsTest.UI.ClassView.CssClass.Group = "mst-group";
            SharpKit.MsTest.UI.ClassView.CssClass.Header = "mst-header";
        }
    },
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    },
    ctors: [],
    IsAbstract: true
};
JsTypes.push(SharpKit$MsTest$UI$ClassView$CssClass);
var SharpKit$MsTest$UI$MainView = {
    fullname: "SharpKit.MsTest.UI.MainView",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (root){
            this.root = null;
            System.Object.ctor.call(this);
            this.root = root;
        },
        Render: function (){
            var html = new System.Text.StringBuilder.ctor();
            html.AppendFormat$$String$$Object("<div class=\'{0}\'>", "mst-container");
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-controls");
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-content");
            html.Append$$String("</div>");
            this.root.html(html.toString());
        },
        GetControls: function (){
            return this.root.find(".mst-controls");
        },
        GetContent: function (){
            return this.root.find(".mst-content");
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.jQuery.jQuery"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$MainView);
var SharpKit$MsTest$UI$MainView$CssClass = {
    fullname: "SharpKit.MsTest.UI.MainView.CssClass",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.MsTest.UI.MainView.CssClass.Container = "mst-container";
            SharpKit.MsTest.UI.MainView.CssClass.Controls = "mst-controls";
            SharpKit.MsTest.UI.MainView.CssClass.Content = "mst-content";
        }
    },
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    },
    ctors: [],
    IsAbstract: true
};
JsTypes.push(SharpKit$MsTest$UI$MainView$CssClass);
var SharpKit$MsTest$Metadata$TestCaseProvider = {
    fullname: "SharpKit.MsTest.Metadata.TestCaseProvider",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        },
        Load: function (){
            var types = new System.Collections.Generic.List$1.ctor(System.Type.ctor);
            var typesRaw = this.GetClasses();
            for (var typeName in typesRaw){
                var type = typesRaw[typeName]._ClrType;
                try{
                    var attribute = System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1(Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute.ctor, System.Linq.Enumerable.OfType$1(Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute.ctor, type.GetCustomAttributes$$Boolean(true)));
                    if (attribute != null)
                        types.Add(type);
                }
                catch($$e1){
                }
            }
            var models = this.LoadMetadata(types);
            return models;
        },
        LoadMetadata: function (types){
            var result = new System.Collections.Generic.Dictionary$2.ctor(System.String.ctor, SharpKit.MsTest.Metadata.TestAssemblyModel.ctor);
            var $it4 = types.GetEnumerator();
            while ($it4.MoveNext()){
                var type = $it4.get_Current();
                var assemblyName = type["_JsType"].assemblyName;
                var assembly;
                if (!(function (){
                    var $1 = {
                        Value: assembly
                    };
                    var $res = result.TryGetValue(assemblyName, $1);
                    assembly = $1.Value;
                    return $res;
                }).call(this))
                    result.set_Item$$TKey(assemblyName, assembly = new SharpKit.MsTest.Metadata.TestAssemblyModel.ctor(assemblyName));
                this.LoadClassMetadata(assembly, type);
            }
            return System.Linq.Enumerable.ToList$1(SharpKit.MsTest.Metadata.TestAssemblyModel.ctor, result.get_Values());
        },
        LoadClassMetadata: function (assemblyModel, type){
            var model = new SharpKit.MsTest.Metadata.TestClassModel.ctor(type);
            for (var $i6 = 0,$t6 = type.GetMethods(),$l6 = $t6.length,method = $t6[$i6]; $i6 < $l6; $i6++, method = $t6[$i6]){
                var isTestMethod = false;
                var categories = new System.Collections.Generic.List$1.ctor(System.String.ctor);
                var attributes = method.GetCustomAttributes$$Boolean(true);
                for (var $i7 = 0,$l7 = attributes.length,attribute = attributes[$i7]; $i7 < $l7; $i7++, attribute = attributes[$i7]){
                    var categoryAttribute = As(attribute, Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryBaseAttribute.ctor);
                    if (categoryAttribute != null)
                        categories.AddRange(categoryAttribute.get_TestCategories());
                    var methodAttribute = As(attribute, Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute.ctor);
                    if (methodAttribute != null)
                        isTestMethod = true;
                }
                if (isTestMethod){
                    var methodModel = new SharpKit.MsTest.Metadata.TestMethodModel.ctor(assemblyModel.get_Name() + "-" + type.get_FullName() + "-" + method.get_Name(), method, categories);
                    model.AddMethod(methodModel);
                    continue;
                }
            }
            assemblyModel.AddClass(model);
        },
        GetClasses: function (){
            return JsCompiler.Types;
        }
    },
    ctors: [{
        name: "ctor",
        parameters: []
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Metadata$TestCaseProvider);
var SharpKit$MsTest$Metadata$TestCaseProvider$ClrTypeGetter = {
    fullname: "SharpKit.MsTest.Metadata.TestCaseProvider.ClrTypeGetter",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            this._ClrType = null;
            System.Object.ctor.call(this);
        }
    },
    ctors: [{
        name: "ctor",
        parameters: []
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Metadata$TestCaseProvider$ClrTypeGetter);
var SharpKit$MsTest$Metadata$TestMethodModel = {
    fullname: "SharpKit.MsTest.Metadata.TestMethodModel",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (uniqueId, method, categories){
            this._UniqueId = null;
            this._Categories = null;
            this._Method = null;
            System.Object.ctor.call(this);
            this.set_UniqueId(uniqueId);
            this.set_Method(method);
            if (categories == null)
                this.set_Categories(new System.Collections.Generic.List$1.ctor(System.String.ctor));
            else
                this.set_Categories(new System.Collections.Generic.List$1.ctor$$IEnumerable$1(System.String.ctor, categories));
        },
        UniqueId$$: "System.String",
        get_UniqueId: function (){
            return this._UniqueId;
        },
        set_UniqueId: function (value){
            this._UniqueId = value;
        },
        Categories$$: "System.Collections.Generic.IReadOnlyList`1[[System.String]]",
        get_Categories: function (){
            return this._Categories;
        },
        set_Categories: function (value){
            this._Categories = value;
        },
        Method$$: "System.Reflection.MethodInfo",
        get_Method: function (){
            return this._Method;
        },
        set_Method: function (value){
            this._Method = value;
        },
        Before: function (instance){
        },
        After: function (instance){
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["System.String", "System.Reflection.MethodInfo", "System.Collections.Generic.IEnumerable"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Metadata$TestMethodModel);
var SharpKit$MsTest$UI$MethodView = {
    fullname: "SharpKit.MsTest.UI.MethodView",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (model){
            this._Model = null;
            this._IsSelected = false;
            System.Object.ctor.call(this);
            this.set_Model(model);
        },
        Model$$: "SharpKit.MsTest.Metadata.TestMethodModel",
        get_Model: function (){
            return this._Model;
        },
        set_Model: function (value){
            this._Model = value;
        },
        IsSelected$$: "System.Boolean",
        get_IsSelected: function (){
            return this._IsSelected;
        },
        set_IsSelected: function (value){
            this._IsSelected = value;
        },
        Render: function (html){
            html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\' data-method-id=\'{1}\'>", "mst-method-container", this.get_Model().get_UniqueId());
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-method-status");
            html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\'><input id=\'{1}\' type=\'checkbox\' /></div>", "mst-method-selector", this.get_Model().get_UniqueId());
            html.AppendFormat$$String$$Object$$Object$$Object("<div class=\'{0}\'><label for=\'{1}\'>{2}</label></div>", "mst-method-name", this.get_Model().get_UniqueId(), this.get_Model().get_Method().get_Name());
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-method-time");
            html.Append$$String("</div>");
        },
        Bind: function (root){
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.MsTest.Metadata.TestMethodModel"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$MethodView);
var SharpKit$MsTest$UI$MethodView$CssClass = {
    fullname: "SharpKit.MsTest.UI.MethodView.CssClass",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.MsTest.UI.MethodView.CssClass.Container = "mst-method-container";
            SharpKit.MsTest.UI.MethodView.CssClass.Selector = "mst-method-selector";
            SharpKit.MsTest.UI.MethodView.CssClass.Name = "mst-method-name";
            SharpKit.MsTest.UI.MethodView.CssClass.Time = "mst-method-time";
            SharpKit.MsTest.UI.MethodView.CssClass.Status = "mst-method-status";
        }
    },
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    },
    ctors: [],
    IsAbstract: true
};
JsTypes.push(SharpKit$MsTest$UI$MethodView$CssClass);
var SharpKit$MsTest$UI$Presenter = {
    fullname: "SharpKit.MsTest.UI.Presenter",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            this.testClassProvider = new SharpKit.MsTest.Metadata.TestCaseProvider.ctor();
            this.mainView = null;
            System.Object.ctor.call(this);
        },
        Render: function (root){
            var assemblies = this.testClassProvider.Load();
            this.mainView = new SharpKit.MsTest.UI.MainView.ctor(root);
            this.mainView.Render();
            var classes = new System.Collections.Generic.List$1.ctor(SharpKit.MsTest.Metadata.TestClassModel.ctor);
            var $it7 = assemblies.GetEnumerator();
            while ($it7.MoveNext()){
                var assembly = $it7.get_Current();
                classes.AddRange(assembly.get_Classes());
            }
            var content = this.mainView.GetContent();
            var view = new SharpKit.MsTest.UI.ClassView.ctor(content);
            view.Render(classes);
        }
    },
    ctors: [{
        name: "ctor",
        parameters: []
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$Presenter);
var TestRuntime = {
    fullname: "TestRuntime",
    baseTypeName: "System.Object",
    staticDefinition: {
        Start: function (root){
            if (root == null)
                root = $(document.body);
            else
                root = $(root);
            var presenter = new SharpKit.MsTest.UI.Presenter.ctor();
            presenter.Render(root);
            return presenter;
        }
    },
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    },
    ctors: [],
    IsAbstract: true
};
JsTypes.push(TestRuntime);
var SharpKit$MsTest$Metadata$TestClassModel = {
    fullname: "SharpKit.MsTest.Metadata.TestClassModel",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (type){
            this.methods = null;
            this._Type = null;
            System.Object.ctor.call(this);
            if (type == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("type"), new Error());
            this.set_Type(type);
            this.methods = new System.Collections.Generic.List$1.ctor(SharpKit.MsTest.Metadata.TestMethodModel.ctor);
        },
        Type$$: "System.Type",
        get_Type: function (){
            return this._Type;
        },
        set_Type: function (value){
            this._Type = value;
        },
        Methods$$: "System.Collections.Generic.IReadOnlyList`1[[SharpKit.MsTest.Metadata.TestMethodModel]]",
        get_Methods: function (){
            return this.methods;
        },
        AddMethod: function (method){
            if (method == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("method"), new Error());
            this.methods.Add(method);
            return this;
        },
        Before: function (instance){
        },
        After: function (instance){
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["System.Type"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Metadata$TestClassModel);

