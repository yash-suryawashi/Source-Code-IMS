using Interface_Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Instrument_Management_System.View
{
    public partial class Update_dialog : Window
    {
        ObservableCollection<Instruments> selectedList = new ObservableCollection<Instruments>();
        List<string> userList;
        List<string> projectList;

        IMethods i = Activator.CreateInstance(Assembly.LoadFile("D:\\Instrument Management System\\Release\\net5.0\\RWClass_Lib")
                    .GetType("RWClass_Lib.RWClass")) 
                     as IMethods;

        public Update_dialog()
        {
            InitializeComponent();

            userList = new List<string> { "Yash S", "Shoeb S", "Shailesh S", "Manas K", "Pradumna S", "Nikhil C" };
            projectList = new List<string> { "project-1", "project-2", "project-3", "project-4" };
            cmbUserUpdate.ItemsSource = userList;
            lbProjectsUpdate.ItemsSource = projectList;

            lbInstruments.ItemsSource = i.getInstruments();
        }

        private void lbInstruments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedList.Clear();
            if (this.lbInstruments.SelectedItem is Instruments)
            {
                selectedList.Add(((Instruments)this.lbInstruments.SelectedItem));
            }
            foreach (var item in selectedList)
            {
                txtNameUpdate.Text = item.Name;
                cmbUserUpdate.SelectedValue = item.User;
                lbProjectsUpdate.ItemsSource = projectList;
            }
        }
    }
}
