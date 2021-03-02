
namespace NecromindUI
{
    partial class AdminControls
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
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnHeroes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaps
            // 
            this.btnMaps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaps.FlatAppearance.BorderSize = 0;
            this.btnMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnMaps.Location = new System.Drawing.Point(40, 20);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(100, 25);
            this.btnMaps.TabIndex = 4;
            this.btnMaps.TabStop = false;
            this.btnMaps.Text = "Maps";
            this.btnMaps.UseVisualStyleBackColor = false;
            // 
            // btnLocations
            // 
            this.btnLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLocations.Location = new System.Drawing.Point(40, 70);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(100, 25);
            this.btnLocations.TabIndex = 5;
            this.btnLocations.TabStop = false;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = false;
            // 
            // btnHeroes
            // 
            this.btnHeroes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHeroes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnHeroes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeroes.FlatAppearance.BorderSize = 0;
            this.btnHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeroes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeroes.Location = new System.Drawing.Point(180, 20);
            this.btnHeroes.Name = "btnHeroes";
            this.btnHeroes.Size = new System.Drawing.Size(100, 25);
            this.btnHeroes.TabIndex = 6;
            this.btnHeroes.TabStop = false;
            this.btnHeroes.Text = "Heroes";
            this.btnHeroes.UseVisualStyleBackColor = false;
            // 
            // AdminControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.btnHeroes);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnMaps);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminControls";
            this.Size = new System.Drawing.Size(1084, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnHeroes;
    }
}
