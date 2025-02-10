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
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            _generationService = new GenerationService(NumbersCb.IsChecked.Value, SymbolsCb.IsChecked.Value, LowerCaseCb.IsChecked.Value, UpperCaseCb.IsChecked.Value, WordsCb.IsChecked.Value);

            int length = int.Parse(PasswordLengthTb.Text);
            int passwordsCount = int.Parse(PasswordsCountTb.Text);

            PasswordsLb.ItemsSource = _generationService.Start(length, passwordsCount);
        }
    }
}
