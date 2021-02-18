
namespace Necromind
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
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.ucMenuNew = new NecromindUI.MenuNew();
            this.SuspendLayout();
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGame.FlatAppearance.BorderSize = 0;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLoadGame.Location = new System.Drawing.Point(480, 140);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(100, 25);
            this.btnLoadGame.TabIndex = 17;
            this.btnLoadGame.Text = "Load";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNewGame.Location = new System.Drawing.Point(480, 100);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 25);
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // ucMenuNew
            // 
            this.ucMenuNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ucMenuNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMenuNew.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ucMenuNew.Location = new System.Drawing.Point(0, 0);
            this.ucMenuNew.Margin = new System.Windows.Forms.Padding(0);
            this.ucMenuNew.Name = "ucMenuNew";
            this.ucMenuNew.Size = new System.Drawing.Size(1084, 661);
            this.ucMenuNew.TabIndex = 18;
            this.ucMenuNew.Visible = false;
            // 
            // Necromind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.ucMenuNew);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Necromind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Necromind";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnNewGame;
        private NecromindUI.MenuNew ucMenuNew;
    }
}