using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab6_AllInOne
{
    public partial class Lab6_1_Form : Form
    {
        private ArrayList myData = new ArrayList();
        private ArrayList sortData = new ArrayList();
        private ArrayList clearData = new ArrayList();

        private Random rnd = new Random();

        private int count = 0;

        public Lab6_1_Form()
        {
            InitializeComponent();
            button_sort.Enabled = false;

            //## Заполнение comboBox ##\\
            for (int i = 4; i < 81; i += 4) {
                comboBox.Items.Add(i.ToString());
            }
        }

        //## Закрытие формы ##\\
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //## Строковое представление массива ##\\
        private string ArrayToString(ArrayList m) {
            string s = "";
            for (int i = 0; i < m.Count; i++) {
                s += m[i] + " ";
            }
            return s;
        }

        //## Сортировка выбором ##\\
        private ArrayList sortSelect(ArrayList x)
        {
            int n = x.Count,
                min = 0;
            Object z;

            for (int i = 0; i < (n - 1); i++) {
                min = i;
                for (int j = (i + 1); j < n; j++)
                    if (Int32.Parse(x[j].ToString()) < Int32.Parse(x[min].ToString()))
                        min = j;
                z = x[i];
                x[i] = x[min];
                x[min] = z;
            }
            return x;
        }

        //## Удаление повторяющихся элементов ##\\
        private ArrayList delRepeats(ArrayList m) {
            int i = 0;
            while (i < m.Count - 1) {
                if (Int32.Parse(m[i].ToString()) == Int32.Parse(m[i + 1].ToString())) {
                    m.RemoveAt(i + 1);
                    count--;
                } else {
                    i++;
                }
            }
            
            return m;
        }

        //## Проверка сортировки ##\\
        public Boolean checkSort(ArrayList m, ArrayList ms)
        {
            int i = 0, range = 200;
            while (i < count - 2 & Int32.Parse(ms[i].ToString()) <= Int32.Parse(ms[i + 1].ToString())) i++;
            if (i < count - 2)
                return false;
            else
            {
                int[] mC = new int[range];
                int[] msC = new int[range];
                for (i = 0; i < range; i++)
                {
                    mC[i] = 0; msC[i] = 0;
                };
                for (i = 0; i < count; i++)
                {
                    mC[Int32.Parse(m[i].ToString()) + range / 2]++;
                    msC[Int32.Parse(ms[i].ToString()) + range / 2]++;
                };
                i = 0;
                while (i < range - 1 & mC[i] == msC[i]) i++;
                if (i == range - 1) return true;
                else return false;
            }
        }


        //## Время рандома! ##\\
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_sort.Enabled = true;

            Int32.TryParse(comboBox.Text, out count);

            myData.Clear();
            //sortData.Clear();
            //clearData.Clear();

            for (int i = 0; i < count; i++) {
                myData.Add(rnd.Next(-99,99));
            }

            textBox.Text += "Созданный массив [" + count + "]:\r\n" + ArrayToString(myData) + "\r\n\r\n";
        }

        //## Сортировка ##\\
        private void button_sort_Click(object sender, EventArgs e)
        {
            sortData = delRepeats(sortSelect(myData));
            //clearData = delRepeats(sortData);

            textBox.Text += "Отсортированный массив [" + count + "]:\r\n" + ArrayToString(sortData) + "\r\n";
            //textBox.Text += "Отсортированный массив [" + count + "]:\r\n" + ArrayToString(clearData) + "\r\n";
            if (checkSort(myData, sortData)) {
                textBox.Text += " ✓ Сортировка правильная\r\n\r\n";
            } else {
                textBox.Text += " × Сортировка неправильная\r\n\r\n";
            }
        }

        private void toolStripButton_showTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Оформить один из алгоритмов сортировки для динамического массива.	
1. Создайте форму для визуального оформления проекта. 
2. Предусмотрите на ней два окна textBox для вывода значений числового динамического массива и отсортированного массива.
3. Для выбора количества элементов массива используйте элемент comboBox.  Воспользуйтесь его свойствами Items и SelectedIndex.
4. Случайные значения элементов динамического массива получите с помощью класса Random и его метода Next.
5. Воспользуйтесь методом Clone() для получения второго объекта ArrayList – динамического массива myAlClone (имя взято для примера), который будет использоваться для написания одного из алгоритмов сортировки. Ниже приведен пример кода с использованием метода Clone().
6. Напишите для динамического массива myAlClone один из алгоритмов сортировки, исследованных в лабораторной работе № 3.
7. Проведите проверку правильности сортировки  с помощью  метода,
написанного в лабораторной работе № 3. 
", "Задание для лабораторной 6.1");
        }
    }
}
