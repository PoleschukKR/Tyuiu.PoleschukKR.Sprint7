
namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    partial class FormGuidForUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuidForUser));
            this.textBoxGuidForUser_PKR = new System.Windows.Forms.TextBox();
            this.labelGuidForUser_PKR = new System.Windows.Forms.Label();
            this.pictureBoxGuidForUser_PKR = new System.Windows.Forms.PictureBox();
            this.buttonExitFromGuidForUser_PKR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuidForUser_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGuidForUser_PKR
            // 
            this.textBoxGuidForUser_PKR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGuidForUser_PKR.Location = new System.Drawing.Point(91, 104);
            this.textBoxGuidForUser_PKR.Multiline = true;
            this.textBoxGuidForUser_PKR.Name = "textBoxGuidForUser_PKR";
            this.textBoxGuidForUser_PKR.ReadOnly = true;
            this.textBoxGuidForUser_PKR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGuidForUser_PKR.Size = new System.Drawing.Size(745, 366);
            this.textBoxGuidForUser_PKR.TabIndex = 0;
            this.textBoxGuidForUser_PKR.Text = resources.GetString("textBoxGuidForUser_PKR.Text");
            this.textBoxGuidForUser_PKR.Enter += new System.EventHandler(this.textBoxGuidForUser_PKR_Enter);
            // 
            // labelGuidForUser_PKR
            // 
            this.labelGuidForUser_PKR.AutoSize = true;
            this.labelGuidForUser_PKR.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidForUser_PKR.Location = new System.Drawing.Point(332, 76);
            this.labelGuidForUser_PKR.Name = "labelGuidForUser_PKR";
            this.labelGuidForUser_PKR.Size = new System.Drawing.Size(245, 25);
            this.labelGuidForUser_PKR.TabIndex = 1;
            this.labelGuidForUser_PKR.Text = "Руководство пользователя";
            // 
            // pictureBoxGuidForUser_PKR
            // 
            this.pictureBoxGuidForUser_PKR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuidForUser_PKR.Image")));
            this.pictureBoxGuidForUser_PKR.Location = new System.Drawing.Point(404, 12);
            this.pictureBoxGuidForUser_PKR.Name = "pictureBoxGuidForUser_PKR";
            this.pictureBoxGuidForUser_PKR.Size = new System.Drawing.Size(87, 50);
            this.pictureBoxGuidForUser_PKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuidForUser_PKR.TabIndex = 2;
            this.pictureBoxGuidForUser_PKR.TabStop = false;
            // 
            // buttonExitFromGuidForUser_PKR
            // 
            this.buttonExitFromGuidForUser_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitFromGuidForUser_PKR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitFromGuidForUser_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitFromGuidForUser_PKR.Image")));
            this.buttonExitFromGuidForUser_PKR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExitFromGuidForUser_PKR.Location = new System.Drawing.Point(780, 485);
            this.buttonExitFromGuidForUser_PKR.Name = "buttonExitFromGuidForUser_PKR";
            this.buttonExitFromGuidForUser_PKR.Size = new System.Drawing.Size(124, 47);
            this.buttonExitFromGuidForUser_PKR.TabIndex = 3;
            this.buttonExitFromGuidForUser_PKR.Text = "Выход";
            this.buttonExitFromGuidForUser_PKR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExitFromGuidForUser_PKR.UseVisualStyleBackColor = true;
            this.buttonExitFromGuidForUser_PKR.Click += new System.EventHandler(this.buttonExitFromGuidForUser_PKR_Click);
            this.buttonExitFromGuidForUser_PKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExitFromGuidForUser_PKR_MouseDown);
            this.buttonExitFromGuidForUser_PKR.MouseEnter += new System.EventHandler(this.buttonExitFromGuidForUser_PKR_MouseEnter);
            this.buttonExitFromGuidForUser_PKR.MouseLeave += new System.EventHandler(this.buttonExitFromGuidForUser_PKR_MouseLeave);
            // 
            // FormGuidForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(916, 544);
            this.Controls.Add(this.buttonExitFromGuidForUser_PKR);
            this.Controls.Add(this.pictureBoxGuidForUser_PKR);
            this.Controls.Add(this.labelGuidForUser_PKR);
            this.Controls.Add(this.textBoxGuidForUser_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuidForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuidForUser_PKR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuidForUser_PKR;
        private System.Windows.Forms.Label labelGuidForUser_PKR;
        private System.Windows.Forms.PictureBox pictureBoxGuidForUser_PKR;
        private System.Windows.Forms.Button buttonExitFromGuidForUser_PKR;
    }
}