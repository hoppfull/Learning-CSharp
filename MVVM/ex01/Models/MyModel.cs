using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01.Models {
    class MyModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
