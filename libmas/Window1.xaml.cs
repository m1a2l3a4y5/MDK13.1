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
using System.Windows.Shapes;

namespace libmas
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            txtPas.Focus();
        }

        private void Voiti(object sender, RoutedEventArgs e)
        {
            if (txtPas.Password == "123") Close();
            else
            {
                MessageBox.Show("Пароль неверен. Повторите ввод");
                txtPas.Focus();
            }
        }

        private void Esc(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Вы желаете завершить работу с программой?", "Выход изпрограммы", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;               
            }
        }
    }
}
