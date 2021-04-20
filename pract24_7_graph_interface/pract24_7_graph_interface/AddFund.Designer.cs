
namespace pract24_7_graph_interface
{
    partial class AddFundForm
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
            this.richTextBoxAdd = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxAdd
            // 
            this.richTextBoxAdd.Location = new System.Drawing.Point(147, 100);
            this.richTextBoxAdd.Name = "richTextBoxAdd";
            this.richTextBoxAdd.Size = new System.Drawing.Size(470, 77);
            this.richTextBoxAdd.TabIndex = 0;
            this.richTextBoxAdd.Text = "";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(434, 233);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(183, 69);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddFundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.richTextBoxAdd);
            this.Name = "AddFundForm";
            this.Text = "AddFund";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddFundForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAdd;
        private System.Windows.Forms.Button Add;
    }
}