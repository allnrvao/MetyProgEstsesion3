namespace EvalueA
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
            TbAge = new TextBox();
            Evaluate = new Button();
            LblAnswer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduce su edad:";
            // 
            // TbAge
            // 
            TbAge.Location = new Point(350, 61);
            TbAge.Name = "TbAge";
            TbAge.Size = new Size(263, 39);
            TbAge.TabIndex = 1;
            // 
            // Evaluate
            // 
            Evaluate.BackColor = Color.DarkGreen;
            Evaluate.ForeColor = Color.MediumSeaGreen;
            Evaluate.Location = new Point(640, 61);
            Evaluate.Name = "Evaluate";
            Evaluate.Size = new Size(140, 50);
            Evaluate.TabIndex = 2;
            Evaluate.Text = "EVALUAR";
            Evaluate.UseVisualStyleBackColor = false;
            Evaluate.Click += Evaluate_Click;
            // 
            // LblAnswer
            // 
            LblAnswer.BorderStyle = BorderStyle.Fixed3D;
            LblAnswer.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAnswer.ForeColor = Color.SeaGreen;
            LblAnswer.Location = new Point(66, 138);
            LblAnswer.Name = "LblAnswer";
            LblAnswer.Size = new Size(724, 39);
            LblAnswer.TabIndex = 3;
            LblAnswer.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 576);
            Controls.Add(LblAnswer);
            Controls.Add(Evaluate);
            Controls.Add(TbAge);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Opacity = 0.92D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evaluar edad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbAge;
        private Button Evaluate;
        private Label LblAnswer;
    }
}
