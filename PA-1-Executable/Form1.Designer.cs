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
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(43, 40);
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
            this.mergeBox.Location = new System.Drawing.Point(12, 108);
            this.mergeBox.Name = "mergeBox";
            this.mergeBox.Size = new System.Drawing.Size(258, 264);
            this.mergeBox.TabIndex = 2;
            this.mergeBox.SelectedIndexChanged += new System.EventHandler(this.mergeBox_SelectedIndexChanged);
            // 
            // quickBox
            // 
            this.quickBox.FormattingEnabled = true;
            this.quickBox.Location = new System.Drawing.Point(299, 109);
            this.quickBox.Name = "quickBox";
            this.quickBox.Size = new System.Drawing.Size(258, 264);
            this.quickBox.TabIndex = 3;
            this.quickBox.SelectedIndexChanged += new System.EventHandler(this.quickBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input a stream of integers to sort";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Merge Sort Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quick Sort Output";
            // 
            // inputStream
            // 
            this.inputStream.Location = new System.Drawing.Point(103, 43);
            this.inputStream.Name = "inputStream";
            this.inputStream.Size = new System.Drawing.Size(454, 20);
            this.inputStream.TabIndex = 1;
            this.inputStream.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 385);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

