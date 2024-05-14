namespace Voronoi_diagram
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountOfPointsTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountOfThreadsTB = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleRadio = new System.Windows.Forms.RadioButton();
            this.multiRadio = new System.Windows.Forms.RadioButton();
            this.ShowPointsCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount of Points:";
            // 
            // AmountOfPointsTB
            // 
            this.AmountOfPointsTB.Location = new System.Drawing.Point(162, 98);
            this.AmountOfPointsTB.Margin = new System.Windows.Forms.Padding(4);
            this.AmountOfPointsTB.Name = "AmountOfPointsTB";
            this.AmountOfPointsTB.Size = new System.Drawing.Size(93, 22);
            this.AmountOfPointsTB.TabIndex = 6;
            this.AmountOfPointsTB.Text = "10";
            this.AmountOfPointsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount of Treads:";
            // 
            // AmountOfThreadsTB
            // 
            this.AmountOfThreadsTB.Location = new System.Drawing.Point(162, 155);
            this.AmountOfThreadsTB.Margin = new System.Windows.Forms.Padding(4);
            this.AmountOfThreadsTB.Name = "AmountOfThreadsTB";
            this.AmountOfThreadsTB.Size = new System.Drawing.Size(93, 22);
            this.AmountOfThreadsTB.TabIndex = 8;
            this.AmountOfThreadsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(41, 330);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(190, 57);
            this.GenerateBtn.TabIndex = 9;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(325, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 524);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // singleRadio
            // 
            this.singleRadio.AutoSize = true;
            this.singleRadio.Location = new System.Drawing.Point(77, 219);
            this.singleRadio.Margin = new System.Windows.Forms.Padding(4);
            this.singleRadio.Name = "singleRadio";
            this.singleRadio.Size = new System.Drawing.Size(111, 21);
            this.singleRadio.TabIndex = 11;
            this.singleRadio.TabStop = true;
            this.singleRadio.Text = "single thread";
            this.singleRadio.UseVisualStyleBackColor = true;
            this.singleRadio.CheckedChanged += new System.EventHandler(this.singleRadio_CheckedChanged);
            // 
            // multiRadio
            // 
            this.multiRadio.AutoSize = true;
            this.multiRadio.Location = new System.Drawing.Point(77, 248);
            this.multiRadio.Margin = new System.Windows.Forms.Padding(4);
            this.multiRadio.Name = "multiRadio";
            this.multiRadio.Size = new System.Drawing.Size(103, 21);
            this.multiRadio.TabIndex = 12;
            this.multiRadio.TabStop = true;
            this.multiRadio.Text = "multi thread";
            this.multiRadio.UseVisualStyleBackColor = true;
            // 
            // ShowPointsCB
            // 
            this.ShowPointsCB.AutoSize = true;
            this.ShowPointsCB.Location = new System.Drawing.Point(77, 277);
            this.ShowPointsCB.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPointsCB.Name = "ShowPointsCB";
            this.ShowPointsCB.Size = new System.Drawing.Size(104, 21);
            this.ShowPointsCB.TabIndex = 13;
            this.ShowPointsCB.Text = "show points";
            this.ShowPointsCB.UseVisualStyleBackColor = true;
            this.ShowPointsCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShowPointsCB);
            this.Controls.Add(this.multiRadio);
            this.Controls.Add(this.singleRadio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.AmountOfThreadsTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountOfPointsTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountOfPointsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountOfThreadsTB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton singleRadio;
        private System.Windows.Forms.RadioButton multiRadio;
        private System.Windows.Forms.CheckBox ShowPointsCB;
    }
}

