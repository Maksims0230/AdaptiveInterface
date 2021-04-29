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

namespace WPF_NET_6
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

        private void WindowMove_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
            else if (e.RightButton == MouseButtonState.Pressed)
            {

            }
        }

        private void ButtonBaseMinimize_OnClick(object sender, RoutedEventArgs e) =>
            this.WindowState = WindowState.Minimized;


        private void ButtonBaseMaximize_OnClick(object sender, RoutedEventArgs e) =>
            this.WindowState = this.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;

        private void ButtonBaseClose_OnClick(object sender, RoutedEventArgs e) => this.Close();
    }
}