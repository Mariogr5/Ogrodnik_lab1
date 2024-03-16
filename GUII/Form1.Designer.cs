namespace GUII
{
    partial class BagpackApplication
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
            this.solev_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.capacity_box = new System.Windows.Forms.TextBox();
            this.seed_box = new System.Windows.Forms.TextBox();
            this.numberOfElements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.problem_boox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.result_boox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // solev_button
            // 
            this.solev_button.Location = new System.Drawing.Point(12, 157);
            this.solev_button.Name = "solev_button";
            this.solev_button.Size = new System.Drawing.Size(116, 23);
            this.solev_button.TabIndex = 0;
            this.solev_button.Text = "Solve";
            this.solev_button.UseVisualStyleBackColor = true;
            this.solev_button.Click += new System.EventHandler(this.solev_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(137, 157);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(109, 23);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear Results";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // capacity_box
            // 
            this.capacity_box.Location = new System.Drawing.Point(12, 119);
            this.capacity_box.Name = "capacity_box";
            this.capacity_box.Size = new System.Drawing.Size(116, 23);
            this.capacity_box.TabIndex = 2;
            this.capacity_box.TextChanged += new System.EventHandler(this.capacity_box_TextChanged);
            // 
            // seed_box
            // 
            this.seed_box.Location = new System.Drawing.Point(12, 72);
            this.seed_box.Name = "seed_box";
            this.seed_box.Size = new System.Drawing.Size(116, 23);
            this.seed_box.TabIndex = 3;
            this.seed_box.TextChanged += new System.EventHandler(this.seed_box_TextChanged);
            // 
            // numberOfElements
            // 
            this.numberOfElements.Location = new System.Drawing.Point(12, 23);
            this.numberOfElements.Name = "numberOfElements";
            this.numberOfElements.Size = new System.Drawing.Size(116, 23);
            this.numberOfElements.TabIndex = 4;
            this.numberOfElements.TextChanged += new System.EventHandler(this.numberOfElements_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bagpack Capacity";
            // 
            // problem_boox
            // 
            this.problem_boox.Location = new System.Drawing.Point(300, 23);
            this.problem_boox.Multiline = true;
            this.problem_boox.Name = "problem_boox";
            this.problem_boox.ReadOnly = true;
            this.problem_boox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.problem_boox.Size = new System.Drawing.Size(292, 355);
            this.problem_boox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Instance";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(300, 394);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(292, 23);
            this.Progress.TabIndex = 15;
            // 
            // result_boox
            // 
            this.result_boox.Location = new System.Drawing.Point(1, 203);
            this.result_boox.Multiline = true;
            this.result_boox.Name = "result_boox";
            this.result_boox.ReadOnly = true;
            this.result_boox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_boox.Size = new System.Drawing.Size(262, 214);
            this.result_boox.TabIndex = 16;
            this.result_boox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BagpackApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 426);
            this.Controls.Add(this.result_boox);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.problem_boox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfElements);
            this.Controls.Add(this.seed_box);
            this.Controls.Add(this.capacity_box);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.solev_button);
            this.Name = "BagpackApplication";
            this.Text = "Bagpack Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button solev_button;
        private Button clear_button;
        private TextBox capacity_box;
        private TextBox seed_box;
        private TextBox numberOfElements;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox problem_boox;
        private Label label4;
        private Label label5;
        private ProgressBar Progress;
        private TextBox result_boox;
    }
}