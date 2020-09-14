namespace NecromindUI
{
    partial class Necromind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Necromind));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.textBoxNewHeroName = new System.Windows.Forms.TextBox();
            this.btnCreateNewHero = new System.Windows.Forms.Button();
            this.btnBackFromNewGame = new System.Windows.Forms.Button();
            this.panelLoadGame = new System.Windows.Forms.Panel();
            this.btnBackFromLoadGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnBackFromGame = new System.Windows.Forms.Button();
            this.groupBoxHeroDetails = new System.Windows.Forms.GroupBox();
            this.labelHeroDefenseValue = new System.Windows.Forms.Label();
            this.labelHeroDamageValue = new System.Windows.Forms.Label();
            this.labelHeroLevelValue = new System.Windows.Forms.Label();
            this.labelHeroXPValue = new System.Windows.Forms.Label();
            this.labelHeroGoldValue = new System.Windows.Forms.Label();
            this.labelHeroHealthValue = new System.Windows.Forms.Label();
            this.labelHeroDefense = new System.Windows.Forms.Label();
            this.labelHeroDamage = new System.Windows.Forms.Label();
            this.labelHeroLevel = new System.Windows.Forms.Label();
            this.labelHeroXP = new System.Windows.Forms.Label();
            this.labelHeroGold = new System.Windows.Forms.Label();
            this.labelHeroHealth = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.panelLoadGame.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.groupBoxHeroDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnLoadGame);
            this.panelMenu.Controls.Add(this.btnNewGame);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(984, 661);
            this.panelMenu.TabIndex = 14;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGame.FlatAppearance.BorderSize = 0;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLoadGame.Location = new System.Drawing.Point(430, 140);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(100, 25);
            this.btnLoadGame.TabIndex = 13;
            this.btnLoadGame.Text = "Load";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNewGame.Location = new System.Drawing.Point(430, 100);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 25);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // panelNewGame
            // 
            this.panelNewGame.Controls.Add(this.textBoxNewHeroName);
            this.panelNewGame.Controls.Add(this.btnCreateNewHero);
            this.panelNewGame.Controls.Add(this.btnBackFromNewGame);
            this.panelNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewGame.Location = new System.Drawing.Point(0, 0);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(984, 661);
            this.panelNewGame.TabIndex = 14;
            // 
            // textBoxNewHeroName
            // 
            this.textBoxNewHeroName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewHeroName.Location = new System.Drawing.Point(430, 100);
            this.textBoxNewHeroName.Multiline = true;
            this.textBoxNewHeroName.Name = "textBoxNewHeroName";
            this.textBoxNewHeroName.Size = new System.Drawing.Size(100, 25);
            this.textBoxNewHeroName.TabIndex = 2;
            // 
            // btnCreateNewHero
            // 
            this.btnCreateNewHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateNewHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCreateNewHero.FlatAppearance.BorderSize = 0;
            this.btnCreateNewHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCreateNewHero.Location = new System.Drawing.Point(430, 140);
            this.btnCreateNewHero.Name = "btnCreateNewHero";
            this.btnCreateNewHero.Size = new System.Drawing.Size(100, 25);
            this.btnCreateNewHero.TabIndex = 1;
            this.btnCreateNewHero.Text = "Create";
            this.btnCreateNewHero.UseVisualStyleBackColor = false;
            this.btnCreateNewHero.Click += new System.EventHandler(this.btnCreateNewHero_Click);
            // 
            // btnBackFromNewGame
            // 
            this.btnBackFromNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnBackFromNewGame.FlatAppearance.BorderSize = 0;
            this.btnBackFromNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBackFromNewGame.Location = new System.Drawing.Point(20, 20);
            this.btnBackFromNewGame.Name = "btnBackFromNewGame";
            this.btnBackFromNewGame.Size = new System.Drawing.Size(100, 25);
            this.btnBackFromNewGame.TabIndex = 0;
            this.btnBackFromNewGame.Text = "Back";
            this.btnBackFromNewGame.UseVisualStyleBackColor = false;
            this.btnBackFromNewGame.Click += new System.EventHandler(this.btnBackFromNewGame_Click);
            // 
            // panelLoadGame
            // 
            this.panelLoadGame.Controls.Add(this.btnBackFromLoadGame);
            this.panelLoadGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadGame.Location = new System.Drawing.Point(0, 0);
            this.panelLoadGame.Name = "panelLoadGame";
            this.panelLoadGame.Size = new System.Drawing.Size(984, 661);
            this.panelLoadGame.TabIndex = 15;
            // 
            // btnBackFromLoadGame
            // 
            this.btnBackFromLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromLoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnBackFromLoadGame.FlatAppearance.BorderSize = 0;
            this.btnBackFromLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromLoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBackFromLoadGame.Location = new System.Drawing.Point(20, 20);
            this.btnBackFromLoadGame.Name = "btnBackFromLoadGame";
            this.btnBackFromLoadGame.Size = new System.Drawing.Size(100, 25);
            this.btnBackFromLoadGame.TabIndex = 1;
            this.btnBackFromLoadGame.Text = "Back";
            this.btnBackFromLoadGame.UseVisualStyleBackColor = false;
            this.btnBackFromLoadGame.Click += new System.EventHandler(this.btnBackFromLoadGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.btnBackFromGame);
            this.panelGame.Controls.Add(this.groupBoxHeroDetails);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(984, 661);
            this.panelGame.TabIndex = 16;
            // 
            // btnBackFromGame
            // 
            this.btnBackFromGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFromGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnBackFromGame.FlatAppearance.BorderSize = 0;
            this.btnBackFromGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBackFromGame.Location = new System.Drawing.Point(20, 20);
            this.btnBackFromGame.Name = "btnBackFromGame";
            this.btnBackFromGame.Size = new System.Drawing.Size(100, 25);
            this.btnBackFromGame.TabIndex = 2;
            this.btnBackFromGame.Text = "Back";
            this.btnBackFromGame.UseVisualStyleBackColor = false;
            this.btnBackFromGame.Click += new System.EventHandler(this.btnBackFromGame_Click);
            // 
            // groupBoxHeroDetails
            // 
            this.groupBoxHeroDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroDefenseValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroDamageValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroLevelValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroXPValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroGoldValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroHealthValue);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroDefense);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroDamage);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroLevel);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroXP);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroGold);
            this.groupBoxHeroDetails.Controls.Add(this.labelHeroHealth);
            this.groupBoxHeroDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHeroDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.groupBoxHeroDetails.Location = new System.Drawing.Point(20, 55);
            this.groupBoxHeroDetails.Name = "groupBoxHeroDetails";
            this.groupBoxHeroDetails.Size = new System.Drawing.Size(187, 183);
            this.groupBoxHeroDetails.TabIndex = 0;
            this.groupBoxHeroDetails.TabStop = false;
            this.groupBoxHeroDetails.Text = "{HERO}\'s Details";
            // 
            // labelHeroDefenseValue
            // 
            this.labelHeroDefenseValue.Location = new System.Drawing.Point(101, 148);
            this.labelHeroDefenseValue.Name = "labelHeroDefenseValue";
            this.labelHeroDefenseValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroDefenseValue.TabIndex = 11;
            this.labelHeroDefenseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroDamageValue
            // 
            this.labelHeroDamageValue.Location = new System.Drawing.Point(100, 125);
            this.labelHeroDamageValue.Name = "labelHeroDamageValue";
            this.labelHeroDamageValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroDamageValue.TabIndex = 10;
            this.labelHeroDamageValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroLevelValue
            // 
            this.labelHeroLevelValue.Location = new System.Drawing.Point(100, 100);
            this.labelHeroLevelValue.Name = "labelHeroLevelValue";
            this.labelHeroLevelValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroLevelValue.TabIndex = 9;
            this.labelHeroLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroXPValue
            // 
            this.labelHeroXPValue.Location = new System.Drawing.Point(100, 75);
            this.labelHeroXPValue.Name = "labelHeroXPValue";
            this.labelHeroXPValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroXPValue.TabIndex = 8;
            this.labelHeroXPValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroGoldValue
            // 
            this.labelHeroGoldValue.Location = new System.Drawing.Point(100, 50);
            this.labelHeroGoldValue.Name = "labelHeroGoldValue";
            this.labelHeroGoldValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroGoldValue.TabIndex = 7;
            this.labelHeroGoldValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroHealthValue
            // 
            this.labelHeroHealthValue.Location = new System.Drawing.Point(100, 25);
            this.labelHeroHealthValue.Name = "labelHeroHealthValue";
            this.labelHeroHealthValue.Size = new System.Drawing.Size(80, 20);
            this.labelHeroHealthValue.TabIndex = 6;
            this.labelHeroHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroDefense
            // 
            this.labelHeroDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroDefense.Location = new System.Drawing.Point(10, 150);
            this.labelHeroDefense.Name = "labelHeroDefense";
            this.labelHeroDefense.Size = new System.Drawing.Size(80, 20);
            this.labelHeroDefense.TabIndex = 5;
            this.labelHeroDefense.Text = "Defense:";
            // 
            // labelHeroDamage
            // 
            this.labelHeroDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroDamage.Location = new System.Drawing.Point(10, 125);
            this.labelHeroDamage.Name = "labelHeroDamage";
            this.labelHeroDamage.Size = new System.Drawing.Size(80, 20);
            this.labelHeroDamage.TabIndex = 4;
            this.labelHeroDamage.Text = "Damage:";
            // 
            // labelHeroLevel
            // 
            this.labelHeroLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroLevel.Location = new System.Drawing.Point(10, 100);
            this.labelHeroLevel.Name = "labelHeroLevel";
            this.labelHeroLevel.Size = new System.Drawing.Size(80, 20);
            this.labelHeroLevel.TabIndex = 3;
            this.labelHeroLevel.Text = "Level:";
            // 
            // labelHeroXP
            // 
            this.labelHeroXP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroXP.Location = new System.Drawing.Point(10, 75);
            this.labelHeroXP.Name = "labelHeroXP";
            this.labelHeroXP.Size = new System.Drawing.Size(80, 20);
            this.labelHeroXP.TabIndex = 2;
            this.labelHeroXP.Text = "XP:";
            // 
            // labelHeroGold
            // 
            this.labelHeroGold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroGold.Location = new System.Drawing.Point(10, 50);
            this.labelHeroGold.Name = "labelHeroGold";
            this.labelHeroGold.Size = new System.Drawing.Size(80, 20);
            this.labelHeroGold.TabIndex = 1;
            this.labelHeroGold.Text = "Gold:";
            // 
            // labelHeroHealth
            // 
            this.labelHeroHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeroHealth.Location = new System.Drawing.Point(10, 25);
            this.labelHeroHealth.Name = "labelHeroHealth";
            this.labelHeroHealth.Size = new System.Drawing.Size(80, 20);
            this.labelHeroHealth.TabIndex = 0;
            this.labelHeroHealth.Text = "Health:";
            // 
            // Necromind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelLoadGame);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Necromind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Necromind";
            this.panelMenu.ResumeLayout(false);
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.panelLoadGame.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.groupBoxHeroDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.TextBox textBoxNewHeroName;
        private System.Windows.Forms.Button btnCreateNewHero;
        private System.Windows.Forms.Button btnBackFromNewGame;
        private System.Windows.Forms.Panel panelLoadGame;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button btnBackFromLoadGame;
        private System.Windows.Forms.Button btnBackFromGame;
        private System.Windows.Forms.GroupBox groupBoxHeroDetails;
        private System.Windows.Forms.Label labelHeroXP;
        private System.Windows.Forms.Label labelHeroGold;
        private System.Windows.Forms.Label labelHeroHealth;
        private System.Windows.Forms.Label labelHeroLevel;
        private System.Windows.Forms.Label labelHeroDefenseValue;
        private System.Windows.Forms.Label labelHeroDamageValue;
        private System.Windows.Forms.Label labelHeroLevelValue;
        private System.Windows.Forms.Label labelHeroXPValue;
        private System.Windows.Forms.Label labelHeroGoldValue;
        private System.Windows.Forms.Label labelHeroHealthValue;
        private System.Windows.Forms.Label labelHeroDefense;
        private System.Windows.Forms.Label labelHeroDamage;
    }
}

