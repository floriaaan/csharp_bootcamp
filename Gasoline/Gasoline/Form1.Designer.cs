
namespace Gasoline
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLabelHelp = new System.Windows.Forms.Label();
            this.fuelService = new System.Windows.Forms.Label();
            this.serviceDone = new System.Windows.Forms.Button();
            this.fuelChoice1 = new Gasoline.FuelChoice();
            this.numPad1 = new Gasoline.NumPad();
            this.cardInsert1 = new Gasoline.CardInsert();
            this.ticketChoice1 = new Gasoline.TicketChoice();
            this.terminate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insérer carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordLabel.Location = new System.Drawing.Point(72, 125);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 39);
            this.passwordLabel.TabIndex = 3;
            // 
            // passwordLabelHelp
            // 
            this.passwordLabelHelp.AutoSize = true;
            this.passwordLabelHelp.Location = new System.Drawing.Point(79, 88);
            this.passwordLabelHelp.Name = "passwordLabelHelp";
            this.passwordLabelHelp.Size = new System.Drawing.Size(120, 17);
            this.passwordLabelHelp.TabIndex = 4;
            this.passwordLabelHelp.Text = "Entrez votre code";
            // 
            // fuelService
            // 
            this.fuelService.AutoSize = true;
            this.fuelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fuelService.Location = new System.Drawing.Point(25, 35);
            this.fuelService.Name = "fuelService";
            this.fuelService.Size = new System.Drawing.Size(0, 26);
            this.fuelService.TabIndex = 6;
            // 
            // serviceDone
            // 
            this.serviceDone.Location = new System.Drawing.Point(13, 483);
            this.serviceDone.Name = "serviceDone";
            this.serviceDone.Size = new System.Drawing.Size(380, 51);
            this.serviceDone.TabIndex = 7;
            this.serviceDone.Text = "Terminer";
            this.serviceDone.UseVisualStyleBackColor = true;
            this.serviceDone.Click += new System.EventHandler(this.serviceDone_Click);
            // 
            // fuelChoice1
            // 
            this.fuelChoice1.Location = new System.Drawing.Point(50, 71);
            this.fuelChoice1.Name = "fuelChoice1";
            this.fuelChoice1.Size = new System.Drawing.Size(300, 368);
            this.fuelChoice1.TabIndex = 5;
            this.fuelChoice1.Load += new System.EventHandler(this.fuelChoice1_Load);
            // 
            // numPad1
            // 
            this.numPad1.Location = new System.Drawing.Point(79, 167);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(250, 310);
            this.numPad1.TabIndex = 2;
            this.numPad1.Load += new System.EventHandler(this.numPad1_Load);
            // 
            // cardInsert1
            // 
            this.cardInsert1.Location = new System.Drawing.Point(30, 35);
            this.cardInsert1.Name = "cardInsert1";
            this.cardInsert1.Size = new System.Drawing.Size(339, 385);
            this.cardInsert1.TabIndex = 0;
            this.cardInsert1.Load += new System.EventHandler(this.cardInsert1_Load);
            // 
            // ticketChoice1
            // 
            this.ticketChoice1.Location = new System.Drawing.Point(50, 71);
            this.ticketChoice1.Name = "ticketChoice1";
            this.ticketChoice1.Size = new System.Drawing.Size(300, 368);
            this.ticketChoice1.TabIndex = 8;
            this.ticketChoice1.Load += new System.EventHandler(this.ticketChoice1_Load);
            // 
            // terminate
            // 
            this.terminate.AutoSize = true;
            this.terminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.terminate.Location = new System.Drawing.Point(33, 226);
            this.terminate.Name = "terminate";
            this.terminate.Size = new System.Drawing.Size(336, 39);
            this.terminate.TabIndex = 9;
            this.terminate.Text = "Merci de votre visite !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 546);
            this.Controls.Add(this.terminate);
            this.Controls.Add(this.ticketChoice1);
            this.Controls.Add(this.serviceDone);
            this.Controls.Add(this.fuelService);
            this.Controls.Add(this.fuelChoice1);
            this.Controls.Add(this.passwordLabelHelp);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.numPad1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardInsert1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CardInsert cardInsert1;
        private System.Windows.Forms.Button button1;
        private NumPad numPad1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLabelHelp;
        private FuelChoice fuelChoice1;
        private System.Windows.Forms.Label fuelService;
        private System.Windows.Forms.Button serviceDone;
        private TicketChoice ticketChoice1;
        private System.Windows.Forms.Label terminate;
    }
}

