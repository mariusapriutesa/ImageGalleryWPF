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

namespace ImageGallery
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void GoBack(object sender, RoutedEventArgs e)
        {
            i--;
            if (i<1)
            {
                i = 5;
            }
            picHolder.Source = new BitmapImage(new Uri(@"Images/img"+i+".jpg" ,UriKind.Relative));
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            picHolder.Source = new BitmapImage(new Uri(@"Images/img" + i + ".jpg", UriKind.Relative));
        }
    }
}
