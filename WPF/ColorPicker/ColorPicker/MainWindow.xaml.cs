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
using Int32 = System.Int32;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int _R = 0;
        public int _G = 0;
        public int _B = 0;

        public string r_text;
        public string g_text;
        public string b_text;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorPicker_OnSelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            r_text = ColorPicker.SelectedColor.Value.R.ToString();
            g_text = ColorPicker.SelectedColor.Value.G.ToString();
            b_text = ColorPicker.SelectedColor.Value.B.ToString();
        }


        private void Hex_OnTextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void R_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            bool check;
            check = Int32.TryParse(R.Text, out _R);
            ColorPicker.SelectedColor = Color.FromRgb(Convert.ToByte(_R), Convert.ToByte(_G), Convert.ToByte(_B));
        }

        private void G_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            bool check;
            check = Int32.TryParse(G.Text, out _G);
            ColorPicker.SelectedColor = Color.FromRgb(Convert.ToByte(_R), Convert.ToByte(_G), Convert.ToByte(_B));
        }

        private void B_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            bool check;
            check = Int32.TryParse(B.Text, out _B);
            ColorPicker.SelectedColor = Color.FromRgb(Convert.ToByte(_R), Convert.ToByte(_G), Convert.ToByte(_B));
        }
    }
}
