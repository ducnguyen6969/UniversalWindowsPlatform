﻿#pragma checksum "E:\DEV\C#\UniversalApp\T2012_HelloWorld\T2012_HelloWorld\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46425D9A1658C85643A8CF3DE940ADC4E91638DC3D237DACBFF29B9D7BCD637C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T2012_HelloWorld
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 112
                {
                    this.login = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.login).Click += this.Button_Click;
                }
                break;
            case 3: // MainPage.xaml line 100
                {
                    this.intrErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 101
                {
                    this.REBCustom = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                    ((global::Windows.UI.Xaml.Controls.RichEditBox)this.REBCustom).Loaded += this.REBCustom_Loaded;
                    ((global::Windows.UI.Xaml.Controls.RichEditBox)this.REBCustom).Unloaded += this.REBCustom_Unloaded;
                    ((global::Windows.UI.Xaml.Controls.RichEditBox)this.REBCustom).SelectionChanged += this.REBCustom_SelectionChanged;
                }
                break;
            case 5: // MainPage.xaml line 93
                {
                    this.birthdayErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // MainPage.xaml line 94
                {
                    this.birthday = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.DatePicker)this.birthday).IsEnabledChanged += this.birthday_IsEnabledChanged;
                }
                break;
            case 7: // MainPage.xaml line 84
                {
                    this.emailErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // MainPage.xaml line 85
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.email).TextChanged += this.email_TextChanged;
                }
                break;
            case 9: // MainPage.xaml line 74
                {
                    this.genderErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 76
                {
                    this.male = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11: // MainPage.xaml line 77
                {
                    this.female = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 12: // MainPage.xaml line 65
                {
                    this.avatarErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // MainPage.xaml line 66
                {
                    this.avatar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.avatar).TextChanged += this.avatar_TextChanged;
                }
                break;
            case 14: // MainPage.xaml line 59
                {
                    this.addressErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // MainPage.xaml line 60
                {
                    this.address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.address).SelectionChanged += this.address_SelectionChanged;
                }
                break;
            case 16: // MainPage.xaml line 48
                {
                    this.phoneErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // MainPage.xaml line 49
                {
                    this.phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.phone).SelectionChanged += this.phone_SelectionChanged;
                }
                break;
            case 18: // MainPage.xaml line 41
                {
                    this.passwordErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // MainPage.xaml line 43
                {
                    this.password = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.password).SelectionChanged += this.password_SelectionChanged;
                }
                break;
            case 20: // MainPage.xaml line 31
                {
                    this.lNameErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // MainPage.xaml line 32
                {
                    this.lName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.lName).SelectionChanged += this.lName_SelectionChanged;
                }
                break;
            case 22: // MainPage.xaml line 25
                {
                    this.fNameErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // MainPage.xaml line 26
                {
                    this.fName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.fName).SelectionChanged += this.fName_SelectionChanged;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
