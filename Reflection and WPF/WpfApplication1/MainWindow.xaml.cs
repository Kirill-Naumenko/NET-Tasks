using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, RoutedEventArgs e)
        {
  
            //Очистка 1 и 2 колонок при выборе новой директории
                if (listBox.SelectedItem != null || listBox1.SelectedItem != null)
                {

                    listBox.SelectedItem = null;
                    listBox1.SelectedItem = null;
                }

                listBox.Items.Clear();
                listBox1.Items.Clear();
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();
                tbText.Text = dialog.SelectedPath;
                
                try
                {
                //Catch если при выборе директории не было выбрано ничего
                    string[] Files = Directory.GetFiles(dialog.SelectedPath.ToString(), "*.dll");
                    foreach (var x in Files)
                    {
                        listBox.Items.Add(x);
                    }
                }
                catch( ArgumentException)
                {
                    
                }
                
            

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {

                listBox1.SelectedItem = null;
                this.listBox1.Items.Clear();
            }

            if (listBox.SelectedItem != null)
            {
                this.listBox1.Items.Clear();
                listBox2.Items.Clear();
                var temp = listBox.SelectedItem.ToString();
                Assembly assembly = Assembly.LoadFile(temp);
                var x = assembly.GetTypes();
                foreach (var t in x)
                {
                    listBox1.Items.Add(t);

                }
            }
            

            
            
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            listBox2.Items.Clear();
            //if (listBox1.SelectedItem != null)
            //{
            //    listBox2.Items.Clear();
            //    var x = (Type)listBox1.SelectedItem;//.GetType();
            //    var meth = x.GetMethods();

            //    foreach (var y in meth)
            //    {
            //        listBox2.Items.Add(y);
            //    }
            //}

        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void radioButtonMethods_Checked(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                var x = (Type)listBox1.SelectedItem;//.GetType();
                var meth = x.GetMethods();

                foreach (var y in meth)
                {
                    listBox2.Items.Add(y);
                }
            }
        }

        private void radioButtonAll_Checked(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                var x = (Type)listBox1.SelectedItem;//.GetType();
                var Meth = x.GetMethods();
                foreach (var y in Meth)
                {
                    listBox2.Items.Add(y);
                }

                var Fields = x.GetFields();
                foreach (var y in Fields)
                {
                    listBox2.Items.Add(y);
                }

                var Properties = x.GetProperties();
                foreach (var y in Properties)
                {
                    listBox2.Items.Add(y);
                }

            }
        }

        private void radioButtonFields_Checked(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                var x = (Type)listBox1.SelectedItem;//.GetType(); 

                var Fields = x.GetFields();
                foreach (var y in Fields)
                {
                    listBox2.Items.Add(y);
                }


            }
        }

        private void radioButtonProperties_Checked(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                var x = (Type)listBox1.SelectedItem;//.GetType();
               
                var Properties = x.GetProperties();
                foreach (var y in Properties)
                {
                    listBox2.Items.Add(y);
                }

            }
        }
    }
}
