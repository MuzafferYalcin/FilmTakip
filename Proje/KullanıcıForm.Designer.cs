namespace Proje
{
    partial class KullanıcıForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            izlediklerimDGV = new DataGridView();
            izleyeceklerimDGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label16 = new Label();
            label15 = new Label();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label18 = new Label();
            label17 = new Label();
            button2 = new Button();
            label3 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)izlediklerimDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)izleyeceklerimDGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // izlediklerimDGV
            // 
            izlediklerimDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            izlediklerimDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izlediklerimDGV.Location = new Point(54, 100);
            izlediklerimDGV.Name = "izlediklerimDGV";
            izlediklerimDGV.RowHeadersWidth = 51;
            izlediklerimDGV.RowTemplate.Height = 29;
            izlediklerimDGV.Size = new Size(534, 308);
            izlediklerimDGV.TabIndex = 0;
            izlediklerimDGV.CellClick += izlediklerimDGV_CellClick;
            // 
            // izleyeceklerimDGV
            // 
            izleyeceklerimDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            izleyeceklerimDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izleyeceklerimDGV.Location = new Point(654, 100);
            izleyeceklerimDGV.Name = "izleyeceklerimDGV";
            izleyeceklerimDGV.RowHeadersWidth = 51;
            izleyeceklerimDGV.RowTemplate.Height = 29;
            izleyeceklerimDGV.Size = new Size(580, 308);
            izleyeceklerimDGV.TabIndex = 1;
            izleyeceklerimDGV.CellClick += izleyeceklerimDGV_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "İzlediklerim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 54);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "İzleyeceklerim";
            // 
            // panel1
            // 
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(54, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 245);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(157, 22);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 10;
            label16.Text = "label16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(40, 22);
            label15.Name = "label15";
            label15.Size = new Size(22, 20);
            label15.TabIndex = 9;
            label15.Text = "Id";
            // 
            // button1
            // 
            button1.Location = new Point(349, 194);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 8;
            button1.Text = "Çıkar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 165);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 7;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(157, 104);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 6;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 65);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 5;
            label8.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 165);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 3;
            label6.Text = "Yıl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 104);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 2;
            label5.Text = "Yönetmen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 65);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 1;
            label4.Text = "Ad";
            // 
            // panel2
            // 
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(654, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 245);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(155, 22);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 10;
            label18.Text = "label18";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(43, 21);
            label17.Name = "label17";
            label17.Size = new Size(22, 20);
            label17.TabIndex = 9;
            label17.Text = "Id";
            // 
            // button2
            // 
            button2.Location = new Point(344, 194);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 8;
            button2.Text = "Çıkar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 177);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 116);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(155, 65);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 5;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 177);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 3;
            label12.Text = "Yıl";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 116);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 2;
            label13.Text = "Yönetmen";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 65);
            label14.Name = "label14";
            label14.Size = new Size(28, 20);
            label14.TabIndex = 1;
            label14.Text = "Ad";
            // 
            // KullanıcıForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 776);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(izleyeceklerimDGV);
            Controls.Add(izlediklerimDGV);
            Name = "KullanıcıForm";
            Text = "KullanıcıForm";
            Load += KullanıcıForm_Load;
            ((System.ComponentModel.ISupportInitialize)izlediklerimDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)izleyeceklerimDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView izlediklerimDGV;
        private DataGridView izleyeceklerimDGV;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button button2;
        private Label label3;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label15;
        private Label label18;
        private Label label17;
    }
}