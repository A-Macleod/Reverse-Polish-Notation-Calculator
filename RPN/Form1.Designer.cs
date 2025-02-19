namespace RPN
{
    partial class Form1
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Eval = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.ArrayButton = new System.Windows.Forms.RadioButton();
            this.LinkedListButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reverse Polish Notation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(40, 149);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(413, 22);
            this.inputText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter expression to evaluate";
            // 
            // Btn_Eval
            // 
            this.Btn_Eval.Location = new System.Drawing.Point(378, 177);
            this.Btn_Eval.Name = "Btn_Eval";
            this.Btn_Eval.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eval.TabIndex = 3;
            this.Btn_Eval.Text = "Evaluate";
            this.Btn_Eval.UseVisualStyleBackColor = true;
            this.Btn_Eval.Click += new System.EventHandler(this.Btn_Eval_Click);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(12, 203);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(463, 118);
            this.outputText.TabIndex = 4;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArrayButton
            // 
            this.ArrayButton.AutoSize = true;
            this.ArrayButton.Checked = true;
            this.ArrayButton.Location = new System.Drawing.Point(349, 61);
            this.ArrayButton.Name = "ArrayButton";
            this.ArrayButton.Size = new System.Drawing.Size(80, 17);
            this.ArrayButton.TabIndex = 5;
            this.ArrayButton.TabStop = true;
            this.ArrayButton.Text = "Array Stack";
            this.ArrayButton.UseVisualStyleBackColor = true;
            // 
            // LinkedListButton
            // 
            this.LinkedListButton.AutoSize = true;
            this.LinkedListButton.Location = new System.Drawing.Point(349, 84);
            this.LinkedListButton.Name = "LinkedListButton";
            this.LinkedListButton.Size = new System.Drawing.Size(104, 17);
            this.LinkedListButton.TabIndex = 6;
            this.LinkedListButton.Text = "LinkedList Stack";
            this.LinkedListButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Implementation Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LinkedListButton);
            this.Controls.Add(this.ArrayButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.Btn_Eval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reverse Polish Notation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Eval;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.RadioButton ArrayButton;
        private System.Windows.Forms.RadioButton LinkedListButton;
        private System.Windows.Forms.Label label3;
    }
}

