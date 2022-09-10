
namespace PasswordCreatorAndTestor
{
    partial class Gestionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionnaire));
            this.dgrPasswords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrPasswords
            // 
            this.dgrPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPasswords.Location = new System.Drawing.Point(231, 302);
            this.dgrPasswords.Name = "dgrPasswords";
            this.dgrPasswords.ReadOnly = true;
            this.dgrPasswords.RowHeadersWidth = 82;
            this.dgrPasswords.RowTemplate.Height = 33;
            this.dgrPasswords.Size = new System.Drawing.Size(1243, 394);
            this.dgrPasswords.TabIndex = 0;
            // 
            // Gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.dgrPasswords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Gestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de mots de passe";
            ((System.ComponentModel.ISupportInitialize)(this.dgrPasswords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPasswords;
    }
}