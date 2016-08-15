namespace Lab6_AllInOne
{
    partial class Lab6_1_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab6_1_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_showTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_showTask,
            this.toolStripButton_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_showTask
            // 
            this.toolStripButton_showTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_showTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_showTask.Image")));
            this.toolStripButton_showTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_showTask.Name = "toolStripButton_showTask";
            this.toolStripButton_showTask.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton_showTask.Text = "Показать задание";
            this.toolStripButton_showTask.ToolTipText = "Показать задание для лабораторной работы";
            this.toolStripButton_showTask.Click += new System.EventHandler(this.toolStripButton_showTask_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton_Exit.Text = "Закрыть";
            this.toolStripButton_Exit.ToolTipText = "Выйти";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(11, 30);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(436, 335);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите число элементов:";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(466, 52);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(182, 25);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // button_sort
            // 
            this.button_sort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_sort.Location = new System.Drawing.Point(466, 97);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(182, 50);
            this.button_sort.TabIndex = 4;
            this.button_sort.Text = "Сортировка выбором";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_exit.Location = new System.Drawing.Point(466, 315);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(182, 50);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Выйти";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Lab6_1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 377);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Lab6_1_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа 6.1 - Динамические массивы";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_showTask;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_exit;
    }
}