using PasswordGenerator.AppData;
using System.Windows;

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GenerationService _generationService;
        public MainWindow()
        {
            InitializeComponent();

            // _generationService = new GenerationService()
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
