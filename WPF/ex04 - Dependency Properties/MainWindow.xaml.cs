using System.Windows;

namespace ex04 {
    public partial class MainWindow : Window {
        public string MyProperty { get; set; }
        public MainWindow() {
            InitializeComponent();

            DataContext = this;

            btn_myButton.Click += (o, e) => {
                MessageBox.Show(MyProperty);
            };
        }
    }
}
