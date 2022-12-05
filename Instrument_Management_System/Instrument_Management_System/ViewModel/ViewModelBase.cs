using Interface_Lib;
using System;
using System.ComponentModel;
using System.Reflection;

namespace Instrument_Management_System.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IMethods i = Activator.CreateInstance(Assembly.LoadFile("D:\\Instrument Management System\\Release\\net5.0\\RWClass_Lib")
                            .GetType("RWClass_Lib.RWClass"))
                             as IMethods;
    }
}