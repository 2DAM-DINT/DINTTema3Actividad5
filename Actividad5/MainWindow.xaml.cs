using System.Windows;
using System.Windows.Controls;

namespace Actividad5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            const int FILAS = 3, COLUMNAS = 3;
            int numero = 1;
            for (int i = 1; i <= FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    Button boton = new Button
                    {
                        Tag = numero,
                        Content = new Viewbox
                        {
                            Child = new TextBlock
                            {
                                Text = numero.ToString()
                            }
                        }
                    };
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);

                    numeros.Children.Add(boton);
                    numero++;
                }
            }
        }
    }
}
