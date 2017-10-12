using System.Windows;
using System.Windows.Controls;

namespace Macronomics
{
    public partial class WeightPage : Page
    {
        private readonly Window _window;

        public WeightPage(Window mainWindow)
        {
            _window = mainWindow;
            InitializeComponent();
        }

        private void logWeightBtnClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
