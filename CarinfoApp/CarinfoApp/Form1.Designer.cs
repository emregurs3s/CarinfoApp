namespace CarinfoApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_Marka = new TextBox();
            textBox_Model = new TextBox();
            textBox_Renk = new TextBox();
            textBox_KapiSayisi = new TextBox();
            textBox_PencereSayisi = new TextBox();
            textBox_Yakit = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 60);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 110);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Model:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 210);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Kapı Sayisi :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 160);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Renk:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 310);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 4;
            label5.Text = "100 km’de Yaktığı Yakıt (Litre):";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 260);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Pencere Sayısı:";
            // 
            // textBox_Marka
            // 
            textBox_Marka.Location = new Point(381, 53);
            textBox_Marka.Name = "textBox_Marka";
            textBox_Marka.Size = new Size(334, 27);
            textBox_Marka.TabIndex = 6;
            textBox_Marka.TextChanged += textBox1_TextChanged;
            // 
            // textBox_Model
            // 
            textBox_Model.Location = new Point(381, 103);
            textBox_Model.Name = "textBox_Model";
            textBox_Model.Size = new Size(334, 27);
            textBox_Model.TabIndex = 7;
            // 
            // textBox_Renk
            // 
            textBox_Renk.Location = new Point(381, 153);
            textBox_Renk.Name = "textBox_Renk";
            textBox_Renk.Size = new Size(334, 27);
            textBox_Renk.TabIndex = 8;
            // 
            // textBox_KapiSayisi
            // 
            textBox_KapiSayisi.Location = new Point(381, 203);
            textBox_KapiSayisi.Name = "textBox_KapiSayisi";
            textBox_KapiSayisi.Size = new Size(334, 27);
            textBox_KapiSayisi.TabIndex = 9;
            textBox_KapiSayisi.TextChanged += textBox_Kapisayisi_TextChanged;
            // 
            // textBox_PencereSayisi
            // 
            textBox_PencereSayisi.Location = new Point(381, 253);
            textBox_PencereSayisi.Name = "textBox_PencereSayisi";
            textBox_PencereSayisi.Size = new Size(334, 27);
            textBox_PencereSayisi.TabIndex = 10;
            // 
            // textBox_Yakit
            // 
            textBox_Yakit.Location = new Point(381, 303);
            textBox_Yakit.Name = "textBox_Yakit";
            textBox_Yakit.Size = new Size(334, 27);
            textBox_Yakit.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(305, 384);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 12;
            button1.Text = "Bilgileri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox_Yakit);
            Controls.Add(textBox_PencereSayisi);
            Controls.Add(textBox_KapiSayisi);
            Controls.Add(textBox_Renk);
            Controls.Add(textBox_Model);
            Controls.Add(textBox_Marka);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_Marka;
        private TextBox textBox_Model;
        private TextBox textBox_Renk;
        private TextBox textBox_KapiSayisi;
        private TextBox textBox_PencereSayisi;
        private TextBox textBox_Yakit;
        private Button button1;
    }
}
