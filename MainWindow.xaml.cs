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
using System.Data;

namespace Сalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement element in MainRoot.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = ((Button)e.OriginalSource).Content.ToString();

            if (str == "AC")
                textLabel.Text = string.Empty;
            else if (str == "=")
            {
                string value = new DataTable().Compute(textLabel.Text,null).ToString();
                textLabel.Text = value;
            }
            else
                textLabel.Text += str;
        }
    }
}
