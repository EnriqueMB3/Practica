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

namespace U2CombinacionDeColores
{
    /// <summary>
    /// Lógica de interacción para UCombinacionColores.xaml
    /// </summary>
    public partial class UCombinacionColores : UserControl
    {
        public UCombinacionColores()
        {
            InitializeComponent();
        }
        //private void RGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    //Color color = Color.FromArgb((byte)A.Value, (byte)R.Value, (byte)G.Value, (byte)B.Value);
        //    //brdColor.Background = new SolidColorBrush(color);
        //    //CodeColor.Text = color.ToString();
        //}

        private void Grid_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromArgb((byte)A.Value, (byte)R.Value, (byte)G.Value, (byte)B.Value);
            brdColor.Background = new SolidColorBrush(color);
            CodeColor.Text = color.ToString();
        }
                                                                                     
        private void brdColor_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(brdColor.Background.ToString());
        }
    }
}
