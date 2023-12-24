
namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_PKR = new System.Windows.Forms.PictureBox();
            this.labelInfo_PKR = new System.Windows.Forms.Label();
            this.buttonOkFormAbout_PKR = new System.Windows.Forms.Button();
            this.linkLabelTelega_PKR = new System.Windows.Forms.LinkLabel();
            this.linkLabelVK_PKR = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PKR
            // 
            this.pictureBoxAvatar_PKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAvatar_PKR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PKR.Image")));
            this.pictureBoxAvatar_PKR.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar_PKR.Name = "pictureBoxAvatar_PKR";
            this.pictureBoxAvatar_PKR.Size = new System.Drawing.Size(201, 221);
            this.pictureBoxAvatar_PKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PKR.TabIndex = 0;
            this.pictureBoxAvatar_PKR.TabStop = false;
            // 
            // labelInfo_PKR
            // 
            this.labelInfo_PKR.AutoSize = true;
            this.labelInfo_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo_PKR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_PKR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo_PKR.Location = new System.Drawing.Point(201, 0);
            this.labelInfo_PKR.Name = "labelInfo_PKR";
            this.labelInfo_PKR.Size = new System.Drawing.Size(458, 180);
            this.labelInfo_PKR.TabIndex = 1;
            this.labelInfo_PKR.Text = resources.GetString("labelInfo_PKR.Text");
            // 
            // buttonOkFormAbout_PKR
            // 
            this.buttonOkFormAbout_PKR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.buttonOkFormAbout_PKR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOkFormAbout_PKR.Location = new System.Drawing.Point(588, 183);
            this.buttonOkFormAbout_PKR.Name = "buttonOkFormAbout_PKR";
            this.buttonOkFormAbout_PKR.Size = new System.Drawing.Size(82, 35);
            this.buttonOkFormAbout_PKR.TabIndex = 2;
            this.buttonOkFormAbout_PKR.Text = "OK";
            this.buttonOkFormAbout_PKR.UseVisualStyleBackColor = false;
            this.buttonOkFormAbout_PKR.Click += new System.EventHandler(this.ButtonOkFormAbout_PKR_Click);
            // 
            // linkLabelTelega_PKR
            // 
            this.linkLabelTelega_PKR.AutoSize = true;
            this.linkLabelTelega_PKR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelTelega_PKR.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.linkLabelTelega_PKR.Location = new System.Drawing.Point(207, 189);
            this.linkLabelTelega_PKR.Name = "linkLabelTelega_PKR";
            this.linkLabelTelega_PKR.Size = new System.Drawing.Size(96, 23);
            this.linkLabelTelega_PKR.TabIndex = 3;
            this.linkLabelTelega_PKR.TabStop = true;
            this.linkLabelTelega_PKR.Text = "Телеграмм";
            this.linkLabelTelega_PKR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelTelega_PKR_LinkClicked);
            // 
            // linkLabelVK_PKR
            // 
            this.linkLabelVK_PKR.AutoSize = true;
            this.linkLabelVK_PKR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelVK_PKR.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.linkLabelVK_PKR.Location = new System.Drawing.Point(326, 189);
            this.linkLabelVK_PKR.Name = "linkLabelVK_PKR";
            this.linkLabelVK_PKR.Size = new System.Drawing.Size(31, 23);
            this.linkLabelVK_PKR.TabIndex = 4;
            this.linkLabelVK_PKR.TabStop = true;
            this.linkLabelVK_PKR.Text = "VK";
            this.linkLabelVK_PKR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelVK_PKR_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(682, 221);
            this.Controls.Add(this.linkLabelVK_PKR);
            this.Controls.Add(this.linkLabelTelega_PKR);
            this.Controls.Add(this.buttonOkFormAbout_PKR);
            this.Controls.Add(this.labelInfo_PKR);
            this.Controls.Add(this.pictureBoxAvatar_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PKR;
        private System.Windows.Forms.Label labelInfo_PKR;
        private System.Windows.Forms.Button buttonOkFormAbout_PKR;
        private System.Windows.Forms.LinkLabel linkLabelTelega_PKR;
        private System.Windows.Forms.LinkLabel linkLabelVK_PKR;
    }
}