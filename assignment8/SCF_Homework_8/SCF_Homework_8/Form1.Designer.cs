namespace SCF_Homework_6._1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 2);
            tableLayoutPanel1.Controls.Add(button3, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 193);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5108376F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.4891624F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tableLayoutPanel1.Size = new Size(1004, 438);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 134);
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(486, 122);
            button1.TabIndex = 0;
            button1.Text = "新建订单";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(505, 294);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(486, 131);
            button2.TabIndex = 1;
            button2.Text = "退出";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 134);
            button3.Location = new Point(505, 13);
            button3.Name = "button3";
            button3.Size = new Size(486, 122);
            button3.TabIndex = 2;
            button3.Text = "查询订单";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 134);
            button4.Location = new Point(13, 141);
            button4.Name = "button4";
            button4.Padding = new Padding(10);
            button4.Size = new Size(486, 147);
            button4.TabIndex = 3;
            button4.Text = "删除订单";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 134);
            button5.Location = new Point(505, 141);
            button5.Name = "button5";
            button5.Padding = new Padding(10);
            button5.Size = new Size(486, 147);
            button5.TabIndex = 4;
            button5.Text = "修改订单";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 134);
            button6.Location = new Point(13, 294);
            button6.Name = "button6";
            button6.Padding = new Padding(10);
            button6.Size = new Size(486, 131);
            button6.TabIndex = 5;
            button6.Text = "查询利润";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(205, 75);
            label1.Name = "label1";
            label1.Size = new Size(624, 47);
            label1.TabIndex = 2;
            label1.Text = "欢迎使用淘多多，请选择您的服务>.<";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 631);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
