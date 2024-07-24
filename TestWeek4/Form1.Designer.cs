namespace TestWeek4
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
            YearComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            NumDayComboBox = new ComboBox();
            DayDomboBox = new ComboBox();
            AddDateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 83);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 207);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "שנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 209);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 209);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "היום בחודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(646, 210);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "היום בשבוע";
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(118, 240);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(121, 23);
            YearComboBox.TabIndex = 5;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(273, 240);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(121, 23);
            MonthComboBox.TabIndex = 6;
            // 
            // NumDayComboBox
            // 
            NumDayComboBox.FormattingEnabled = true;
            NumDayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            NumDayComboBox.Location = new Point(440, 240);
            NumDayComboBox.Name = "NumDayComboBox";
            NumDayComboBox.Size = new Size(121, 23);
            NumDayComboBox.TabIndex = 7;
            // 
            // DayDomboBox
            // 
            DayDomboBox.FormattingEnabled = true;
            DayDomboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            DayDomboBox.Location = new Point(607, 240);
            DayDomboBox.Name = "DayDomboBox";
            DayDomboBox.Size = new Size(121, 23);
            DayDomboBox.TabIndex = 8;
            // 
            // AddDateButton
            // 
            AddDateButton.Location = new Point(12, 240);
            AddDateButton.Name = "AddDateButton";
            AddDateButton.Size = new Size(75, 23);
            AddDateButton.TabIndex = 9;
            AddDateButton.Text = "צור תאריך";
            AddDateButton.UseVisualStyleBackColor = true;
            AddDateButton.Click += AddDateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddDateButton);
            Controls.Add(DayDomboBox);
            Controls.Add(NumDayComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(YearComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox YearComboBox;
        private ComboBox MonthComboBox;
        private ComboBox NumDayComboBox;
        private ComboBox DayDomboBox;
        private Button AddDateButton;
    }
}
