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
    /// Логика взаимодействия для Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            
            int value;
            if(Int32.TryParse(txtcolumns.Text, out value))
            {
                Pass.CulumnCount= value;
            }
            else 
            {
                MessageBox.Show("Ошибка в указании столбца");
                txtcolumns.Focus();
                return;
            }
            if(Int32.TryParse(txtrows.Text, out value))
            {
                Pass.RuwCount = value;
            }
            else
            {
                MessageBox.Show("Ошибка в указании cтрок");
                txtrows.Focus();
                return;
            }
            Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
           
            txtcolumns.Focus();
            txtcolumns.Text =Pass.CulumnCount.ToString();
            txtrows.Text = Pass.RuwCount.ToString();
        }
    }
}
