using Interface_Lib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using Instrument_Management_System.View;

namespace Instrument_Management_System
{
    public partial class MainWindow : Window
    {
        List<string> userList;
        List<string> projectList;

        IMethods i = Activator.CreateInstance(Assembly.LoadFile("D:\\Instrument Management System\\Release\\net5.0\\RWClass_Lib")
                    .GetType("RWClass_Lib.RWClass"))
                     as IMethods;

        public MainWindow()
        {
            InitializeComponent();

            userList = new List<string> { "Yash S", "Shoeb S", "Shailesh S", "Manas K", "Pradumna S", "Nikhil C" };
            projectList = new List<string> { "project-1", "project-2", "project-3", "project-4" };
        }


        private void addNewBtn_Click(object sender, RoutedEventArgs e)
        {
            Add_dialog ad = new Add_dialog();
            ad.Show();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            Update_dialog upd = new Update_dialog();
            upd.Show();
        }
    }
}
