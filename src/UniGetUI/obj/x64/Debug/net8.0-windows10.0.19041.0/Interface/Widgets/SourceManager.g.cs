﻿#pragma checksum "C:\SomePrograms\WingetUI-Store\src\UniGetUI\Interface\Widgets\SourceManager.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B256187A5FDE79FB4F653A0B548BE1FD09F83B88BBE1C0FDBC9CF93FE6287EDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniGetUI.Interface.Widgets
{
    partial class SourceManager : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ContentControl_Content(global::Microsoft.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_HyperlinkButton_NavigateUri(global::Microsoft.UI.Xaml.Controls.HyperlinkButton obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.NavigateUri = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SourceManager_obj3_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISourceManager_Bindings
        {
            private global::UniGetUI.Interface.Widgets.SourceItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj4;
            private global::Microsoft.UI.Xaml.Controls.HyperlinkButton obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj7;
            private global::Microsoft.UI.Xaml.Controls.Button obj8;

            // Fields for each event bindings event handler.
            private global::Microsoft.UI.Xaml.RoutedEventHandler obj8Click;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4TextDisabled = false;
            private static bool isobj5ContentDisabled = false;
            private static bool isobj5NavigateUriDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj6VisibilityDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj7VisibilityDisabled = false;

            public SourceManager_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 33 && columnNumber == 21)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 21)
                {
                    isobj5ContentDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 21)
                {
                    isobj5NavigateUriDisabled = true;
                }
                else if (lineNumber == 43 && columnNumber == 21)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 17)
                {
                    isobj6VisibilityDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 21)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 17)
                {
                    isobj7VisibilityDisabled = true;
                }
                else if (lineNumber == 53 && columnNumber == 95)
                {
                    this.obj8.Click -= obj8Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Interface\Widgets\SourceManager.xaml line 13
                        this.obj3 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target));
                        break;
                    case 4: // Interface\Widgets\SourceManager.xaml line 30
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 5: // Interface\Widgets\SourceManager.xaml line 35
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.HyperlinkButton>(target);
                        break;
                    case 6: // Interface\Widgets\SourceManager.xaml line 41
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 7: // Interface\Widgets\SourceManager.xaml line 47
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 8: // Interface\Widgets\SourceManager.xaml line 53
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                        this.obj8Click = (global::System.Object p0, global::Microsoft.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.Remove(p0, p1);
                        };
                        (global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target)).Click += obj8Click;
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj3.Target as global::Microsoft.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::UniGetUI.Interface.Widgets.SourceItem>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISourceManager_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::UniGetUI.Interface.Widgets.SourceItem>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UniGetUI.Interface.Widgets.SourceItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Source(obj.Source, phase);
                    }
                }
            }
            private void Update_Source(global::UniGetUI.PackageEngine.Classes.ManagerSource obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Source_Name(obj.Name, phase);
                        this.Update_Source_Url(obj.Url, phase);
                        this.Update_Source_UpdateDate(obj.UpdateDate, phase);
                        this.Update_Source_Manager(obj.Manager, phase);
                        this.Update_Source_PackageCount(obj.PackageCount, phase);
                    }
                }
            }
            private void Update_Source_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 30
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_Source_Url(global::System.Uri obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 35
                    if (!isobj5ContentDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentControl_Content(this.obj5, obj, null);
                    }
                    // Interface\Widgets\SourceManager.xaml line 35
                    if (!isobj5NavigateUriDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj5, obj, null);
                    }
                }
            }
            private void Update_Source_UpdateDate(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 41
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_Source_Manager(global::UniGetUI.PackageEngine.Classes.PackageManager obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Source_Manager_Capabilities(obj.Capabilities, phase);
                    }
                }
            }
            private void Update_Source_Manager_Capabilities(global::UniGetUI.PackageEngine.Classes.ManagerCapabilities obj, int phase)
            {
                if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                {
                    this.Update_Source_Manager_Capabilities_Sources(obj.Sources, phase);
                }
            }
            private void Update_Source_Manager_Capabilities_Sources(global::UniGetUI.PackageEngine.Classes.ManagerSource.Capabilities obj, int phase)
            {
                if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                {
                    this.Update_Source_Manager_Capabilities_Sources_KnowsUpdateDate(obj.KnowsUpdateDate, phase);
                }
            }
            private void Update_Source_Manager_Capabilities_Sources_KnowsUpdateDate(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                {
                    this.Update_Source_Manager_Capabilities_Sources_KnowsUpdateDate_Cast_KnowsUpdateDate_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_Source_Manager_Capabilities_Sources_KnowsUpdateDate_Cast_KnowsUpdateDate_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 41
                    if (!isobj6VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj6, obj);
                    }
                    // Interface\Widgets\SourceManager.xaml line 47
                    if (!isobj7VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj7, obj);
                    }
                }
            }
            private void Update_Source_PackageCount(global::System.Nullable<global::System.Int32> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 47
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SourceManager_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISourceManager_Bindings
        {
            private global::UniGetUI.Interface.Widgets.SourceManager dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10ItemsSourceDisabled = false;

            private SourceManager_obj1_BindingsTracking bindingsTracking;

            public SourceManager_obj1_Bindings()
            {
                this.bindingsTracking = new SourceManager_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 92 && columnNumber == 13)
                {
                    isobj10ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Interface\Widgets\SourceManager.xaml line 90
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        this.bindingsTracking.RegisterTwoWayListener_10(this.obj10);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISourceManager_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::UniGetUI.Interface.Widgets.SourceManager>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UniGetUI.Interface.Widgets.SourceManager obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Sources(obj.Sources, phase);
                    }
                }
            }
            private void Update_Sources(global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Sources(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Interface\Widgets\SourceManager.xaml line 90
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_10_ItemsSource()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Sources = (global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem>)this.obj10.ItemsSource;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SourceManager_obj1_BindingsTracking
            {
                private global::System.WeakReference<SourceManager_obj1_Bindings> weakRefToBindingObj; 

                public SourceManager_obj1_BindingsTracking(SourceManager_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SourceManager_obj1_Bindings>(obj);
                }

                public SourceManager_obj1_Bindings TryGetBindingObject()
                {
                    SourceManager_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Sources(null);
                }

                public void PropertyChanged_Sources(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SourceManager_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Sources(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    SourceManager_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem> cache_Sources = null;
                public void UpdateChildListeners_Sources(global::System.Collections.ObjectModel.ObservableCollection<global::UniGetUI.Interface.Widgets.SourceItem> obj)
                {
                    if (obj != cache_Sources)
                    {
                        if (cache_Sources != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Sources).PropertyChanged -= PropertyChanged_Sources;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Sources).CollectionChanged -= CollectionChanged_Sources;
                            cache_Sources = null;
                        }
                        if (obj != null)
                        {
                            cache_Sources = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Sources;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Sources;
                        }
                    }
                }
                public void RegisterTwoWayListener_10(global::Microsoft.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_10_ItemsSource();
                        }
                    });
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 9: // Interface\Widgets\SourceManager.xaml line 84
                {
                    this.LoadingBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressBar>(target);
                }
                break;
            case 10: // Interface\Widgets\SourceManager.xaml line 90
                {
                    this.DataList = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                }
                break;
            case 11: // Interface\Widgets\SourceManager.xaml line 78
                {
                    this.Header = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 12: // Interface\Widgets\SourceManager.xaml line 79
                {
                    this.AddSourceButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                }
                break;
            case 13: // Interface\Widgets\SourceManager.xaml line 80
                {
                    this.ReloadButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.ReloadButton).Click += this.ReloadButton_Click;
                }
                break;
            case 14: // Interface\Widgets\SourceManager.xaml line 81
                {
                    this.SearchAnimatedIcon = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.FontIcon>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Interface\Widgets\SourceManager.xaml line 2
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    SourceManager_obj1_Bindings bindings = new SourceManager_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 3: // Interface\Widgets\SourceManager.xaml line 13
                {                    
                    global::Microsoft.UI.Xaml.Controls.Grid element3 = (global::Microsoft.UI.Xaml.Controls.Grid)target;
                    SourceManager_obj3_Bindings bindings = new SourceManager_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

