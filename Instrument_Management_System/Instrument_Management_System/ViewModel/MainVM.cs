using Interface_Lib;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using Instrument_Management_System.Command;

namespace Instrument_Management_System.ViewModel
{
    public class MainVM : ViewModelBase
    {
        public GetInstrumentsComamand _getCommand { get; set; }
        public DeleteCommand _deleteCommand { get; set; }

        private ObservableCollection<Instruments> instruments_List;
        public ObservableCollection<Instruments> Instruments_List
        {
            get { return instruments_List; }
            set 
            { 
                instruments_List = value; 
                OnPropertyChanged(nameof(Instruments_List));
            }
        }

        private Instruments selectedInstrument;
        public Instruments SelectedInstrument
        {
            get { return selectedInstrument; }
            set
            {
                selectedInstrument = value;
                OnPropertyChanged(nameof(SelectedInstrument));
            }
        }

        public void delete_instr()
        {
            Instruments intr = SelectedInstrument;
            if (intr != null)
            {
                string deleteInstr = intr.Name;
                i.deleteInstrument(deleteInstr);
                get_instr();
            }
            else
            {
                MessageBox.Show("Please select the instrument that you want to delete");
            }
        }

        public void get_instr()
        {
            if(i.getInstruments() != null)
            {
                Instruments_List = new ObservableCollection<Instruments>(i.getInstruments());
            }
            else
            {
                MessageBox.Show("There is no data to show! Add data to file.");
            }
        }

        public MainVM()
        {
            _getCommand = new GetInstrumentsComamand(this);
            _deleteCommand = new DeleteCommand(this);
        }
    }
}
