using System.Windows;

namespace ex03 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MyClass { MyProperty = "Hello DataContext!" };
        }
    }

    public class MyClass {
        public string MyProperty { get; set; }
    }
}
