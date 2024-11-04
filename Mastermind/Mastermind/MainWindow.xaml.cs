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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> colors = new List<string> { "Red", "Yellow", "Orange", "White", "Green", "Bleu" };
        List<string> chosenColors = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            RandomColors();
            ComboBoxes();
        }
        private void RandomColors()
        {

            Random random = new Random();
            for (int i = 0; i < 4; i++) 
            { 
             int index = random.Next(colors.Count);
                chosenColors.Add(colors[index]);
            
            }
            string colorstring = string.Join(",", chosenColors);
            Title = "Mastermind: " + colorstring;
        }

        private void ComboBoxes()
        {

            foreach (string colors in colors)
            {
                comboBox1.Items.Add(colors);
                comboBox2.Items.Add(colors);
                comboBox3.Items.Add(colors);
                comboBox4.Items.Add(colors);
            }
        }
    }
}