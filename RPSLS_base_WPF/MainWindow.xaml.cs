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

namespace RPSLS_base_WPF
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

        private void smallBtn_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 22;
            testBtn.Width = 75;
            testBtn.FontSize = 12;
        }

        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 47;
            testBtn.Width = 100;
            testBtn.FontSize = 24;
        }

        private void largeBtn_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 72;
            testBtn.Width = 125;
            testBtn.FontSize = 36;
        }

        // new buttons of the same size that has the same effect as above
        private void btn_sm_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 22;
            testBtn.Width = 75;
            testBtn.FontSize = 12;
        }

        private void btn_md_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 47;
            testBtn.Width = 100;
            testBtn.FontSize = 24;
        }

        private void btn_lg_Click(object sender, RoutedEventArgs e)
        {
            testBtn.Height = 72;
            testBtn.Width = 125;
            testBtn.FontSize = 36;
        }
    }
}
