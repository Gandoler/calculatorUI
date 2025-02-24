//using User_Interface.ExtendedTool;


using Guna.UI2.WinForms.Suite;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace calculator_winforms.AppLogic.Login.View
{
    partial class LoginFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrom));
            this.panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LogintextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelBackTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackTitle
            // 
            this.panelBackTitle.Controls.Add(this.ExitButton);
            this.panelBackTitle.Controls.Add(this.LoginLabel);
            this.panelBackTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panelBackTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackTitle.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(112)))), ((int)(((byte)(101)))));
            this.panelBackTitle.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(200)))));
            this.panelBackTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBackTitle.Name = "panelBackTitle";
            this.panelBackTitle.Size = new System.Drawing.Size(350, 54);
            this.panelBackTitle.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginLabel.Location = new System.Drawing.Point(131, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(99, 31);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "LOGIN";
            // 
            // LogintextBox
            // 
            this.LogintextBox.BackColor = System.Drawing.Color.Transparent;
            this.LogintextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(200)))));
            this.LogintextBox.BorderRadius = 15;
            this.LogintextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogintextBox.DefaultText = "";
            this.LogintextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LogintextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LogintextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LogintextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LogintextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(200)))));
            this.LogintextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LogintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogintextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LogintextBox.Location = new System.Drawing.Point(98, 90);
            this.LogintextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LogintextBox.MaxLength = 20;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.PasswordChar = '\0';
            this.LogintextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.LogintextBox.PlaceholderText = "Login";
            this.LogintextBox.SelectedText = "";
            this.LogintextBox.Size = new System.Drawing.Size(171, 43);
            this.LogintextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(200)))));
            this.PasswordTextBox.BorderRadius = 15;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(200)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(98, 141);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(171, 43);
            this.PasswordTextBox.TabIndex = 16;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 15;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(98, 190);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(171, 43);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "LOGIN";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(301, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.Size = new System.Drawing.Size(46, 47);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "X";
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 278);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.panelBackTitle);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelBackTitle.ResumeLayout(false);
            this.panelBackTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBackTitle;
        private Label LoginLabel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2TextBox LogintextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButton;
    }
}