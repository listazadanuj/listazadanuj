namespace WindowsFormsApplication1
{
    partial class Wydarzenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wydarzenie));
            this.button_do_zrobienia = new System.Windows.Forms.Button();
            this.button_przypomnienie = new System.Windows.Forms.Button();
            this.button_lista_zakupow = new System.Windows.Forms.Button();
            this.button_wydarzenie = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.text_box_check_name = new System.Windows.Forms.TextBox();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.comboBox_kategory = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_do_zrobienia
            // 
            this.button_do_zrobienia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_do_zrobienia.BackgroundImage")));
            this.button_do_zrobienia.Location = new System.Drawing.Point(24, 467);
            this.button_do_zrobienia.Name = "button_do_zrobienia";
            this.button_do_zrobienia.Size = new System.Drawing.Size(293, 30);
            this.button_do_zrobienia.TabIndex = 15;
            this.button_do_zrobienia.UseVisualStyleBackColor = true;
            this.button_do_zrobienia.Click += new System.EventHandler(this.button_do_zrobienia_Click);
            // 
            // button_przypomnienie
            // 
            this.button_przypomnienie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_przypomnienie.BackgroundImage")));
            this.button_przypomnienie.Location = new System.Drawing.Point(24, 352);
            this.button_przypomnienie.Name = "button_przypomnienie";
            this.button_przypomnienie.Size = new System.Drawing.Size(293, 30);
            this.button_przypomnienie.TabIndex = 14;
            this.button_przypomnienie.UseVisualStyleBackColor = true;
            this.button_przypomnienie.Click += new System.EventHandler(this.button_przypomnienie_Click);
            // 
            // button_lista_zakupow
            // 
            this.button_lista_zakupow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_lista_zakupow.BackgroundImage")));
            this.button_lista_zakupow.Location = new System.Drawing.Point(24, 410);
            this.button_lista_zakupow.Name = "button_lista_zakupow";
            this.button_lista_zakupow.Size = new System.Drawing.Size(293, 30);
            this.button_lista_zakupow.TabIndex = 13;
            this.button_lista_zakupow.UseVisualStyleBackColor = true;
            this.button_lista_zakupow.Click += new System.EventHandler(this.button_lista_zakupow_Click);
            // 
            // button_wydarzenie
            // 
            this.button_wydarzenie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_wydarzenie.BackgroundImage")));
            this.button_wydarzenie.Location = new System.Drawing.Point(24, 291);
            this.button_wydarzenie.Name = "button_wydarzenie";
            this.button_wydarzenie.Size = new System.Drawing.Size(293, 30);
            this.button_wydarzenie.TabIndex = 12;
            this.button_wydarzenie.UseVisualStyleBackColor = true;
            this.button_wydarzenie.Click += new System.EventHandler(this.button_wydarzenie_Click);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_search.Location = new System.Drawing.Point(820, 142);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 30);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Szukaj";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // text_box_check_name
            // 
            this.text_box_check_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_check_name.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_box_check_name.Location = new System.Drawing.Point(628, 43);
            this.text_box_check_name.Name = "text_box_check_name";
            this.text_box_check_name.Size = new System.Drawing.Size(286, 26);
            this.text_box_check_name.TabIndex = 10;
            this.text_box_check_name.Text = "nazwa";
            // 
            // comboBox_date
            // 
            this.comboBox_date.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(793, 96);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(121, 21);
            this.comboBox_date.TabIndex = 9;
            this.comboBox_date.Text = "data";
            // 
            // comboBox_kategory
            // 
            this.comboBox_kategory.ForeColor = System.Drawing.Color.Black;
            this.comboBox_kategory.FormattingEnabled = true;
            this.comboBox_kategory.Items.AddRange(new object[] {
            "Wydarzenie",
            "Przypomnienie",
            "Lista zakupów",
            "Do zrobienia"});
            this.comboBox_kategory.Location = new System.Drawing.Point(628, 96);
            this.comboBox_kategory.Name = "comboBox_kategory";
            this.comboBox_kategory.Size = new System.Drawing.Size(136, 21);
            this.comboBox_kategory.TabIndex = 8;
            this.comboBox_kategory.Text = "kategoria";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(469, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 26);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(385, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(385, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Opis";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(469, 282);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 71);
            this.textBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(385, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Priorytet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(469, 373);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(385, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(469, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 26);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(385, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Alarm";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(469, 466);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 26);
            this.textBox4.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Format: dd-mm-yy-hh-mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data. Format j.w";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(653, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(625, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "labe;";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Wydarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 660);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_do_zrobienia);
            this.Controls.Add(this.button_przypomnienie);
            this.Controls.Add(this.button_lista_zakupow);
            this.Controls.Add(this.button_wydarzenie);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.text_box_check_name);
            this.Controls.Add(this.comboBox_date);
            this.Controls.Add(this.comboBox_kategory);
            this.Name = "Wydarzenie";
            this.Text = "Wydarzenie";
            this.Load += new System.EventHandler(this.Wydarzenie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_do_zrobienia;
        private System.Windows.Forms.Button button_przypomnienie;
        private System.Windows.Forms.Button button_lista_zakupow;
        private System.Windows.Forms.Button button_wydarzenie;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox text_box_check_name;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.ComboBox comboBox_kategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;

    }
}