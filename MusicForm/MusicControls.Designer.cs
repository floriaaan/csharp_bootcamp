
namespace MusicForm
{
    partial class MusicControls
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.musicTitle = new System.Windows.Forms.Label();
            this.musicValidateBtn = new System.Windows.Forms.Button();
            this.musicDescription = new System.Windows.Forms.Label();
            this.musicID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musicTitle
            // 
            this.musicTitle.AutoSize = true;
            this.musicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.musicTitle.Location = new System.Drawing.Point(3, 0);
            this.musicTitle.Name = "musicTitle";
            this.musicTitle.Size = new System.Drawing.Size(81, 29);
            this.musicTitle.TabIndex = 0;
            this.musicTitle.Text = "Name";
            // 
            // musicValidateBtn
            // 
            this.musicValidateBtn.Location = new System.Drawing.Point(447, 3);
            this.musicValidateBtn.Name = "musicValidateBtn";
            this.musicValidateBtn.Size = new System.Drawing.Size(75, 59);
            this.musicValidateBtn.TabIndex = 1;
            this.musicValidateBtn.Text = "Validate";
            this.musicValidateBtn.UseVisualStyleBackColor = true;
            this.musicValidateBtn.Click += new System.EventHandler(this.musicValidateBtn_Click);
            // 
            // musicDescription
            // 
            this.musicDescription.AutoSize = true;
            this.musicDescription.Location = new System.Drawing.Point(5, 29);
            this.musicDescription.Name = "musicDescription";
            this.musicDescription.Size = new System.Drawing.Size(79, 17);
            this.musicDescription.TabIndex = 2;
            this.musicDescription.Text = "Description";
            // 
            // musicID
            // 
            this.musicID.AutoSize = true;
            this.musicID.Enabled = false;
            this.musicID.Location = new System.Drawing.Point(430, 45);
            this.musicID.Name = "musicID";
            this.musicID.Size = new System.Drawing.Size(0, 17);
            this.musicID.TabIndex = 3;
            this.musicID.Visible = false;
            // 
            // MusicControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.musicID);
            this.Controls.Add(this.musicDescription);
            this.Controls.Add(this.musicValidateBtn);
            this.Controls.Add(this.musicTitle);
            this.Name = "MusicControls";
            this.Size = new System.Drawing.Size(525, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musicTitle;
        private System.Windows.Forms.Button musicValidateBtn;
        private System.Windows.Forms.Label musicDescription;
        private System.Windows.Forms.Label musicID;
    }
}
