using System;
using System.Windows.Input;
using Instrument_Management_System.ViewModel;

namespace Instrument_Management_System.Command
{
    public class DeleteCommand : ICommand
    {
        public MainVM _delete_vm { get; set; }
        public DeleteCommand(MainVM vm)
        {
            _delete_vm = vm;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _delete_vm.delete_instr();
        }
    }
}
