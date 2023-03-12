using System;

namespace TeknikTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string multipleOfThree = "zig";
        string multipleOfFive = "zag";
        string multipleThreeAndFive = "zigzag";
        string multipleFiveAndThree = "zagzig";

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            int number1 = int.Parse(num1.Text);
            int number2 = int.Parse(num2.Text);
            int number3 = int.Parse(num3.Text);

            int calculate = (number1 + number2) * number3;
            result.Text = calculate.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {


            for (int i = 1; i <= 200; i++)
            {
                bool three = (i % 3 == 0);
                bool five = (i % 5 == 0);
                bool threeAndFive = (i % 3 == 0 && i % 5 == 0);

                if (i <= 100)
                {
                    if (threeAndFive)
                    {
                        listView1.Items.Add(multipleThreeAndFive);
                    }
                    else if (three)
                    {
                        listView1.Items.Add(multipleOfThree);
                    }
                    else if (five)
                    {
                        listView1.Items.Add(multipleOfFive);
                    }
                    else
                    {
                        listView1.Items.Add(i.ToString());
                    }
                }
                else
                {
                    if (threeAndFive)
                    {
                        listView1.Items.Add(multipleFiveAndThree);
                    }
                    else if (three)
                    {
                        listView1.Items.Add(multipleOfThree);
                    }
                    else if (five)
                    {
                        listView1.Items.Add(multipleOfFive);
                    }
                    else
                    {
                        listView1.Items.Add(i.ToString());
                    }
                }
            }
        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxMultiplicationTable.Text);

            if (num < 13 && num > 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    dataGridView1.Columns.Add("col" + i.ToString(), i.ToString());
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = i.ToString();

                }
                for (int i = 0; i < num; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = (i + 1).ToString();
                }
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        dataGridView1.Rows[i].Cells[j - 1].Value = (i * j).ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen 0-13 arasýnda bir sayý giriniz","Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            List<decimal> numbers = new List<decimal>();

            openFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] nums = line.Split(' ');
                        foreach (var number in nums)
                        {
                            if (decimal.TryParse(number, out decimal parsedNumber))
                            {
                                numbers.Add(parsedNumber);
                            }
                        }
                    }
                }
            }
            numbers.Sort();
            numbers.Reverse();
            foreach (var num in numbers)
            {
                listBox1.Items.Add(num);
            }
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxFibonacci.Text);
            List<long> list = new List<long>();
            list.Add(0);
            list.Add(1);
            for (int i = 1; i < num; i++)
            {
                list.Add(list[i - 1] + list[i]);
            }
            string result = list[num - 1].ToString();
            textBoxFibonacciResult.Text = num + ". Fibonacci sayýsý = " + result;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}