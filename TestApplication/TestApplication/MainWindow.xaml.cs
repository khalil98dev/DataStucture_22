using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApplication
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void btnShowMessage_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
        {
           
            
           


            
        }


        private void koko(object sender, RequestNavigateEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show($"Hello There: your link is below: {e.Uri.ToString()} Do you want to browse it? ", "Navigator",
              MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (Result == MessageBoxResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = e.Uri.ToString(),
                    UseShellExecute = true
                });
            }
        }




    }
}
