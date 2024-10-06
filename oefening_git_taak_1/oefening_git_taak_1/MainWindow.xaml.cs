using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oefening_git_taak_1
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
        private void PXLImage_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = PXLImage.Source != null ? new SolidColorBrush(Colors.LightBlue) : new SolidColorBrush(Colors.LightGray);
        }
        private void PXLImage_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }
        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == GreenButton)
            {

                ShowColorInfo("#008000", "Groen is de kleur van genezing.", "Groen.png");
            }
            else if (sender == RedButton)
            {
                ShowColorInfo("#FF0000", "Rood is de kleur van warmte.", "Rood.png");
            }
            else if (sender == YellowButton)
            {
                ShowColorInfo("#FFFF00", "Geel is de kleur van levenslust.", "Geel.png");
            }
            else if (sender == BlueButton)
            {
                ShowColorInfo("#0000FF", "Blauw is de kleur van intelligentie.", "Blauw.png");
            }
        }
        // Helper function to update color code and information text
       
        // MouseLeave event for the PXL Image (Reset background)
    }
}
