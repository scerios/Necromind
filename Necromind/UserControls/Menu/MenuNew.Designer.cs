﻿
namespace NecromindUI.UserControls.Menu
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
            this.btnErrorClose = new System.Windows.Forms.Button();
            this.labErrorMsg = new System.Windows.Forms.Label();
            this.labErrorTitle = new System.Windows.Forms.Label();
            this.panError.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHeroName
            // 
            this.tbHeroName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHeroName.Location = new System.Drawing.Point(492, 100);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.Size = new System.Drawing.Size(100, 22);
            this.tbHeroName.TabIndex = 5;
            this.tbHeroName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbHeroName_KeyUp);
            // 
            // btnCreateNewHero
            // 
            this.btnCreateNewHero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateNewHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCreateNewHero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewHero.FlatAppearance.BorderSize = 0;
            this.btnCreateNewHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCreateNewHero.Location = new System.Drawing.Point(492, 140);
            this.btnCreateNewHero.Name = "btnCreateNewHero";
            this.btnCreateNewHero.Size = new System.Drawing.Size(100, 25);
            this.btnCreateNewHero.TabIndex = 4;
            this.btnCreateNewHero.TabStop = false;
            this.btnCreateNewHero.Text = "Create";
            this.btnCreateNewHero.UseVisualStyleBackColor = false;
            this.btnCreateNewHero.Click += new System.EventHandler(this.BtnCreateNewHero_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panError
            // 
            this.panError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panError.Controls.Add(this.btnErrorClose);
            this.panError.Controls.Add(this.labErrorMsg);
            this.panError.Controls.Add(this.labErrorTitle);
            this.panError.Location = new System.Drawing.Point(392, 200);
            this.panError.Name = "panError";
            this.panError.Size = new System.Drawing.Size(300, 178);
            this.panError.TabIndex = 24;
            this.panError.Visible = false;
            // 
            // btnErrorClose
            // 
            this.btnErrorClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnErrorClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErrorClose.FlatAppearance.BorderSize = 0;
            this.btnErrorClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnErrorClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnErrorClose.Location = new System.Drawing.Point(266, 12);
            this.btnErrorClose.Name = "btnErrorClose";
            this.btnErrorClose.Size = new System.Drawing.Size(24, 23);
            this.btnErrorClose.TabIndex = 2;
            this.btnErrorClose.TabStop = false;
            this.btnErrorClose.Text = "X";
            this.btnErrorClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErrorClose.UseVisualStyleBackColor = false;
            this.btnErrorClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.Size = new System.Drawing.Size(1084, 717);
            this.panError.ResumeLayout(false);
            this.panError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewHero;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panError;
        private System.Windows.Forms.Button btnErrorClose;
        private System.Windows.Forms.Label labErrorMsg;
        private System.Windows.Forms.Label labErrorTitle;
        public System.Windows.Forms.TextBox tbHeroName;
    }
}
