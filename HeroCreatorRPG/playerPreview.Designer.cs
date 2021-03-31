
namespace HeroCreatorRPG
{
    partial class playerPreview
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
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.playerStatus = new System.Windows.Forms.TextBox();
            this.aToZBtn = new System.Windows.Forms.Button();
            this.zToABtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 20;
            this.playerListBox.Items.AddRange(new object[] {
            "Example"});
            this.playerListBox.Location = new System.Drawing.Point(18, 18);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(268, 664);
            this.playerListBox.TabIndex = 0;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged);
            // 
            // playerStatus
            // 
            this.playerStatus.Location = new System.Drawing.Point(297, 85);
            this.playerStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerStatus.Multiline = true;
            this.playerStatus.Name = "playerStatus";
            this.playerStatus.Size = new System.Drawing.Size(655, 598);
            this.playerStatus.TabIndex = 1;
            // 
            // aToZBtn
            // 
            this.aToZBtn.Location = new System.Drawing.Point(297, 18);
            this.aToZBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aToZBtn.Name = "aToZBtn";
            this.aToZBtn.Size = new System.Drawing.Size(112, 35);
            this.aToZBtn.TabIndex = 2;
            this.aToZBtn.Text = "A to Z";
            this.aToZBtn.UseVisualStyleBackColor = true;
            this.aToZBtn.Click += new System.EventHandler(this.aToZBtn_Click);
            // 
            // zToABtn
            // 
            this.zToABtn.Location = new System.Drawing.Point(418, 18);
            this.zToABtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zToABtn.Name = "zToABtn";
            this.zToABtn.Size = new System.Drawing.Size(112, 35);
            this.zToABtn.TabIndex = 3;
            this.zToABtn.Text = "Z to A";
            this.zToABtn.UseVisualStyleBackColor = true;
            this.zToABtn.Click += new System.EventHandler(this.zToABtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(540, 18);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 35);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(844, 18);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 35);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // playerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 692);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.zToABtn);
            this.Controls.Add(this.aToZBtn);
            this.Controls.Add(this.playerStatus);
            this.Controls.Add(this.playerListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "playerPreview";
            this.Text = "Player Preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.TextBox playerStatus;
        private System.Windows.Forms.Button aToZBtn;
        private System.Windows.Forms.Button zToABtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}