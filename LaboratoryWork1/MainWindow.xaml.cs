using Microsoft.Win32;
using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LaboratoryWork1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList CurrentArray = new ArrayList();
        private readonly int itemCount;

        public MainWindow()
        {
            InitializeComponent();
            string[] TasksArray = { "Расчет №1", "Расчет №2", "№1", "№2", "№3", "№4", "№5", "[Голубой] №2", "[Голубой]  №4", "[Голубой]  №5", "[Зеленый]  №3", "[Зеленый]  №6", "[Зеленый]  №7", "[Зеленый] №16", "[Красный] №8", "[Красный] №9", "[Красный] №10" };
            for (int index = 0; index < TasksArray.Length; index++)
            {
                comboBox_tasks.Items.Add(TasksArray[index]);
            }
            comboBox_tasks.SelectedIndex = 0;
        }

        private void GenArrList(ArrayList myAL, int ItemCount)
        {
            Random rnd1 = new Random();
            int number;
            for (int index = 0; index < ItemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
            }
        } //Генерация ArrayList случайными числами



        private void OutArrList(ArrayList myAL, ListBox myLB)
        {
            for (int index = 0; index < myAL.Count; index++)
            {
                myLB.Items.Add(myAL[index]);
            }
        } //Вывод ArrayList в ListBox

        //1. Дан массив из n чисел. Сколько элементов массива больше своих «соседей»,­ т.е. предыдущег­о и последующе­го. Первый и последний элементы не рассматрив­ать.

        private int Task1(ArrayList myAL)
        {
            int testcout = 0;
            for (int i = 1; i < myAL.Count - 1; i++)
            {
                if ((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[i + 1]) testcout++;
            }
            return testcout;
        }
        //2. Для массива из n чисел найти номер первого элемента, большего 25.

        private int Task2(ArrayList myAL)
        {
            int item_number = -1;
            for (int i = 0; i < myAL.Count; i++)
            {
                if ((int)myAL[i] > 25)
                {
                    item_number = i;
                    break;
                }
            }
            return item_number;
        }
        //3. В массиве из n чисел найти сумму элементов больших, чем второй элемент этого массива.

        private int Task3(ArrayList myAL)
        {
            int sum = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                if ((int)myAL[i] > (int)myAL[1])
                {
                    sum += (int)myAL[i];
                }
            }
            return sum;
        }
        //4. Для массива из n чисел найти номер первого элемента большего K, где K вводится в отдельном дочернем или диалоговом окне.

        private int Task4(ArrayList myAL, int k)
        {
            int Item_number = -1;
            for (int i = 0; i < myAL.Count; i++)
            {
                if ((int)myAL[i] > k)
                {
                    Item_number = i;
                    break;
                }
            }
            return Item_number;
        }
        //5. В массиве из n чисел найти сумму элементов больших, чем K-ый по счету элемент этого массива, где K вводится в отдельном дочернем или диалоговом окне.

        private int Task5(ArrayList myAL, int k)
        {
            int sum = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                if ((int)myAL[i] > (int)myAL[k - 1])
                {
                    sum += (int)myAL[i];
                }
            }
            return sum;
        }


        //2. Дан массив из K чисел. Сколько элементов массива меньше своих «соседей», т.е. предыдущего и последующего. Первый и последний элементы массива считаются соседними, т.е. массив представляет из себя кольцевой список.

        private int BlueTask2(ArrayList myAL)
        {
            int count = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                if (i == 0 && ((int)myAL[i] > (int)myAL[myAL.Count - 1] && (int)myAL[i] > (int)myAL[i + 1]))
                {
                    count++;
                }
                if (i == myAL.Count - 1 && ((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[0]))
                {
                    count++;
                }
                if ((i != 0 && i != myAL.Count - 1) && ((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[i + 1]))
                {
                    count++;
                }
            }
            return count;
        }

        //4. Сколько элементов массива составляют со своими соседями упорядоченную последовательность. Первый и последний элементы массива считаются соседними.

        private int BlueTask4(ArrayList myAL)

        {
            int count = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                if (i == 0 && (((int)myAL[i] >= (int)myAL[myAL.Count - 1] && (int)myAL[i] <= (int)myAL[i + 1]) || ((int)myAL[i] <= (int)myAL[myAL.Count - 1] && (int)myAL[i] >= (int)myAL[i + 1])))
                {
                    count++;
                }
                if (i == myAL.Count - 1 && (((int)myAL[i] >= (int)myAL[i - 1] && (int)myAL[i] <= (int)myAL[0]) || ((int)myAL[i] <= (int)myAL[i - 1] && (int)myAL[i] >= (int)myAL[0])))
                {
                    count++;
                }
                if ((i != 0 && i != myAL.Count - 1) && (((int)myAL[i] >= (int)myAL[i - 1] && (int)myAL[i] <= (int)myAL[i + 1]) || ((int)myAL[i] <= (int)myAL[i - 1] && (int)myAL[i] >= (int)myAL[i + 1])))
                {
                    count++;
                }
            }
            return count;
        }

        //5. Дан массив из K чисел.Замените элементы массива таким образом, чтобы элементы составляли со своими соседями упорядоченную последовательность.Направления последовательности могут меняться.
        private void BlueTask5(ArrayList myAL)
        {
            int temp;
            for (int i = 1; i < myAL.Count - 1; i = i + 3)
            {
                if ((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[i + 1])
                {
                    if ((int)myAL[i - 1] < (int)myAL[i + 1])
                    {
                        temp = (int)myAL[i];
                        myAL[i] = myAL[i + 1];
                        myAL[i + 1] = temp;
                    }
                    else
                    {
                        temp = (int)myAL[i];
                        myAL[i] = myAL[i - 1];
                        myAL[i - 1] = temp;
                    }
                }
                else if ((int)myAL[i] < (int)myAL[i - 1] && (int)myAL[i] < (int)myAL[i + 1])
                {
                    if ((int)myAL[i - 1] < (int)myAL[i + 1])
                    {
                        temp = (int)myAL[i];
                        myAL[i] = myAL[i - 1];
                        myAL[i - 1] = temp;
                    }
                    else
                    {
                        temp = (int)myAL[i];
                        myAL[i] = myAL[i + 1];
                        myAL[i + 1] = temp;
                    }
                }
            }
        }
        //3. Для массива из K чисел найти номер самого малого по значению элемента, значение которого больше среднего значения элементов массива.
        private int GreenTask3(ArrayList myAL)
        {
            int min, sum, average;
            sum = average = min = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                sum += (int)myAL[i];
            }
            average = sum / myAL.Count;
            for (int i = 0; i < myAL.Count; i++)
            {
                if ((int)myAL[i] > average && min == 0)
                {
                    min = (int)myAL[i];
                }
                else if (min > (int)myAL[i] && (int)myAL[i] > average)
                {
                    min = (int)myAL[i];
                }
            }
            return myAL.IndexOf(min) + 1;
        }
        //6. Дан массив из K чисел. Выведите к исходному массиву вместо значений элементов их отклонение от среднего значения элементов массива.
        private void GreenTask6(ArrayList myAL)
        {
            int sum, average;
            sum = average = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                sum += (int)myAL[i];
            }
            average = sum / myAL.Count;
            for (int i = 0; i < myAL.Count; i++)
            {
                myAL[i] = (int)myAL[i] - average;
            }
        }
        //7. Дан массив из K чисел. Найдите среднее значение элементов массива. Замените все элементы массива, отклонение от среднего значения которых больше половины среднего отклонения всех элементов, на среднее значение.
        private void GreenTask7(ArrayList myAL)
        {
            int sum = 0;
            double average, average_deviation;
            average = average_deviation = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                sum += (int)myAL[i];
            }
            average = sum / myAL.Count;
            for (int i = 0; i < myAL.Count; i++)
            {
                average_deviation += Math.Pow(((int)myAL[i] - average), 2);
            }
            average_deviation = Math.Sqrt(average_deviation / myAL.Count);
            for (int i = 0; i < myAL.Count; i++)
            {
                if (Math.Abs((int)myAL[i] - average) > (average_deviation / 2))
                {
                    myAL[i] = Math.Round(average, 2);
                }
            }
        }
        //8. Дан массив из K чисел. Найдите среднее значение элементов массива. Замените все элементы массива, отклонение от среднего значения которых больше L процентов от среднего отклонения всех элементов, на среднее значение.
        private void RedTask8(ArrayList myAL, int k)
        {
            double sum = 0;
            double z = Convert.ToDouble(k) / 100;
            double average, average_deviation;
            average = average_deviation = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                sum += (int)myAL[i];
            }
            average = sum / myAL.Count;
            for (int i = 0; i < myAL.Count; i++)
            {
                average_deviation += Math.Pow(((int)myAL[i] - average), 2);
            }
            average_deviation = Math.Sqrt(average_deviation / myAL.Count);
            for (int i = 0; i < myAL.Count; i++)
            {
                if (Math.Abs((int)myAL[i] - average) > (average_deviation * z))
                {
                    myAL[i] = Math.Round(average, 2);
                }
            }
        }


        //9. Дан массив из K чисел. Найдите среднее значение элементов массива. Измените все элементы массива, отклонение от среднего значения которых больше L процентов от среднего отклонения всех элементов, на коэфициент Z.

        private void RedTask9(ArrayList myAL, int k, double k2) 
        {
            double sum = 0;
            double l = Convert.ToDouble(k) / 100;
            double z = k2;
            double average, average_deviation;
            average = average_deviation = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                sum += (int)myAL[i];
            }
            average = sum / myAL.Count;
            for (int i = 0; i < myAL.Count; i++)
            {
                average_deviation += Math.Pow(((int)myAL[i] - average), 2);
            }
            average_deviation = Math.Sqrt(average_deviation / myAL.Count);
            for (int i = 0; i < myAL.Count; i++)
            {
                if (Math.Abs((int)myAL[i] - average) > (average_deviation * l))
                {
                    myAL[i] = (int)myAL[i] * z;
                }
            }
        }

        //10. Реализуйте многоитерационный алгоритм усреднения (задание 9).

        private void RedTask10(ArrayList myAL, int k, double k2, int n) 
        {
            double sum = 0;
            double l = Convert.ToDouble(k) / 100;
            double z = k2;
            double average, average_deviation;
            average = average_deviation = 0;
            for (int i = 0; i < n; i++)
            {
                sum = average = average_deviation = 0;
                for (int j = 0; j < myAL.Count; j++)
                {
                    sum += Convert.ToDouble(myAL[j]);
                }
                average = sum / myAL.Count;
                for (int j = 0; j < myAL.Count; j++)
                {
                    average_deviation += Math.Pow((Convert.ToDouble(myAL[j]) - average), 2);
                }
                average_deviation = Math.Sqrt(average_deviation / myAL.Count);
                for (int j = 0; j < myAL.Count; j++)
                {
                    if (Math.Abs(Convert.ToDouble(myAL[j]) - average) > (average_deviation * l))
                    {
                        myAL[j] = Math.Round(Convert.ToDouble(myAL[j]) * z, 2);
                        //myAL[j] = Convert.ToDouble(myAL[j]) * z;
                    }
                }
            }
        }

        //16. Реализуйте функцию генерации всеубывающей последовательности значений элементов массива (для каждого следующего элемента случайно не само значение элемента, а его ущерб относительно текущего).
        private void GreenTask16(ArrayList myAL, int ItemCount)
        {
            Random rnd = new Random();
            double num = 0;
            int start_number = rnd.Next(-100, 100);
            for (int index = 0; index < ItemCount; index++)
            {
                if (index == 0)
                {
                    myAL.Add(start_number);
                }
                else
                {
                    num = Convert.ToDouble(myAL[index]) * rnd.NextDouble();
                    myAL.Add(num);
        
                    }
            }
        }
        private void button_task_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int itemCount = Convert.ToInt32(tbN.Text);

                if (comboBox_tasks.Text == "Расчет №1")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                }

                if (comboBox_tasks.Text == "Расчет №2")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    OutArrList(myAL, lbMain);
                    myAL.Sort();
                    CurrentArray = myAL;
                    lbMain.Items.Add("Отсортированный массив:");
                    OutArrList(myAL, lbMain);
                }

                if (comboBox_tasks.Text == "№1")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Кол-во элементов массива больше своих «соседей»: " + Task1(myAL));
                }

                if (comboBox_tasks.Text == "№2")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    int item_num = Task2(myAL);
                    if (item_num == -1)
                    {
                        lbMain.Items.Add("В массиве нет элементов больше 25");
                    }
                    else lbMain.Items.Add("Номер первого элемента, больше 25: " + (item_num + 1));
                }

                if (comboBox_tasks.Text == "№3")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Cумма элементов больших, чем второй элемент\nэтого массива: " + Task3(myAL));
                }

                if (comboBox_tasks.Text == "№4")
                {
                    Window1 GetK = new Window1();

                    if (GetK.ShowDialog() == true)
                    {
                        int k = GetK.K;
                        lbMain.Items.Clear();
                        lbMain.Items.Add("Сгенерированный массив:");
                        ArrayList myAL = new ArrayList();
                        GenArrList(myAL, itemCount);
                        CurrentArray = myAL;
                        OutArrList(myAL, lbMain);
                        int item_num = Task4(myAL, k);
                        if (item_num == -1)
                        {
                            lbMain.Items.Add($"В массиве нет элементов больше " + k);
                        }
                        else lbMain.Items.Add($"Номер первого элемента, больше " + k + ": " + (item_num + 1));
                    }
                }

                if (comboBox_tasks.Text == "№5")
                {
                    Window1 GetK = new Window1();

                    if (GetK.ShowDialog() == true)
                    {
                        int k = GetK.K;
                        lbMain.Items.Clear();
                        lbMain.Items.Add("Сгенерированный массив:");
                        ArrayList myAL = new ArrayList();
                        GenArrList(myAL, itemCount);
                        CurrentArray = myAL;
                        OutArrList(myAL, lbMain);
                        lbMain.Items.Add($"Cумма элементов больших, чем " + k + " элемент\nэтого массива: " + Task5(myAL, k));
                    }
                }



                if (comboBox_tasks.Text == "[Голубой] №2")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Кол-во элементов массива меньше своих «соседей»: " + BlueTask2(myAL));

                }


                if (comboBox_tasks.Text == "[Голубой]  №4")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Кол-во элементов массива составляющих со своими\nсоседями упорядоченную последовательность: " + BlueTask4(myAL));
                }

                if (comboBox_tasks.Text == "[Голубой]  №5")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Измененный массив:");
                    BlueTask5(myAL);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                }



                if (comboBox_tasks.Text == "[Зеленый]  №3")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Номер самого малого по значению элемента, значение\nкоторого больше среднего значения элементов: " + GreenTask3(myAL));
                }

                if (comboBox_tasks.Text == "[Зеленый]  №6")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Измененный массив:");
                    GreenTask6(myAL);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                }

                if (comboBox_tasks.Text == "[Зеленый]  №7")
                {
                    lbMain.Items.Clear();
                    lbMain.Items.Add("Сгенерированный массив:");
                    ArrayList myAL = new ArrayList();
                    GenArrList(myAL, itemCount);
                    OutArrList(myAL, lbMain);
                    lbMain.Items.Add("Измененный массив:");
                    GreenTask7(myAL);
                    CurrentArray = myAL;
                    OutArrList(myAL, lbMain);
                }

                if (comboBox_tasks.Text == "[Красный] №8")
                {
                    Window1 GetK = new Window1();

                    if (GetK.ShowDialog() == true && (GetK.K >= 0 && GetK.K <= 100))
                    {
                        int k = GetK.K;
                        lbMain.Items.Clear();
                        lbMain.Items.Add("Сгенерированный массив:");
                        ArrayList myAL = new ArrayList();
                        GenArrList(myAL, itemCount);
                        OutArrList(myAL, lbMain);
                        lbMain.Items.Add("Измененный массив:");
                        RedTask8(myAL, k);
                        CurrentArray = myAL;
                        OutArrList(myAL, lbMain);
                    }
                }

                if (comboBox_tasks.Text == "[Красный] №9")


                {
                    lbMain.Items.Clear();
                            lbMain.Items.Add("Сгенерированный массив:");
                            ArrayList myAL = new ArrayList();
                            GenArrList(myAL, itemCount);
                            OutArrList(myAL, lbMain);
                    Window1 GetK = new Window1("Введите L:");

                    if (GetK.ShowDialog() == true && (GetK.K >= 0 && GetK.K <= 100))
                    {
                        Window1 GetK2 = new Window1("Введите Z:");
                        if (GetK2.ShowDialog() == true && (GetK2.K_double >= -10 && GetK2.K_double <= 10))
                        {
                            int k = GetK.K;
                            double k2 = GetK2.K_double;
                            
                            lbMain.Items.Add("Измененный массив:");
                            RedTask9(myAL, k, k2);
                            CurrentArray = myAL;
                            OutArrList(myAL, lbMain);


                        }
                    }
                }

                if (comboBox_tasks.Text == "[Красный] №10")
                {lbMain.Items.Add("Сгенерированный массив:");
                                ArrayList myAL = new ArrayList();
                                GenArrList(myAL, itemCount);
                                OutArrList(myAL, lbMain);
                    Window1 GetK = new Window1("Введите L:");

                    if (GetK.ShowDialog() == true && (GetK.K >= 0 && GetK.K <= 100))
                    {
                        Window1 GetK2 = new Window1("Введите Z:");
                        if (GetK2.ShowDialog() == true && (GetK2.K_double >= -10 && GetK2.K_double <= 10))
                        {
                            Window1 GetK3 = new Window1("Введите кол-во итераций:");
                            if (GetK3.ShowDialog() == true && (GetK3.K >= 0 && GetK3.K <= 100))
                            {
                                int k = GetK.K;
                                double k2 = GetK2.K_double;
                                int n = GetK3.K;
                                lbMain.Items.Clear();
                                
                                lbMain.Items.Add("Измененный массив:");
                                RedTask10(myAL, k, k2, n);
                                CurrentArray = myAL;
                                OutArrList(myAL, lbMain);
                            }
                        }
                    }
                }
            
                if (comboBox_tasks.Text == "[Зеленый] №16")
            {
                lbMain.Items.Clear();
                lbMain.Items.Add("Сгенерированный массив:");
                ArrayList myAL = new ArrayList();
                GreenTask16(myAL, itemCount);
                CurrentArray = myAL;
                OutArrList(myAL, lbMain);
            } } 
            
                     catch

            {
                MessageBox.Show(" НЕ корректные данные.", "Ошибка");
            }

}
        private void GenArrList(ArrayList myAL, object itemCount)
        {
            throw new NotImplementedException();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
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

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
        }

        private void button_about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторы:\nЗотова А.А - МФиИ, Группа 121171(3Б)\nХныкина А.А - МФиИ, Группа 121171(3Б)\nМалыгина В.Д  - МФиИ, Группа 121171(3Б)\n☺☺☺", "Об авторе");
        }

        private void button_hist_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentArray.Count > 0)
            {
                histogram Hist = new histogram();
                Hist.CreatingHistogram(CurrentArray);
                Hist.Show();
            }
        }
    }
}