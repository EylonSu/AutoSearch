namespace AutoSearch
{
    partial class AutoSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSearch));
            this.txtBox_Input = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.radioBtn = new System.Windows.Forms.RadioButton();
            this.btn_SetDeafault = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Input
            // 
            this.txtBox_Input.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBox_Input.Location = new System.Drawing.Point(69, 38);
            this.txtBox_Input.Name = "txtBox_Input";
            this.txtBox_Input.Size = new System.Drawing.Size(251, 20);
            this.txtBox_Input.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_Del);
            this.groupBox.Controls.Add(this.btn_SetDeafault);
            this.groupBox.Controls.Add(this.radioBtn);
            this.groupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Location = new System.Drawing.Point(69, 77);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(318, 264);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // btn_Send
            // 
            this.btn_Send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Send.BackgroundImage = global::AutoSearch.Properties.Resources.google;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Send.Location = new System.Drawing.Point(196, 347);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(50, 50);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // radioBtn
            // 
            this.radioBtn.AutoSize = true;
            this.radioBtn.Checked = true;
            this.radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioBtn.Location = new System.Drawing.Point(48, 29);
            this.radioBtn.Name = "radioBtn";
            this.radioBtn.Size = new System.Drawing.Size(51, 28);
            this.radioBtn.TabIndex = 10;
            this.radioBtn.TabStop = true;
            this.radioBtn.Text = "C#";
            this.radioBtn.UseVisualStyleBackColor = true;
            // 
            // btn_SetDeafault
            // 
            this.btn_SetDeafault.AutoSize = true;
            this.btn_SetDeafault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_SetDeafault.Location = new System.Drawing.Point(105, 23);
            this.btn_SetDeafault.Name = "btn_SetDeafault";
            this.btn_SetDeafault.Size = new System.Drawing.Size(131, 34);
            this.btn_SetDeafault.TabIndex = 2;
            this.btn_SetDeafault.TabStop = false;
            this.btn_SetDeafault.Text = "Set as default";
            this.btn_SetDeafault.UseVisualStyleBackColor = false;
            this.btn_SetDeafault.Visible = false;
            // 
            // btn_Del
            // 
            this.btn_Del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BackgroundImage = global::AutoSearch.Properties.Resources.cancel_button;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Del.Location = new System.Drawing.Point(7, 23);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(35, 34);
            this.btn_Del.TabIndex = 3;
            this.btn_Del.TabStop = false;
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = global::AutoSearch.Properties.Resources.plus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.Location = new System.Drawing.Point(336, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 50);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // AutoSearch
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 409);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Input);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoSearch";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoSearch";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Input;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_SetDeafault;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.RadioButton radioBtn;
        private System.Windows.Forms.Button btn_Send;
    }
}

