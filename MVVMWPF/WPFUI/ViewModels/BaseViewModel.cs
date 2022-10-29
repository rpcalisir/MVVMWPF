using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //When this event handler method is executed, PropertyChanged event is invoked
        protected void OnPropertyChanged(string parameterName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameterName));
        }
    }
}
