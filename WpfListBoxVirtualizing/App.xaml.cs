﻿using System.Windows;

namespace WpfListBoxVirtualizing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.DataContext = new ViewModel();
            mainWindow.Show();
        }
    }
}
