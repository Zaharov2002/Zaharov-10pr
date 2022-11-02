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

namespace Zaharov_10pr
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Add(textBox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Remove(textBox1.Text);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }
    }
}
