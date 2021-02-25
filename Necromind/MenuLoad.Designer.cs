
using System;

namespace NecromindUI
{
    partial class MenuLoad
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panError = new System.Windows.Forms.Panel();
            this.btnErrorClose = new System.Windows.Forms.Button();
            this.labErrorMsg = new System.Windows.Forms.Label();
            this.labErrorTitle = new System.Windows.Forms.Label();
            this.panConfDel = new System.Windows.Forms.Panel();
            this.labQuestionMark = new System.Windows.Forms.Label();
            this.labDelConfirm = new System.Windows.Forms.Label();
            this.btnDelClose = new System.Windows.Forms.Button();
            this.labHeroName = new System.Windows.Forms.Label();
            this.labDelQuestion = new System.Windows.Forms.Label();
            this.btnDelHero = new System.Windows.Forms.Button();
            this.tbDelHeroName = new System.Windows.Forms.TextBox();
            this.panError.SuspendLayout();
            this.panConfDel.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panError
            // 
            this.panError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panError.Controls.Add(this.btnErrorClose);
            this.panError.Controls.Add(this.labErrorMsg);
            this.panError.Controls.Add(this.labErrorTitle);
            this.panError.Location = new System.Drawing.Point(400, 200);
            this.panError.Name = "panError";
            this.panError.Size = new System.Drawing.Size(300, 178);
            this.panError.TabIndex = 23;
            this.panError.Visible = false;
            // 
            // btnErrorClose
            // 
            this.btnErrorClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnErrorClose.FlatAppearance.BorderSize = 0;
            this.btnErrorClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnErrorClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnErrorClose.Location = new System.Drawing.Point(266, 12);
            this.btnErrorClose.Name = "btnErrorClose";
            this.btnErrorClose.Size = new System.Drawing.Size(24, 23);
            this.btnErrorClose.TabIndex = 2;
            this.btnErrorClose.Text = "X";
            this.btnErrorClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErrorClose.UseVisualStyleBackColor = false;
            this.btnErrorClose.Click += new System.EventHandler(this.BtnErrorClose_Click);
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
            // panConfDel
            // 
            this.panConfDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panConfDel.Controls.Add(this.labQuestionMark);
            this.panConfDel.Controls.Add(this.labDelConfirm);
            this.panConfDel.Controls.Add(this.btnDelClose);
            this.panConfDel.Controls.Add(this.labHeroName);
            this.panConfDel.Controls.Add(this.labDelQuestion);
            this.panConfDel.Controls.Add(this.btnDelHero);
            this.panConfDel.Controls.Add(this.tbDelHeroName);
            this.panConfDel.Location = new System.Drawing.Point(400, 200);
            this.panConfDel.Name = "panConfDel";
            this.panConfDel.Size = new System.Drawing.Size(300, 241);
            this.panConfDel.TabIndex = 24;
            this.panConfDel.Visible = false;
            // 
            // labQuestionMark
            // 
            this.labQuestionMark.AutoSize = true;
            this.labQuestionMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labQuestionMark.Location = new System.Drawing.Point(219, 65);
            this.labQuestionMark.Name = "labQuestionMark";
            this.labQuestionMark.Size = new System.Drawing.Size(16, 16);
            this.labQuestionMark.TabIndex = 9;
            this.labQuestionMark.Text = "?";
            // 
            // labDelConfirm
            // 
            this.labDelConfirm.AutoSize = true;
            this.labDelConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDelConfirm.Location = new System.Drawing.Point(18, 96);
            this.labDelConfirm.MinimumSize = new System.Drawing.Size(264, 0);
            this.labDelConfirm.Name = "labDelConfirm";
            this.labDelConfirm.Size = new System.Drawing.Size(264, 32);
            this.labDelConfirm.TabIndex = 8;
            this.labDelConfirm.Text = "Type the name of the character \r\nto confirm delete.";
            this.labDelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelClose
            // 
            this.btnDelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnDelClose.FlatAppearance.BorderSize = 0;
            this.btnDelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDelClose.Location = new System.Drawing.Point(266, 12);
            this.btnDelClose.Name = "btnDelClose";
            this.btnDelClose.Size = new System.Drawing.Size(24, 23);
            this.btnDelClose.TabIndex = 7;
            this.btnDelClose.Text = "X";
            this.btnDelClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelClose.UseVisualStyleBackColor = false;
            this.btnDelClose.Click += new System.EventHandler(this.BtnDelClose_Click);
            // 
            // labHeroName
            // 
            this.labHeroName.AutoSize = true;
            this.labHeroName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labHeroName.Location = new System.Drawing.Point(87, 65);
            this.labHeroName.MinimumSize = new System.Drawing.Size(125, 16);
            this.labHeroName.Name = "labHeroName";
            this.labHeroName.Size = new System.Drawing.Size(125, 18);
            this.labHeroName.TabIndex = 6;
            this.labHeroName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDelQuestion
            // 
            this.labDelQuestion.AutoSize = true;
            this.labDelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labDelQuestion.Location = new System.Drawing.Point(18, 40);
            this.labDelQuestion.Name = "labDelQuestion";
            this.labDelQuestion.Size = new System.Drawing.Size(264, 16);
            this.labDelQuestion.TabIndex = 5;
            this.labDelQuestion.Text = "Are you sure your want to DELETE";
            // 
            // btnDelHero
            // 
            this.btnDelHero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDelHero.CausesValidation = false;
            this.btnDelHero.Enabled = false;
            this.btnDelHero.FlatAppearance.BorderSize = 0;
            this.btnDelHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelHero.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnDelHero.Location = new System.Drawing.Point(100, 197);
            this.btnDelHero.Name = "btnDelHero";
            this.btnDelHero.Size = new System.Drawing.Size(100, 25);
            this.btnDelHero.TabIndex = 4;
            this.btnDelHero.Text = "DELETE";
            this.btnDelHero.UseVisualStyleBackColor = false;
            this.btnDelHero.Click += new System.EventHandler(this.BtnDeleteHero_Click);
            // 
            // tbDelHeroName
            // 
            this.tbDelHeroName.Location = new System.Drawing.Point(87, 150);
            this.tbDelHeroName.Multiline = true;
            this.tbDelHeroName.Name = "tbDelHeroName";
            this.tbDelHeroName.Size = new System.Drawing.Size(125, 25);
            this.tbDelHeroName.TabIndex = 1;
            this.tbDelHeroName.TextChanged += new System.EventHandler(this.TbDelHeroName_TextChanged);
            // 
            // MenuLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panConfDel);
            this.Controls.Add(this.panError);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuLoad";
            this.Size = new System.Drawing.Size(1084, 661);
            this.panError.ResumeLayout(false);
            this.panError.PerformLayout();
            this.panConfDel.ResumeLayout(false);
            this.panConfDel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panError;
        private System.Windows.Forms.Button btnErrorClose;
        private System.Windows.Forms.Label labErrorMsg;
        private System.Windows.Forms.Label labErrorTitle;
        private System.Windows.Forms.Panel panConfDel;
        private System.Windows.Forms.Button btnDelHero;
        private System.Windows.Forms.TextBox tbDelHeroName;
        private System.Windows.Forms.Label labHeroName;
        private System.Windows.Forms.Label labDelQuestion;
        private System.Windows.Forms.Button btnDelClose;
        private System.Windows.Forms.Label labQuestionMark;
        private System.Windows.Forms.Label labDelConfirm;
    }
}
