using System.Windows;
using System.Windows.Controls;

namespace ex04 {
    public partial class MyUserControl : UserControl {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(MyUserControl));
        public string Label {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MyUserControl));
        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public MyUserControl() {
            InitializeComponent();
            (Content as FrameworkElement).DataContext = this;
        }
    }
}
