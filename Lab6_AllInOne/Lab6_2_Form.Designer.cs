namespace Lab6_AllInOne
{
    partial class Lab6_2_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab6_2_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_showTask = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_exit = new System.Windows.Forms.ToolStripButton();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_addToRightPlace = new System.Windows.Forms.Button();
            this.button_addToEnd = new System.Windows.Forms.Button();
            this.button_addToStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.button_showList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_merge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_listLenght = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_showTask,
            this.toolStrip_exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_showTask
            // 
            this.toolStrip_showTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_showTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_showTask.Image")));
            this.toolStrip_showTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_showTask.Name = "toolStrip_showTask";
            this.toolStrip_showTask.Size = new System.Drawing.Size(107, 22);
            this.toolStrip_showTask.Text = "Показать задание";
            this.toolStrip_showTask.Click += new System.EventHandler(this.toolStrip_showTask_Click);
            // 
            // toolStrip_exit
            // 
            this.toolStrip_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_exit.Image")));
            this.toolStrip_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_exit.Name = "toolStrip_exit";
            this.toolStrip_exit.Size = new System.Drawing.Size(57, 22);
            this.toolStrip_exit.Text = "Закрыть";
            this.toolStrip_exit.Click += new System.EventHandler(this.toolStrip_exit_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(12, 35);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(244, 358);
            this.textBox_output.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_addToRightPlace);
            this.groupBox1.Controls.Add(this.button_addToEnd);
            this.groupBox1.Controls.Add(this.button_addToStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_value);
            this.groupBox1.Location = new System.Drawing.Point(270, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формирование списка";
            // 
            // button_addToRightPlace
            // 
            this.button_addToRightPlace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_addToRightPlace.Location = new System.Drawing.Point(6, 149);
            this.button_addToRightPlace.Name = "button_addToRightPlace";
            this.button_addToRightPlace.Size = new System.Drawing.Size(266, 42);
            this.button_addToRightPlace.TabIndex = 4;
            this.button_addToRightPlace.Text = "Без нарушения порядка";
            this.button_addToRightPlace.UseVisualStyleBackColor = true;
            this.button_addToRightPlace.Click += new System.EventHandler(this.button_addToRightPlace_Click);
            // 
            // button_addToEnd
            // 
            this.button_addToEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_addToEnd.Location = new System.Drawing.Point(6, 101);
            this.button_addToEnd.Name = "button_addToEnd";
            this.button_addToEnd.Size = new System.Drawing.Size(266, 42);
            this.button_addToEnd.TabIndex = 3;
            this.button_addToEnd.Text = "В конец";
            this.button_addToEnd.UseVisualStyleBackColor = true;
            this.button_addToEnd.Click += new System.EventHandler(this.button_addToEnd_Click);
            // 
            // button_addToStart
            // 
            this.button_addToStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_addToStart.Location = new System.Drawing.Point(6, 53);
            this.button_addToStart.Name = "button_addToStart";
            this.button_addToStart.Size = new System.Drawing.Size(266, 42);
            this.button_addToStart.TabIndex = 2;
            this.button_addToStart.Text = "В начало";
            this.button_addToStart.UseVisualStyleBackColor = true;
            this.button_addToStart.Click += new System.EventHandler(this.button_addToStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение:";
            // 
            // textBox_value
            // 
            this.textBox_value.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_value.Location = new System.Drawing.Point(85, 22);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(187, 25);
            this.textBox_value.TabIndex = 0;
            this.textBox_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_value.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // button_showList
            // 
            this.button_showList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_showList.Location = new System.Drawing.Point(270, 240);
            this.button_showList.Name = "button_showList";
            this.button_showList.Size = new System.Drawing.Size(278, 42);
            this.button_showList.TabIndex = 5;
            this.button_showList.Text = "Показать список";
            this.button_showList.UseVisualStyleBackColor = true;
            this.button_showList.Click += new System.EventHandler(this.button_showList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_merge);
            this.groupBox2.Location = new System.Drawing.Point(270, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // button_merge
            // 
            this.button_merge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_merge.Location = new System.Drawing.Point(6, 21);
            this.button_merge.Name = "button_merge";
            this.button_merge.Size = new System.Drawing.Size(265, 42);
            this.button_merge.TabIndex = 5;
            this.button_merge.Text = "Слиянием";
            this.button_merge.UseVisualStyleBackColor = true;
            this.button_merge.Click += new System.EventHandler(this.button_merge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(266, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Число элементов в списке:";
            // 
            // textBox_listLenght
            // 
            this.textBox_listLenght.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_listLenght.Location = new System.Drawing.Point(449, 368);
            this.textBox_listLenght.Name = "textBox_listLenght";
            this.textBox_listLenght.Size = new System.Drawing.Size(98, 25);
            this.textBox_listLenght.TabIndex = 8;
            this.textBox_listLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lab6_2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 399);
            this.Controls.Add(this.textBox_listLenght);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_showList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Lab6_2_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа 6.2 - Связанные списки";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_showTask;
        private System.Windows.Forms.ToolStripButton toolStrip_exit;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Button button_addToRightPlace;
        private System.Windows.Forms.Button button_addToEnd;
        private System.Windows.Forms.Button button_addToStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_showList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_merge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_listLenght;
    }
}