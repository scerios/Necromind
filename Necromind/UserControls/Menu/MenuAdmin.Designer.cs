
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.panControls = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panSettings = new System.Windows.Forms.Panel();
            this.btnInfo = new NecromindLibrary.Config.Button_WOC();
            this.panMain.SuspendLayout();
            this.panControls.SuspendLayout();
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
            this.tbPassword.Location = new System.Drawing.Point(500, 30);
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
            this.btnEnter.Location = new System.Drawing.Point(500, 70);
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
            this.panSettings.Location = new System.Drawing.Point(0, 120);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(1084, 527);
            this.panSettings.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Panel panSettings;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.TextBox tbPassword;
        private NecromindLibrary.Config.Button_WOC btnInfo;
    }
}
