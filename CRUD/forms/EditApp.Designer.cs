﻿namespace CRUD.forms
{
    partial class EditApp
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
            this.targetIdTb = new System.Windows.Forms.TextBox();
            this.newFirstNameTb = new System.Windows.Forms.TextBox();
            this.newLastNameTb = new System.Windows.Forms.TextBox();
            this.targetIdLabel = new System.Windows.Forms.Label();
            this.newFirstNameLabel = new System.Windows.Forms.Label();
            this.newLastNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targetIdTb
            // 
            this.targetIdTb.Location = new System.Drawing.Point(111, 15);
            this.targetIdTb.Name = "targetIdTb";
            this.targetIdTb.Size = new System.Drawing.Size(122, 23);
            this.targetIdTb.TabIndex = 0;
            // 
            // newFirstNameTb
            // 
            this.newFirstNameTb.Location = new System.Drawing.Point(110, 44);
            this.newFirstNameTb.Name = "newFirstNameTb";
            this.newFirstNameTb.Size = new System.Drawing.Size(122, 23);
            this.newFirstNameTb.TabIndex = 2;
            // 
            // newLastNameTb
            // 
            this.newLastNameTb.Location = new System.Drawing.Point(110, 73);
            this.newLastNameTb.Name = "newLastNameTb";
            this.newLastNameTb.Size = new System.Drawing.Size(122, 23);
            this.newLastNameTb.TabIndex = 3;
            // 
            // targetIdLabel
            // 
            this.targetIdLabel.AutoSize = true;
            this.targetIdLabel.Location = new System.Drawing.Point(14, 18);
            this.targetIdLabel.Name = "targetIdLabel";
            this.targetIdLabel.Size = new System.Drawing.Size(52, 15);
            this.targetIdLabel.TabIndex = 4;
            this.targetIdLabel.Text = "Target Id";
            // 
            // newFirstNameLabel
            // 
            this.newFirstNameLabel.AutoSize = true;
            this.newFirstNameLabel.Location = new System.Drawing.Point(13, 47);
            this.newFirstNameLabel.Name = "newFirstNameLabel";
            this.newFirstNameLabel.Size = new System.Drawing.Size(91, 15);
            this.newFirstNameLabel.TabIndex = 6;
            this.newFirstNameLabel.Text = "New First Name";
            // 
            // newLastNameLabel
            // 
            this.newLastNameLabel.AutoSize = true;
            this.newLastNameLabel.Location = new System.Drawing.Point(13, 76);
            this.newLastNameLabel.Name = "newLastNameLabel";
            this.newLastNameLabel.Size = new System.Drawing.Size(90, 15);
            this.newLastNameLabel.TabIndex = 7;
            this.newLastNameLabel.Text = "New Last Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(110, 102);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 49);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 164);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.newLastNameLabel);
            this.Controls.Add(this.newFirstNameLabel);
            this.Controls.Add(this.targetIdLabel);
            this.Controls.Add(this.newLastNameTb);
            this.Controls.Add(this.newFirstNameTb);
            this.Controls.Add(this.targetIdTb);
            this.Name = "EditApp";
            this.Text = "EditApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox targetIdTb;
        private TextBox newFirstNameTb;
        private TextBox newLastNameTb;
        private Label targetIdLabel;
        private Label newFirstNameLabel;
        private Label newLastNameLabel;
        private Button SaveButton;
    }
}