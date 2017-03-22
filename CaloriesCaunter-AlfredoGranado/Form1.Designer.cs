namespace CaloriesCaunter_AlfredoGranado
{
    partial class xCaloriesForm1
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xCaloriesForm1));
            this.xPortionsLable1 = new System.Windows.Forms.Label();
            this.xCaloriesLabel2 = new System.Windows.Forms.Label();
            this.xTotalCaloriesLable3 = new System.Windows.Forms.Label();
            this.xPresentationLable1 = new System.Windows.Forms.Label();
            this.xGoodToGoLable4 = new System.Windows.Forms.Label();
            this.xDidYouNeedItLable5 = new System.Windows.Forms.Label();
            this.xPortionsTextBox1 = new System.Windows.Forms.TextBox();
            this.xCaloriesTextBox2 = new System.Windows.Forms.TextBox();
            this.xTotalCaloriesTextBox3 = new System.Windows.Forms.TextBox();
            this.xGoodToGoTextBox4 = new System.Windows.Forms.TextBox();
            this.xDidYouNeedItTextBox5 = new System.Windows.Forms.TextBox();
            this.xCalculationButton1 = new System.Windows.Forms.Button();
            this.xClearButton2 = new System.Windows.Forms.Button();
            this.xExitButton3 = new System.Windows.Forms.Button();
            this.xPoundsButton4 = new System.Windows.Forms.Button();
            this.xPoundsTextBox6 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(787, 523);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // xPortionsLable1
            // 
            this.xPortionsLable1.AutoSize = true;
            this.xPortionsLable1.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.xPortionsLable1.Location = new System.Drawing.Point(32, 70);
            this.xPortionsLable1.Name = "xPortionsLable1";
            this.xPortionsLable1.Size = new System.Drawing.Size(88, 25);
            this.xPortionsLable1.TabIndex = 0;
            this.xPortionsLable1.Text = "Portions ";
            // 
            // xCaloriesLabel2
            // 
            this.xCaloriesLabel2.AutoSize = true;
            this.xCaloriesLabel2.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.xCaloriesLabel2.Location = new System.Drawing.Point(325, 70);
            this.xCaloriesLabel2.Name = "xCaloriesLabel2";
            this.xCaloriesLabel2.Size = new System.Drawing.Size(80, 25);
            this.xCaloriesLabel2.TabIndex = 1;
            this.xCaloriesLabel2.Text = "Calories";
            this.xCaloriesLabel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // xTotalCaloriesLable3
            // 
            this.xTotalCaloriesLable3.AutoSize = true;
            this.xTotalCaloriesLable3.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.xTotalCaloriesLable3.Location = new System.Drawing.Point(583, 71);
            this.xTotalCaloriesLable3.Name = "xTotalCaloriesLable3";
            this.xTotalCaloriesLable3.Size = new System.Drawing.Size(152, 25);
            this.xTotalCaloriesLable3.TabIndex = 2;
            this.xTotalCaloriesLable3.Text = "Total Of Calories";
            // 
            // xPresentationLable1
            // 
            this.xPresentationLable1.AutoSize = true;
            this.xPresentationLable1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPresentationLable1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.xPresentationLable1.Location = new System.Drawing.Point(141, 9);
            this.xPresentationLable1.Name = "xPresentationLable1";
            this.xPresentationLable1.Size = new System.Drawing.Size(488, 29);
            this.xPresentationLable1.TabIndex = 3;
            this.xPresentationLable1.Text = "Values are based on a 2,000 calorie diet";
            // 
            // xGoodToGoLable4
            // 
            this.xGoodToGoLable4.AutoSize = true;
            this.xGoodToGoLable4.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.xGoodToGoLable4.Location = new System.Drawing.Point(34, 293);
            this.xGoodToGoLable4.Name = "xGoodToGoLable4";
            this.xGoodToGoLable4.Size = new System.Drawing.Size(111, 25);
            this.xGoodToGoLable4.TabIndex = 4;
            this.xGoodToGoLable4.Text = "Good To Go";
            this.xGoodToGoLable4.Visible = false;
            this.xGoodToGoLable4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // xDidYouNeedItLable5
            // 
            this.xDidYouNeedItLable5.AutoSize = true;
            this.xDidYouNeedItLable5.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.xDidYouNeedItLable5.Location = new System.Drawing.Point(609, 293);
            this.xDidYouNeedItLable5.Name = "xDidYouNeedItLable5";
            this.xDidYouNeedItLable5.Size = new System.Drawing.Size(142, 25);
            this.xDidYouNeedItLable5.TabIndex = 5;
            this.xDidYouNeedItLable5.Text = "Did You Nee it?";
            this.xDidYouNeedItLable5.Click += new System.EventHandler(this.xDidYouNeedItLable5_Click);
            // 
            // xPortionsTextBox1
            // 
            this.xPortionsTextBox1.Location = new System.Drawing.Point(22, 98);
            this.xPortionsTextBox1.Name = "xPortionsTextBox1";
            this.xPortionsTextBox1.Size = new System.Drawing.Size(115, 20);
            this.xPortionsTextBox1.TabIndex = 6;
            this.xPortionsTextBox1.TextChanged += new System.EventHandler(this.xPortionsTextBox1_TextChanged);
            // 
            // xCaloriesTextBox2
            // 
            this.xCaloriesTextBox2.Location = new System.Drawing.Point(296, 98);
            this.xCaloriesTextBox2.Name = "xCaloriesTextBox2";
            this.xCaloriesTextBox2.Size = new System.Drawing.Size(134, 20);
            this.xCaloriesTextBox2.TabIndex = 7;
            this.xCaloriesTextBox2.TextChanged += new System.EventHandler(this.CaloriesTextBox2_TextChanged);
            // 
            // xTotalCaloriesTextBox3
            // 
            this.xTotalCaloriesTextBox3.Location = new System.Drawing.Point(588, 98);
            this.xTotalCaloriesTextBox3.Name = "xTotalCaloriesTextBox3";
            this.xTotalCaloriesTextBox3.Size = new System.Drawing.Size(132, 20);
            this.xTotalCaloriesTextBox3.TabIndex = 8;
            // 
            // xGoodToGoTextBox4
            // 
            this.xGoodToGoTextBox4.ForeColor = System.Drawing.Color.Olive;
            this.xGoodToGoTextBox4.Location = new System.Drawing.Point(37, 329);
            this.xGoodToGoTextBox4.Name = "xGoodToGoTextBox4";
            this.xGoodToGoTextBox4.Size = new System.Drawing.Size(108, 20);
            this.xGoodToGoTextBox4.TabIndex = 9;
            this.xGoodToGoTextBox4.Visible = false;
            this.xGoodToGoTextBox4.TextChanged += new System.EventHandler(this.xGoodToGoTextBox4_TextChanged);
            // 
            // xDidYouNeedItTextBox5
            // 
            this.xDidYouNeedItTextBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.xDidYouNeedItTextBox5.Location = new System.Drawing.Point(620, 329);
            this.xDidYouNeedItTextBox5.Name = "xDidYouNeedItTextBox5";
            this.xDidYouNeedItTextBox5.Size = new System.Drawing.Size(100, 20);
            this.xDidYouNeedItTextBox5.TabIndex = 10;
            this.xDidYouNeedItTextBox5.TextChanged += new System.EventHandler(this.xDidYouNeedItTextBox5_TextChanged);
            // 
            // xCalculationButton1
            // 
            this.xCalculationButton1.ForeColor = System.Drawing.Color.ForestGreen;
            this.xCalculationButton1.Location = new System.Drawing.Point(330, 166);
            this.xCalculationButton1.Name = "xCalculationButton1";
            this.xCalculationButton1.Size = new System.Drawing.Size(75, 23);
            this.xCalculationButton1.TabIndex = 11;
            this.xCalculationButton1.Text = "Calculation";
            this.xCalculationButton1.UseVisualStyleBackColor = true;
            this.xCalculationButton1.Click += new System.EventHandler(this.xCalculationButton1_Click);
            // 
            // xClearButton2
            // 
            this.xClearButton2.ForeColor = System.Drawing.Color.Orange;
            this.xClearButton2.Location = new System.Drawing.Point(330, 277);
            this.xClearButton2.Name = "xClearButton2";
            this.xClearButton2.Size = new System.Drawing.Size(75, 23);
            this.xClearButton2.TabIndex = 12;
            this.xClearButton2.Text = "Clear";
            this.xClearButton2.UseVisualStyleBackColor = true;
            this.xClearButton2.Click += new System.EventHandler(this.xClearButton2_Click);
            // 
            // xExitButton3
            // 
            this.xExitButton3.ForeColor = System.Drawing.Color.Crimson;
            this.xExitButton3.Location = new System.Drawing.Point(330, 478);
            this.xExitButton3.Name = "xExitButton3";
            this.xExitButton3.Size = new System.Drawing.Size(75, 23);
            this.xExitButton3.TabIndex = 13;
            this.xExitButton3.Text = "Exit";
            this.xExitButton3.UseVisualStyleBackColor = true;
            this.xExitButton3.Click += new System.EventHandler(this.xExitButton3_Click);
            // 
            // xPoundsButton4
            // 
            this.xPoundsButton4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.xPoundsButton4.Location = new System.Drawing.Point(330, 381);
            this.xPoundsButton4.Name = "xPoundsButton4";
            this.xPoundsButton4.Size = new System.Drawing.Size(75, 23);
            this.xPoundsButton4.TabIndex = 15;
            this.xPoundsButton4.Text = "Pounds";
            this.xPoundsButton4.UseVisualStyleBackColor = true;
            this.xPoundsButton4.Click += new System.EventHandler(this.xPoundsButton4_Click);
            // 
            // xPoundsTextBox6
            // 
            this.xPoundsTextBox6.Location = new System.Drawing.Point(296, 423);
            this.xPoundsTextBox6.Name = "xPoundsTextBox6";
            this.xPoundsTextBox6.Size = new System.Drawing.Size(134, 20);
            this.xPoundsTextBox6.TabIndex = 16;
            this.xPoundsTextBox6.Visible = false;
            this.xPoundsTextBox6.TextChanged += new System.EventHandler(this.xPoundsTextBox6_TextChanged);
            // 
            // xCaloriesForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.xPoundsTextBox6);
            this.Controls.Add(this.xPoundsButton4);
            this.Controls.Add(this.xExitButton3);
            this.Controls.Add(this.xClearButton2);
            this.Controls.Add(this.xCalculationButton1);
            this.Controls.Add(this.xDidYouNeedItTextBox5);
            this.Controls.Add(this.xGoodToGoTextBox4);
            this.Controls.Add(this.xTotalCaloriesTextBox3);
            this.Controls.Add(this.xCaloriesTextBox2);
            this.Controls.Add(this.xPortionsTextBox1);
            this.Controls.Add(this.xDidYouNeedItLable5);
            this.Controls.Add(this.xGoodToGoLable4);
            this.Controls.Add(this.xPresentationLable1);
            this.Controls.Add(this.xTotalCaloriesLable3);
            this.Controls.Add(this.xCaloriesLabel2);
            this.Controls.Add(this.xPortionsLable1);
            this.Controls.Add(pictureBox1);
            this.Name = "xCaloriesForm1";
            this.Text = "Calories Counter ";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xPortionsLable1;
        private System.Windows.Forms.Label xCaloriesLabel2;
        private System.Windows.Forms.Label xTotalCaloriesLable3;
        private System.Windows.Forms.Label xPresentationLable1;
        private System.Windows.Forms.Label xGoodToGoLable4;
        private System.Windows.Forms.Label xDidYouNeedItLable5;
        private System.Windows.Forms.TextBox xPortionsTextBox1;
        private System.Windows.Forms.TextBox xCaloriesTextBox2;
        private System.Windows.Forms.TextBox xTotalCaloriesTextBox3;
        private System.Windows.Forms.TextBox xGoodToGoTextBox4;
        private System.Windows.Forms.TextBox xDidYouNeedItTextBox5;
        private System.Windows.Forms.Button xCalculationButton1;
        private System.Windows.Forms.Button xClearButton2;
        private System.Windows.Forms.Button xExitButton3;
        private System.Windows.Forms.Button xPoundsButton4;
        private System.Windows.Forms.TextBox xPoundsTextBox6;
    }
}

