﻿using System.Drawing;
using System.Windows.Forms;

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
            this.panelConfirmDelete = new System.Windows.Forms.Panel();
            this.btnDeleteHero = new System.Windows.Forms.Button();
            this.richTextBoxConfirmDelete = new System.Windows.Forms.RichTextBox();
            this.textBoxDeleteHeroName = new System.Windows.Forms.TextBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.groupBoxTargetDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxTargetInventory = new System.Windows.Forms.GroupBox();
            this.listBoxCharacterItems = new System.Windows.Forms.ListBox();
            this.groupBoxHeroItems = new System.Windows.Forms.GroupBox();
            this.listBoxHeroItems = new System.Windows.Forms.ListBox();
            this.panelGameMenu = new System.Windows.Forms.Panel();
            this.panelVendor = new System.Windows.Forms.Panel();
            this.btnBackFromGame = new System.Windows.Forms.Button();
            this.panelLocation = new System.Windows.Forms.Panel();
            this.btnOutskirts = new System.Windows.Forms.Button();
            this.btnTown = new System.Windows.Forms.Button();
            this.btnMonastery = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnBrangor = new System.Windows.Forms.Button();
            this.btnViascen = new System.Windows.Forms.Button();
            this.btnShoj = new System.Windows.Forms.Button();
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
            this.panelError = new System.Windows.Forms.Panel();
            this.labelErrorMsg = new System.Windows.Forms.Label();
            this.labelErrorTitle = new System.Windows.Forms.Label();
            this.richTextBoxEventLog = new System.Windows.Forms.RichTextBox();
            this.panelAction = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.panelLoadGame.SuspendLayout();
            this.panelConfirmDelete.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.groupBoxTargetInventory.SuspendLayout();
            this.groupBoxHeroItems.SuspendLayout();
            this.panelGameMenu.SuspendLayout();
            this.panelVendor.SuspendLayout();
            this.panelLocation.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.groupBoxHeroDetails.SuspendLayout();
            this.panelError.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnLoadGame);
            this.panelMenu.Controls.Add(this.btnNewGame);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1084, 661);
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
            this.btnLoadGame.Location = new System.Drawing.Point(480, 140);
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
            this.btnNewGame.Location = new System.Drawing.Point(480, 100);
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
            this.panelNewGame.Size = new System.Drawing.Size(1084, 661);
            this.panelNewGame.TabIndex = 14;
            // 
            // textBoxNewHeroName
            // 
            this.textBoxNewHeroName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewHeroName.Location = new System.Drawing.Point(480, 100);
            this.textBoxNewHeroName.Name = "textBoxNewHeroName";
            this.textBoxNewHeroName.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewHeroName.TabIndex = 2;
            this.textBoxNewHeroName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewHeroName_KeyPress);
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
            this.panelLoadGame.Size = new System.Drawing.Size(1084, 661);
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
            // panelConfirmDelete
            // 
            this.panelConfirmDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfirmDelete.Controls.Add(this.btnDeleteHero);
            this.panelConfirmDelete.Controls.Add(this.richTextBoxConfirmDelete);
            this.panelConfirmDelete.Controls.Add(this.textBoxDeleteHeroName);
            this.panelConfirmDelete.Location = new System.Drawing.Point(380, 180);
            this.panelConfirmDelete.Name = "panelConfirmDelete";
            this.panelConfirmDelete.Size = new System.Drawing.Size(300, 222);
            this.panelConfirmDelete.TabIndex = 2;
            // 
            // btnDeleteHero
            // 
            this.btnDeleteHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDeleteHero.CausesValidation = false;
            this.btnDeleteHero.Enabled = false;
            this.btnDeleteHero.FlatAppearance.BorderSize = 0;
            this.btnDeleteHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHero.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnDeleteHero.Location = new System.Drawing.Point(100, 180);
            this.btnDeleteHero.Name = "btnDeleteHero";
            this.btnDeleteHero.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteHero.TabIndex = 4;
            this.btnDeleteHero.Text = "DELETE";
            this.btnDeleteHero.UseVisualStyleBackColor = false;
            this.btnDeleteHero.Click += new System.EventHandler(this.buttonDeleteHero_Click);
            // 
            // richTextBoxConfirmDelete
            // 
            this.richTextBoxConfirmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.richTextBoxConfirmDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConfirmDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxConfirmDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.richTextBoxConfirmDelete.Location = new System.Drawing.Point(21, 22);
            this.richTextBoxConfirmDelete.Name = "richTextBoxConfirmDelete";
            this.richTextBoxConfirmDelete.ReadOnly = true;
            this.richTextBoxConfirmDelete.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxConfirmDelete.Size = new System.Drawing.Size(264, 109);
            this.richTextBoxConfirmDelete.TabIndex = 3;
            this.richTextBoxConfirmDelete.Text = "Are you sure your want to DELETE\n{HERO}?\nTo confirm you must enter\nthe hero\'s nam" +
    "e, then press\nENTER.\nTo cancel: press ESC.";
            // 
            // textBoxDeleteHeroName
            // 
            this.textBoxDeleteHeroName.Location = new System.Drawing.Point(87, 137);
            this.textBoxDeleteHeroName.Multiline = true;
            this.textBoxDeleteHeroName.Name = "textBoxDeleteHeroName";
            this.textBoxDeleteHeroName.Size = new System.Drawing.Size(125, 25);
            this.textBoxDeleteHeroName.TabIndex = 1;
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.panelAction);
            this.panelGame.Controls.Add(this.richTextBoxEventLog);
            this.panelGame.Controls.Add(this.groupBoxTargetDetails);
            this.panelGame.Controls.Add(this.groupBoxTargetInventory);
            this.panelGame.Controls.Add(this.groupBoxHeroItems);
            this.panelGame.Controls.Add(this.panelGameMenu);
            this.panelGame.Controls.Add(this.groupBoxHeroDetails);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1084, 661);
            this.panelGame.TabIndex = 16;
            // 
            // groupBoxTargetDetails
            // 
            this.groupBoxTargetDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTargetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTargetDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.groupBoxTargetDetails.Location = new System.Drawing.Point(695, 20);
            this.groupBoxTargetDetails.Name = "groupBoxTargetDetails";
            this.groupBoxTargetDetails.Size = new System.Drawing.Size(230, 180);
            this.groupBoxTargetDetails.TabIndex = 12;
            this.groupBoxTargetDetails.TabStop = false;
            this.groupBoxTargetDetails.Text = "{TARGET}\'s Details";
            // 
            // groupBoxTargetInventory
            // 
            this.groupBoxTargetInventory.Controls.Add(this.listBoxCharacterItems);
            this.groupBoxTargetInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.groupBoxTargetInventory.Location = new System.Drawing.Point(475, 20);
            this.groupBoxTargetInventory.Name = "groupBoxTargetInventory";
            this.groupBoxTargetInventory.Size = new System.Drawing.Size(215, 180);
            this.groupBoxTargetInventory.TabIndex = 5;
            this.groupBoxTargetInventory.TabStop = false;
            this.groupBoxTargetInventory.Text = "{TARGET}\'s Items";
            // 
            // listBoxCharacterItems
            // 
            this.listBoxCharacterItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.listBoxCharacterItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCharacterItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.listBoxCharacterItems.FormattingEnabled = true;
            this.listBoxCharacterItems.ItemHeight = 16;
            this.listBoxCharacterItems.Location = new System.Drawing.Point(6, 26);
            this.listBoxCharacterItems.Name = "listBoxCharacterItems";
            this.listBoxCharacterItems.Size = new System.Drawing.Size(200, 144);
            this.listBoxCharacterItems.TabIndex = 0;
            // 
            // groupBoxHeroItems
            // 
            this.groupBoxHeroItems.Controls.Add(this.listBoxHeroItems);
            this.groupBoxHeroItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.groupBoxHeroItems.Location = new System.Drawing.Point(255, 20);
            this.groupBoxHeroItems.Name = "groupBoxHeroItems";
            this.groupBoxHeroItems.Size = new System.Drawing.Size(215, 180);
            this.groupBoxHeroItems.TabIndex = 4;
            this.groupBoxHeroItems.TabStop = false;
            this.groupBoxHeroItems.Text = "{HERO}\'s Items";
            // 
            // listBoxHeroItems
            // 
            this.listBoxHeroItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.listBoxHeroItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHeroItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.listBoxHeroItems.FormattingEnabled = true;
            this.listBoxHeroItems.ItemHeight = 16;
            this.listBoxHeroItems.Location = new System.Drawing.Point(6, 26);
            this.listBoxHeroItems.Name = "listBoxHeroItems";
            this.listBoxHeroItems.Size = new System.Drawing.Size(200, 144);
            this.listBoxHeroItems.TabIndex = 0;
            // 
            // panelGameMenu
            // 
            this.panelGameMenu.Controls.Add(this.panelVendor);
            this.panelGameMenu.Controls.Add(this.panelLocation);
            this.panelGameMenu.Controls.Add(this.panelBack);
            this.panelGameMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGameMenu.Location = new System.Drawing.Point(944, 0);
            this.panelGameMenu.Name = "panelGameMenu";
            this.panelGameMenu.Size = new System.Drawing.Size(140, 661);
            this.panelGameMenu.TabIndex = 3;
            // 
            // panelVendor
            // 
            this.panelVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVendor.Controls.Add(this.btnBrangor);
            this.panelVendor.Controls.Add(this.btnViascen);
            this.panelVendor.Controls.Add(this.btnShoj);
            this.panelVendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVendor.Location = new System.Drawing.Point(0, 220);
            this.panelVendor.Name = "panelVendor";
            this.panelVendor.Size = new System.Drawing.Size(140, 155);
            this.panelVendor.TabIndex = 0;
            // 
            // btnBackFromGame
            // 
            this.btnBackFromGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // panelLocation
            // 
            this.panelLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLocation.Controls.Add(this.btnOutskirts);
            this.panelLocation.Controls.Add(this.btnMonastery);
            this.panelLocation.Controls.Add(this.btnTown);
            this.panelLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocation.Location = new System.Drawing.Point(0, 65);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(140, 155);
            this.panelLocation.TabIndex = 1;
            // 
            // btnOutskirts
            // 
            this.btnOutskirts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOutskirts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnOutskirts.FlatAppearance.BorderSize = 0;
            this.btnOutskirts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutskirts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnOutskirts.Location = new System.Drawing.Point(20, 65);
            this.btnOutskirts.Name = "btnOutskirts";
            this.btnOutskirts.Size = new System.Drawing.Size(100, 25);
            this.btnOutskirts.TabIndex = 14;
            this.btnOutskirts.Text = "Outskirts";
            this.btnOutskirts.UseVisualStyleBackColor = false;
            // 
            // btnTown
            // 
            this.btnTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnTown.FlatAppearance.BorderSize = 0;
            this.btnTown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnTown.Location = new System.Drawing.Point(20, 20);
            this.btnTown.Name = "btnTown";
            this.btnTown.Size = new System.Drawing.Size(100, 25);
            this.btnTown.TabIndex = 13;
            this.btnTown.Text = "Town";
            this.btnTown.UseVisualStyleBackColor = false;
            // 
            // btnMonastery
            // 
            this.btnMonastery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMonastery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMonastery.FlatAppearance.BorderSize = 0;
            this.btnMonastery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonastery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnMonastery.Location = new System.Drawing.Point(20, 110);
            this.btnMonastery.Name = "btnMonastery";
            this.btnMonastery.Size = new System.Drawing.Size(100, 25);
            this.btnMonastery.TabIndex = 15;
            this.btnMonastery.Text = "Monastery";
            this.btnMonastery.UseVisualStyleBackColor = false;
            // 
            // panelBack
            // 
            this.panelBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBack.Controls.Add(this.btnBackFromGame);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(140, 65);
            this.panelBack.TabIndex = 2;
            // 
            // btnBrangor
            // 
            this.btnBrangor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrangor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrangor.FlatAppearance.BorderSize = 0;
            this.btnBrangor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrangor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnBrangor.Location = new System.Drawing.Point(20, 110);
            this.btnBrangor.Name = "btnBrangor";
            this.btnBrangor.Size = new System.Drawing.Size(100, 25);
            this.btnBrangor.TabIndex = 18;
            this.btnBrangor.Text = "Brangor";
            this.btnBrangor.UseVisualStyleBackColor = false;
            // 
            // btnViascen
            // 
            this.btnViascen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViascen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnViascen.FlatAppearance.BorderSize = 0;
            this.btnViascen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViascen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnViascen.Location = new System.Drawing.Point(20, 65);
            this.btnViascen.Name = "btnViascen";
            this.btnViascen.Size = new System.Drawing.Size(100, 25);
            this.btnViascen.TabIndex = 17;
            this.btnViascen.Text = "Viascen";
            this.btnViascen.UseVisualStyleBackColor = false;
            // 
            // btnShoj
            // 
            this.btnShoj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShoj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnShoj.FlatAppearance.BorderSize = 0;
            this.btnShoj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnShoj.Location = new System.Drawing.Point(20, 20);
            this.btnShoj.Name = "btnShoj";
            this.btnShoj.Size = new System.Drawing.Size(100, 25);
            this.btnShoj.TabIndex = 16;
            this.btnShoj.Text = "Shoj";
            this.btnShoj.UseVisualStyleBackColor = false;
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
            this.groupBoxHeroDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.groupBoxHeroDetails.Location = new System.Drawing.Point(20, 20);
            this.groupBoxHeroDetails.Name = "groupBoxHeroDetails";
            this.groupBoxHeroDetails.Size = new System.Drawing.Size(230, 180);
            this.groupBoxHeroDetails.TabIndex = 0;
            this.groupBoxHeroDetails.TabStop = false;
            this.groupBoxHeroDetails.Text = "{HERO}\'s Details";
            // 
            // labelHeroDefenseValue
            // 
            this.labelHeroDefenseValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroDefenseValue.Location = new System.Drawing.Point(116, 150);
            this.labelHeroDefenseValue.Name = "labelHeroDefenseValue";
            this.labelHeroDefenseValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroDefenseValue.TabIndex = 11;
            this.labelHeroDefenseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroDamageValue
            // 
            this.labelHeroDamageValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroDamageValue.Location = new System.Drawing.Point(116, 125);
            this.labelHeroDamageValue.Name = "labelHeroDamageValue";
            this.labelHeroDamageValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroDamageValue.TabIndex = 10;
            this.labelHeroDamageValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroLevelValue
            // 
            this.labelHeroLevelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroLevelValue.Location = new System.Drawing.Point(116, 100);
            this.labelHeroLevelValue.Name = "labelHeroLevelValue";
            this.labelHeroLevelValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroLevelValue.TabIndex = 9;
            this.labelHeroLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroXPValue
            // 
            this.labelHeroXPValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroXPValue.Location = new System.Drawing.Point(116, 75);
            this.labelHeroXPValue.Name = "labelHeroXPValue";
            this.labelHeroXPValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroXPValue.TabIndex = 8;
            this.labelHeroXPValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroGoldValue
            // 
            this.labelHeroGoldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroGoldValue.Location = new System.Drawing.Point(116, 50);
            this.labelHeroGoldValue.Name = "labelHeroGoldValue";
            this.labelHeroGoldValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroGoldValue.TabIndex = 7;
            this.labelHeroGoldValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroHealthValue
            // 
            this.labelHeroHealthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeroHealthValue.Location = new System.Drawing.Point(116, 25);
            this.labelHeroHealthValue.Name = "labelHeroHealthValue";
            this.labelHeroHealthValue.Size = new System.Drawing.Size(108, 20);
            this.labelHeroHealthValue.TabIndex = 6;
            this.labelHeroHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeroDefense
            // 
            this.labelHeroDefense.Location = new System.Drawing.Point(10, 150);
            this.labelHeroDefense.Name = "labelHeroDefense";
            this.labelHeroDefense.Size = new System.Drawing.Size(90, 20);
            this.labelHeroDefense.TabIndex = 5;
            this.labelHeroDefense.Text = "Defense:";
            // 
            // labelHeroDamage
            // 
            this.labelHeroDamage.Location = new System.Drawing.Point(10, 125);
            this.labelHeroDamage.Name = "labelHeroDamage";
            this.labelHeroDamage.Size = new System.Drawing.Size(90, 20);
            this.labelHeroDamage.TabIndex = 4;
            this.labelHeroDamage.Text = "Damage:";
            // 
            // labelHeroLevel
            // 
            this.labelHeroLevel.Location = new System.Drawing.Point(10, 100);
            this.labelHeroLevel.Name = "labelHeroLevel";
            this.labelHeroLevel.Size = new System.Drawing.Size(90, 20);
            this.labelHeroLevel.TabIndex = 3;
            this.labelHeroLevel.Text = "Level:";
            // 
            // labelHeroXP
            // 
            this.labelHeroXP.Location = new System.Drawing.Point(10, 75);
            this.labelHeroXP.Name = "labelHeroXP";
            this.labelHeroXP.Size = new System.Drawing.Size(90, 20);
            this.labelHeroXP.TabIndex = 2;
            this.labelHeroXP.Text = "XP:";
            // 
            // labelHeroGold
            // 
            this.labelHeroGold.Location = new System.Drawing.Point(10, 50);
            this.labelHeroGold.Name = "labelHeroGold";
            this.labelHeroGold.Size = new System.Drawing.Size(90, 20);
            this.labelHeroGold.TabIndex = 1;
            this.labelHeroGold.Text = "Gold:";
            // 
            // labelHeroHealth
            // 
            this.labelHeroHealth.Location = new System.Drawing.Point(10, 25);
            this.labelHeroHealth.Name = "labelHeroHealth";
            this.labelHeroHealth.Size = new System.Drawing.Size(90, 20);
            this.labelHeroHealth.TabIndex = 0;
            this.labelHeroHealth.Text = "Health:";
            // 
            // panelError
            // 
            this.panelError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelError.Controls.Add(this.labelErrorMsg);
            this.panelError.Controls.Add(this.labelErrorTitle);
            this.panelError.Location = new System.Drawing.Point(380, 180);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(300, 178);
            this.panelError.TabIndex = 13;
            // 
            // labelErrorMsg
            // 
            this.labelErrorMsg.AutoSize = true;
            this.labelErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labelErrorMsg.Location = new System.Drawing.Point(10, 50);
            this.labelErrorMsg.MinimumSize = new System.Drawing.Size(280, 110);
            this.labelErrorMsg.Name = "labelErrorMsg";
            this.labelErrorMsg.Size = new System.Drawing.Size(280, 110);
            this.labelErrorMsg.TabIndex = 1;
            this.labelErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelErrorTitle
            // 
            this.labelErrorTitle.AutoSize = true;
            this.labelErrorTitle.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labelErrorTitle.Location = new System.Drawing.Point(10, 15);
            this.labelErrorTitle.MinimumSize = new System.Drawing.Size(280, 0);
            this.labelErrorTitle.Name = "labelErrorTitle";
            this.labelErrorTitle.Size = new System.Drawing.Size(280, 16);
            this.labelErrorTitle.TabIndex = 0;
            this.labelErrorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxEventLog
            // 
            this.richTextBoxEventLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.richTextBoxEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxEventLog.Location = new System.Drawing.Point(20, 340);
            this.richTextBoxEventLog.Name = "richTextBoxEventLog";
            this.richTextBoxEventLog.Size = new System.Drawing.Size(905, 300);
            this.richTextBoxEventLog.TabIndex = 13;
            this.richTextBoxEventLog.Text = "";
            // 
            // panelAction
            // 
            this.panelAction.Location = new System.Drawing.Point(20, 220);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(905, 100);
            this.panelAction.TabIndex = 14;
            // 
            // Necromind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelConfirmDelete);
            this.Controls.Add(this.panelLoadGame);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.panelError);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Necromind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Necromind";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Necromind_KeyPress);
            this.panelMenu.ResumeLayout(false);
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.panelLoadGame.ResumeLayout(false);
            this.panelConfirmDelete.ResumeLayout(false);
            this.panelConfirmDelete.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.groupBoxTargetInventory.ResumeLayout(false);
            this.groupBoxHeroItems.ResumeLayout(false);
            this.panelGameMenu.ResumeLayout(false);
            this.panelVendor.ResumeLayout(false);
            this.panelLocation.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.groupBoxHeroDetails.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
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
        private System.Windows.Forms.Panel panelConfirmDelete;
        private System.Windows.Forms.RichTextBox richTextBoxConfirmDelete;
        private System.Windows.Forms.TextBox textBoxDeleteHeroName;
        private Panel panelGameMenu;
        private GroupBox groupBoxTargetDetails;
        private GroupBox groupBoxTargetInventory;
        private ListBox listBoxCharacterItems;
        private GroupBox groupBoxHeroItems;
        private ListBox listBoxHeroItems;
        private Panel panelError;
        private Label labelErrorMsg;
        private Label labelErrorTitle;
        private Button btnDeleteHero;
        private Button btnBrangor;
        private Button btnViascen;
        private Button btnShoj;
        private Button btnMonastery;
        private Button btnOutskirts;
        private Button btnTown;
        private Panel panelVendor;
        private Panel panelLocation;
        private Panel panelBack;
        private Panel panelAction;
        private RichTextBox richTextBoxEventLog;
    }
}

