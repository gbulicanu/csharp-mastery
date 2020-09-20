using System.Windows;
using System.Windows.Controls;

namespace WpfApp
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Downcast to button
            var button = sender as Button;
            if (button != null) 
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }

            MessageBox.Show("Hello World!");
        }
    }
}
