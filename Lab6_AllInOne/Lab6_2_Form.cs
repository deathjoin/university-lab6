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
    public partial class Lab6_2_Form : Form
    {
        ListNum l = new ListNum(0, true);

        public Lab6_2_Form()
        {
            InitializeComponent();

            textBox_listLenght.Text = "0";

            button_addToEnd.Enabled = false;
            button_addToStart.Enabled = false;
            button_addToRightPlace.Enabled = false;
        }
        
        //## Закрытие формы ##\\
        private void toolStrip_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //## Изменение значения в поле "значение" :) ##\\
        private void onValueChanged(object sender, EventArgs e)
        {
            try {
                Int32.Parse(textBox_value.Text);
                button_addToEnd.Enabled = true;
                button_addToStart.Enabled = true;
                button_addToRightPlace.Enabled = true;
            } catch {
                button_addToEnd.Enabled = false;
                button_addToStart.Enabled = false;
                button_addToRightPlace.Enabled = false;
            }
        }

        //## Показать задание ##\\
        private void toolStrip_showTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Оформить проект для лаб№3, используя тип даннных - линейный список.
1. Создать линейный список, добавляя новый элемент в его начало и конец.
2. Создать упорядоченный линейный список, добавляя очередной элемент как включение в упорядоченный список.
3. Упорядочить методом пузырька линейный список, созданный при выполнении задания №1.", "Задание для лабораторной 6.2");
        }

        //## Показать список ##\\
        private void button_showList_Click(object sender, EventArgs e)
        {
                textBox_output.Text += l.getString();
        }

        //## Добавление в начало списка ##\\
        private void button_addToStart_Click(object sender, EventArgs e)
        {
            l.addToStart(Int32.Parse(textBox_value.Text));
            textBox_listLenght.Text = l.getLength().ToString();
        }

        //## Добавление в конец списка ##\\
        private void button_addToEnd_Click(object sender, EventArgs e)
        {
            l.addToEnd(Int32.Parse(textBox_value.Text));
            textBox_listLenght.Text = l.getLength().ToString();
        }

        //## Добавление без нарушения порядка ##\\
        private void button_addToRightPlace_Click(object sender, EventArgs e)
        {
            l.addToRightPlace(Int32.Parse(textBox_value.Text));
            textBox_listLenght.Text = l.getLength().ToString();
        }

        //## Сортировка слиянием ##\\
        private void button_merge_Click(object sender, EventArgs e)
        {
            if (l.getLength() == 0) {
                textBox_output.Text = l.getString();
            } else {
                l = l.mergeSort();
            }
        }
    }
}
