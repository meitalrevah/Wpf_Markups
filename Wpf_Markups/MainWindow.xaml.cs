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

namespace Wpf_Markups
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Background = Brushes.Red;
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Background = new SolidColorBrush(Colors.Blue);

                e.Handled = true; //גורם לזה לצבוע רק את הריבוע הפנימי בלי החיצוני
            }
        }
    }
}
