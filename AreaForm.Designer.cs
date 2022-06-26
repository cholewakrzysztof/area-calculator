
namespace AreaCalculator
{
    partial class AreaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Points = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Area = new System.Windows.Forms.Label();
            this.textBox_Precision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_CalculateArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUNKTY";
            // 
            // listBox_Points
            // 
            this.listBox_Points.FormattingEnabled = true;
            this.listBox_Points.ItemHeight = 15;
            this.listBox_Points.Location = new System.Drawing.Point(13, 32);
            this.listBox_Points.Name = "listBox_Points";
            this.listBox_Points.Size = new System.Drawing.Size(144, 94);
            this.listBox_Points.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "POWIERZCHNIA";
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.Location = new System.Drawing.Point(13, 217);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(85, 15);
            this.label_Area.TabIndex = 3;
            this.label_Area.Text = "wynik obliczen";
            // 
            // textBox_Precision
            // 
            this.textBox_Precision.Location = new System.Drawing.Point(13, 147);
            this.textBox_Precision.Name = "textBox_Precision";
            this.textBox_Precision.Size = new System.Drawing.Size(144, 23);
            this.textBox_Precision.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECYZJA";
            // 
            // button_CalculateArea
            // 
            this.button_CalculateArea.Location = new System.Drawing.Point(12, 176);
            this.button_CalculateArea.Name = "button_CalculateArea";
            this.button_CalculateArea.Size = new System.Drawing.Size(145, 23);
            this.button_CalculateArea.TabIndex = 6;
            this.button_CalculateArea.Text = "OBLICZ POWIERZCHNIE";
            this.button_CalculateArea.UseVisualStyleBackColor = true;
            this.button_CalculateArea.Click += new System.EventHandler(this.button_CalculateArea_Click);
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 244);
            this.Controls.Add(this.button_CalculateArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Precision);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Points);
            this.Controls.Add(this.label1);
            this.Name = "AreaForm";
            this.Text = "AreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.TextBox textBox_Precision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_CalculateArea;
    }
}