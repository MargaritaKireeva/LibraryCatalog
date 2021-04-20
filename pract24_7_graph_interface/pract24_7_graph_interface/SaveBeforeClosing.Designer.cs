namespace pract24_7_graph_interface
{
    partial class SaveBeforeClosing
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
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(289, 64);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(157, 42);
            this.SaveAndClose.TabIndex = 0;
            this.SaveAndClose.Text = "Сохранить и выйти";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(60, 64);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(147, 42);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Выйти без сохранения";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveBeforeClosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 174);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveAndClose);
            this.Name = "SaveBeforeClosing";
            this.Text = "SaveBeforeClosing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveAndClose;
        private System.Windows.Forms.Button Cancel;
    }
}