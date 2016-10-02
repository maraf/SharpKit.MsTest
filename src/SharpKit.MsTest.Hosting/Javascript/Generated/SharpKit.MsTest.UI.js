/* Generated by SharpKit 5 v5.4.4 */
function $CombineDelegates(del1,del2)
{
    if(del1 == null)
        return del2;
    if(del2 == null)
        return del1;
    var del=$CreateMulticastDelegateFunction();
    del.delegates = [];
    if(del1.isMulticastDelegate)
    {
        for(var i=0;i < del1.delegates.length;i++)
            del.delegates.push(del1.delegates[i]);
    }
    else
    {
        del.delegates.push(del1);
    }
    if(del2.isMulticastDelegate)
    {
        for(var i=0;i < del2.delegates.length;i++)
            del.delegates.push(del2.delegates[i]);
    }
    else
    {
        del.delegates.push(del2);
    }
    return del;
};

function $CreateMulticastDelegateFunction()
{
    var del2 = null;
    
    var del=function()
    {
        var x=undefined;
        for(var i=0;i < del2.delegates.length;i++)
        {
            var del3=del2.delegates[i];
            x = del3.apply(null,arguments);
        }
        return x;
    };
    del.isMulticastDelegate = true;
    del2 = del;   
    
    return del;
};

function $RemoveDelegate(delOriginal,delToRemove)
{
    if(delToRemove == null || delOriginal == null)
        return delOriginal;
    if(delOriginal.isMulticastDelegate)
    {
        if(delToRemove.isMulticastDelegate)
            throw new Error("Multicast to multicast delegate removal is not implemented yet");
        var del=$CreateMulticastDelegateFunction();
        for(var i=0;i < delOriginal.delegates.length;i++)
        {
            var del2=delOriginal.delegates[i];
            if(del2 != delToRemove)
            {
                if(del.delegates == null)
                    del.delegates = [];
                del.delegates.push(del2);
            }
        }
        if(del.delegates == null)
            return null;
        if(del.delegates.length == 1)
            return del.delegates[0];
        return del;
    }
    else
    {
        if(delToRemove.isMulticastDelegate)
            throw new Error("single to multicast delegate removal is not supported");
        if(delOriginal == delToRemove)
            return null;
        return delOriginal;
    }
};

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

if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}

