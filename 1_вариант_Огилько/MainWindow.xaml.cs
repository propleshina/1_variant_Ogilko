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

namespace _1_вариант_Огилько
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool Check(string Task1, string Task2, string Task3, string Task4)
        {
            if (!(string.IsNullOrEmpty(Task1)) && !(string.IsNullOrEmpty(Task2)) && !(string.IsNullOrEmpty(Task3)) && !(string.IsNullOrEmpty(Task4)))
            {
                int mark1;
                int mark2;
                int mark3;
                int mark4;
                bool ismark1 = int.TryParse(Task1, out mark1);
                bool ismark2 = int.TryParse(Task2, out mark2);
                bool ismark3 = int.TryParse(Task3, out mark3);
                bool ismark4 = int.TryParse(Task4, out mark4);
                if (ismark1 && ismark2 && ismark3 && ismark4)
                {
                    if (mark1 == Convert.ToDouble(Task1) && mark2 == Convert.ToDouble(Task2) && mark3 == Convert.ToDouble(Task3) && mark4 == Convert.ToDouble(Task4))
                    {
                        if (mark1 > 10 || mark1 < 0)
                        {
                            MessageBox.Show("В 1 задании можно набрать от 0 до 10 баллов");
                            return false;
                        }
                        else if (mark2 > 50 || mark2 < 0)
                        {
                            MessageBox.Show("В 2 задании можно набрать от 0 до 50 баллов");
                            return false;
                        }
                        else if (mark3 > 30 || mark3 < 0)
                        {
                            MessageBox.Show("В 3 задании можно набрать от 0 до 30 баллов");
                            return false;
                        }
                        else if (mark4 > 10 || mark4 < 0)
                        {
                            MessageBox.Show("В 4 задании можно набрать от 0 до 10 баллов");
                            return false;
                        }
                        else
                        {
                            int totalmark = mark1 + mark2 + mark3 + mark4;
                            if (totalmark <= 19)
                            {
                                Mark.Text = "«2» (неудовлетворительно)";
                                return true;
                            }
                            else if (totalmark <= 39)
                            {
                                Mark.Text = "«3» (удовлетворительно)";
                                return true;
                            }
                            else if (totalmark <= 69)
                            {
                                Mark.Text = "«4» (хорошо)";
                                return true;
                            }
                            else if (totalmark <= 100)
                            {
                                Mark.Text = "«5» (отлично)";
                                return true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так, попробуйте снова!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели все данные!\n(если за какое-то из заданий получено 0 баллов, пишите 0, не оставляйте поле пустым!)");
                return false;
            }
            return false;
        }

        private void CheckMark_Click(object sender, RoutedEventArgs e)
        {
            Check(Task1.Text, Task2.Text,Task3.Text,Task4.Text);
        }
    }
}
