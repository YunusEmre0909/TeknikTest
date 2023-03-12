namespace TeknikTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num1 = new TextBox();
            num3 = new TextBox();
            num2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            result = new TextBox();
            btnCalculate = new Button();
            label7 = new Label();
            listView1 = new ListView();
            btnPrint = new Button();
            label6 = new Label();
            textBoxMultiplicationTable = new TextBox();
            btnMultiplicationTable = new Button();
            dataGridView1 = new DataGridView();
            btnFileSelect = new Button();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            label8 = new Label();
            textBoxFibonacci = new TextBox();
            btnFibonacci = new Button();
            textBoxFibonacciResult = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(56, 37);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 0;
            // 
            // num3
            // 
            num3.Location = new Point(359, 37);
            num3.Name = "num3";
            num3.Size = new Size(100, 23);
            num3.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(185, 37);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(11, 15);
            label1.TabIndex = 3;
            label1.Text = "(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 40);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(11, 15);
            label2.TabIndex = 4;
            label2.Text = "(";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 40);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 5;
            label3.Text = "x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 40);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 40);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 7;
            label5.Text = "=";
            // 
            // result
            // 
            result.Location = new Point(511, 37);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(536, 84);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 120);
            label7.Name = "label7";
            label7.Size = new Size(602, 15);
            label7.TabIndex = 11;
            label7.Text = "-----------------------------------------------------------------------------------------------------------------------";
            // 
            // listView1
            // 
            listView1.Location = new Point(26, 154);
            listView1.Name = "listView1";
            listView1.Size = new Size(585, 138);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(536, 360);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 386);
            label6.Name = "label6";
            label6.Size = new Size(602, 15);
            label6.TabIndex = 14;
            label6.Text = "-----------------------------------------------------------------------------------------------------------------------";
            label6.Click += label6_Click;
            // 
            // textBoxMultiplicationTable
            // 
            textBoxMultiplicationTable.Location = new Point(26, 415);
            textBoxMultiplicationTable.Name = "textBoxMultiplicationTable";
            textBoxMultiplicationTable.Size = new Size(115, 23);
            textBoxMultiplicationTable.TabIndex = 15;
            // 
            // btnMultiplicationTable
            // 
            btnMultiplicationTable.Location = new Point(258, 415);
            btnMultiplicationTable.Name = "btnMultiplicationTable";
            btnMultiplicationTable.Size = new Size(164, 23);
            btnMultiplicationTable.TabIndex = 16;
            btnMultiplicationTable.Text = "Çarpım Tablosunu Oluştur";
            btnMultiplicationTable.UseVisualStyleBackColor = true;
            btnMultiplicationTable.Click += btnMultiplicationTable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(26, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(585, 213);
            dataGridView1.TabIndex = 17;
            // 
            // btnFileSelect
            // 
            btnFileSelect.Location = new Point(816, 46);
            btnFileSelect.Name = "btnFileSelect";
            btnFileSelect.Size = new Size(75, 23);
            btnFileSelect.TabIndex = 18;
            btnFileSelect.Text = "Dosya Seç";
            btnFileSelect.UseVisualStyleBackColor = true;
            btnFileSelect.Click += btnFileSelect_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(957, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 199);
            listBox1.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(751, 277);
            label8.Name = "label8";
            label8.Size = new Size(562, 15);
            label8.TabIndex = 20;
            label8.Text = "---------------------------------------------------------------------------------------------------------------";
            // 
            // textBoxFibonacci
            // 
            textBoxFibonacci.Location = new Point(976, 316);
            textBoxFibonacci.Name = "textBoxFibonacci";
            textBoxFibonacci.Size = new Size(191, 23);
            textBoxFibonacci.TabIndex = 21;
            // 
            // btnFibonacci
            // 
            btnFibonacci.Location = new Point(772, 315);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(119, 23);
            btnFibonacci.TabIndex = 22;
            btnFibonacci.Text = "Fibonacci Hesapla";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // textBoxFibonacciResult
            // 
            textBoxFibonacciResult.Location = new Point(856, 386);
            textBoxFibonacciResult.Name = "textBoxFibonacciResult";
            textBoxFibonacciResult.Size = new Size(311, 23);
            textBoxFibonacciResult.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 305);
            label9.Name = "label9";
            label9.Size = new Size(573, 15);
            label9.TabIndex = 24;
            label9.Text = "1’den 200’e kadar olan sayılar yazılacak. Ancak sayı 3’ün katı ise sayının yerine ‘zig’ yazılacak, sayı 5’in katı ise";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 320);
            label10.Name = "label10";
            label10.Size = new Size(435, 15);
            label10.TabIndex = 25;
            label10.Text = "sayının yerine ‘zag’ yazılacak. Sayı hem 3’ün hem de 5’in katı ise ‘zigzag’ yazılacak.";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 335);
            label11.Name = "label11";
            label11.Size = new Size(252, 15);
            label11.TabIndex = 26;
            label11.Text = "100’den sonra ‘zigzag’ yerine ‘zagzig’ yazılacak.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 690);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBoxFibonacciResult);
            Controls.Add(btnFibonacci);
            Controls.Add(textBoxFibonacci);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(btnFileSelect);
            Controls.Add(dataGridView1);
            Controls.Add(btnMultiplicationTable);
            Controls.Add(textBoxMultiplicationTable);
            Controls.Add(label6);
            Controls.Add(btnPrint);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(btnCalculate);
            Controls.Add(result);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private TextBox num3;
        private TextBox num2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox result;
        private Button btnCalculate;
        private Label label7;
        private ListView listView1;
        private Button btnPrint;
        private Label label6;
        private TextBox textBoxMultiplicationTable;
        private Button btnMultiplicationTable;
        private DataGridView dataGridView1;
        private Button btnFileSelect;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private Label label8;
        private TextBox textBoxFibonacci;
        private Button btnFibonacci;
        private TextBox textBoxFibonacciResult;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}