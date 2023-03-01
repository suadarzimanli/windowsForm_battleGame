namespace WFA
{
    partial class Form20
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
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnBomb = new System.Windows.Forms.Button();
            this.btnNpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarrior
            // 
            this.btnWarrior.Location = new System.Drawing.Point(89, 247);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(223, 55);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.Text = "warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnArcher
            // 
            this.btnArcher.Location = new System.Drawing.Point(496, 248);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(223, 55);
            this.btnArcher.TabIndex = 1;
            this.btnArcher.Text = "archer";
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnWizard
            // 
            this.btnWizard.Location = new System.Drawing.Point(889, 247);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(223, 56);
            this.btnWizard.TabIndex = 2;
            this.btnWizard.Text = "wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            // 
            // btnBomb
            // 
            this.btnBomb.Location = new System.Drawing.Point(496, 385);
            this.btnBomb.Name = "btnBomb";
            this.btnBomb.Size = new System.Drawing.Size(223, 54);
            this.btnBomb.TabIndex = 3;
            this.btnBomb.Text = "bomb";
            this.btnBomb.UseVisualStyleBackColor = true;
            this.btnBomb.Click += new System.EventHandler(this.btnBomb_Click);
            // 
            // btnNpc
            // 
            this.btnNpc.Location = new System.Drawing.Point(496, 512);
            this.btnNpc.Name = "btnNpc";
            this.btnNpc.Size = new System.Drawing.Size(223, 54);
            this.btnNpc.TabIndex = 4;
            this.btnNpc.Text = "NPC";
            this.btnNpc.UseVisualStyleBackColor = true;
            this.btnNpc.Click += new System.EventHandler(this.btnNpc_Click);
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnNpc);
            this.Controls.Add(this.btnBomb);
            this.Controls.Add(this.btnWizard);
            this.Controls.Add(this.btnArcher);
            this.Controls.Add(this.btnWarrior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form20";
            this.Text = "Form20";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnArcher;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Button btnBomb;
        private System.Windows.Forms.Button btnNpc;
    }
}