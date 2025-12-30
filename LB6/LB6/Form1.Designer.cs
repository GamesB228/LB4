namespace LB6
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
            txtName = new TextBox();
            txtCourse = new TextBox();
            txtGroup = new TextBox();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnWinners = new Button();
            listBox1 = new ListBox();
            btnImportJson = new Button();
            btnSaveJson = new Button();
            btnSortCourse = new Button();
            btnGetNames = new Button();
            btnGroupByCourse = new Button();
            btnAverageResult = new Button();
            btnBestWorst = new Button();
            btnNamesBelowResult = new Button();
            txtMaxResult = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            txtName.Text = "ПІБ";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(12, 41);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(100, 23);
            txtCourse.TabIndex = 1;
            txtCourse.Text = "Курс";
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(129, 12);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(100, 23);
            txtGroup.TabIndex = 2;
            txtGroup.Text = "Група";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(129, 41);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 3;
            txtResult.Text = "Результат";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(309, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWinners
            // 
            btnWinners.Location = new Point(667, 38);
            btnWinners.Name = "btnWinners";
            btnWinners.Size = new Size(82, 23);
            btnWinners.TabIndex = 5;
            btnWinners.Text = "Переможці";
            btnWinners.UseVisualStyleBackColor = true;
            btnWinners.Click += btnWinners_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(737, 259);
            listBox1.TabIndex = 6;
            // 
            // btnImportJson
            // 
            btnImportJson.Location = new Point(489, 38);
            btnImportJson.Name = "btnImportJson";
            btnImportJson.Size = new Size(91, 23);
            btnImportJson.TabIndex = 7;
            btnImportJson.Text = "Завантажити";
            btnImportJson.UseVisualStyleBackColor = true;
            btnImportJson.Click += btnImportJson_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(586, 38);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 8;
            btnSaveJson.Text = "Зберегти";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnSortCourse
            // 
            btnSortCourse.Location = new Point(390, 38);
            btnSortCourse.Name = "btnSortCourse";
            btnSortCourse.Size = new Size(93, 23);
            btnSortCourse.TabIndex = 9;
            btnSortCourse.Text = "Відсортувати";
            btnSortCourse.UseVisualStyleBackColor = true;
            btnSortCourse.Click += btnSortCourse_Click;
            // 
            // btnGetNames
            // 
            btnGetNames.Location = new Point(28, 373);
            btnGetNames.Name = "btnGetNames";
            btnGetNames.Size = new Size(84, 56);
            btnGetNames.TabIndex = 10;
            btnGetNames.Text = "Отримати список ПІБ";
            btnGetNames.UseVisualStyleBackColor = true;
            btnGetNames.Click += btnGetNames_Click;
            // 
            // btnGroupByCourse
            // 
            btnGroupByCourse.Location = new Point(136, 373);
            btnGroupByCourse.Name = "btnGroupByCourse";
            btnGroupByCourse.Size = new Size(93, 56);
            btnGroupByCourse.TabIndex = 11;
            btnGroupByCourse.Text = "Групування студентів за курсом";
            btnGroupByCourse.UseVisualStyleBackColor = true;
            btnGroupByCourse.Click += btnGroupByCourse_Click;
            // 
            // btnAverageResult
            // 
            btnAverageResult.Location = new Point(259, 373);
            btnAverageResult.Name = "btnAverageResult";
            btnAverageResult.Size = new Size(95, 56);
            btnAverageResult.TabIndex = 12;
            btnAverageResult.Text = "Середній результат";
            btnAverageResult.UseVisualStyleBackColor = true;
            btnAverageResult.Click += btnAverageResult_Click;
            // 
            // btnBestWorst
            // 
            btnBestWorst.Location = new Point(390, 374);
            btnBestWorst.Name = "btnBestWorst";
            btnBestWorst.Size = new Size(93, 54);
            btnBestWorst.TabIndex = 13;
            btnBestWorst.Text = "Найкращий і найгірший результат";
            btnBestWorst.UseVisualStyleBackColor = true;
            btnBestWorst.Click += btnBestWorst_Click;
            // 
            // btnNamesBelowResult
            // 
            btnNamesBelowResult.Location = new Point(511, 373);
            btnNamesBelowResult.Name = "btnNamesBelowResult";
            btnNamesBelowResult.Size = new Size(182, 55);
            btnNamesBelowResult.TabIndex = 14;
            btnNamesBelowResult.Text = "ПІБ студентів з результатом нижче заданого";
            btnNamesBelowResult.UseVisualStyleBackColor = true;
            btnNamesBelowResult.Click += btnNamesBelowResult_Click;
            // 
            // txtMaxResult
            // 
            txtMaxResult.Location = new Point(699, 390);
            txtMaxResult.Name = "txtMaxResult";
            txtMaxResult.Size = new Size(100, 23);
            txtMaxResult.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaxResult);
            Controls.Add(btnNamesBelowResult);
            Controls.Add(btnBestWorst);
            Controls.Add(btnAverageResult);
            Controls.Add(btnGroupByCourse);
            Controls.Add(btnGetNames);
            Controls.Add(btnSortCourse);
            Controls.Add(btnSaveJson);
            Controls.Add(btnImportJson);
            Controls.Add(listBox1);
            Controls.Add(btnWinners);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtGroup);
            Controls.Add(txtCourse);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCourse;
        private TextBox txtGroup;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnWinners;
        private ListBox listBox1;
        private Button btnImportJson;
        private Button btnSaveJson;
        private Button btnSortCourse;
        private Button btnGetNames;
        private Button btnGroupByCourse;
        private Button btnAverageResult;
        private Button btnBestWorst;
        private Button btnNamesBelowResult;
        private TextBox txtMaxResult;
    }
}
