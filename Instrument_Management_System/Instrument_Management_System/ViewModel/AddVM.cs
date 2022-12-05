using Interface_Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Instrument_Management_System.Command;

namespace Instrument_Management_System.ViewModel
{
    public class AddVM : ViewModelBase
    {
        string multipleSelections, name, user, project;

        public AddCommand _addCommand { get; set; }

        private string newInstrumentName;
        public string NewInstrumentName
        {
            get { return newInstrumentName; }
            set 
            { 
                newInstrumentName = value; 
                OnPropertyChanged(nameof(NewInstrumentName));
            }
        }

        private int newInstrumentUser_index;
        public int NewInstrumentUser_index
        {
            get { return newInstrumentUser_index; }
            set
            {
                newInstrumentUser_index = value;
                OnPropertyChanged(nameof(NewInstrumentUser_index));
            }
        }

        private string newInstrumentUser_value;
        public string NewInstrumentUser_value
        {
            get { return newInstrumentUser_value; }
            set 
            {
                newInstrumentUser_value = value;
                OnPropertyChanged(nameof(NewInstrumentUser_value));
            }
        }

        private int newInstrumentProjects_index;
        public int NewInstrumentProjects_index
        {
            get { return newInstrumentProjects_index; }
            set 
            { 
                newInstrumentProjects_index = value; 
                OnPropertyChanged(nameof(NewInstrumentProjects_index));
            }
        }

        public void add(object a)
        {
            if (NewInstrumentName.Equals(string.Empty))
            {
                name = "";
            }
            else
            {
                name = NewInstrumentName.Trim();
            }

            var collection = a as ICollection;
            List<string> selections = collection.Cast<string>().ToList();

            if (NewInstrumentUser_index != -1)
            {
                user = NewInstrumentUser_value;
            }
            else
            {
                user = "";
            }

            if (NewInstrumentProjects_index != -1)
            {
               foreach (var item in selections)
               {
                    multipleSelections += (multipleSelections == "" ? "" : " ") + item;
               }
               project = multipleSelections.ToString();
               multipleSelections = String.Empty;
            }
            else
            {
               project = "";
            }

            Instruments newInst = new Instruments()
            {
                Name = name,
                User = user,
                Project = project
            };

            i.addInstrument(newInst);
            NewInstrumentName = string.Empty;
            NewInstrumentUser_index = -1;
            NewInstrumentProjects_index = -1;   
        }

        public AddVM()
        {
            _addCommand = new AddCommand(this);
        }
    }
}
