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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(AA.Text);
            int D = A % 7;
            string Day = "";
            switch (D)
            {
                case 0: Day = "Воскресенье"; break;
                case 1: Day = "Понедельник"; break;
                case 2: Day = "Вторник"; break;
                case 3: Day = "Среда"; break;
                case 4: Day = "Четверг"; break;
                case 5: Day = "Пятница"; break;
                case 6: Day = "Суббота"; break;
            }
            Rezult.Text = $"Ответ: {Day}";
        }
    }
}