if (typeof ($CreateAnonymousDelegate) == 'undefined') {
    var $CreateAnonymousDelegate = function (target, func) {
        if (target == null || func == null)
            return func;
        var delegate = function () {
            return func.apply(target, arguments);
        };
        delegate.func = func;
        delegate.target = target;
        delegate.isDelegate = true;
        return delegate;
    }
}


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var SharpKit$MsTest$Log = {
    fullname: "SharpKit.MsTest.Log",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (){
            this.InfoAdded = null;
            System.Object.ctor.call(this);
        },
        add_InfoAdded: function (value){
            this.InfoAdded = $CombineDelegates(this.InfoAdded, value);
        },
        remove_InfoAdded: function (value){
            this.InfoAdded = $RemoveDelegate(this.InfoAdded, value);
        },
        Info$$String: function (message){
            if (this.InfoAdded != null)
                this.InfoAdded(message);
        },
        Info$$String$$Object: function (format, parameter1){
            this.Info$$String(System.String.Format$$String$$Object(format, parameter1));
        },
        Info$$String$$Object$$Object: function (format, parameter1, parameter2){
            this.Info$$String(System.String.Format$$String$$Object$$Object(format, parameter1, parameter2));
        }
    },
    ctors: [{
        name: "ctor",
        parameters: []
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$Log);
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
var SharpKit$MsTest$TestExecutor = {
    fullname: "SharpKit.MsTest.TestExecutor",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (log){
            this.log = null;
            System.Object.ctor.call(this);
            this.log = log;
        },
        Run: function (assemblies){
            var $it1 = assemblies.GetEnumerator();
            while ($it1.MoveNext()){
                var assembly = $it1.get_Current();
                this.RunAssembly(assembly);
            }
        },
        RunAssembly: function (assembly){
            this.log.Info$$String$$Object("Starting assembly \'{0}\'.", assembly.get_Name());
            this.InitAssembly(assembly);
            var $it2 = assembly.get_Classes().GetEnumerator();
            while ($it2.MoveNext()){
                var type = $it2.get_Current();
                this.RunClass(type);
            }
            this.log.Info$$String$$Object("Cleaning assembly \'{0}\'.", assembly.get_Name());
            this.CleanAssembly(assembly);
            this.log.Info$$String$$Object("Ending assembly \'{0}\'.", assembly.get_Name());
        },
        InitAssembly: function (assembly){
        },
        CleanAssembly: function (assembly){
        },
        RunClass: function (type){
            this.log.Info$$String$$Object("Starting type \'{0}\'.", type.get_Type().get_Name());
            var instance = this.InitType(type);
            var $it3 = type.get_Methods().GetEnumerator();
            while ($it3.MoveNext()){
                var method = $it3.get_Current();
                this.RunMethod(method, instance);
            }
            this.log.Info$$String$$Object("Cleaning type \'{0}\'.", type.get_Type().get_Name());
            this.CleanType(type, instance);
            this.log.Info$$String$$Object("Ending type \'{0}\'.", type.get_Type().get_Name());
        },
        InitType: function (type){
            return System.Activator.CreateInstance$$Type(type.get_Type());
        },
        CleanType: function (type, instance){
        },
        RunMethod: function (method, instance){
            this.log.Info$$String$$Object("Starting method \'{0}\'.", method.get_Method().get_Name());
            try{
                method.get_Method().Invoke(instance, new Array(0));
            }
            catch(e){
                this.log.Info$$String$$Object("Exception: {0}", e.toString());
            }
            this.log.Info$$String$$Object("Ending method \'{0}\'.", method.get_Method().get_Name());
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.MsTest.Log"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$TestExecutor);
var SharpKit$MsTest$TestExecutor$IMethodInfo = {
    fullname: "SharpKit.MsTest.TestExecutor.IMethodInfo",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Interface",
    ctors: [],
    IsAbstract: true
};
JsTypes.push(SharpKit$MsTest$TestExecutor$IMethodInfo);
var SharpKit$MsTest$UI$ControlView = {
    fullname: "SharpKit.MsTest.UI.ControlView",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.MsTest.UI",
    Kind: "Class",
    definition: {
        ctor: function (root){
            this.root = null;
            this.RunAll = null;
            this.RunSelected = null;
            System.Object.ctor.call(this);
            this.root = root;
        },
        add_RunAll: function (value){
            this.RunAll = $CombineDelegates(this.RunAll, value);
        },
        remove_RunAll: function (value){
            this.RunAll = $RemoveDelegate(this.RunAll, value);
        },
        add_RunSelected: function (value){
            this.RunSelected = $CombineDelegates(this.RunSelected, value);
        },
        remove_RunSelected: function (value){
            this.RunSelected = $RemoveDelegate(this.RunSelected, value);
        },
        RunAllButton$$: "SharpKit.jQuery.jQuery",
        get_RunAllButton: function (){
            return this.root.find(".mst-run-all");
        },
        RunSelectedButton$$: "SharpKit.jQuery.jQuery",
        get_RunSelectedButton: function (){
            return this.root.find(".mst-run-selected");
        },
        Render: function (){
            var html = new System.Text.StringBuilder.ctor();
            html.AppendFormat$$String$$Object("<button class=\'{0}\'>Run selected</button>", "mst-run-selected");
            html.AppendFormat$$String$$Object("<button class=\'{0}\'>Run all</button>", "mst-run-all");
            this.root.html(html.toString());
            this.Bind();
        },
        Bind: function (){
            this.get_RunAllButton().click($CreateDelegate(this, this.OnRunAllClicked));
            this.get_RunSelectedButton().click($CreateDelegate(this, this.OnRunSelectedClicked));
        },
        OnRunAllClicked: function (){
            if (this.RunAll != null)
                this.RunAll();
        },
        OnRunSelectedClicked: function (){
            if (this.RunSelected != null)
                this.RunSelected();
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.jQuery.jQuery"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$ControlView);
var SharpKit$MsTest$UI$ControlView$CssClass = {
    fullname: "SharpKit.MsTest.UI.ControlView.CssClass",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.MsTest.UI.ControlView.CssClass.All = "mst-run-all";
            SharpKit.MsTest.UI.ControlView.CssClass.Selected = "mst-run-selected";
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
JsTypes.push(SharpKit$MsTest$UI$ControlView$CssClass);
var SharpKit$MsTest$UI$GroupView = {
    fullname: "SharpKit.MsTest.UI.GroupView",
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
        MainSelector$$: "SharpKit.jQuery.jQuery",
        get_MainSelector: function (){
            return this.root.find(".mst-group-header").find("input");
        },
        Render: function (classes){
            var html = new System.Text.StringBuilder.ctor();
            var $it4 = classes.GetEnumerator();
            while ($it4.MoveNext()){
                var type = $it4.get_Current();
                html.AppendFormat$$String$$Object("<div class=\'{0}\'>", "mst-group");
                html.AppendFormat$$String$$Object("<div class=\'{0}\'>", "mst-group-header");
                html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-group-status");
                html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\'><input id=\'{1}\' type=\'checkbox\' /></div>", "mst-group-selector", type.get_Type().get_FullName());
                html.AppendFormat$$String$$Object$$Object$$Object("<div class=\'{0}\'><label for=\'{1}\'>{2}</label></div>", "mst-group-name", type.get_Type().get_FullName(), type.get_Type().get_Name());
                html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-group-Time");
                html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "clear");
                html.Append$$String("</div>");
                var $it5 = type.get_Methods().GetEnumerator();
                while ($it5.MoveNext()){
                    var method = $it5.get_Current();
                    var view = new SharpKit.MsTest.UI.MethodView.ctor(type, method);
                    view.Render(html);
                    this.methods.Add(view);
                }
                html.Append$$String("</div>");
            }
            this.root.html(html.toString());
            this.Bind(this.root);
            var $it6 = this.methods.GetEnumerator();
            while ($it6.MoveNext()){
                var view = $it6.get_Current();
                view.Bind(this.root);
            }
        },
        Bind: function (root){
            root.find(".mst-group-header").find("input").change($CreateDelegate(this, this.OnHeaderChanged));
        },
        OnHeaderChanged: function (){
            var $it7 = this.methods.GetEnumerator();
            while ($it7.MoveNext()){
                var view = $it7.get_Current();
                view.set_IsSelected(this.get_MainSelector().is(":checked"));
            }
        },
        GetSelected: function (){
            var result = new System.Collections.Generic.Dictionary$2.ctor(System.String.ctor, SharpKit.MsTest.Metadata.TestAssemblyModel.ctor);
            var $it8 = this.methods.GetEnumerator();
            while ($it8.MoveNext()){
                var view = $it8.get_Current();
                if (view.get_IsSelected()){
                    var assemblyName = view.get_ClassModel().get_Type()["_JsType"].assemblyName;
                    var assemblyModel;
                    if (!(function (){
                        var $1 = {
                            Value: assemblyModel
                        };
                        var $res = result.TryGetValue(view.get_ClassModel().get_Type().get_FullName(), $1);
                        assemblyModel = $1.Value;
                        return $res;
                    }).call(this))
                        result.set_Item$$TKey(view.get_ClassModel().get_Type().get_FullName(), assemblyModel = new SharpKit.MsTest.Metadata.TestAssemblyModel.ctor(assemblyName));
                    var classModel = System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1$$Func$2(SharpKit.MsTest.Metadata.TestClassModel.ctor, assemblyModel.get_Classes(), $CreateAnonymousDelegate(this, function (c){
                        return c.get_Type().get_FullName() == view.get_ClassModel().get_Type().get_FullName();
                    }));
                    if (classModel == null){
                        classModel = new SharpKit.MsTest.Metadata.TestClassModel.ctor(view.get_ClassModel().get_Type());
                        assemblyModel.AddClass(classModel);
                    }
                    classModel.AddMethod(view.get_Model());
                }
            }
            return result.get_Values();
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.jQuery.jQuery"]
    }
    ],
    IsAbstract: false
};
JsTypes.push(SharpKit$MsTest$UI$GroupView);
var SharpKit$MsTest$UI$GroupView$CssClass = {
    fullname: "SharpKit.MsTest.UI.GroupView.CssClass",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.MsTest.UI.GroupView.CssClass.Clear = "clear";
            SharpKit.MsTest.UI.GroupView.CssClass.Group = "mst-group";
            SharpKit.MsTest.UI.GroupView.CssClass.Header = "mst-group-header";
            SharpKit.MsTest.UI.GroupView.CssClass.HeaderName = "mst-group-name";
            SharpKit.MsTest.UI.GroupView.CssClass.HeaderStatus = "mst-group-status";
            SharpKit.MsTest.UI.GroupView.CssClass.HeaderSelector = "mst-group-selector";
            SharpKit.MsTest.UI.GroupView.CssClass.HeaderTime = "mst-group-Time";
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
JsTypes.push(SharpKit$MsTest$UI$GroupView$CssClass);
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
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-log");
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "clear");
            html.Append$$String("</div>");
            this.root.html(html.toString());
        },
        GetControls: function (){
            return this.root.find(".mst-controls");
        },
        GetContent: function (){
            return this.root.find(".mst-content");
        },
        GetLog: function (){
            return this.root.find(".mst-log");
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
            SharpKit.MsTest.UI.MainView.CssClass.Clear = "clear";
            SharpKit.MsTest.UI.MainView.CssClass.Container = "mst-container";
            SharpKit.MsTest.UI.MainView.CssClass.Controls = "mst-controls";
            SharpKit.MsTest.UI.MainView.CssClass.Content = "mst-content";
            SharpKit.MsTest.UI.MainView.CssClass.Log = "mst-log";
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
            var $it9 = types.GetEnumerator();
            while ($it9.MoveNext()){
                var type = $it9.get_Current();
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
            for (var $i11 = 0,$t11 = type.GetMethods(),$l11 = $t11.length,method = $t11[$i11]; $i11 < $l11; $i11++, method = $t11[$i11]){
                var isTestMethod = false;
                var categories = new System.Collections.Generic.List$1.ctor(System.String.ctor);
                var attributes = method.GetCustomAttributes$$Boolean(true);
                for (var $i12 = 0,$l12 = attributes.length,attribute = attributes[$i12]; $i12 < $l12; $i12++, attribute = attributes[$i12]){
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
        ctor: function (classModel, model){
            this.root = null;
            this._ClassModel = null;
            this._Model = null;
            System.Object.ctor.call(this);
            this.set_ClassModel(classModel);
            this.set_Model(model);
        },
        ClassModel$$: "SharpKit.MsTest.Metadata.TestClassModel",
        get_ClassModel: function (){
            return this._ClassModel;
        },
        set_ClassModel: function (value){
            this._ClassModel = value;
        },
        Model$$: "SharpKit.MsTest.Metadata.TestMethodModel",
        get_Model: function (){
            return this._Model;
        },
        set_Model: function (value){
            this._Model = value;
        },
        Selector$$: "SharpKit.jQuery.jQuery",
        get_Selector: function (){
            return this.root.find("[data-method-id=\'" + this.get_Model().get_UniqueId() + "\']").find("input");
        },
        IsSelected$$: "System.Boolean",
        get_IsSelected: function (){
            return this.get_Selector().attr("checked") == "checked";
        },
        set_IsSelected: function (value){
            if (value)
                this.get_Selector().attr("checked", "checked");
            else
                this.get_Selector().removeAttr("checked");
        },
        Render: function (html){
            html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\' data-method-id=\'{1}\'>", "mst-method-container", this.get_Model().get_UniqueId());
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-method-status");
            html.AppendFormat$$String$$Object$$Object("<div class=\'{0}\'><input id=\'{1}\' type=\'checkbox\' /></div>", "mst-method-selector", this.get_Model().get_UniqueId());
            html.AppendFormat$$String$$Object$$Object$$Object("<div class=\'{0}\'><label for=\'{1}\'>{2}</label></div>", "mst-method-name", this.get_Model().get_UniqueId(), this.get_Model().get_Method().get_Name());
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "mst-method-time");
            html.AppendFormat$$String$$Object("<div class=\'{0}\'></div>", "clear");
            html.Append$$String("</div>");
        },
        Bind: function (root){
            this.root = root;
        }
    },
    ctors: [{
        name: "ctor",
        parameters: ["SharpKit.MsTest.Metadata.TestClassModel", "SharpKit.MsTest.Metadata.TestMethodModel"]
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
            SharpKit.MsTest.UI.MethodView.CssClass.Clear = "clear";
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
            this.assemblies = null;
            this.mainView = null;
            this.controls = null;
            this.groupView = null;
            System.Object.ctor.call(this);
        },
        Render: function (root){
            this.assemblies = this.testClassProvider.Load();
            this.mainView = new SharpKit.MsTest.UI.MainView.ctor(root);
            this.mainView.Render();
            this.controls = new SharpKit.MsTest.UI.ControlView.ctor(this.mainView.GetControls());
            this.controls.add_RunAll($CreateDelegate(this, this.OnRunAll));
            this.controls.add_RunSelected($CreateDelegate(this, this.OnRunSelected));
            this.controls.Render();
            var classes = new System.Collections.Generic.List$1.ctor(SharpKit.MsTest.Metadata.TestClassModel.ctor);
            var $it12 = this.assemblies.GetEnumerator();
            while ($it12.MoveNext()){
                var assembly = $it12.get_Current();
                classes.AddRange(assembly.get_Classes());
            }
            var content = this.mainView.GetContent();
            this.groupView = new SharpKit.MsTest.UI.GroupView.ctor(content);
            this.groupView.Render(classes);
        },
        OnRunAll: function (){
            this.RunTest(this.assemblies);
        },
        OnRunSelected: function (){
            var selected = this.groupView.GetSelected();
            this.RunTest(selected);
        },
        RunTest: function (assemblies){
            var log = new SharpKit.MsTest.Log.ctor();
            log.add_InfoAdded($CreateDelegate(this, this.OnLogInfoAdded));
            var executor = new SharpKit.MsTest.TestExecutor.ctor(log);
            executor.Run(assemblies);
        },
        OnLogInfoAdded: function (message){
            this.mainView.GetLog().append(message + "<br />");
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

