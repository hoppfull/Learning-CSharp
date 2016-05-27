using System;
using System.Windows;

namespace ex03 {
    class ViewModel {
        public string Text { get; set; }

        public RelayCommand ClickCommand { get; } = new RelayCommand();
        public ViewModel() {
            ClickCommand.OnExecute += o => { MessageBox.Show(Text); };
            ClickCommand.OnExecute += o => { Console.WriteLine(Text); };
            ClickCommand.OnCanExecute = o => !string.IsNullOrWhiteSpace(Text);
        }
    }
}
