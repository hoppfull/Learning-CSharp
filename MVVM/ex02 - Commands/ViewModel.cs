using System;
using System.Windows;
using System.Windows.Input;

namespace ex02 {
    class ViewModel {
        public ICommand EnableCommand { get; set; }
        public ICommand ClickCommand { get; set; }
        private Model Model = new Model { Message = "Hello MVVM from ViewModel!" };
        private bool canExecuteClick = false;

        public ViewModel() {
            Action<object> clickCommand = o => { MessageBox.Show(Model.Message); };
            clickCommand += o => { MessageBox.Show((string)o); };
            EnableCommand = new RelayCommand(o => { canExecuteClick = !canExecuteClick; }, o => true);
            ClickCommand = new RelayCommand(clickCommand, o => canExecuteClick);
        }
    }
}
