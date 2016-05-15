using System.ComponentModel;

namespace ex01.Models {
    class MyModel : INotifyPropertyChanged {
        private string myProperty;
        public string MyProperty {
            get { return myProperty; }
            set {
                myProperty = value;
                OnPropertyChanged("MyProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
