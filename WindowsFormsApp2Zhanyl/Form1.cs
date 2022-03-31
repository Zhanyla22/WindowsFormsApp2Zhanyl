using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Zhanyl
{
    public partial class Form1 : Form
    {
        int[] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayArray(int[] A, ListBox LB)
        {
            LB.Items.Clear();
            for (int i = 0; i < A.Length; i++)
                LB.Items.Add(A[i]);
        }
        private void Print(string str, long k, ListBox LB)
        {
            LB.Items.Add(str + k);
        }
        private void PrintD(string str, double k, ListBox LB)
        {
            LB.Items.Add(str + k);
        }






        private void button1_Click(object sender, EventArgs e) // генератор
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            mas = new int[n];
            string str = " ";
            textBox2.Text = "";
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, n + 1);

                textBox2.AppendText(mas[i] + str);
            }

            DisplayArray(mas, listBox1);

        }

        private void button2_Click(object sender, EventArgs e) //найти
        {
            int i;          //текущий индекс
            int max;        //максимальный элемент
            int k = 0;      //индекс максимального элемента
            int kol_vo_max = 0; //кол-во максимальных элементов массива
            int ind = 0;            //индекс последнего максимального элемента
            int sum = 0;            //сумма элементов массива
            long proiz = 1;     //произведение элементов массива
            double otn = 0.0;		//отношение произведения элементов массива к сумме
            int m = mas.Length;

            max = mas[0];

            for (i = 1; i < m; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    k = i;
                }
            }

            for (i = 0; i < m; i++)
            {
                if (mas[i] == max)
                {
                    kol_vo_max++;
                    ind = i;
                }
                k = ind;
            }
            for (i = 0; i < m; i++)
            {
                if (i < k)
                    proiz *= mas[i];
                if (i > k)
                    sum += mas[i];
            }

            Print("Максимальный элемент=", max, listBox1);

            Print("kol-vo max=", kol_vo_max, listBox1);
            Print("index poslednego max elementa=", k, listBox1);

            otn = Convert.ToDouble(proiz) / Convert.ToDouble(sum);

            if (sum == 0) Print("net elementov raspolojennih posle poslednego max=", max, listBox1);
            else
                    if (proiz == 1) Print("net elementov raspolojennih do poslednego max=", max, listBox1);
            else
            {
                Print("proizvedenie elementov massiva, raspologengih do max elementa =", proiz, listBox1);
                Print("summa elementov massiva, raspologengih posle poslednego max elementa =", sum, listBox1);
                PrintD("otnoshenie prozvedeniya k summe =", otn, listBox1);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
