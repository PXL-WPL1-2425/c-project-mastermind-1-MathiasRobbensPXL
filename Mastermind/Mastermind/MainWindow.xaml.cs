using System.Reflection.Emit;
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
            comboBox1.ItemsSource = colors;
            comboBox2.ItemsSource = colors;
            comboBox3.ItemsSource = colors;
            comboBox4.ItemsSource = colors;

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Als er een kleur is geselecteerd in combobox 1, toon deze in label 1
            //if (comboBox1.SelectedItem != null)
            //label1.Content = comboBox1.SelectedItem.ToString();

            // Doe hetzelfde voor de andere comboboxen en labels
            //if (comboBox2.SelectedItem != null)
            //label2.Content = comboBox2.SelectedItem.ToString();
            //if (comboBox3.SelectedItem != null)
            //label3.Content = comboBox3.SelectedItem.ToString();
            //if (comboBox4.SelectedItem != null)
            //label4.Content = comboBox4.SelectedItem.ToString();

            //Deze code gaf enkel de naam weer van de kleur in het bijhorende label, even bijwerken.

            if (comboBox1.SelectedItem != null)
                label1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(comboBox1.SelectedItem.ToString()));
            if (comboBox2.SelectedItem != null)
                label2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(comboBox2.SelectedItem.ToString()));
            if (comboBox3.SelectedItem != null)
                label3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(comboBox3.SelectedItem.ToString()));
            if (comboBox4.SelectedItem != null)
                label4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(comboBox4.SelectedItem.ToString()));

        }

        private void validateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}