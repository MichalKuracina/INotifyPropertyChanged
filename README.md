# INotifyPropertyChanged

Solution demonstrates how INotifyPropertyChanged interface works in WPF. 

```cs
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf_inotifypropertychanged.Model
{
    public class CountModel : INotifyPropertyChanged
    {
        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

 ```

Link to documentation -> [docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-6.0)
