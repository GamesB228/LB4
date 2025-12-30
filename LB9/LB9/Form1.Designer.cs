namespace LB9
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
            btnPaySalary = new Button();
            btnVacation = new Button();
            SuspendLayout();
            // 
            // btnPaySalary
            // 
            btnPaySalary.Location = new Point(116, 75);
            btnPaySalary.Name = "btnPaySalary";
            btnPaySalary.Size = new Size(146, 25);
            btnPaySalary.TabIndex = 0;
            btnPaySalary.Text = "Виплатити зарплату";
            btnPaySalary.UseVisualStyleBackColor = true;
            btnPaySalary.Click += btnPaySalary_Click;
            // 
            // btnVacation
            // 
            btnVacation.Location = new Point(601, 75);
            btnVacation.Name = "btnVacation";
            btnVacation.Size = new Size(137, 25);
            btnVacation.TabIndex = 1;
            btnVacation.Text = "Запит на відпустку";
            btnVacation.UseVisualStyleBackColor = true;
            btnVacation.Click += btnVacation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVacation);
            Controls.Add(btnPaySalary);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaySalary;
        private Button btnVacation;
    }
}
