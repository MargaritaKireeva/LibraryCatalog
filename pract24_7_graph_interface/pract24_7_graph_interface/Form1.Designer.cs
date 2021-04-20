
namespace pract24_7_graph_interface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddFund = new System.Windows.Forms.Button();
            this.DeleteFund = new System.Windows.Forms.Button();
            this.listBoxFunds = new System.Windows.Forms.ListBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.radioButtonAllBook = new System.Windows.Forms.RadioButton();
            this.radioButtonFund = new System.Windows.Forms.RadioButton();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFund
            // 
            this.AddFund.Location = new System.Drawing.Point(479, 31);
            this.AddFund.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddFund.Name = "AddFund";
            this.AddFund.Size = new System.Drawing.Size(98, 42);
            this.AddFund.TabIndex = 0;
            this.AddFund.Text = "Добавить фонд";
            this.AddFund.UseVisualStyleBackColor = true;
            this.AddFund.Click += new System.EventHandler(this.AddFund_Click);
            // 
            // DeleteFund
            // 
            this.DeleteFund.Location = new System.Drawing.Point(479, 78);
            this.DeleteFund.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteFund.Name = "DeleteFund";
            this.DeleteFund.Size = new System.Drawing.Size(98, 42);
            this.DeleteFund.TabIndex = 1;
            this.DeleteFund.Text = "Удалить фонд";
            this.DeleteFund.UseVisualStyleBackColor = true;
            this.DeleteFund.Click += new System.EventHandler(this.DeleteFund_Click);
            // 
            // listBoxFunds
            // 
            this.listBoxFunds.FormattingEnabled = true;
            this.listBoxFunds.Location = new System.Drawing.Point(12, 31);
            this.listBoxFunds.Name = "listBoxFunds";
            this.listBoxFunds.Size = new System.Drawing.Size(165, 173);
            this.listBoxFunds.TabIndex = 5;
            this.listBoxFunds.SelectedIndexChanged += new System.EventHandler(this.listBoxFunds_SelectedIndexChanged);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(208, 31);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(246, 316);
            this.listBoxBooks.TabIndex = 6;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(479, 125);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(98, 43);
            this.AddBook.TabIndex = 7;
            this.AddBook.Text = "Добавить книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Location = new System.Drawing.Point(479, 175);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(98, 41);
            this.DeleteBook.TabIndex = 8;
            this.DeleteBook.Text = "Удалить книгу";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(2, 244);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(121, 20);
            this.textBoxFind.TabIndex = 11;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(133, 244);
            this.Find.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(56, 19);
            this.Find.TabIndex = 12;
            this.Find.Text = "Поиск";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // radioButtonAllBook
            // 
            this.radioButtonAllBook.AutoSize = true;
            this.radioButtonAllBook.Location = new System.Drawing.Point(2, 277);
            this.radioButtonAllBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAllBook.Name = "radioButtonAllBook";
            this.radioButtonAllBook.Size = new System.Drawing.Size(194, 17);
            this.radioButtonAllBook.TabIndex = 13;
            this.radioButtonAllBook.TabStop = true;
            this.radioButtonAllBook.Text = "по всему содержимому каталога";
            this.radioButtonAllBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonFund
            // 
            this.radioButtonFund.AutoSize = true;
            this.radioButtonFund.Location = new System.Drawing.Point(2, 300);
            this.radioButtonFund.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFund.Name = "radioButtonFund";
            this.radioButtonFund.Size = new System.Drawing.Size(190, 17);
            this.radioButtonFund.TabIndex = 14;
            this.radioButtonFund.TabStop = true;
            this.radioButtonFund.Text = "по содержимому данного фонда";
            this.radioButtonFund.UseVisualStyleBackColor = true;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(472, 256);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(112, 61);
            this.SaveChanges.TabIndex = 15;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.radioButtonFund);
            this.Controls.Add(this.radioButtonAllBook);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.listBoxFunds);
            this.Controls.Add(this.DeleteFund);
            this.Controls.Add(this.AddFund);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Библиотечный каталог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFund;
        private System.Windows.Forms.Button DeleteFund;
        private System.Windows.Forms.ListBox listBoxFunds;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.RadioButton radioButtonAllBook;
        private System.Windows.Forms.RadioButton radioButtonFund;
        private System.Windows.Forms.Button SaveChanges;
    }
}

