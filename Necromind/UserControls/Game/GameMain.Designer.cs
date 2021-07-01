
namespace NecromindUI.UserControls.Game
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
            this.panMovement = new System.Windows.Forms.Panel();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.panHero = new System.Windows.Forms.Panel();
            this.labHeroDmgMax = new System.Windows.Forms.Label();
            this.labHDash = new System.Windows.Forms.Label();
            this.labHSlash = new System.Windows.Forms.Label();
            this.labHeroHealth = new System.Windows.Forms.Label();
            this.labHeroDef = new System.Windows.Forms.Label();
            this.labHeroLvl = new System.Windows.Forms.Label();
            this.labHeroGold = new System.Windows.Forms.Label();
            this.labHLvl = new System.Windows.Forms.Label();
            this.labHeroDmgMin = new System.Windows.Forms.Label();
            this.labHeroHealthMax = new System.Windows.Forms.Label();
            this.labHGold = new System.Windows.Forms.Label();
            this.labHDef = new System.Windows.Forms.Label();
            this.labHDmg = new System.Windows.Forms.Label();
            this.labHHealth = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labHeroName = new System.Windows.Forms.Label();
            this.panExit = new System.Windows.Forms.Panel();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.labExitQuestion = new System.Windows.Forms.Label();
            this.panHostileInteraction = new System.Windows.Forms.Panel();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnRetreat = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnFortify = new System.Windows.Forms.Button();
            this.labTargetName = new System.Windows.Forms.Label();
            this.panTarget = new System.Windows.Forms.Panel();
            this.labTargetDmgMax = new System.Windows.Forms.Label();
            this.labTDash = new System.Windows.Forms.Label();
            this.labTSlash = new System.Windows.Forms.Label();
            this.labTargetHealth = new System.Windows.Forms.Label();
            this.labTargetDef = new System.Windows.Forms.Label();
            this.labTargetLvl = new System.Windows.Forms.Label();
            this.labTargetGold = new System.Windows.Forms.Label();
            this.labTLvl = new System.Windows.Forms.Label();
            this.labTargetDmgMin = new System.Windows.Forms.Label();
            this.labTargetHealthMax = new System.Windows.Forms.Label();
            this.labTGold = new System.Windows.Forms.Label();
            this.labTDef = new System.Windows.Forms.Label();
            this.labTDmg = new System.Windows.Forms.Label();
            this.labTHealth = new System.Windows.Forms.Label();
            this.panFriendlyInteraction = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnQuest = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.panBottom.SuspendLayout();
            this.panEventLog.SuspendLayout();
            this.panMovement.SuspendLayout();
            this.panHero.SuspendLayout();
            this.panExit.SuspendLayout();
            this.panHostileInteraction.SuspendLayout();
            this.panTarget.SuspendLayout();
            this.panFriendlyInteraction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.panEventLog);
            this.panBottom.Controls.Add(this.panMovement);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 467);
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
            this.rtbEventLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.rtbEventLog.Location = new System.Drawing.Point(30, 0);
            this.rtbEventLog.Name = "rtbEventLog";
            this.rtbEventLog.ReadOnly = true;
            this.rtbEventLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEventLog.Size = new System.Drawing.Size(724, 250);
            this.rtbEventLog.TabIndex = 14;
            this.rtbEventLog.TabStop = false;
            this.rtbEventLog.Text = "";
            // 
            // panMovement
            // 
            this.panMovement.Controls.Add(this.btnSouth);
            this.panMovement.Controls.Add(this.btnEast);
            this.panMovement.Controls.Add(this.btnWest);
            this.panMovement.Controls.Add(this.btnNorth);
            this.panMovement.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMovement.Location = new System.Drawing.Point(784, 0);
            this.panMovement.Name = "panMovement";
            this.panMovement.Size = new System.Drawing.Size(300, 250);
            this.panMovement.TabIndex = 0;
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
            this.btnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
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
            this.btnEast.Click += new System.EventHandler(this.BtnEast_Click);
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
            this.btnWest.Click += new System.EventHandler(this.BtnWest_Click);
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
            this.btnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // panHero
            // 
            this.panHero.Controls.Add(this.labHeroDmgMax);
            this.panHero.Controls.Add(this.labHDash);
            this.panHero.Controls.Add(this.labHSlash);
            this.panHero.Controls.Add(this.labHeroHealth);
            this.panHero.Controls.Add(this.labHeroDef);
            this.panHero.Controls.Add(this.labHeroLvl);
            this.panHero.Controls.Add(this.labHeroGold);
            this.panHero.Controls.Add(this.labHLvl);
            this.panHero.Controls.Add(this.labHeroDmgMin);
            this.panHero.Controls.Add(this.labHeroHealthMax);
            this.panHero.Controls.Add(this.labHGold);
            this.panHero.Controls.Add(this.labHDef);
            this.panHero.Controls.Add(this.labHDmg);
            this.panHero.Controls.Add(this.labHHealth);
            this.panHero.Location = new System.Drawing.Point(250, 50);
            this.panHero.Name = "panHero";
            this.panHero.Size = new System.Drawing.Size(210, 140);
            this.panHero.TabIndex = 1;
            // 
            // labHeroDmgMax
            // 
            this.labHeroDmgMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroDmgMax.Location = new System.Drawing.Point(155, 35);
            this.labHeroDmgMax.Name = "labHeroDmgMax";
            this.labHeroDmgMax.Size = new System.Drawing.Size(50, 20);
            this.labHeroDmgMax.TabIndex = 35;
            this.labHeroDmgMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHDash
            // 
            this.labHDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHDash.Location = new System.Drawing.Point(135, 35);
            this.labHDash.Name = "labHDash";
            this.labHDash.Size = new System.Drawing.Size(15, 20);
            this.labHDash.TabIndex = 34;
            this.labHDash.Text = "-";
            this.labHDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHSlash
            // 
            this.labHSlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHSlash.Location = new System.Drawing.Point(135, 10);
            this.labHSlash.Name = "labHSlash";
            this.labHSlash.Size = new System.Drawing.Size(15, 20);
            this.labHSlash.TabIndex = 33;
            this.labHSlash.Text = "/";
            this.labHSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHeroHealth
            // 
            this.labHeroHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroHealth.Location = new System.Drawing.Point(155, 10);
            this.labHeroHealth.Name = "labHeroHealth";
            this.labHeroHealth.Size = new System.Drawing.Size(50, 20);
            this.labHeroHealth.TabIndex = 32;
            this.labHeroHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHeroDef
            // 
            this.labHeroDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroDef.Location = new System.Drawing.Point(80, 60);
            this.labHeroDef.Name = "labHeroDef";
            this.labHeroDef.Size = new System.Drawing.Size(125, 20);
            this.labHeroDef.TabIndex = 31;
            this.labHeroDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labHeroLvl
            // 
            this.labHeroLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroLvl.Location = new System.Drawing.Point(80, 110);
            this.labHeroLvl.Name = "labHeroLvl";
            this.labHeroLvl.Size = new System.Drawing.Size(125, 20);
            this.labHeroLvl.TabIndex = 29;
            this.labHeroLvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labHeroGold
            // 
            this.labHeroGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroGold.Location = new System.Drawing.Point(80, 85);
            this.labHeroGold.Name = "labHeroGold";
            this.labHeroGold.Size = new System.Drawing.Size(125, 20);
            this.labHeroGold.TabIndex = 27;
            this.labHeroGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labHLvl
            // 
            this.labHLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labHLvl.Location = new System.Drawing.Point(3, 110);
            this.labHLvl.Name = "labHLvl";
            this.labHLvl.Size = new System.Drawing.Size(78, 20);
            this.labHLvl.TabIndex = 23;
            this.labHLvl.Text = "Level:";
            this.labHLvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHeroDmgMin
            // 
            this.labHeroDmgMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroDmgMin.Location = new System.Drawing.Point(80, 35);
            this.labHeroDmgMin.Name = "labHeroDmgMin";
            this.labHeroDmgMin.Size = new System.Drawing.Size(50, 20);
            this.labHeroDmgMin.TabIndex = 30;
            this.labHeroDmgMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHeroHealthMax
            // 
            this.labHeroHealthMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroHealthMax.Location = new System.Drawing.Point(80, 10);
            this.labHeroHealthMax.Name = "labHeroHealthMax";
            this.labHeroHealthMax.Size = new System.Drawing.Size(50, 20);
            this.labHeroHealthMax.TabIndex = 26;
            this.labHeroHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHGold
            // 
            this.labHGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labHGold.Location = new System.Drawing.Point(3, 85);
            this.labHGold.Name = "labHGold";
            this.labHGold.Size = new System.Drawing.Size(78, 20);
            this.labHGold.TabIndex = 21;
            this.labHGold.Text = "Gold:";
            this.labHGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHDef
            // 
            this.labHDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labHDef.Location = new System.Drawing.Point(3, 60);
            this.labHDef.Name = "labHDef";
            this.labHDef.Size = new System.Drawing.Size(78, 20);
            this.labHDef.TabIndex = 25;
            this.labHDef.Text = "Defense:";
            this.labHDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHDmg
            // 
            this.labHDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labHDmg.Location = new System.Drawing.Point(3, 35);
            this.labHDmg.Name = "labHDmg";
            this.labHDmg.Size = new System.Drawing.Size(78, 20);
            this.labHDmg.TabIndex = 24;
            this.labHDmg.Text = "Damage:";
            this.labHDmg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHHealth
            // 
            this.labHHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labHHealth.Location = new System.Drawing.Point(3, 10);
            this.labHHealth.Name = "labHHealth";
            this.labHHealth.Size = new System.Drawing.Size(78, 20);
            this.labHHealth.TabIndex = 20;
            this.labHHealth.Text = "Health:";
            this.labHHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // labHeroName
            // 
            this.labHeroName.AutoSize = true;
            this.labHeroName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHeroName.Location = new System.Drawing.Point(250, 30);
            this.labHeroName.MinimumSize = new System.Drawing.Size(210, 0);
            this.labHeroName.Name = "labHeroName";
            this.labHeroName.Size = new System.Drawing.Size(210, 18);
            this.labHeroName.TabIndex = 3;
            this.labHeroName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panHostileInteraction
            // 
            this.panHostileInteraction.Controls.Add(this.btnUse);
            this.panHostileInteraction.Controls.Add(this.btnRetreat);
            this.panHostileInteraction.Controls.Add(this.btnAttack);
            this.panHostileInteraction.Controls.Add(this.btnFortify);
            this.panHostileInteraction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panHostileInteraction.Location = new System.Drawing.Point(0, 402);
            this.panHostileInteraction.Name = "panHostileInteraction";
            this.panHostileInteraction.Size = new System.Drawing.Size(1084, 65);
            this.panHostileInteraction.TabIndex = 26;
            this.panHostileInteraction.Visible = false;
            // 
            // btnUse
            // 
            this.btnUse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUse.Enabled = false;
            this.btnUse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnUse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnUse.Location = new System.Drawing.Point(859, 20);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(100, 25);
            this.btnUse.TabIndex = 17;
            this.btnUse.TabStop = false;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = false;
            // 
            // btnRetreat
            // 
            this.btnRetreat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRetreat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnRetreat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetreat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnRetreat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnRetreat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetreat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnRetreat.Location = new System.Drawing.Point(375, 20);
            this.btnRetreat.Name = "btnRetreat";
            this.btnRetreat.Size = new System.Drawing.Size(100, 25);
            this.btnRetreat.TabIndex = 16;
            this.btnRetreat.TabStop = false;
            this.btnRetreat.Text = "Retreat";
            this.btnRetreat.UseVisualStyleBackColor = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAttack.Location = new System.Drawing.Point(125, 20);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(100, 25);
            this.btnAttack.TabIndex = 15;
            this.btnAttack.TabStop = false;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // btnFortify
            // 
            this.btnFortify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFortify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnFortify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFortify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnFortify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnFortify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnFortify.Location = new System.Drawing.Point(619, 20);
            this.btnFortify.Name = "btnFortify";
            this.btnFortify.Size = new System.Drawing.Size(100, 25);
            this.btnFortify.TabIndex = 14;
            this.btnFortify.TabStop = false;
            this.btnFortify.Text = "Fortify";
            this.btnFortify.UseVisualStyleBackColor = false;
            this.btnFortify.Click += new System.EventHandler(this.BtnFortify_Click);
            // 
            // labTargetName
            // 
            this.labTargetName.AutoSize = true;
            this.labTargetName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTargetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetName.Location = new System.Drawing.Point(850, 30);
            this.labTargetName.MinimumSize = new System.Drawing.Size(210, 0);
            this.labTargetName.Name = "labTargetName";
            this.labTargetName.Size = new System.Drawing.Size(210, 18);
            this.labTargetName.TabIndex = 27;
            this.labTargetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTarget
            // 
            this.panTarget.Controls.Add(this.labTargetDmgMax);
            this.panTarget.Controls.Add(this.labTDash);
            this.panTarget.Controls.Add(this.labTSlash);
            this.panTarget.Controls.Add(this.labTargetHealth);
            this.panTarget.Controls.Add(this.labTargetDef);
            this.panTarget.Controls.Add(this.labTargetLvl);
            this.panTarget.Controls.Add(this.labTargetGold);
            this.panTarget.Controls.Add(this.labTLvl);
            this.panTarget.Controls.Add(this.labTargetDmgMin);
            this.panTarget.Controls.Add(this.labTargetHealthMax);
            this.panTarget.Controls.Add(this.labTGold);
            this.panTarget.Controls.Add(this.labTDef);
            this.panTarget.Controls.Add(this.labTDmg);
            this.panTarget.Controls.Add(this.labTHealth);
            this.panTarget.Location = new System.Drawing.Point(850, 51);
            this.panTarget.Name = "panTarget";
            this.panTarget.Size = new System.Drawing.Size(210, 140);
            this.panTarget.TabIndex = 28;
            this.panTarget.Visible = false;
            // 
            // labTargetDmgMax
            // 
            this.labTargetDmgMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetDmgMax.Location = new System.Drawing.Point(155, 35);
            this.labTargetDmgMax.Name = "labTargetDmgMax";
            this.labTargetDmgMax.Size = new System.Drawing.Size(50, 20);
            this.labTargetDmgMax.TabIndex = 35;
            this.labTargetDmgMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTDash
            // 
            this.labTDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTDash.Location = new System.Drawing.Point(135, 35);
            this.labTDash.Name = "labTDash";
            this.labTDash.Size = new System.Drawing.Size(15, 20);
            this.labTDash.TabIndex = 34;
            this.labTDash.Text = "-";
            this.labTDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTSlash
            // 
            this.labTSlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTSlash.Location = new System.Drawing.Point(135, 10);
            this.labTSlash.Name = "labTSlash";
            this.labTSlash.Size = new System.Drawing.Size(15, 20);
            this.labTSlash.TabIndex = 33;
            this.labTSlash.Text = "/";
            this.labTSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTargetHealth
            // 
            this.labTargetHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetHealth.Location = new System.Drawing.Point(155, 10);
            this.labTargetHealth.Name = "labTargetHealth";
            this.labTargetHealth.Size = new System.Drawing.Size(50, 20);
            this.labTargetHealth.TabIndex = 32;
            this.labTargetHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTargetDef
            // 
            this.labTargetDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetDef.Location = new System.Drawing.Point(80, 60);
            this.labTargetDef.Name = "labTargetDef";
            this.labTargetDef.Size = new System.Drawing.Size(125, 20);
            this.labTargetDef.TabIndex = 31;
            this.labTargetDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTargetLvl
            // 
            this.labTargetLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetLvl.Location = new System.Drawing.Point(80, 110);
            this.labTargetLvl.Name = "labTargetLvl";
            this.labTargetLvl.Size = new System.Drawing.Size(125, 20);
            this.labTargetLvl.TabIndex = 29;
            this.labTargetLvl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTargetGold
            // 
            this.labTargetGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetGold.Location = new System.Drawing.Point(80, 85);
            this.labTargetGold.Name = "labTargetGold";
            this.labTargetGold.Size = new System.Drawing.Size(125, 20);
            this.labTargetGold.TabIndex = 27;
            this.labTargetGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTLvl
            // 
            this.labTLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labTLvl.Location = new System.Drawing.Point(3, 110);
            this.labTLvl.Name = "labTLvl";
            this.labTLvl.Size = new System.Drawing.Size(78, 20);
            this.labTLvl.TabIndex = 23;
            this.labTLvl.Text = "Level:";
            this.labTLvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTargetDmgMin
            // 
            this.labTargetDmgMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetDmgMin.Location = new System.Drawing.Point(80, 35);
            this.labTargetDmgMin.Name = "labTargetDmgMin";
            this.labTargetDmgMin.Size = new System.Drawing.Size(50, 20);
            this.labTargetDmgMin.TabIndex = 30;
            this.labTargetDmgMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTargetHealthMax
            // 
            this.labTargetHealthMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labTargetHealthMax.Location = new System.Drawing.Point(80, 10);
            this.labTargetHealthMax.Name = "labTargetHealthMax";
            this.labTargetHealthMax.Size = new System.Drawing.Size(50, 20);
            this.labTargetHealthMax.TabIndex = 26;
            this.labTargetHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTGold
            // 
            this.labTGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labTGold.Location = new System.Drawing.Point(3, 85);
            this.labTGold.Name = "labTGold";
            this.labTGold.Size = new System.Drawing.Size(78, 20);
            this.labTGold.TabIndex = 21;
            this.labTGold.Text = "Gold:";
            this.labTGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTDef
            // 
            this.labTDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labTDef.Location = new System.Drawing.Point(3, 60);
            this.labTDef.Name = "labTDef";
            this.labTDef.Size = new System.Drawing.Size(78, 20);
            this.labTDef.TabIndex = 25;
            this.labTDef.Text = "Defense:";
            this.labTDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTDmg
            // 
            this.labTDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labTDmg.Location = new System.Drawing.Point(3, 35);
            this.labTDmg.Name = "labTDmg";
            this.labTDmg.Size = new System.Drawing.Size(78, 20);
            this.labTDmg.TabIndex = 24;
            this.labTDmg.Text = "Damage:";
            this.labTDmg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTHealth
            // 
            this.labTHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.labTHealth.Location = new System.Drawing.Point(3, 10);
            this.labTHealth.Name = "labTHealth";
            this.labTHealth.Size = new System.Drawing.Size(78, 20);
            this.labTHealth.TabIndex = 20;
            this.labTHealth.Text = "Health:";
            this.labTHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panFriendlyInteraction
            // 
            this.panFriendlyInteraction.Controls.Add(this.btnAccept);
            this.panFriendlyInteraction.Controls.Add(this.btnSell);
            this.panFriendlyInteraction.Controls.Add(this.btnBuy);
            this.panFriendlyInteraction.Controls.Add(this.btnQuest);
            this.panFriendlyInteraction.Controls.Add(this.btnTrade);
            this.panFriendlyInteraction.Controls.Add(this.btnTalk);
            this.panFriendlyInteraction.Location = new System.Drawing.Point(0, 402);
            this.panFriendlyInteraction.Name = "panFriendlyInteraction";
            this.panFriendlyInteraction.Size = new System.Drawing.Size(1084, 65);
            this.panFriendlyInteraction.TabIndex = 29;
            this.panFriendlyInteraction.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAccept.Location = new System.Drawing.Point(944, 20);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 25);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSell.Location = new System.Drawing.Point(764, 20);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(100, 25);
            this.btnSell.TabIndex = 16;
            this.btnSell.TabStop = false;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBuy.Location = new System.Drawing.Point(584, 20);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 25);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.TabStop = false;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnQuest
            // 
            this.btnQuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnQuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.btnQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnQuest.Location = new System.Drawing.Point(400, 20);
            this.btnQuest.Name = "btnQuest";
            this.btnQuest.Size = new System.Drawing.Size(100, 25);
            this.btnQuest.TabIndex = 14;
            this.btnQuest.TabStop = false;
            this.btnQuest.Text = "Quest";
            this.btnQuest.UseVisualStyleBackColor = false;
            // 
            // btnTrade
            // 
            this.btnTrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnTrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnTrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.btnTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnTrade.Location = new System.Drawing.Point(220, 20);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(100, 25);
            this.btnTrade.TabIndex = 13;
            this.btnTrade.TabStop = false;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = false;
            // 
            // btnTalk
            // 
            this.btnTalk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnTalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTalk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnTalk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnTalk.Location = new System.Drawing.Point(40, 20);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(100, 25);
            this.btnTalk.TabIndex = 12;
            this.btnTalk.TabStop = false;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panTarget);
            this.Controls.Add(this.labTargetName);
            this.Controls.Add(this.panExit);
            this.Controls.Add(this.panHostileInteraction);
            this.Controls.Add(this.labHeroName);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.panHero);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panFriendlyInteraction);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameMain";
            this.Size = new System.Drawing.Size(1084, 717);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyDown);
            this.panBottom.ResumeLayout(false);
            this.panEventLog.ResumeLayout(false);
            this.panMovement.ResumeLayout(false);
            this.panHero.ResumeLayout(false);
            this.panExit.ResumeLayout(false);
            this.panExit.PerformLayout();
            this.panHostileInteraction.ResumeLayout(false);
            this.panTarget.ResumeLayout(false);
            this.panFriendlyInteraction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panEventLog;
        private System.Windows.Forms.Panel panMovement;
        private System.Windows.Forms.Panel panHero;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.RichTextBox rtbEventLog;
        private System.Windows.Forms.Label labHSlash;
        private System.Windows.Forms.Label labHeroHealth;
        private System.Windows.Forms.Label labHeroDef;
        private System.Windows.Forms.Label labHeroDmgMin;
        private System.Windows.Forms.Label labHeroLvl;
        private System.Windows.Forms.Label labHeroGold;
        private System.Windows.Forms.Label labHeroHealthMax;
        private System.Windows.Forms.Label labHDef;
        private System.Windows.Forms.Label labHDmg;
        private System.Windows.Forms.Label labHLvl;
        private System.Windows.Forms.Label labHGold;
        private System.Windows.Forms.Label labHHealth;
        private System.Windows.Forms.Label labHeroName;
        private System.Windows.Forms.Panel panExit;
        private System.Windows.Forms.Label labExitQuestion;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Panel panHostileInteraction;
        private System.Windows.Forms.Label labHeroDmgMax;
        private System.Windows.Forms.Label labHDash;
        private System.Windows.Forms.Label labTargetName;
        private System.Windows.Forms.Panel panTarget;
        private System.Windows.Forms.Label labTargetDmgMax;
        private System.Windows.Forms.Label labTDash;
        private System.Windows.Forms.Label labTSlash;
        private System.Windows.Forms.Label labTargetHealth;
        private System.Windows.Forms.Label labTargetDef;
        private System.Windows.Forms.Label labTargetLvl;
        private System.Windows.Forms.Label labTargetGold;
        private System.Windows.Forms.Label labTLvl;
        private System.Windows.Forms.Label labTargetDmgMin;
        private System.Windows.Forms.Label labTargetHealthMax;
        private System.Windows.Forms.Label labTGold;
        private System.Windows.Forms.Label labTDef;
        private System.Windows.Forms.Label labTDmg;
        private System.Windows.Forms.Label labTHealth;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnRetreat;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnFortify;
        private System.Windows.Forms.Panel panFriendlyInteraction;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnQuest;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnTalk;
    }
}
