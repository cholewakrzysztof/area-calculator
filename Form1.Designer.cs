
namespace AreaCalculator
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
            this.button_addPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_connectPoints = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_drawSample = new System.Windows.Forms.Button();
            this.button_connectPointsCurve = new System.Windows.Forms.Button();
            this.button_drawLayout = new System.Windows.Forms.Button();
            this.button_areaForm = new System.Windows.Forms.Button();
            this.button_drawPoints = new System.Windows.Forms.Button();
            this.button_drawSinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addPoint
            // 
            this.button_addPoint.Location = new System.Drawing.Point(12, 70);
            this.button_addPoint.Name = "button_addPoint";
            this.button_addPoint.Size = new System.Drawing.Size(134, 23);
            this.button_addPoint.TabIndex = 0;
            this.button_addPoint.Text = "DODAJ";
            this.button_addPoint.UseVisualStyleBackColor = true;
            this.button_addPoint.Click += new System.EventHandler(this.button_addPoint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // button_connectPoints
            // 
            this.button_connectPoints.Location = new System.Drawing.Point(13, 100);
            this.button_connectPoints.Name = "button_connectPoints";
            this.button_connectPoints.Size = new System.Drawing.Size(133, 23);
            this.button_connectPoints.TabIndex = 5;
            this.button_connectPoints.Text = "POŁĄCZ";
            this.button_connectPoints.UseVisualStyleBackColor = true;
            this.button_connectPoints.Click += new System.EventHandler(this.button_connectPoints_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(13, 130);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(133, 23);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "WYCZYŚĆ";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_drawSample
            // 
            this.button_drawSample.Location = new System.Drawing.Point(13, 160);
            this.button_drawSample.Name = "button_drawSample";
            this.button_drawSample.Size = new System.Drawing.Size(133, 23);
            this.button_drawSample.TabIndex = 7;
            this.button_drawSample.Text = "RYSUJ PRZYKŁAD";
            this.button_drawSample.UseVisualStyleBackColor = true;
            this.button_drawSample.Click += new System.EventHandler(this.button_drawSample_Click);
            // 
            // button_connectPointsCurve
            // 
            this.button_connectPointsCurve.Location = new System.Drawing.Point(13, 190);
            this.button_connectPointsCurve.Name = "button_connectPointsCurve";
            this.button_connectPointsCurve.Size = new System.Drawing.Size(133, 23);
            this.button_connectPointsCurve.TabIndex = 8;
            this.button_connectPointsCurve.Text = "POŁĄCZ KRZYWĄ";
            this.button_connectPointsCurve.UseVisualStyleBackColor = true;
            this.button_connectPointsCurve.Click += new System.EventHandler(this.button_connectPointsCurve_Click);
            // 
            // button_drawLayout
            // 
            this.button_drawLayout.Location = new System.Drawing.Point(13, 220);
            this.button_drawLayout.Name = "button_drawLayout";
            this.button_drawLayout.Size = new System.Drawing.Size(133, 23);
            this.button_drawLayout.TabIndex = 9;
            this.button_drawLayout.Text = "RYSUJ UKŁAD";
            this.button_drawLayout.UseVisualStyleBackColor = true;
            this.button_drawLayout.Click += new System.EventHandler(this.button_drawLayout_Click);
            // 
            // button_areaForm
            // 
            this.button_areaForm.Location = new System.Drawing.Point(13, 250);
            this.button_areaForm.Name = "button_areaForm";
            this.button_areaForm.Size = new System.Drawing.Size(133, 23);
            this.button_areaForm.TabIndex = 10;
            this.button_areaForm.Text = "WŁĄCZ KALKULATOR";
            this.button_areaForm.UseVisualStyleBackColor = true;
            this.button_areaForm.Click += new System.EventHandler(this.button_areaForm_Click);
            // 
            // button_drawPoints
            // 
            this.button_drawPoints.Location = new System.Drawing.Point(13, 280);
            this.button_drawPoints.Name = "button_drawPoints";
            this.button_drawPoints.Size = new System.Drawing.Size(133, 23);
            this.button_drawPoints.TabIndex = 11;
            this.button_drawPoints.Text = "RYSUJ PUNKTY";
            this.button_drawPoints.UseVisualStyleBackColor = true;
            this.button_drawPoints.Click += new System.EventHandler(this.button_drawPoints_Click);
            // 
            // button_drawSinus
            // 
            this.button_drawSinus.Location = new System.Drawing.Point(13, 310);
            this.button_drawSinus.Name = "button_drawSinus";
            this.button_drawSinus.Size = new System.Drawing.Size(133, 23);
            this.button_drawSinus.TabIndex = 12;
            this.button_drawSinus.Text = "STWÓRZ SINUS";
            this.button_drawSinus.UseVisualStyleBackColor = true;
            this.button_drawSinus.Click += new System.EventHandler(this.button_drawSinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 342);
            this.Controls.Add(this.button_drawSinus);
            this.Controls.Add(this.button_drawPoints);
            this.Controls.Add(this.button_areaForm);
            this.Controls.Add(this.button_drawLayout);
            this.Controls.Add(this.button_connectPointsCurve);
            this.Controls.Add(this.button_drawSample);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_connectPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_addPoint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_connectPoints;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_drawSample;
        private System.Windows.Forms.Button button_connectPointsCurve;
        private System.Windows.Forms.Button button_drawLayout;
        private System.Windows.Forms.Button button_areaForm;
        private System.Windows.Forms.Button button_drawPoints;
        private System.Windows.Forms.Button button_drawSinus;
    }
}

