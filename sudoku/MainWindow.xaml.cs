using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sudoku
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

        private void CzteryNaCztery(object sender, RoutedEventArgs e)
        {
            Window Okno = new SudokuEasyMode();
            Okno.ShowDialog();
        }

        private void DziewiecNaDziewiec(object sender, RoutedEventArgs e)
        {
            Window Okno2 = new HardMode();
            Okno2.ShowDialog();
        }
    }
}