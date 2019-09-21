﻿namespace RetroFun.Pages
{
    partial class GiftEditor
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
            this.furnITextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GiftTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FurniIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PageIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnonymousChbx = new System.Windows.Forms.CheckBox();
            this.SendGiftBtn = new Sulakore.Components.SKoreButton();
            this.SButtonLoopToggle = new Sulakore.Components.SKoreButton();
            this.LoopCoolDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LoopCoolDown)).BeginInit();
            this.SuspendLayout();
            // 
            // furnITextBox
            // 
            this.furnITextBox.Location = new System.Drawing.Point(186, 85);
            this.furnITextBox.Name = "furnITextBox";
            this.furnITextBox.Size = new System.Drawing.Size(123, 20);
            this.furnITextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 52);
            this.label5.TabIndex = 36;
            this.label5.Text = "If The Furni supports text\r\nwrite here,\r\nelse \r\nleave blank as default\r\n";
            // 
            // GiftTextBox
            // 
            this.GiftTextBox.Location = new System.Drawing.Point(12, 175);
            this.GiftTextBox.Name = "GiftTextBox";
            this.GiftTextBox.Size = new System.Drawing.Size(123, 20);
            this.GiftTextBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gift Text";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(12, 125);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(123, 20);
            this.UsernameTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username to send";
            // 
            // FurniIDBox
            // 
            this.FurniIDBox.Location = new System.Drawing.Point(12, 76);
            this.FurniIDBox.Name = "FurniIDBox";
            this.FurniIDBox.Size = new System.Drawing.Size(123, 20);
            this.FurniIDBox.TabIndex = 31;
            this.FurniIDBox.TextChanged += new System.EventHandler(this.FurniIDBox_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "FurniID";
            // 
            // PageIdBox
            // 
            this.PageIdBox.Location = new System.Drawing.Point(12, 30);
            this.PageIdBox.Name = "PageIdBox";
            this.PageIdBox.Size = new System.Drawing.Size(123, 20);
            this.PageIdBox.TabIndex = 29;
            this.PageIdBox.TextChanged += new System.EventHandler(this.PageIdBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "PageID";
            // 
            // AnonymousChbx
            // 
            this.AnonymousChbx.AutoSize = true;
            this.AnonymousChbx.Location = new System.Drawing.Point(12, 218);
            this.AnonymousChbx.Name = "AnonymousChbx";
            this.AnonymousChbx.Size = new System.Drawing.Size(123, 17);
            this.AnonymousChbx.TabIndex = 27;
            this.AnonymousChbx.Text = "Gift It as Anonymous";
            this.AnonymousChbx.UseVisualStyleBackColor = true;
            // 
            // SendGiftBtn
            // 
            this.SendGiftBtn.Location = new System.Drawing.Point(160, 218);
            this.SendGiftBtn.Name = "SendGiftBtn";
            this.SendGiftBtn.Size = new System.Drawing.Size(224, 20);
            this.SendGiftBtn.TabIndex = 26;
            this.SendGiftBtn.Text = "Send The Gift";
            this.SendGiftBtn.Click += new System.EventHandler(this.SendGiftBtn_Click_1);
            // 
            // SButtonLoopToggle
            // 
            this.SButtonLoopToggle.Location = new System.Drawing.Point(160, 175);
            this.SButtonLoopToggle.Name = "SButtonLoopToggle";
            this.SButtonLoopToggle.Size = new System.Drawing.Size(169, 20);
            this.SButtonLoopToggle.TabIndex = 38;
            this.SButtonLoopToggle.Text = "Send The Gift On loop : Disabled";
            this.SButtonLoopToggle.Click += new System.EventHandler(this.SButtonLoopToggle_Click);
            // 
            // LoopCoolDown
            // 
            this.LoopCoolDown.Location = new System.Drawing.Point(374, 176);
            this.LoopCoolDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LoopCoolDown.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.LoopCoolDown.Name = "LoopCoolDown";
            this.LoopCoolDown.Size = new System.Drawing.Size(81, 20);
            this.LoopCoolDown.TabIndex = 39;
            this.LoopCoolDown.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            // 
            // GiftEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoopCoolDown);
            this.Controls.Add(this.SButtonLoopToggle);
            this.Controls.Add(this.furnITextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GiftTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FurniIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PageIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnonymousChbx);
            this.Controls.Add(this.SendGiftBtn);
            this.Name = "GiftEditor";
            this.Size = new System.Drawing.Size(477, 257);
            ((System.ComponentModel.ISupportInitialize)(this.LoopCoolDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox furnITextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GiftTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FurniIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PageIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AnonymousChbx;
        private Sulakore.Components.SKoreButton SendGiftBtn;
        private Sulakore.Components.SKoreButton SButtonLoopToggle;
        private System.Windows.Forms.NumericUpDown LoopCoolDown;
    }
}

