using System;
using System.Collections;
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

namespace HashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            hashtable.Add(keyTextBox.Text, valueTextBox.Text);
            MessageBox.Show("Added Key: " + keyTextBox.Text + " to Hashtable.");
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(keyTextBox.Text);
            MessageBox.Show("Removed Key: " + keyTextBox.Text + " from Hashtable.");
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show All
            foreach (string key in icollection)
            {
                MessageBox.Show(key + ": " + hashtable[key].ToString());
            }
        }
    }
}
