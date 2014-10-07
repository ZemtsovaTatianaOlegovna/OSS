using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;

namespace lab1
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

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели данные");

            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не все введенные символы являются цифрами!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }


            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели данные");
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не все введенные символы являются цифрами!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                myAL.Sort();
                lbMain.Items.Add("Отсортированный массив");
                foreach (int elem in myAL)
                {
                    lbMain.Items.Add(elem);
                }
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели данные");
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не все введенные символы являются цифрами!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                int count = 0;
                for (index = 1; index < myArr.Length - 1; index++)
                    // if(myAL[index] > myAL[index-1])
                    if ((myArr[index - 1] < myArr[index]) && (myArr[index] > myArr[index + 1]))
                        count++;

                lbMain.Items.Add("Количество соседних элементов");
                lbMain.Items.Add(count);
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int num = 25;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели данные");
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не все введенные символы являются цифрами!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 0; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                for (index = 0; index < myArr.Length; index++)
                if (myArr[index] > num)
                {
                    lbMain.Items.Add("Номер элемента");
                    lbMain.Items.Add(index+1);
                    break;

            }
        }}

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели данные");
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не все введенные символы являются цифрами!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 0; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                for (index = 0; index < myArr.Length; index++)
                    if (myArr[index] > myArr[1])
                    {
                        sum += myArr[index];
                    }
                lbMain.Items.Add("Сумма");
                lbMain.Items.Add(sum);
            }
        }

        
        
    }
}
