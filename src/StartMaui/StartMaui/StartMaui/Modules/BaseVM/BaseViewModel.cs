using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StartMaui.Modules.BaseVM
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;


            storage = value;

            OnPropertyChanged(propertyName);
            return true;
        }

        private string _title; public string Title
        {
            get => _title; 
            set => _title = value; 
        }
    }
}
