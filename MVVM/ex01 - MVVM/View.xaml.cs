using System.Windows;

namespace ex01 {
    public partial class View : Window {
        public View() {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
