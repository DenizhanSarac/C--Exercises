namespace GameOfLand
{
    partial class BilgiYarismasi
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.labelpuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldogru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelsoru = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelzaman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 142);
            this.textBox1.TabIndex = 0;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(12, 188);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(115, 38);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(186, 188);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(115, 38);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(12, 260);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(115, 38);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(186, 260);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(115, 38);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonraki.Location = new System.Drawing.Point(644, 12);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(115, 38);
            this.btnsonraki.TabIndex = 5;
            this.btnsonraki.Text = "Başla";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // labelpuan
            // 
            this.labelpuan.AutoSize = true;
            this.labelpuan.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpuan.Location = new System.Drawing.Point(691, 102);
            this.labelpuan.Name = "labelpuan";
            this.labelpuan.Size = new System.Drawing.Size(17, 19);
            this.labelpuan.TabIndex = 7;
            this.labelpuan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(640, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puan:";
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.Location = new System.Drawing.Point(672, 178);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(36, 13);
            this.labeldogru.TabIndex = 9;
            this.labeldogru.Text = "Doğru";
            this.labeldogru.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(640, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soru:";
            // 
            // labelsoru
            // 
            this.labelsoru.AutoSize = true;
            this.labelsoru.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoru.Location = new System.Drawing.Point(691, 135);
            this.labelsoru.Name = "labelsoru";
            this.labelsoru.Size = new System.Drawing.Size(17, 19);
            this.labelsoru.TabIndex = 10;
            this.labelsoru.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(644, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(640, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Süre:";
            // 
            // labelzaman
            // 
            this.labelzaman.AutoSize = true;
            this.labelzaman.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelzaman.Location = new System.Drawing.Point(691, 207);
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Size = new System.Drawing.Size(17, 19);
            this.labelzaman.TabIndex = 13;
            this.labelzaman.Text = "0";
            // 
            // BilgiYarismasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelzaman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelsoru);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelpuan);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.textBox1);
            this.Name = "BilgiYarismasi";
            this.Text = "BilgiYarismasi";
            this.Load += new System.EventHandler(this.BilgiYarismasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Label labelpuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsoru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelzaman;
    }
}