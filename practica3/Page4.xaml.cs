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

namespace practica3
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(AA.Text);
            int B = int.Parse(BB.Text);
            int C = int.Parse(CC.Text);
            int S1 = A * B;
            int S2 = C * C;
            Rezult.Text = $"Ответ: Поместилось {A/C * B/C} квадратов, оставшаяся площадь  {S1 - A/C * (B/C) * S2}";
        }
    }
}
