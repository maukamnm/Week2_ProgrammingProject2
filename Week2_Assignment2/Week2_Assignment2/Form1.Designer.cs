
namespace Week2_Assignment2
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
            this.computeButton = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.CheckBox();
            this.time = new System.Windows.Forms.CheckBox();
            this.day = new System.Windows.Forms.CheckBox();
            this.PickFruit = new System.Windows.Forms.ListBox();
            this.equals = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.dayOutput = new System.Windows.Forms.TextBox();
            this.timeOutput = new System.Windows.Forms.TextBox();
            this.dateOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(429, 144);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(112, 34);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "Compute!";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(326, 101);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(75, 29);
            this.date.TabIndex = 1;
            this.date.Text = "Date";
            this.date.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(326, 171);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(76, 29);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            this.time.UseVisualStyleBackColor = true;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(326, 136);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(69, 29);
            this.day.TabIndex = 3;
            this.day.Text = "Day";
            this.day.UseVisualStyleBackColor = true;
            // 
            // PickFruit
            // 
            this.PickFruit.FormattingEnabled = true;
            this.PickFruit.ItemHeight = 25;
            this.PickFruit.Items.AddRange(new object[] {
            "Apple",
            "Strawberry",
            "Banana"});
            this.PickFruit.Location = new System.Drawing.Point(127, 100);
            this.PickFruit.Name = "PickFruit";
            this.PickFruit.Size = new System.Drawing.Size(180, 129);
            this.PickFruit.TabIndex = 4;
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(573, 144);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(29, 25);
            this.equals.TabIndex = 5;
            this.equals.Text = "= ";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(617, 144);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(150, 31);
            this.output.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 29);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 29);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yellow";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 29);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Green";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(26, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(338, 25);
            this.Title.TabIndex = 10;
            this.Title.Text = "Compute the Title of the Next Top Movie:";
            // 
            // dayOutput
            // 
            this.dayOutput.Location = new System.Drawing.Point(617, 252);
            this.dayOutput.Name = "dayOutput";
            this.dayOutput.Size = new System.Drawing.Size(150, 31);
            this.dayOutput.TabIndex = 11;
            // 
            // timeOutput
            // 
            this.timeOutput.Location = new System.Drawing.Point(617, 309);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(150, 31);
            this.timeOutput.TabIndex = 12;
            // 
            // dateOutput
            // 
            this.dateOutput.Location = new System.Drawing.Point(617, 198);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(150, 31);
            this.dateOutput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.dayOutput);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.PickFruit);
            this.Controls.Add(this.day);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.computeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.CheckBox time;
        private System.Windows.Forms.CheckBox day;
        private System.Windows.Forms.ListBox PickFruit;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox dayOutput;
        private System.Windows.Forms.TextBox timeOutput;
        private System.Windows.Forms.TextBox dateOutput;
    }
}

