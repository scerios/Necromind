
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
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.btnCreateNewHero = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panError = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labErrorMsg = new System.Windows.Forms.Label();
            this.labErrorTitle = new System.Windows.Forms.Label();
            this.panError.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHeroName
            // 
            this.tbHeroName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHeroName.Location = new System.Drawing.Point(500, 100);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.Size = new System.Drawing.Size(100, 22);
            this.tbHeroName.TabIndex = 5;
            // 
            // btnCreateNewHero
            // 
            this.btnCreateNewHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateNewHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCreateNewHero.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateNewHero.FlatAppearance.BorderSize = 0;
            this.btnCreateNewHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCreateNewHero.Location = new System.Drawing.Point(500, 140);
            this.btnCreateNewHero.Name = "btnCreateNewHero";
            this.btnCreateNewHero.Size = new System.Drawing.Size(100, 25);
            this.btnCreateNewHero.TabIndex = 4;
            this.btnCreateNewHero.Text = "Create";
            this.btnCreateNewHero.UseVisualStyleBackColor = false;
            this.btnCreateNewHero.Click += new System.EventHandler(this.BtnCreateNewHero_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panError
            // 
            this.panError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panError.Controls.Add(this.btnClose);
            this.panError.Controls.Add(this.labErrorMsg);
            this.panError.Controls.Add(this.labErrorTitle);
            this.panError.Location = new System.Drawing.Point(400, 200);
            this.panError.Name = "panError";
            this.panError.Size = new System.Drawing.Size(300, 178);
            this.panError.TabIndex = 24;
            this.panError.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.Location = new System.Drawing.Point(266, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // labErrorMsg
            // 
            this.labErrorMsg.AutoSize = true;
            this.labErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labErrorMsg.Location = new System.Drawing.Point(10, 50);
            this.labErrorMsg.MinimumSize = new System.Drawing.Size(280, 110);
            this.labErrorMsg.Name = "labErrorMsg";
            this.labErrorMsg.Size = new System.Drawing.Size(280, 110);
            this.labErrorMsg.TabIndex = 1;
            this.labErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labErrorTitle
            // 
            this.labErrorTitle.AutoSize = true;
            this.labErrorTitle.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labErrorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labErrorTitle.Location = new System.Drawing.Point(10, 15);
            this.labErrorTitle.MinimumSize = new System.Drawing.Size(240, 0);
            this.labErrorTitle.Name = "labErrorTitle";
            this.labErrorTitle.Size = new System.Drawing.Size(240, 16);
            this.labErrorTitle.TabIndex = 0;
            this.labErrorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panError);
            this.Controls.Add(this.tbHeroName);
            this.Controls.Add(this.btnCreateNewHero);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuNew";
            this.Size = new System.Drawing.Size(1084, 661);
            this.panError.ResumeLayout(false);
            this.panError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHeroName;
        private System.Windows.Forms.Button btnCreateNewHero;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labErrorMsg;
        private System.Windows.Forms.Label labErrorTitle;
    }
}
