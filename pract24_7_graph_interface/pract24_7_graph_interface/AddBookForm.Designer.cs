namespace pract24_7_graph_interface
{
    partial class AddBookForm
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
            this.Add = new System.Windows.Forms.Button();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAuthor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(552, 178);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 51);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(136, 233);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(383, 66);
            this.richTextBoxName.TabIndex = 1;
            this.richTextBoxName.Text = "";
            // 
            // richTextBoxAuthor
            // 
            this.richTextBoxAuthor.Location = new System.Drawing.Point(136, 105);
            this.richTextBoxAuthor.Name = "richTextBoxAuthor";
            this.richTextBoxAuthor.Size = new System.Drawing.Size(383, 64);
            this.richTextBoxAuthor.TabIndex = 2;
            this.richTextBoxAuthor.Text = "";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxAuthor);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.Add);
            this.Name = "AddBookForm";
            this.Text = "AddBook";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddBookForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxAuthor;
    }
}