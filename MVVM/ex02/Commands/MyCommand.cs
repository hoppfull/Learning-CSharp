using System;
using System.Windows.Input;
using ex02.ViewModels;

namespace ex02.Commands {
    public class MyCommand : ICommand {
        public event EventHandler CanExecuteChanged;
        public MyViewModel ViewModel { get; }

        public MyCommand(MyViewModel vm) {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            ViewModel.MyMethod();
        }
    }
}
