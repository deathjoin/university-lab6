namespace Lab6_AllInOne
{
    partial class MainForm
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
            this.button_openFirstPart = new System.Windows.Forms.Button();
            this.button_showFirstTask = new System.Windows.Forms.Button();
            this.button_openSecPart = new System.Windows.Forms.Button();
            this.button_showSecTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openFirstPart
            // 
            this.button_openFirstPart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_openFirstPart.Location = new System.Drawing.Point(11, 65);
            this.button_openFirstPart.Name = "button_openFirstPart";
            this.button_openFirstPart.Size = new System.Drawing.Size(220, 66);
            this.button_openFirstPart.TabIndex = 0;
            this.button_openFirstPart.Text = "LAB 6.1\r\nДинамические массивы";
            this.button_openFirstPart.UseVisualStyleBackColor = true;
            this.button_openFirstPart.Click += new System.EventHandler(this.button_openFirstPart_Click);
            // 
            // button_showFirstTask
            // 
            this.button_showFirstTask.Location = new System.Drawing.Point(230, 65);
            this.button_showFirstTask.Name = "button_showFirstTask";
            this.button_showFirstTask.Size = new System.Drawing.Size(67, 66);
            this.button_showFirstTask.TabIndex = 1;
            this.button_showFirstTask.Text = "Задание";
            this.button_showFirstTask.UseVisualStyleBackColor = true;
            this.button_showFirstTask.Click += new System.EventHandler(this.button_showFirstTask_Click);
            // 
            // button_openSecPart
            // 
            this.button_openSecPart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_openSecPart.Location = new System.Drawing.Point(11, 137);
            this.button_openSecPart.Name = "button_openSecPart";
            this.button_openSecPart.Size = new System.Drawing.Size(221, 66);
            this.button_openSecPart.TabIndex = 2;
            this.button_openSecPart.Text = "LAB 6.2\r\nСвязанные списки";
            this.button_openSecPart.UseVisualStyleBackColor = true;
            this.button_openSecPart.Click += new System.EventHandler(this.button_openSecPart_Click);
            // 
            // button_showSecTask
            // 
            this.button_showSecTask.Location = new System.Drawing.Point(231, 137);
            this.button_showSecTask.Name = "button_showSecTask";
            this.button_showSecTask.Size = new System.Drawing.Size(66, 66);
            this.button_showSecTask.TabIndex = 3;
            this.button_showSecTask.Text = "Задание";
            this.button_showSecTask.UseVisualStyleBackColor = true;
            this.button_showSecTask.Click += new System.EventHandler(this.button_showSecTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите лабораторную:";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_exit.Location = new System.Drawing.Point(11, 209);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(286, 66);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Выйти";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 288);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_showSecTask);
            this.Controls.Add(this.button_openSecPart);
            this.Controls.Add(this.button_showFirstTask);
            this.Controls.Add(this.button_openFirstPart);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_openFirstPart;
        private System.Windows.Forms.Button button_showFirstTask;
        private System.Windows.Forms.Button button_openSecPart;
        private System.Windows.Forms.Button button_showSecTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
    }
}

