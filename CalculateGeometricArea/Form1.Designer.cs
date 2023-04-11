namespace CalculateGeometricArea
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
            this.textBoxLegA = new System.Windows.Forms.TextBox();
            this.textBox_LegB = new System.Windows.Forms.TextBox();
            this.textBox_Hypotenuse = new System.Windows.Forms.TextBox();
            this.label_LegA = new System.Windows.Forms.Label();
            this.label2_LegB = new System.Windows.Forms.Label();
            this.label3_Hypotenuse = new System.Windows.Forms.Label();
            this.textBox_Radius = new System.Windows.Forms.TextBox();
            this.label_Radius = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLegA
            // 
            this.textBoxLegA.Location = new System.Drawing.Point(41, 60);
            this.textBoxLegA.Name = "textBoxLegA";
            this.textBoxLegA.Size = new System.Drawing.Size(100, 23);
            this.textBoxLegA.TabIndex = 1;
            // 
            // textBox_LegB
            // 
            this.textBox_LegB.Location = new System.Drawing.Point(182, 60);
            this.textBox_LegB.Name = "textBox_LegB";
            this.textBox_LegB.Size = new System.Drawing.Size(100, 23);
            this.textBox_LegB.TabIndex = 2;
            // 
            // textBox_Hypotenuse
            // 
            this.textBox_Hypotenuse.Location = new System.Drawing.Point(311, 60);
            this.textBox_Hypotenuse.Name = "textBox_Hypotenuse";
            this.textBox_Hypotenuse.Size = new System.Drawing.Size(100, 23);
            this.textBox_Hypotenuse.TabIndex = 3;
            // 
            // label_LegA
            // 
            this.label_LegA.AutoSize = true;
            this.label_LegA.Location = new System.Drawing.Point(68, 42);
            this.label_LegA.Name = "label_LegA";
            this.label_LegA.Size = new System.Drawing.Size(37, 15);
            this.label_LegA.TabIndex = 4;
            this.label_LegA.Text = "Leg A";
            // 
            // label2_LegB
            // 
            this.label2_LegB.AutoSize = true;
            this.label2_LegB.Location = new System.Drawing.Point(207, 42);
            this.label2_LegB.Name = "label2_LegB";
            this.label2_LegB.Size = new System.Drawing.Size(36, 15);
            this.label2_LegB.TabIndex = 5;
            this.label2_LegB.Text = "Leg B";
            // 
            // label3_Hypotenuse
            // 
            this.label3_Hypotenuse.AutoSize = true;
            this.label3_Hypotenuse.Location = new System.Drawing.Point(329, 42);
            this.label3_Hypotenuse.Name = "label3_Hypotenuse";
            this.label3_Hypotenuse.Size = new System.Drawing.Size(71, 15);
            this.label3_Hypotenuse.TabIndex = 6;
            this.label3_Hypotenuse.Text = "Hypotenuse";
            // 
            // textBox_Radius
            // 
            this.textBox_Radius.Location = new System.Drawing.Point(182, 259);
            this.textBox_Radius.Name = "textBox_Radius";
            this.textBox_Radius.Size = new System.Drawing.Size(100, 23);
            this.textBox_Radius.TabIndex = 7;
            // 
            // label_Radius
            // 
            this.label_Radius.AutoSize = true;
            this.label_Radius.Location = new System.Drawing.Point(195, 241);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(75, 15);
            this.label_Radius.TabIndex = 8;
            this.label_Radius.Text = "Circle Radius";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Triangle Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Calculate Circle Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Radius);
            this.Controls.Add(this.textBox_Radius);
            this.Controls.Add(this.label3_Hypotenuse);
            this.Controls.Add(this.label2_LegB);
            this.Controls.Add(this.label_LegA);
            this.Controls.Add(this.textBox_Hypotenuse);
            this.Controls.Add(this.textBox_LegB);
            this.Controls.Add(this.textBoxLegA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxLegA;
        private TextBox textBox_LegB;
        private TextBox textBox_Hypotenuse;
        private Label label_LegA;
        private Label label2_LegB;
        private Label label3_Hypotenuse;
        private TextBox textBox_Radius;
        private Label label_Radius;
        private Button button1;
        private Button button2;
    }
}