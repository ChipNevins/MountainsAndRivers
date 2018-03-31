using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfMountainsAndRivers.Models;

namespace WpfMountainsAndRivers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class MountainsAndRiversApp : Application
    {
        private ObservableCollection<River> rivers = new ObservableCollection<River>();

        void AppStartup(object sender, StartupEventArgs args)
        {
            LoadData();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        public ObservableCollection<River> Rivers
        {
            get { return this.rivers; }
            set { this.rivers = value; }
        }

        private void LoadData()
        {
            for (int i = 1; i < 126; i++) {
                string s = i.ToString();
                Rivers.Add(new River("R" + s, "River " + s, i));
            }
        }

    }
}
