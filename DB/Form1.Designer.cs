namespace DB
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlFilling = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControlDictionaries = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dataGridViewStreetType = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dataGridViewAutoType = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.dataGridViewLoadStatus = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDriverPatron = new System.Windows.Forms.TextBox();
            this.textBoxDriverSurname = new System.Windows.Forms.TextBox();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAutoNumber = new System.Windows.Forms.TextBox();
            this.textBoxAutoName = new System.Windows.Forms.TextBox();
            this.comboBoxDriverInsert = new System.Windows.Forms.ComboBox();
            this.comboBoxAutoTypeInsert = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBuffer = new System.Windows.Forms.DataGridView();
            this.buttonAutoAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlFilling.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControlDictionaries.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStreetType)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoType)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadStatus)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuffer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 529);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlFilling);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "заполнение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlFilling
            // 
            this.tabControlFilling.Controls.Add(this.tabPage6);
            this.tabControlFilling.Controls.Add(this.tabPage7);
            this.tabControlFilling.Controls.Add(this.tabPage8);
            this.tabControlFilling.Location = new System.Drawing.Point(6, 6);
            this.tabControlFilling.Name = "tabControlFilling";
            this.tabControlFilling.SelectedIndex = 0;
            this.tabControlFilling.Size = new System.Drawing.Size(1000, 492);
            this.tabControlFilling.TabIndex = 9;
            this.tabControlFilling.SelectedIndexChanged += new System.EventHandler(this.tabControlFilling_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControlDictionaries);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 466);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "заполнение справочников";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControlDictionaries
            // 
            this.tabControlDictionaries.Controls.Add(this.tabPage9);
            this.tabControlDictionaries.Controls.Add(this.tabPage10);
            this.tabControlDictionaries.Controls.Add(this.tabPage11);
            this.tabControlDictionaries.Location = new System.Drawing.Point(6, 6);
            this.tabControlDictionaries.Name = "tabControlDictionaries";
            this.tabControlDictionaries.SelectedIndex = 0;
            this.tabControlDictionaries.Size = new System.Drawing.Size(980, 454);
            this.tabControlDictionaries.TabIndex = 9;
            this.tabControlDictionaries.SelectedIndexChanged += new System.EventHandler(this.tabControlDictionaries_SelectedIndexChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.dataGridViewStreetType);
            this.tabPage9.Controls.Add(this.textBox3);
            this.tabPage9.Controls.Add(this.label1);
            this.tabPage9.Controls.Add(this.button4);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(972, 428);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Тип улицы";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStreetType
            // 
            this.dataGridViewStreetType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStreetType.Location = new System.Drawing.Point(219, 6);
            this.dataGridViewStreetType.Name = "dataGridViewStreetType";
            this.dataGridViewStreetType.Size = new System.Drawing.Size(747, 416);
            this.dataGridViewStreetType.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "тип улицы";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.dataGridViewAutoType);
            this.tabPage10.Controls.Add(this.label2);
            this.tabPage10.Controls.Add(this.textBox1);
            this.tabPage10.Controls.Add(this.button2);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(972, 428);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Тип авто";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAutoType
            // 
            this.dataGridViewAutoType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutoType.Location = new System.Drawing.Point(199, 6);
            this.dataGridViewAutoType.Name = "dataGridViewAutoType";
            this.dataGridViewAutoType.Size = new System.Drawing.Size(767, 416);
            this.dataGridViewAutoType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "тип авто";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.dataGridViewLoadStatus);
            this.tabPage11.Controls.Add(this.textBox2);
            this.tabPage11.Controls.Add(this.button3);
            this.tabPage11.Controls.Add(this.label3);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(972, 428);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Статус загрузки";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLoadStatus
            // 
            this.dataGridViewLoadStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadStatus.Location = new System.Drawing.Point(193, 3);
            this.dataGridViewLoadStatus.Name = "dataGridViewLoadStatus";
            this.dataGridViewLoadStatus.Size = new System.Drawing.Size(773, 419);
            this.dataGridViewLoadStatus.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "статус загрузки";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonAddDriver);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.textBoxDriverPatron);
            this.tabPage7.Controls.Add(this.textBoxDriverSurname);
            this.tabPage7.Controls.Add(this.textBoxDriverName);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(992, 466);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "заполнение водителя";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(10, 437);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDriver.TabIndex = 8;
            this.buttonAddDriver.Text = "Добавить";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "фамилия";
            // 
            // textBoxDriverPatron
            // 
            this.textBoxDriverPatron.Location = new System.Drawing.Point(10, 97);
            this.textBoxDriverPatron.Name = "textBoxDriverPatron";
            this.textBoxDriverPatron.Size = new System.Drawing.Size(100, 20);
            this.textBoxDriverPatron.TabIndex = 2;
            // 
            // textBoxDriverSurname
            // 
            this.textBoxDriverSurname.Location = new System.Drawing.Point(9, 58);
            this.textBoxDriverSurname.Name = "textBoxDriverSurname";
            this.textBoxDriverSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxDriverSurname.TabIndex = 1;
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(9, 19);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDriverName.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.buttonAutoAdd);
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Controls.Add(this.label9);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.textBoxAutoNumber);
            this.tabPage8.Controls.Add(this.textBoxAutoName);
            this.tabPage8.Controls.Add(this.comboBoxDriverInsert);
            this.tabPage8.Controls.Add(this.comboBoxAutoTypeInsert);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(992, 466);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "заполнение автомобилей";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "водитель";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "тип авто";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "номер автомобиля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "название автомобиля";
            // 
            // textBoxAutoNumber
            // 
            this.textBoxAutoNumber.Location = new System.Drawing.Point(134, 57);
            this.textBoxAutoNumber.Name = "textBoxAutoNumber";
            this.textBoxAutoNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoNumber.TabIndex = 3;
            // 
            // textBoxAutoName
            // 
            this.textBoxAutoName.Location = new System.Drawing.Point(134, 9);
            this.textBoxAutoName.Name = "textBoxAutoName";
            this.textBoxAutoName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoName.TabIndex = 2;
            // 
            // comboBoxDriverInsert
            // 
            this.comboBoxDriverInsert.FormattingEnabled = true;
            this.comboBoxDriverInsert.Location = new System.Drawing.Point(134, 112);
            this.comboBoxDriverInsert.Name = "comboBoxDriverInsert";
            this.comboBoxDriverInsert.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDriverInsert.TabIndex = 1;
            // 
            // comboBoxAutoTypeInsert
            // 
            this.comboBoxAutoTypeInsert.FormattingEnabled = true;
            this.comboBoxAutoTypeInsert.Location = new System.Drawing.Point(134, 160);
            this.comboBoxAutoTypeInsert.Name = "comboBoxAutoTypeInsert";
            this.comboBoxAutoTypeInsert.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutoTypeInsert.TabIndex = 0;
            this.comboBoxAutoTypeInsert.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuffer
            // 
            this.dataGridViewBuffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuffer.Location = new System.Drawing.Point(1242, 34);
            this.dataGridViewBuffer.Name = "dataGridViewBuffer";
            this.dataGridViewBuffer.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBuffer.TabIndex = 3;
            // 
            // buttonAutoAdd
            // 
            this.buttonAutoAdd.Location = new System.Drawing.Point(911, 437);
            this.buttonAutoAdd.Name = "buttonAutoAdd";
            this.buttonAutoAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoAdd.TabIndex = 9;
            this.buttonAutoAdd.Text = "Добавить";
            this.buttonAutoAdd.UseVisualStyleBackColor = true;
            this.buttonAutoAdd.Click += new System.EventHandler(this.buttonAutoAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 544);
            this.Controls.Add(this.dataGridViewBuffer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlFilling.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControlDictionaries.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStreetType)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoType)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadStatus)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuffer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlFilling;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDriverPatron;
        private System.Windows.Forms.TextBox textBoxDriverSurname;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAutoNumber;
        private System.Windows.Forms.TextBox textBoxAutoName;
        private System.Windows.Forms.ComboBox comboBoxDriverInsert;
        private System.Windows.Forms.ComboBox comboBoxAutoTypeInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControlDictionaries;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dataGridViewStreetType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView dataGridViewAutoType;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.DataGridView dataGridViewLoadStatus;
        private System.Windows.Forms.DataGridView dataGridViewBuffer;
        private System.Windows.Forms.Button buttonAutoAdd;
    }
}

