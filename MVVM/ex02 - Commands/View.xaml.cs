using System.Windows;

namespace ex02 {
    public partial class View : Window {
        public View() {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
