using System.Windows;

namespace prueba
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nombreTextBox.Text.Equals("")) nombreTextBlock.Text = "Hola Mundo!";
            else nombreTextBlock.Text = "Hola " + nombreTextBox.Text + "!";
        }
    }
}
