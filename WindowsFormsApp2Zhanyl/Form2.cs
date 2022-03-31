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
    public partial class Form2 : Form
    {
        int[] nums;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Print(string str, long k, ListBox LB)
        {
            LB.Items.Add(str + k);
        }
        private void PrintD(string str, double k, ListBox LB)
        {
            LB.Items.Add(str + k);
        }
        private void DisplayArray(int[] A, ListBox LB)
        {
            LB.Items.Clear();
            for (int i = 0; i < A.Length; i++)
                LB.Items.Add(A[i]);
        }
        private void button1_Click(object sender, EventArgs e) // генератор
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            nums = new int[n];
            string str = " ";
            textBox2.Text = "";
            for (int i = 0; i < n; i++)
            {
                nums[i] = rnd.Next(1, n + 1);

                textBox2.AppendText(nums[i] + str);
            }

            DisplayArray(nums, listBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            int nums2 = nums[0];
            int l = 0;
            int summa = 0;
            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] <= nums2)
                {
                    nums2 = nums[i];
                    l = i;

                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    summa += nums[i];
                }

            }




            var str = string.Join(" ", nums);
            listBox1.Items.Add(str);
            Print("Минимальный элемент массива = ", nums2, listBox1);
            Print("Сумма отрицательных элементов массива = ", summa, listBox1);
            listBox1.Items.Add("Соотношение = "+nums2 +"/"+summa);
            if (summa == 0)
            {
                listBox1.Items.Add("ошибка отрицательных нет");
            }
        }
    }
}

 
