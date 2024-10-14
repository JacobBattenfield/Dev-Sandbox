
using System.Windows;

namespace Display_Input_Test
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

        private void DisplayInputButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = InputText.Text;
            string cleanedInput = userInput.Length<=50? userInput : userInput.Substring(0,50);
            
            OutputDisplay.Content = cleanedInput;
        }
    }
}