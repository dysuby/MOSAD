﻿#pragma checksum "D:\vsProject\toDoList\toDoList\ItemEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCCC061B36BD08A7A37340FF51C75DF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toDoList
{
    partial class ItemEditor : global::Windows.UI.Xaml.Controls.UserControl
    {


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Image img; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider ImgZoomer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox title; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox description; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.DatePicker datePicker; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button CreateOrUpdate; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button Cancel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///ItemEditor.xaml");
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        
        private interface IItemEditor_Bindings
        {
            void Initialize();
            void Update();
            void StopTracking();
        }
#pragma warning disable 0169    //  Proactively suppress unused field warning in case Bindings is not used.
        private IItemEditor_Bindings Bindings;
#pragma warning restore 0169
    }
}

