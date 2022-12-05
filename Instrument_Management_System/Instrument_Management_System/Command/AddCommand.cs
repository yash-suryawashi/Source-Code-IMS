﻿using System;
using System.Windows.Input;
using Instrument_Management_System.ViewModel;

namespace Instrument_Management_System.Command
{
    public class AddCommand : ICommand
    {
        public AddVM _add_vm { get; set; }

        public AddCommand(AddVM vm)
        {
            _add_vm = vm;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _add_vm.add(parameter);
        }
    }
}
