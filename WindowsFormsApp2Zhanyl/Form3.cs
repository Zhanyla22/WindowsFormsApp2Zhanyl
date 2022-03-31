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
    public partial class Form3 : Form
    {
        int[] nums;
        public Form3()
        {
            InitializeComponent();
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
            
            for (int i = 0; i <= nums.Length; i++)
            {
                if (nums[i + 1] > 0 && nums[i] > 0)
                {
                    listBox1.Items.Add("в массиве имеется два подряд идущих положительных");
                    break;
                }
                if (nums[i + 1] < 0 && nums[i] > 0)
                {
                    listBox1.Items.Add("в массиве не имеется два подряд идущих положительных");
                    break;
                }

            }
        }
    }
}
