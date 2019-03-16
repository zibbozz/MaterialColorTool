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
using System.Windows.Shapes;

namespace MaterialColorTool
{
    /// <summary>
    /// Interaktionslogik für CheatSheetWindow.xaml
    /// </summary>
    public partial class CheatSheetWindow : Window
    {
        public CheatSheetWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            umgebungGrid.Visibility = Visibility.Visible;
            layoutGrid.Visibility = Visibility.Hidden;
            typoGrid.Visibility = Visibility.Hidden;
            bewegungGrid.Visibility = Visibility.Hidden;

            menuMaker.SetValue(Grid.ColumnProperty, 0);
        }

        private void Border_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            umgebungGrid.Visibility = Visibility.Hidden;
            layoutGrid.Visibility = Visibility.Visible;
            typoGrid.Visibility = Visibility.Hidden;
            bewegungGrid.Visibility = Visibility.Hidden;

            menuMaker.SetValue(Grid.ColumnProperty, 1);
        }

        private void Border_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            umgebungGrid.Visibility = Visibility.Hidden;
            layoutGrid.Visibility = Visibility.Hidden;
            typoGrid.Visibility = Visibility.Visible;
            bewegungGrid.Visibility = Visibility.Hidden;

            menuMaker.SetValue(Grid.ColumnProperty, 2);
        }

        private void Border_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            umgebungGrid.Visibility = Visibility.Hidden;
            layoutGrid.Visibility = Visibility.Hidden;
            typoGrid.Visibility = Visibility.Hidden;
            bewegungGrid.Visibility = Visibility.Visible;

            menuMaker.SetValue(Grid.ColumnProperty, 3);
        }
    }
}
