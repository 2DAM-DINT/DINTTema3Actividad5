using System.Windows;
using System.Windows.Controls;

namespace Actividad5
{
    public partial class App : Application
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (MainWindow as MainWindow).numerosPulsados.Text += (sender as Button).Tag.ToString();
        }
    }
}
