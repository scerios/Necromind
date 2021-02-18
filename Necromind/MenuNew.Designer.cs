
namespace NecromindUI
{
    partial class MenuNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNewHeroName = new System.Windows.Forms.TextBox();
            this.btnCreateNewHero = new System.Windows.Forms.Button();
            this.btnBackFromNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewHeroName
            // 
            this.textBoxNewHeroName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewHeroName.Location = new System.Drawing.Point(480, 100);
            this.textBoxNewHeroName.Name = "textBoxNewHeroName";
            this.textBoxNewHeroName.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewHeroName.TabIndex = 5;
            // 
            // btnCreateNewHero
            // 
            this.btnCreateNewHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateNewHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCreateNewHero.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateNewHero.FlatAppearance.BorderSize = 0;
            this.btnCreateNewHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCreateNewHero.Location = new System.Drawing.Point(480, 140);
            this.btnCreateNewHero.Name = "btnCreateNewHero";
            this.btnCreateNewHero.Size = new System.Drawing.Size(100, 25);
            this.btnCreateNewHero.TabIndex = 4;
            this.btnCreateNewHero.Text = "Create";
            this.btnCreateNewHero.UseVisualStyleBackColor = false;
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
            this.btnBackFromNewGame.TabIndex = 3;
            this.btnBackFromNewGame.Text = "Back";
            this.btnBackFromNewGame.UseVisualStyleBackColor = false;
            this.btnBackFromNewGame.Click += new System.EventHandler(this.btnBackFromNewGame_Click);
            // 
            // MenuNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.textBoxNewHeroName);
            this.Controls.Add(this.btnCreateNewHero);
            this.Controls.Add(this.btnBackFromNewGame);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuNew";
            this.Size = new System.Drawing.Size(1084, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewHeroName;
        private System.Windows.Forms.Button btnCreateNewHero;
        private System.Windows.Forms.Button btnBackFromNewGame;
    }
}
