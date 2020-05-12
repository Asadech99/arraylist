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

namespace arraylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arraylist;
        private object arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arraylist = new Arraylist();

        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            //show data

            
            foreach (string data in arraylist)
            {

                MessageBox.Show("Count : " + arraylist.Count.ToString() + "Data : " + data);
            }

        }
        //add data
        private void add_Click(object sender, RoutedEventArgs e)
        {
            arraylist.Add(infor.Text);
            MessageBox.Show("add ข้อมูลสำเร็จ");
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            arraylist.Remove(infor.Text);
            MessageBox.Show("Remove ข้อมูลสำเร็จ");
        }

        
    }

}
