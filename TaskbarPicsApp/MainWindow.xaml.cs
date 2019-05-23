using System.Windows;

namespace TaskbarPicsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        // ReSharper disable once NotAccessedField.Local
        private IconWindow _iconWindow;

        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e) => _iconWindow = new IconWindow();
    }
}
