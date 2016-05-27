using System;
using System.Windows.Input;

namespace ex02 {
    class RelayCommand : ICommand {
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<object> execute;
        private Predicate<object> canExecute;

        public RelayCommand(Action<object> execute = null, Predicate<object> canExecute = null) {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object arg) {
            return canExecute != null && canExecute(arg);
        }

        public void Execute(object arg) {
            execute?.Invoke(arg);
        }
    }
}
