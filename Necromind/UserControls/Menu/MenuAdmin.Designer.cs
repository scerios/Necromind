
namespace NecromindUI.UserControls.Menu
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.btnBack = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.panControls = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panSettings = new System.Windows.Forms.Panel();
            this.panInfoPass = new System.Windows.Forms.Panel();
            this.btnInfoPassClose = new System.Windows.Forms.Button();
            this.labInfoPassMsg = new System.Windows.Forms.Label();
            this.labInfoPassTitle = new System.Windows.Forms.Label();
            this.btnInfo = new NecromindLibrary.Config.RoundButton();
            this.panInfoConv = new System.Windows.Forms.Panel();
            this.btnInfoConvClose = new System.Windows.Forms.Button();
            this.labInfoConvMsg = new System.Windows.Forms.Label();
            this.labInfoConvTitle = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            this.panControls.SuspendLayout();
            this.panSettings.SuspendLayout();
            this.panInfoPass.SuspendLayout();
            this.panInfoConv.SuspendLayout();
            this.SuspendLayout();
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
            // panMain
            // 
            this.panMain.Controls.Add(this.panControls);
            this.panMain.Controls.Add(this.panSettings);
            this.panMain.Location = new System.Drawing.Point(0, 70);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1084, 647);
            this.panMain.TabIndex = 4;
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.tbPassword);
            this.panControls.Controls.Add(this.btnEnter);
            this.panControls.Location = new System.Drawing.Point(0, 0);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(1084, 120);
            this.panControls.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.Location = new System.Drawing.Point(492, 30);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.TabStop = false;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyUp);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnEnter.Location = new System.Drawing.Point(492, 70);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 25);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // panSettings
            // 
            this.panSettings.Controls.Add(this.panInfoConv);
            this.panSettings.Controls.Add(this.panInfoPass);
            this.panSettings.Location = new System.Drawing.Point(0, 120);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(1084, 527);
            this.panSettings.TabIndex = 1;
            // 
            // panInfoPass
            // 
            this.panInfoPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panInfoPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInfoPass.Controls.Add(this.btnInfoPassClose);
            this.panInfoPass.Controls.Add(this.labInfoPassMsg);
            this.panInfoPass.Controls.Add(this.labInfoPassTitle);
            this.panInfoPass.Location = new System.Drawing.Point(267, 50);
            this.panInfoPass.Name = "panInfoPass";
            this.panInfoPass.Size = new System.Drawing.Size(550, 200);
            this.panInfoPass.TabIndex = 25;
            this.panInfoPass.Visible = false;
            // 
            // btnInfoPassClose
            // 
            this.btnInfoPassClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoPassClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInfoPassClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoPassClose.FlatAppearance.BorderSize = 0;
            this.btnInfoPassClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPassClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfoPassClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnInfoPassClose.Location = new System.Drawing.Point(516, 12);
            this.btnInfoPassClose.Name = "btnInfoPassClose";
            this.btnInfoPassClose.Size = new System.Drawing.Size(24, 23);
            this.btnInfoPassClose.TabIndex = 2;
            this.btnInfoPassClose.TabStop = false;
            this.btnInfoPassClose.Text = "X";
            this.btnInfoPassClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoPassClose.UseVisualStyleBackColor = false;
            this.btnInfoPassClose.Click += new System.EventHandler(this.BtnInfoPassClose_Click);
            // 
            // labInfoPassMsg
            // 
            this.labInfoPassMsg.AutoSize = true;
            this.labInfoPassMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labInfoPassMsg.Location = new System.Drawing.Point(10, 50);
            this.labInfoPassMsg.MinimumSize = new System.Drawing.Size(500, 120);
            this.labInfoPassMsg.Name = "labInfoPassMsg";
            this.labInfoPassMsg.Size = new System.Drawing.Size(500, 120);
            this.labInfoPassMsg.TabIndex = 1;
            this.labInfoPassMsg.Text = "Whatever you enter the first time when you are accessing\r\nthe admin layer, it wil" +
    "l be your password from then on.\r\n\r\nThere are no restrictions, it can be either " +
    "a single letter\r\nor nothing at all.";
            this.labInfoPassMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labInfoPassTitle
            // 
            this.labInfoPassTitle.AutoSize = true;
            this.labInfoPassTitle.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labInfoPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labInfoPassTitle.Location = new System.Drawing.Point(10, 15);
            this.labInfoPassTitle.MinimumSize = new System.Drawing.Size(300, 0);
            this.labInfoPassTitle.Name = "labInfoPassTitle";
            this.labInfoPassTitle.Size = new System.Drawing.Size(300, 16);
            this.labInfoPassTitle.TabIndex = 0;
            this.labInfoPassTitle.Text = "Information regarding admin password";
            this.labInfoPassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInfo
            // 
            this.btnInfo.BorderColor = System.Drawing.Color.Transparent;
            this.btnInfo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfo.Location = new System.Drawing.Point(1039, 16);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInfo.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnInfo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "i";
            this.btnInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // panInfoConv
            // 
            this.panInfoConv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panInfoConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInfoConv.Controls.Add(this.btnInfoConvClose);
            this.panInfoConv.Controls.Add(this.labInfoConvMsg);
            this.panInfoConv.Controls.Add(this.labInfoConvTitle);
            this.panInfoConv.Location = new System.Drawing.Point(267, 50);
            this.panInfoConv.Name = "panInfoConv";
            this.panInfoConv.Size = new System.Drawing.Size(550, 200);
            this.panInfoConv.TabIndex = 26;
            this.panInfoConv.Visible = false;
            // 
            // btnInfoConvClose
            // 
            this.btnInfoConvClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoConvClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInfoConvClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoConvClose.FlatAppearance.BorderSize = 0;
            this.btnInfoConvClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoConvClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfoConvClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnInfoConvClose.Location = new System.Drawing.Point(516, 12);
            this.btnInfoConvClose.Name = "btnInfoConvClose";
            this.btnInfoConvClose.Size = new System.Drawing.Size(24, 23);
            this.btnInfoConvClose.TabIndex = 2;
            this.btnInfoConvClose.TabStop = false;
            this.btnInfoConvClose.Text = "X";
            this.btnInfoConvClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoConvClose.UseVisualStyleBackColor = false;
            this.btnInfoConvClose.Click += new System.EventHandler(this.BtnInfoConvClose_Click);
            // 
            // labInfoConvMsg
            // 
            this.labInfoConvMsg.AutoSize = true;
            this.labInfoConvMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labInfoConvMsg.Location = new System.Drawing.Point(10, 50);
            this.labInfoConvMsg.MinimumSize = new System.Drawing.Size(500, 120);
            this.labInfoConvMsg.Name = "labInfoConvMsg";
            this.labInfoConvMsg.Size = new System.Drawing.Size(500, 128);
            this.labInfoConvMsg.TabIndex = 1;
            this.labInfoConvMsg.Text = resources.GetString("labInfoConvMsg.Text");
            this.labInfoConvMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labInfoConvTitle
            // 
            this.labInfoConvTitle.AutoSize = true;
            this.labInfoConvTitle.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labInfoConvTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labInfoConvTitle.Location = new System.Drawing.Point(10, 15);
            this.labInfoConvTitle.MinimumSize = new System.Drawing.Size(300, 0);
            this.labInfoConvTitle.Name = "labInfoConvTitle";
            this.labInfoConvTitle.Size = new System.Drawing.Size(320, 16);
            this.labInfoConvTitle.TabIndex = 0;
            this.labInfoConvTitle.Text = "Information regarding value conventions";
            this.labInfoConvTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuAdmin";
            this.Size = new System.Drawing.Size(1084, 717);
            this.panMain.ResumeLayout(false);
            this.panControls.ResumeLayout(false);
            this.panControls.PerformLayout();
            this.panSettings.ResumeLayout(false);
            this.panInfoPass.ResumeLayout(false);
            this.panInfoPass.PerformLayout();
            this.panInfoConv.ResumeLayout(false);
            this.panInfoConv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Panel panSettings;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.TextBox tbPassword;
        private NecromindLibrary.Config.RoundButton btnInfo;
        private System.Windows.Forms.Panel panInfoPass;
        private System.Windows.Forms.Button btnInfoPassClose;
        private System.Windows.Forms.Label labInfoPassMsg;
        private System.Windows.Forms.Label labInfoPassTitle;
        private System.Windows.Forms.Panel panInfoConv;
        private System.Windows.Forms.Button btnInfoConvClose;
        private System.Windows.Forms.Label labInfoConvMsg;
        private System.Windows.Forms.Label labInfoConvTitle;
    }
}
