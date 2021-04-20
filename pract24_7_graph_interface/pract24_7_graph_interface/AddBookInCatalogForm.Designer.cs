namespace pract24_7_graph_interface
{
    partial class AddBookInCatalogForm
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
            this.richTextBoxAuthor = new System.Windows.Forms.RichTextBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFundName = new System.Windows.Forms.RichTextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxAuthor
            // 
            this.richTextBoxAuthor.Location = new System.Drawing.Point(140, 70);
            this.richTextBoxAuthor.Name = "richTextBoxAuthor";
            this.richTextBoxAuthor.Size = new System.Drawing.Size(352, 55);
            this.richTextBoxAuthor.TabIndex = 0;
            this.richTextBoxAuthor.Text = "";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(140, 178);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(352, 51);
            this.richTextBoxName.TabIndex = 1;
            this.richTextBoxName.Text = "";
            // 
            // richTextBoxFundName
            // 
            this.richTextBoxFundName.Location = new System.Drawing.Point(140, 300);
            this.richTextBoxFundName.Name = "richTextBoxFundName";
            this.richTextBoxFundName.Size = new System.Drawing.Size(352, 49);
            this.richTextBoxFundName.TabIndex = 2;
            this.richTextBoxFundName.Text = "";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(583, 300);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(159, 62);
            this.AddBook.TabIndex = 3;
            this.AddBook.Text = "Добавить";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AddBookInCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.richTextBoxFundName);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.richTextBoxAuthor);
            this.Name = "AddBookInCatalogForm";
            this.Text = "AddBookInCatalogForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddBookInCatalogForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAuthor;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxFundName;
        private System.Windows.Forms.Button AddBook;
    }
}