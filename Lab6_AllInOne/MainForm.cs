using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_AllInOne
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_showFirstTask_Click(object sender, EventArgs e)
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

        private void button_showSecTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Оформить проект для лаб№3, используя тип даннных - линейный список.
1. Создать линейный список, добавляя новый элемент в его начало и конец.
2. Создать упорядоченный линейный список, добавляя очередной элемент как включение в упорядоченный список.
3. Упорядочить методом пузырька линейный список, созданный при выполнении задания №1.", "Задание для лабораторной 6.2");
        }

        private void button_openFirstPart_Click(object sender, EventArgs e)
        {
            Lab6_1_Form form1 = new Lab6_1_Form();
            form1.Show();

            form1.FormClosing += new FormClosingEventHandler(onForm1Closing);

            button_openFirstPart.Enabled = false;
            button_showFirstTask.Enabled = false;
        }

        private void button_openSecPart_Click(object sender, EventArgs e)
        {
            Lab6_2_Form form2 = new Lab6_2_Form();
            form2.Show();

            form2.FormClosing += new FormClosingEventHandler(onForm2Closing);

            button_openSecPart.Enabled = false;
            button_showSecTask.Enabled = false;
        }

        private void onForm1Closing(object sender, FormClosingEventArgs e) {
            button_openFirstPart.Enabled = true;
            button_showFirstTask.Enabled = true;
        }

        private void onForm2Closing(object sender, FormClosingEventArgs e) {
            button_openSecPart.Enabled = true;
            button_showSecTask.Enabled = true;
        }
    }
}
