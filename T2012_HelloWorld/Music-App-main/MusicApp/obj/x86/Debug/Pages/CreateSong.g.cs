﻿#pragma checksum "E:\DEV\C#\UniversalApp\UniversalWindowsPlatform\Music-App-main\MusicApp\Pages\CreateSong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A06B71E3EF8383416B62081AA8FB6095196FDCBE4DF26954BCC73A1B7FB8BF80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicApp.Pages
{
    partial class CreateSong : 
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
            case 2: // Pages\CreateSong.xaml line 83
                {
                    this.progress1 = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 3: // Pages\CreateSong.xaml line 80
                {
                    this.login = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.login).Click += this.Create;
                }
                break;
            case 4: // Pages\CreateSong.xaml line 75
                {
                    this.thumbnailImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // Pages\CreateSong.xaml line 72
                {
                    this.txtThumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtThumbnail).TextChanged += this.txtThumbnail_TextChanged;
                }
                break;
            case 6: // Pages\CreateSong.xaml line 73
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.OpenThumbnail;
                }
                break;
            case 7: // Pages\CreateSong.xaml line 69
                {
                    this.txtErrThumbnail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Pages\CreateSong.xaml line 61
                {
                    this.txtLink = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtLink).TextChanged += this.txtLink_TextChanged;
                }
                break;
            case 9: // Pages\CreateSong.xaml line 62
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.OpenLink;
                }
                break;
            case 10: // Pages\CreateSong.xaml line 58
                {
                    this.txtErrLink = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Pages\CreateSong.xaml line 50
                {
                    this.txtDescription = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtDescription).SelectionChanged += this.txtDescription_SelectionChanged;
                }
                break;
            case 12: // Pages\CreateSong.xaml line 48
                {
                    this.txtErrDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Pages\CreateSong.xaml line 42
                {
                    this.txtAuthor = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtAuthor).SelectionChanged += this.txtAuthor_SelectionChanged;
                }
                break;
            case 14: // Pages\CreateSong.xaml line 40
                {
                    this.txtErrAuthor = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Pages\CreateSong.xaml line 32
                {
                    this.txtSinger = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtSinger).SelectionChanged += this.txtSinger_SelectionChanged;
                }
                break;
            case 16: // Pages\CreateSong.xaml line 30
                {
                    this.txtErrSinger = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Pages\CreateSong.xaml line 24
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtName).SelectionChanged += this.txtName_SelectionChanged;
                }
                break;
            case 18: // Pages\CreateSong.xaml line 22
                {
                    this.txtErrName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Pages\CreateSong.xaml line 15
                {
                    this.addTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

