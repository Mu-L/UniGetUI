﻿#pragma checksum "C:\SomePrograms\WingetUI-Store\src\UniGetUI\Interface\Dialogs\AboutWingetUI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FAC98CD890DE0F545D532B87758907E4DF00804EE6E8A46B104010705FC487FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniGetUI.Interface
{
    partial class AboutWingetUI : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2403")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AboutWingetUI_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IAboutWingetUI_Bindings
        {
            private global::UniGetUI.Interface.AboutWingetUI dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj4;
            private global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj5;
            private global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj6;
            private global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj7;
            private global::Microsoft.UI.Xaml.Controls.SelectorBarItem obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;

            public AboutWingetUI_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 20 && columnNumber == 78)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 60)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 60)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 60)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 60)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Interface\Dialogs\AboutWingetUI.xaml line 20
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                        break;
                    case 5: // Interface\Dialogs\AboutWingetUI.xaml line 25
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                        break;
                    case 6: // Interface\Dialogs\AboutWingetUI.xaml line 30
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                        break;
                    case 7: // Interface\Dialogs\AboutWingetUI.xaml line 35
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                        break;
                    case 8: // Interface\Dialogs\AboutWingetUI.xaml line 40
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
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

            // IAboutWingetUI_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::UniGetUI.Interface.AboutWingetUI>(newDataRoot);
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

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_Tools_M_Translate_539783673(int phase)
            {
                global::System.String p0 = "About";
                global::System.String result = this.dataRoot.Tools.Translate(p0);
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Dialogs\AboutWingetUI.xaml line 20
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(this.obj4, result, null);
                    }
                }
            }

            private void Invoke_Tools_M_Translate_3296254554(int phase)
            {
                global::System.String p0 = "Third-party licenses";
                global::System.String result = this.dataRoot.Tools.Translate(p0);
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Dialogs\AboutWingetUI.xaml line 25
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(this.obj5, result, null);
                    }
                }
            }

            private void Invoke_Tools_M_Translate_1707823444(int phase)
            {
                global::System.String p0 = "Contributors";
                global::System.String result = this.dataRoot.Tools.Translate(p0);
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Dialogs\AboutWingetUI.xaml line 30
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(this.obj6, result, null);
                    }
                }
            }

            private void Invoke_Tools_M_Translate_1140538941(int phase)
            {
                global::System.String p0 = "Translators";
                global::System.String result = this.dataRoot.Tools.Translate(p0);
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Dialogs\AboutWingetUI.xaml line 35
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(this.obj7, result, null);
                    }
                }
            }

            private void Invoke_Tools_M_Translate_1062172035(int phase)
            {
                global::System.String p0 = "Support me";
                global::System.String result = this.dataRoot.Tools.Translate(p0);
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Interface\Dialogs\AboutWingetUI.xaml line 40
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_SelectorBarItem_Text(this.obj8, result, null);
                    }
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UniGetUI.Interface.AboutWingetUI obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Tools(obj.Tools, phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_Tools(global::UniGetUI.Core.AppTools obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Tools_M_Translate_539783673(phase);
                        this.Update_Tools_M_Translate_3296254554(phase);
                        this.Update_Tools_M_Translate_1707823444(phase);
                        this.Update_Tools_M_Translate_1140538941(phase);
                        this.Update_Tools_M_Translate_1062172035(phase);
                    }
                }
            }
            private void Update_Tools_M_Translate_539783673(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj4TextDisabled)
                    {
                        this.PendingFunctionBindings["Tools_M_Translate_539783673"] = new InvokeFunctionDelegate(this.Invoke_Tools_M_Translate_539783673); 
                    }
                }
            }
            private void Update_Tools_M_Translate_3296254554(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj5TextDisabled)
                    {
                        this.PendingFunctionBindings["Tools_M_Translate_3296254554"] = new InvokeFunctionDelegate(this.Invoke_Tools_M_Translate_3296254554); 
                    }
                }
            }
            private void Update_Tools_M_Translate_1707823444(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj6TextDisabled)
                    {
                        this.PendingFunctionBindings["Tools_M_Translate_1707823444"] = new InvokeFunctionDelegate(this.Invoke_Tools_M_Translate_1707823444); 
                    }
                }
            }
            private void Update_Tools_M_Translate_1140538941(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj7TextDisabled)
                    {
                        this.PendingFunctionBindings["Tools_M_Translate_1140538941"] = new InvokeFunctionDelegate(this.Invoke_Tools_M_Translate_1140538941); 
                    }
                }
            }
            private void Update_Tools_M_Translate_1062172035(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj8TextDisabled)
                    {
                        this.PendingFunctionBindings["Tools_M_Translate_1062172035"] = new InvokeFunctionDelegate(this.Invoke_Tools_M_Translate_1062172035); 
                    }
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
            case 2: // Interface\Dialogs\AboutWingetUI.xaml line 19
                {
                    this.SelectorBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBar>(target);
                    ((global::Microsoft.UI.Xaml.Controls.SelectorBar)this.SelectorBar).SelectionChanged += this.SelectorBar_SelectionChanged;
                }
                break;
            case 3: // Interface\Dialogs\AboutWingetUI.xaml line 47
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 4: // Interface\Dialogs\AboutWingetUI.xaml line 20
                {
                    this.SelectorBarItemPage1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                }
                break;
            case 5: // Interface\Dialogs\AboutWingetUI.xaml line 25
                {
                    this.SelectorBarItemPage2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                }
                break;
            case 6: // Interface\Dialogs\AboutWingetUI.xaml line 30
                {
                    this.SelectorBarItemPage3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                }
                break;
            case 7: // Interface\Dialogs\AboutWingetUI.xaml line 35
                {
                    this.SelectorBarItemPage4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
                }
                break;
            case 8: // Interface\Dialogs\AboutWingetUI.xaml line 40
                {
                    this.SelectorBarItemPage5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SelectorBarItem>(target);
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
            case 1: // Interface\Dialogs\AboutWingetUI.xaml line 2
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    AboutWingetUI_obj1_Bindings bindings = new AboutWingetUI_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

