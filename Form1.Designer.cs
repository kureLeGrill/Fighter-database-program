namespace Client
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
            this.label8 = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReWrightFighter = new System.Windows.Forms.ToolStripMenuItem();
            this.addFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxForAgeTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxForReachFrom = new System.Windows.Forms.TextBox();
            this.text_box_for_height_from = new System.Windows.Forms.TextBox();
            this.text_box_for_age = new System.Windows.Forms.TextBox();
            this.text_box_for_surname = new System.Windows.Forms.TextBox();
            this.text_box_for_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_box_for_height_to = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonForDelete = new System.Windows.Forms.Button();
            this.boxForPromoution = new System.Windows.Forms.ComboBox();
            this.comboBoxForWeight = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boxForReachto = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "to";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete fighter";
            // 
            // ReWrightFighter
            // 
            this.ReWrightFighter.Name = "ReWrightFighter";
            this.ReWrightFighter.Size = new System.Drawing.Size(145, 22);
            this.ReWrightFighter.Text = "Edit fighter";
            this.ReWrightFighter.Click += new System.EventHandler(this.ReWrightFighter_Click);
            // 
            // addFighterToolStripMenuItem
            // 
            this.addFighterToolStripMenuItem.Name = "addFighterToolStripMenuItem";
            this.addFighterToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addFighterToolStripMenuItem.Text = "Add fighter";
            this.addFighterToolStripMenuItem.Click += new System.EventHandler(this.addFighterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFighterToolStripMenuItem,
            this.ReWrightFighter,
            this.deleteToolStripMenuItem,
            this.saveToExelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToExelToolStripMenuItem
            // 
            this.saveToExelToolStripMenuItem.Name = "saveToExelToolStripMenuItem";
            this.saveToExelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToExelToolStripMenuItem.Text = "Save to exel";
            this.saveToExelToolStripMenuItem.Click += new System.EventHandler(this.saveToExelToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "from";
            // 
            // textBoxForAgeTo
            // 
            this.textBoxForAgeTo.Location = new System.Drawing.Point(36, 94);
            this.textBoxForAgeTo.Name = "textBoxForAgeTo";
            this.textBoxForAgeTo.Size = new System.Drawing.Size(51, 20);
            this.textBoxForAgeTo.TabIndex = 37;
            this.textBoxForAgeTo.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "promoution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "name";
            // 
            // boxForReachFrom
            // 
            this.boxForReachFrom.Location = new System.Drawing.Point(151, 154);
            this.boxForReachFrom.Name = "boxForReachFrom";
            this.boxForReachFrom.Size = new System.Drawing.Size(51, 20);
            this.boxForReachFrom.TabIndex = 29;
            this.boxForReachFrom.Text = "0";
            // 
            // text_box_for_height_from
            // 
            this.text_box_for_height_from.Location = new System.Drawing.Point(36, 154);
            this.text_box_for_height_from.Name = "text_box_for_height_from";
            this.text_box_for_height_from.Size = new System.Drawing.Size(51, 20);
            this.text_box_for_height_from.TabIndex = 28;
            this.text_box_for_height_from.Text = "140";
            // 
            // text_box_for_age
            // 
            this.text_box_for_age.Location = new System.Drawing.Point(36, 68);
            this.text_box_for_age.Name = "text_box_for_age";
            this.text_box_for_age.Size = new System.Drawing.Size(51, 20);
            this.text_box_for_age.TabIndex = 27;
            this.text_box_for_age.Text = "0";
            // 
            // text_box_for_surname
            // 
            this.text_box_for_surname.Location = new System.Drawing.Point(276, 73);
            this.text_box_for_surname.Name = "text_box_for_surname";
            this.text_box_for_surname.Size = new System.Drawing.Size(150, 20);
            this.text_box_for_surname.TabIndex = 26;
            this.text_box_for_surname.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // text_box_for_name
            // 
            this.text_box_for_name.Location = new System.Drawing.Point(276, 47);
            this.text_box_for_name.Name = "text_box_for_name";
            this.text_box_for_name.Size = new System.Drawing.Size(150, 20);
            this.text_box_for_name.TabIndex = 25;
            this.text_box_for_name.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 245);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 237);
            this.dataGridView1.TabIndex = 24;
           
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TextBoxChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "height ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "reach ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "from";
            // 
            // text_box_for_height_to
            // 
            this.text_box_for_height_to.Location = new System.Drawing.Point(36, 180);
            this.text_box_for_height_to.Name = "text_box_for_height_to";
            this.text_box_for_height_to.Size = new System.Drawing.Size(51, 20);
            this.text_box_for_height_to.TabIndex = 48;
            this.text_box_for_height_to.Text = "175";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "to";
            // 
            // buttonForDelete
            // 
            this.buttonForDelete.Location = new System.Drawing.Point(579, 429);
            this.buttonForDelete.Name = "buttonForDelete";
            this.buttonForDelete.Size = new System.Drawing.Size(119, 44);
            this.buttonForDelete.TabIndex = 50;
            this.buttonForDelete.Text = "Delete";
            this.buttonForDelete.UseVisualStyleBackColor = true;
            this.buttonForDelete.Click += new System.EventHandler(this.buttonForDelete_Click);
            // 
            // boxForPromoution
            // 
            this.boxForPromoution.FormattingEnabled = true;
            this.boxForPromoution.Location = new System.Drawing.Point(553, 78);
            this.boxForPromoution.Name = "boxForPromoution";
            this.boxForPromoution.Size = new System.Drawing.Size(165, 21);
            this.boxForPromoution.TabIndex = 51;
            this.boxForPromoution.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // comboBoxForWeight
            // 
            this.comboBoxForWeight.FormattingEnabled = true;
            this.comboBoxForWeight.Location = new System.Drawing.Point(553, 51);
            this.comboBoxForWeight.Name = "comboBoxForWeight";
            this.comboBoxForWeight.Size = new System.Drawing.Size(165, 21);
            this.comboBoxForWeight.TabIndex = 52;
            this.comboBoxForWeight.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "from";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "to";
            // 
            // boxForReachto
            // 
            this.boxForReachto.Location = new System.Drawing.Point(151, 180);
            this.boxForReachto.Name = "boxForReachto";
            this.boxForReachto.Size = new System.Drawing.Size(51, 20);
            this.boxForReachto.TabIndex = 55;
            this.boxForReachto.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 485);
            this.Controls.Add(this.boxForReachto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxForWeight);
            this.Controls.Add(this.boxForPromoution);
            this.Controls.Add(this.buttonForDelete);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_box_for_height_to);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxForAgeTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxForReachFrom);
            this.Controls.Add(this.text_box_for_height_from);
            this.Controls.Add(this.text_box_for_age);
            this.Controls.Add(this.text_box_for_surname);
            this.Controls.Add(this.text_box_for_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReWrightFighter;
        private System.Windows.Forms.ToolStripMenuItem addFighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxForAgeTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxForReachFrom;
        private System.Windows.Forms.TextBox text_box_for_height_from;
        private System.Windows.Forms.TextBox text_box_for_age;
        private System.Windows.Forms.TextBox text_box_for_surname;
        private System.Windows.Forms.TextBox text_box_for_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_box_for_height_to;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonForDelete;
        private System.Windows.Forms.ComboBox boxForPromoution;
        private System.Windows.Forms.ComboBox comboBoxForWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxForReachto;
        private System.Windows.Forms.ToolStripMenuItem saveToExelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

