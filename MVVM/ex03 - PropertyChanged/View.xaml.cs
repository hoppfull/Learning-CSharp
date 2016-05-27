using System.Windows;

namespace ex03 {
    public partial class View : Window {
        public View() {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
