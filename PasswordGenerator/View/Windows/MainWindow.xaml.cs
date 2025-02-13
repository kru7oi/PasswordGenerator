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

            _generationService = new GenerationService(NumbersCb.IsChecked.Value, SymbolsCb.IsChecked.Value, LowerCaseCb.IsChecked.Value, UpperCaseCb.IsChecked.Value);
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            int length = int.Parse(CharactersLengthTb.Text);
            int passwordsCount = int.Parse(PasswordsCountTb.Text);

            PasswordsLb.ItemsSource = _generationService.Start(length, passwordsCount);
        }
    }
}
