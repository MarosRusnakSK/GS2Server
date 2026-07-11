using System;
using GS2.Utilities.Helpers;

namespace GS2.Utilities.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowV
    {
        public MainWindowV()
        {
            InitializeComponent();
            DataContext = new MainWindowVm();
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            Settings.Save();
        }

        public void Dispose()
        {
            // var vm = (MainWindowVM)DataContext;

        }

        private void MainWindow_OnContentRendered(object sender, EventArgs e)
        {
            MouseLeftButtonDown += delegate { DragMove(); };
        }
    }
}
