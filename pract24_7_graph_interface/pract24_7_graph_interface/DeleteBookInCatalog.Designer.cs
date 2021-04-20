namespace pract24_7_graph_interface
{
    partial class DeleteBookInCatalog
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
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(337, 134);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(85, 45);
            this.OK.TabIndex = 0;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DeleteBookInCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 214);
            this.Controls.Add(this.OK);
            this.Name = "DeleteBookInCatalog";
            this.ShowIcon = false;
            this.Text = "DeleteBookInCatalog";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteBookInCatalog_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
    }
}