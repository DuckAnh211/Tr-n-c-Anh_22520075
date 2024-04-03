using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520075_Lab2
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputFile = "input3.txt";
            string outputFile = "output3.txt";

            try
            {                
                string[] lines = File.ReadAllLines(inputFile);

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    foreach (string line in lines)
                    {
                        string result = Tinh(line);
                        richTextBox1.AppendText(result + "\n");
                        writer.WriteLine(result);
                    }
                }

                Console.WriteLine("Đã tính toán và ghi kết quả xuống file output3.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private string Tinh(string expression)
        {
            expression = expression.Replace(" ", "");

            char[] operators = { '+', '-', '*', '/' };

            string[] elements = expression.Split(operators);

            double result = double.Parse(elements[0]);

            for (int i = 1; i < elements.Length; i++)
            {

                char op = expression[expression.IndexOf(elements[i]) - 1];

                double nextNumber = double.Parse(elements[i]);

                switch (op)
                {
                    case '+':
                        result += nextNumber;
                        break;
                    case '-':
                        result -= nextNumber;
                        break;
                    case '*':
                        result *= nextNumber;
                        break;
                    case '/':
                        result /= nextNumber;
                        break;
                }
            }
            return expression + " = " + result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
