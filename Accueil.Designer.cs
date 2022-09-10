
namespace PasswordCreatorAndTestor
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.butGMP = new System.Windows.Forms.Button();
            this.butGestionnaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGMP
            // 
            this.butGMP.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGMP.Location = new System.Drawing.Point(23, 47);
            this.butGMP.Margin = new System.Windows.Forms.Padding(2);
            this.butGMP.Name = "butGMP";
            this.butGMP.Size = new System.Drawing.Size(153, 137);
            this.butGMP.TabIndex = 0;
            this.butGMP.Text = "Générateur";
            this.butGMP.UseVisualStyleBackColor = true;
            this.butGMP.Click += new System.EventHandler(this.butGMP_Click);
            // 
            // butGestionnaire
            // 
            this.butGestionnaire.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGestionnaire.Location = new System.Drawing.Point(194, 47);
            this.butGestionnaire.Margin = new System.Windows.Forms.Padding(2);
            this.butGestionnaire.Name = "butGestionnaire";
            this.butGestionnaire.Size = new System.Drawing.Size(171, 137);
            this.butGestionnaire.TabIndex = 1;
            this.butGestionnaire.Text = "Gestionnaire de mots de passe";
            this.butGestionnaire.UseVisualStyleBackColor = true;
            this.butGestionnaire.Click += new System.EventHandler(this.butGestionnaire_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.butGestionnaire);
            this.Controls.Add(this.butGMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGMP;
        private System.Windows.Forms.Button butGestionnaire;
    }
}

