using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace WunderPomoUWP.Controls
{
    [ContentProperty(Name = "Content")]
    public sealed class Expander : Control
    {
        public Expander()
        {
            this.DefaultStyleKey = typeof(Expander);
        }

        public static readonly DependencyProperty ContentProperty =
       DependencyProperty.Register("Content", typeof(object), typeof(Expander), new PropertyMetadata(null));

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(Expander), new PropertyMetadata(null));

        public static readonly DependencyProperty IsExpandProperty =
            DependencyProperty.Register("IsExpand", typeof(bool), typeof(Expander), new PropertyMetadata(true));

        /// <summary>
        /// 控件的内容
        /// </summary>
        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        /// <summary>
        /// 控件的标题
        /// </summary>
        public object Header
        {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// 返回或设置控件是否展开
        /// </summary>
        public bool IsExpand
        {
            get { return (bool)GetValue(IsExpandProperty); }
            set { SetValue(IsExpandProperty, value); }
        }

        private ToggleButton button;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            button = GetTemplateChild("toggleButton") as ToggleButton;
            button.Loaded += (s, e) => { ChangeControlState(false); };
            button.Checked += (s, e) => { ChangeControlState(); };
            button.Unchecked += (s, e) => { ChangeControlState(); };
        }

        /// <summary>
        /// 改变控件的 VisualState
        /// </summary>
        /// <param name="useTransition">是否使用 VisualTransition，默认使用</param>
        private void ChangeControlState(bool useTransition = true)
        {
            if (button.IsChecked.Value)
            {
                VisualStateManager.GoToState(this, "Expanded", useTransition);
            }
            else
            {
                VisualStateManager.GoToState(this, "Normal", useTransition);
            }
        }
    }
}
