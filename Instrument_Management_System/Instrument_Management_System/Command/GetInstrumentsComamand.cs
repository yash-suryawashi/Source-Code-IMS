using System;
using System.Windows.Input;
using Instrument_Management_System.ViewModel;

namespace Instrument_Management_System.Command
{
    public class GetInstrumentsComamand : ICommand
    {
        public MainVM get_vm;
        public GetInstrumentsComamand(MainVM vm)
        {
            get_vm = vm;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            get_vm.get_instr();
        }
    }
}
