namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox_kategory = new System.Windows.Forms.ComboBox();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.text_box_check_name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_wydarzenie = new System.Windows.Forms.Button();
            this.button_przypomnienie = new System.Windows.Forms.Button();
            this.button_do_zrobienia = new System.Windows.Forms.Button();
            this.button_lista_zakupow = new System.Windows.Forms.Button();
            this.ostatnio_dodane = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.comboBox_kategory.Location = new System.Drawing.Point(626, 95);
            this.comboBox_kategory.Name = "comboBox_kategory";
            this.comboBox_kategory.Size = new System.Drawing.Size(136, 21);
            this.comboBox_kategory.TabIndex = 0;
            this.comboBox_kategory.Text = "kategoria";
            this.comboBox_kategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategory_SelectedIndexChanged);
            // 
            // comboBox_date
            // 
            this.comboBox_date.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(791, 95);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(121, 21);
            this.comboBox_date.TabIndex = 1;
            this.comboBox_date.Text = "data";
            this.comboBox_date.SelectedIndexChanged += new System.EventHandler(this.comboBox_date_SelectedIndexChanged);
            // 
            // text_box_check_name
            // 
            this.text_box_check_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_check_name.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_box_check_name.Location = new System.Drawing.Point(626, 42);
            this.text_box_check_name.Name = "text_box_check_name";
            this.text_box_check_name.Size = new System.Drawing.Size(286, 26);
            this.text_box_check_name.TabIndex = 2;
            this.text_box_check_name.Text = "nazwa";
            this.text_box_check_name.TextChanged += new System.EventHandler(this.text_box_check_name_TextChanged);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_search.Location = new System.Drawing.Point(818, 141);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 32);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Szukaj";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_wydarzenie
            // 
            this.button_wydarzenie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_wydarzenie.BackgroundImage")));
            this.button_wydarzenie.Location = new System.Drawing.Point(22, 290);
            this.button_wydarzenie.Name = "button_wydarzenie";
            this.button_wydarzenie.Size = new System.Drawing.Size(293, 32);
            this.button_wydarzenie.TabIndex = 4;
            this.button_wydarzenie.UseVisualStyleBackColor = true;
            this.button_wydarzenie.Click += new System.EventHandler(this.button_wydarzenie_Click);
            // 
            // button_przypomnienie
            // 
            this.button_przypomnienie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_przypomnienie.BackgroundImage")));
            this.button_przypomnienie.Location = new System.Drawing.Point(22, 351);
            this.button_przypomnienie.Name = "button_przypomnienie";
            this.button_przypomnienie.Size = new System.Drawing.Size(293, 32);
            this.button_przypomnienie.TabIndex = 6;
            this.button_przypomnienie.UseVisualStyleBackColor = true;
            // 
            // button_do_zrobienia
            // 
            this.button_do_zrobienia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_do_zrobienia.BackgroundImage")));
            this.button_do_zrobienia.Location = new System.Drawing.Point(22, 466);
            this.button_do_zrobienia.Name = "button_do_zrobienia";
            this.button_do_zrobienia.Size = new System.Drawing.Size(293, 32);
            this.button_do_zrobienia.TabIndex = 7;
            this.button_do_zrobienia.UseVisualStyleBackColor = true;
            // 
            // button_lista_zakupow
            // 
            this.button_lista_zakupow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_lista_zakupow.BackgroundImage")));
            this.button_lista_zakupow.Location = new System.Drawing.Point(22, 409);
            this.button_lista_zakupow.Name = "button_lista_zakupow";
            this.button_lista_zakupow.Size = new System.Drawing.Size(293, 32);
            this.button_lista_zakupow.TabIndex = 5;
            this.button_lista_zakupow.UseVisualStyleBackColor = true;
            // 
            // ostatnio_dodane
            // 
            this.ostatnio_dodane.AutoSize = true;
            this.ostatnio_dodane.Location = new System.Drawing.Point(367, 309);
            this.ostatnio_dodane.Name = "ostatnio_dodane";
            this.ostatnio_dodane.Size = new System.Drawing.Size(35, 13);
            this.ostatnio_dodane.TabIndex = 8;
            this.ostatnio_dodane.Text = "label1";
            this.ostatnio_dodane.Click += new System.EventHandler(this.ostatnio_dodane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(626, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ostatnio_dodane);
            this.Controls.Add(this.button_do_zrobienia);
            this.Controls.Add(this.button_przypomnienie);
            this.Controls.Add(this.button_lista_zakupow);
            this.Controls.Add(this.button_wydarzenie);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.text_box_check_name);
            this.Controls.Add(this.comboBox_date);
            this.Controls.Add(this.comboBox_kategory);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_kategory;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.TextBox text_box_check_name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_wydarzenie;
        private System.Windows.Forms.Button button_przypomnienie;
        private System.Windows.Forms.Button button_do_zrobienia;
        private System.Windows.Forms.Button button_lista_zakupow;
        private System.Windows.Forms.Label ostatnio_dodane;
        private System.Windows.Forms.Label label1;
    }
}