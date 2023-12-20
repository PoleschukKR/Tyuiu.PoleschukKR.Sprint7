
namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    partial class FormAboutCompanies
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutCompanies));
            this.ComboBoxCompanies_PKR = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCompanies_PKR = new System.Windows.Forms.Label();
            this.listBoxCompanies_PKR = new System.Windows.Forms.ListBox();
            this.roundButtonInfoAboutCompanies = new Tyuiu.PoleschukKR.Sprint7.Project.V12.RoundButton();
            this.buttonExitFormComp_PKR = new System.Windows.Forms.Button();
            this.toolTipAboutCompanies_PKR = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ComboBoxCompanies_PKR
            // 
            this.ComboBoxCompanies_PKR.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCompanies_PKR.BorderColor = System.Drawing.Color.DarkBlue;
            this.ComboBoxCompanies_PKR.BorderRadius = 10;
            this.ComboBoxCompanies_PKR.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ComboBoxCompanies_PKR.BorderThickness = 2;
            this.ComboBoxCompanies_PKR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCompanies_PKR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCompanies_PKR.FillColor = System.Drawing.Color.Gray;
            this.ComboBoxCompanies_PKR.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCompanies_PKR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCompanies_PKR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxCompanies_PKR.ForeColor = System.Drawing.Color.White;
            this.ComboBoxCompanies_PKR.ItemHeight = 30;
            this.ComboBoxCompanies_PKR.Items.AddRange(new object[] {
            "Asus",
            "MSI",
            "HP",
            "Huawei",
            "Intel",
            "AMD"});
            this.ComboBoxCompanies_PKR.Location = new System.Drawing.Point(17, 61);
            this.ComboBoxCompanies_PKR.Name = "ComboBoxCompanies_PKR";
            this.ComboBoxCompanies_PKR.Size = new System.Drawing.Size(188, 36);
            this.ComboBoxCompanies_PKR.TabIndex = 0;
            this.toolTipAboutCompanies_PKR.SetToolTip(this.ComboBoxCompanies_PKR, "Выберите компанию, о которой\r\nхотите узнать информацию\r\n\r\n");
            this.ComboBoxCompanies_PKR.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCompanies_PKR_SelectedIndexChanged);
            // 
            // labelCompanies_PKR
            // 
            this.labelCompanies_PKR.AutoSize = true;
            this.labelCompanies_PKR.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompanies_PKR.ForeColor = System.Drawing.Color.White;
            this.labelCompanies_PKR.Location = new System.Drawing.Point(12, 19);
            this.labelCompanies_PKR.Name = "labelCompanies_PKR";
            this.labelCompanies_PKR.Size = new System.Drawing.Size(193, 25);
            this.labelCompanies_PKR.TabIndex = 1;
            this.labelCompanies_PKR.Text = "Выберите компанию";
            // 
            // listBoxCompanies_PKR
            // 
            this.listBoxCompanies_PKR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxCompanies_PKR.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCompanies_PKR.FormattingEnabled = true;
            this.listBoxCompanies_PKR.ItemHeight = 25;
            this.listBoxCompanies_PKR.Items.AddRange(new object[] {
            ""});
            this.listBoxCompanies_PKR.Location = new System.Drawing.Point(17, 125);
            this.listBoxCompanies_PKR.Name = "listBoxCompanies_PKR";
            this.listBoxCompanies_PKR.Size = new System.Drawing.Size(885, 354);
            this.listBoxCompanies_PKR.TabIndex = 2;
            // 
            // roundButtonInfoAboutCompanies
            // 
            this.roundButtonInfoAboutCompanies.BackColor = System.Drawing.Color.Red;
            this.roundButtonInfoAboutCompanies.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.roundButtonInfoAboutCompanies.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundButtonInfoAboutCompanies.ButtonHighlightColor = System.Drawing.Color.Red;
            this.roundButtonInfoAboutCompanies.ButtonHighlightColor2 = System.Drawing.Color.Red;
            this.roundButtonInfoAboutCompanies.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButtonInfoAboutCompanies.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundButtonInfoAboutCompanies.ButtonPressedColor2 = System.Drawing.Color.DarkViolet;
            this.roundButtonInfoAboutCompanies.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButtonInfoAboutCompanies.ButtonRoundRadius = 15;
            this.roundButtonInfoAboutCompanies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButtonInfoAboutCompanies.Location = new System.Drawing.Point(296, 61);
            this.roundButtonInfoAboutCompanies.Name = "roundButtonInfoAboutCompanies";
            this.roundButtonInfoAboutCompanies.Size = new System.Drawing.Size(210, 41);
            this.roundButtonInfoAboutCompanies.TabIndex = 3;
            this.roundButtonInfoAboutCompanies.Text = "Стереть данные";
            this.toolTipAboutCompanies_PKR.SetToolTip(this.roundButtonInfoAboutCompanies, "Нажмите, чтобы стереть информацию о компании,\r\nзатем выберите новую\r\n");
            this.roundButtonInfoAboutCompanies.Click += new System.EventHandler(this.roundButtonInfoAboutCompanies_Click);
            // 
            // buttonExitFormComp_PKR
            // 
            this.buttonExitFormComp_PKR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.buttonExitFormComp_PKR.FlatAppearance.BorderSize = 0;
            this.buttonExitFormComp_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitFormComp_PKR.ForeColor = System.Drawing.Color.White;
            this.buttonExitFormComp_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitFormComp_PKR.Image")));
            this.buttonExitFormComp_PKR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExitFormComp_PKR.Location = new System.Drawing.Point(17, 485);
            this.buttonExitFormComp_PKR.Name = "buttonExitFormComp_PKR";
            this.buttonExitFormComp_PKR.Size = new System.Drawing.Size(124, 47);
            this.buttonExitFormComp_PKR.TabIndex = 4;
            this.buttonExitFormComp_PKR.Text = "Выход ";
            this.toolTipAboutCompanies_PKR.SetToolTip(this.buttonExitFormComp_PKR, "Выход в главное меню\r\n");
            this.buttonExitFormComp_PKR.UseVisualStyleBackColor = false;
            this.buttonExitFormComp_PKR.Click += new System.EventHandler(this.buttonExitFormComp_PKR_Click);
            this.buttonExitFormComp_PKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExitFormComp_PKR_MouseDown);
            this.buttonExitFormComp_PKR.MouseLeave += new System.EventHandler(this.buttonExitFormComp_PKR_MouseLeave);
            // 
            // toolTipAboutCompanies_PKR
            // 
            this.toolTipAboutCompanies_PKR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolTipAboutCompanies_PKR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTipAboutCompanies_PKR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAboutCompanies_PKR.ToolTipTitle = "Подсказка";
            // 
            // FormAboutCompanies
            // 
            this.AcceptButton = this.buttonExitFormComp_PKR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(916, 544);
            this.Controls.Add(this.buttonExitFormComp_PKR);
            this.Controls.Add(this.roundButtonInfoAboutCompanies);
            this.Controls.Add(this.listBoxCompanies_PKR);
            this.Controls.Add(this.labelCompanies_PKR);
            this.Controls.Add(this.ComboBoxCompanies_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutCompanies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutCompanies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCompanies_PKR;
        private System.Windows.Forms.Label labelCompanies_PKR;
        private System.Windows.Forms.ListBox listBoxCompanies_PKR;
        private RoundButton roundButtonInfoAboutCompanies;
        private System.Windows.Forms.Button buttonExitFormComp_PKR;
        private System.Windows.Forms.ToolTip toolTipAboutCompanies_PKR;
    }
}