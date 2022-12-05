using System;
using System.Windows.Input;
using Instrument_Management_System.ViewModel;

namespace Instrument_Management_System.Command
{
    public class UpdateCommand : ICommand
    {
        public UpdateVM _update_vm { get; set; }

        public UpdateCommand(UpdateVM vm)
        {
            _update_vm = vm;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _update_vm.update(parameter);
        }
    }
}
