
namespace NecromindUI
{
    partial class GameMain
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
            this.panBottom = new System.Windows.Forms.Panel();
            this.panEventLog = new System.Windows.Forms.Panel();
            this.rtbEventLog = new System.Windows.Forms.RichTextBox();
            this.panControls = new System.Windows.Forms.Panel();
            this.panHero = new System.Windows.Forms.Panel();
            this.labSlash = new System.Windows.Forms.Label();
            this.labHealthValue = new System.Windows.Forms.Label();
            this.labDefValue = new System.Windows.Forms.Label();
            this.labLvlValue = new System.Windows.Forms.Label();
            this.labGoldValue = new System.Windows.Forms.Label();
            this.labLvl = new System.Windows.Forms.Label();
            this.labDmgValue = new System.Windows.Forms.Label();
            this.labHealthMaxValue = new System.Windows.Forms.Label();
            this.labGold = new System.Windows.Forms.Label();
            this.labDef = new System.Windows.Forms.Label();
            this.labDmg = new System.Windows.Forms.Label();
            this.labHealth = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.panExit = new System.Windows.Forms.Panel();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.labExitQuestion = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.panBottom.SuspendLayout();
            this.panEventLog.SuspendLayout();
            this.panControls.SuspendLayout();
            this.panHero.SuspendLayout();
            this.panExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.panEventLog);
            this.panBottom.Controls.Add(this.panControls);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 411);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1084, 250);
            this.panBottom.TabIndex = 0;
            // 
            // panEventLog
            // 
            this.panEventLog.Controls.Add(this.rtbEventLog);
            this.panEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panEventLog.Location = new System.Drawing.Point(0, 0);
            this.panEventLog.Name = "panEventLog";
            this.panEventLog.Size = new System.Drawing.Size(784, 250);
            this.panEventLog.TabIndex = 1;
            // 
            // rtbEventLog
            // 
            this.rtbEventLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.rtbEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEventLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEventLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.rtbEventLog.Location = new System.Drawing.Point(0, 0);
            this.rtbEventLog.Name = "rtbEventLog";
            this.rtbEventLog.ReadOnly = true;
            this.rtbEventLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEventLog.Size = new System.Drawing.Size(784, 250);
            this.rtbEventLog.TabIndex = 14;
            this.rtbEventLog.TabStop = false;
            this.rtbEventLog.Text = "";
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.btnSouth);
            this.panControls.Controls.Add(this.btnEast);
            this.panControls.Controls.Add(this.btnWest);
            this.panControls.Controls.Add(this.btnNorth);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panControls.Location = new System.Drawing.Point(784, 0);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(300, 250);
            this.panControls.TabIndex = 0;
            // 
            // panHero
            // 
            this.panHero.Controls.Add(this.labSlash);
            this.panHero.Controls.Add(this.labHealthValue);
            this.panHero.Controls.Add(this.labDefValue);
            this.panHero.Controls.Add(this.labLvlValue);
            this.panHero.Controls.Add(this.labGoldValue);
            this.panHero.Controls.Add(this.labLvl);
            this.panHero.Controls.Add(this.labDmgValue);
            this.panHero.Controls.Add(this.labHealthMaxValue);
            this.panHero.Controls.Add(this.labGold);
            this.panHero.Controls.Add(this.labDef);
            this.panHero.Controls.Add(this.labDmg);
            this.panHero.Controls.Add(this.labHealth);
            this.panHero.Location = new System.Drawing.Point(30, 50);
            this.panHero.Name = "panHero";
            this.panHero.Size = new System.Drawing.Size(210, 140);
            this.panHero.TabIndex = 1;
            // 
            // labSlash
            // 
            this.labSlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labSlash.Location = new System.Drawing.Point(135, 10);
            this.labSlash.Name = "labSlash";
            this.labSlash.Size = new System.Drawing.Size(15, 20);
            this.labSlash.TabIndex = 33;
            this.labSlash.Text = "/";
            this.labSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHealthValue
            // 
            this.labHealthValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthValue.Location = new System.Drawing.Point(155, 10);
            this.labHealthValue.Name = "labHealthValue";
            this.labHealthValue.Size = new System.Drawing.Size(50, 20);
            this.labHealthValue.TabIndex = 32;
            this.labHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDefValue
            // 
            this.labDefValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefValue.Location = new System.Drawing.Point(80, 60);
            this.labDefValue.Name = "labDefValue";
            this.labDefValue.Size = new System.Drawing.Size(125, 20);
            this.labDefValue.TabIndex = 31;
            this.labDefValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLvlValue
            // 
            this.labLvlValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlValue.Location = new System.Drawing.Point(80, 110);
            this.labLvlValue.Name = "labLvlValue";
            this.labLvlValue.Size = new System.Drawing.Size(125, 20);
            this.labLvlValue.TabIndex = 29;
            this.labLvlValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGoldValue
            // 
            this.labGoldValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldValue.Location = new System.Drawing.Point(80, 85);
            this.labGoldValue.Name = "labGoldValue";
            this.labGoldValue.Size = new System.Drawing.Size(125, 20);
            this.labGoldValue.TabIndex = 27;
            this.labGoldValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLvl
            // 
            this.labLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvl.Location = new System.Drawing.Point(3, 110);
            this.labLvl.Name = "labLvl";
            this.labLvl.Size = new System.Drawing.Size(78, 20);
            this.labLvl.TabIndex = 23;
            this.labLvl.Text = "Level:";
            this.labLvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDmgValue
            // 
            this.labDmgValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgValue.Location = new System.Drawing.Point(80, 35);
            this.labDmgValue.Name = "labDmgValue";
            this.labDmgValue.Size = new System.Drawing.Size(125, 20);
            this.labDmgValue.TabIndex = 30;
            this.labDmgValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labHealthMaxValue
            // 
            this.labHealthMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthMaxValue.Location = new System.Drawing.Point(80, 10);
            this.labHealthMaxValue.Name = "labHealthMaxValue";
            this.labHealthMaxValue.Size = new System.Drawing.Size(50, 20);
            this.labHealthMaxValue.TabIndex = 26;
            this.labHealthMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGold
            // 
            this.labGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGold.Location = new System.Drawing.Point(3, 85);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(78, 20);
            this.labGold.TabIndex = 21;
            this.labGold.Text = "Gold:";
            this.labGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDef
            // 
            this.labDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDef.Location = new System.Drawing.Point(3, 60);
            this.labDef.Name = "labDef";
            this.labDef.Size = new System.Drawing.Size(78, 20);
            this.labDef.TabIndex = 25;
            this.labDef.Text = "Defense:";
            this.labDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDmg
            // 
            this.labDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmg.Location = new System.Drawing.Point(3, 35);
            this.labDmg.Name = "labDmg";
            this.labDmg.Size = new System.Drawing.Size(78, 20);
            this.labDmg.TabIndex = 24;
            this.labDmg.Text = "Damage:";
            this.labDmg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHealth
            // 
            this.labHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealth.Location = new System.Drawing.Point(3, 10);
            this.labHealth.Name = "labHealth";
            this.labHealth.Size = new System.Drawing.Size(78, 20);
            this.labHealth.TabIndex = 20;
            this.labHealth.Text = "Health:";
            this.labHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labLocation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLocation.Location = new System.Drawing.Point(0, 0);
            this.labLocation.MinimumSize = new System.Drawing.Size(1084, 20);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(1084, 20);
            this.labLocation.TabIndex = 2;
            this.labLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(30, 30);
            this.labName.MinimumSize = new System.Drawing.Size(210, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(210, 18);
            this.labName.TabIndex = 3;
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panExit
            // 
            this.panExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panExit.Controls.Add(this.btnSaveExit);
            this.panExit.Controls.Add(this.btnContinue);
            this.panExit.Controls.Add(this.labExitQuestion);
            this.panExit.Location = new System.Drawing.Point(400, 200);
            this.panExit.Name = "panExit";
            this.panExit.Size = new System.Drawing.Size(300, 140);
            this.panExit.TabIndex = 25;
            this.panExit.Visible = false;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnSaveExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveExit.FlatAppearance.BorderSize = 0;
            this.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSaveExit.Location = new System.Drawing.Point(75, 50);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(150, 25);
            this.btnSaveExit.TabIndex = 5;
            this.btnSaveExit.TabStop = false;
            this.btnSaveExit.Text = "Save and Exit";
            this.btnSaveExit.UseVisualStyleBackColor = false;
            this.btnSaveExit.Click += new System.EventHandler(this.BtnSaveExit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnContinue.Location = new System.Drawing.Point(100, 95);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(100, 25);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // labExitQuestion
            // 
            this.labExitQuestion.AutoSize = true;
            this.labExitQuestion.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labExitQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labExitQuestion.Location = new System.Drawing.Point(10, 10);
            this.labExitQuestion.MaximumSize = new System.Drawing.Size(0, 20);
            this.labExitQuestion.MinimumSize = new System.Drawing.Size(280, 20);
            this.labExitQuestion.Name = "labExitQuestion";
            this.labExitQuestion.Size = new System.Drawing.Size(280, 20);
            this.labExitQuestion.TabIndex = 0;
            this.labExitQuestion.Text = "Are you sure you want to quit?";
            this.labExitQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNorth
            // 
            this.btnNorth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnNorth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNorth.Enabled = false;
            this.btnNorth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnNorth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNorth.Location = new System.Drawing.Point(100, 35);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(100, 25);
            this.btnNorth.TabIndex = 5;
            this.btnNorth.TabStop = false;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = false;
            // 
            // btnWest
            // 
            this.btnWest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnWest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWest.Enabled = false;
            this.btnWest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnWest.Location = new System.Drawing.Point(25, 110);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(100, 25);
            this.btnWest.TabIndex = 6;
            this.btnWest.TabStop = false;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = false;
            // 
            // btnEast
            // 
            this.btnEast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnEast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEast.Enabled = false;
            this.btnEast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnEast.Location = new System.Drawing.Point(175, 110);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(100, 25);
            this.btnEast.TabIndex = 7;
            this.btnEast.TabStop = false;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = false;
            // 
            // btnSouth
            // 
            this.btnSouth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnSouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSouth.Enabled = false;
            this.btnSouth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnSouth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSouth.Location = new System.Drawing.Point(100, 185);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(100, 25);
            this.btnSouth.TabIndex = 8;
            this.btnSouth.TabStop = false;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = false;
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panExit);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.panHero);
            this.Controls.Add(this.panBottom);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameMain";
            this.Size = new System.Drawing.Size(1084, 661);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyUp);
            this.panBottom.ResumeLayout(false);
            this.panEventLog.ResumeLayout(false);
            this.panControls.ResumeLayout(false);
            this.panHero.ResumeLayout(false);
            this.panExit.ResumeLayout(false);
            this.panExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panEventLog;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Panel panHero;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.RichTextBox rtbEventLog;
        private System.Windows.Forms.Label labSlash;
        private System.Windows.Forms.Label labHealthValue;
        private System.Windows.Forms.Label labDefValue;
        private System.Windows.Forms.Label labDmgValue;
        private System.Windows.Forms.Label labLvlValue;
        private System.Windows.Forms.Label labGoldValue;
        private System.Windows.Forms.Label labHealthMaxValue;
        private System.Windows.Forms.Label labDef;
        private System.Windows.Forms.Label labDmg;
        private System.Windows.Forms.Label labLvl;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Label labHealth;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Panel panExit;
        private System.Windows.Forms.Label labExitQuestion;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
    }
}
