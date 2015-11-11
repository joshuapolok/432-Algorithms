namespace PA_1_Executable
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
            this.submit = new System.Windows.Forms.Button();
            this.mergeBox = new System.Windows.Forms.ListBox();
            this.quickBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputStream = new System.Windows.Forms.TextBox();
            this.mergeLabel = new System.Windows.Forms.Label();
            this.quickLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(43, 28);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(54, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.SubmitButton);
            // 
            // mergeBox
            // 
            this.mergeBox.FormattingEnabled = true;
            this.mergeBox.Location = new System.Drawing.Point(86, 96);
            this.mergeBox.Name = "mergeBox";
            this.mergeBox.Size = new System.Drawing.Size(132, 199);
            this.mergeBox.TabIndex = 2;
            // 
            // quickBox
            // 
            this.quickBox.FormattingEnabled = true;
            this.quickBox.Location = new System.Drawing.Point(348, 97);
            this.quickBox.Name = "quickBox";
            this.quickBox.Size = new System.Drawing.Size(132, 199);
            this.quickBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input a stream of integers to sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Merge Sort Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quick Sort Output";
            // 
            // inputStream
            // 
            this.inputStream.Location = new System.Drawing.Point(103, 31);
            this.inputStream.Name = "inputStream";
            this.inputStream.Size = new System.Drawing.Size(454, 20);
            this.inputStream.TabIndex = 1;
            // 
            // mergeLabel
            // 
            this.mergeLabel.AutoSize = true;
            this.mergeLabel.Location = new System.Drawing.Point(9, 308);
            this.mergeLabel.Name = "mergeLabel";
            this.mergeLabel.Size = new System.Drawing.Size(91, 13);
            this.mergeLabel.TabIndex = 7;
            this.mergeLabel.Text = "Merge Sort Time: ";
            // 
            // quickLabel
            // 
            this.quickLabel.AutoSize = true;
            this.quickLabel.Location = new System.Drawing.Point(296, 308);
            this.quickLabel.Name = "quickLabel";
            this.quickLabel.Size = new System.Drawing.Size(89, 13);
            this.quickLabel.TabIndex = 8;
            this.quickLabel.Text = "Quick Sort Time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 339);
            this.Controls.Add(this.quickLabel);
            this.Controls.Add(this.mergeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quickBox);
            this.Controls.Add(this.mergeBox);
            this.Controls.Add(this.inputStream);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "432 Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox mergeBox;
        private System.Windows.Forms.ListBox quickBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputStream;
        private System.Windows.Forms.Label mergeLabel;
        private System.Windows.Forms.Label quickLabel;
    }
}

