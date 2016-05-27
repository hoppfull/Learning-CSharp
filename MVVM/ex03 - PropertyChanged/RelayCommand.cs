using System;
using System.Windows.Input;

namespace ex03 {
    class RelayCommand : ICommand {
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Action<object> OnExecute;
        public Predicate<object> OnCanExecute;

        public RelayCommand(Predicate<object> OnCanExecute = null) {
            this.OnCanExecute = OnCanExecute;
        }

        public bool CanExecute(object arg) {
            return OnCanExecute != null && OnCanExecute(arg);
        }

        public void Execute(object arg) {
            OnExecute?.Invoke(arg);
        }
    }
}
