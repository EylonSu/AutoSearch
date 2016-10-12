namespace AutoSearch
{
    partial class Form_NewRow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Query = new System.Windows.Forms.TextBox();
            this.checkBox_Default = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btb_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your query";
            // 
            // txtBox_Query
            // 
            this.txtBox_Query.Location = new System.Drawing.Point(54, 100);
            this.txtBox_Query.Name = "txtBox_Query";
            this.txtBox_Query.Size = new System.Drawing.Size(295, 20);
            this.txtBox_Query.TabIndex = 0;
            // 
            // checkBox_Default
            // 
            this.checkBox_Default.AutoSize = true;
            this.checkBox_Default.Location = new System.Drawing.Point(54, 149);
            this.checkBox_Default.Name = "checkBox_Default";
            this.checkBox_Default.Size = new System.Drawing.Size(91, 17);
            this.checkBox_Default.TabIndex = 10;
            this.checkBox_Default.Text = "Set as default";
            this.checkBox_Default.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(87, 215);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(140, 60);
            this.btn_Submit.TabIndex = 20;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btb_Cancel
            // 
            this.btb_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btb_Cancel.Location = new System.Drawing.Point(233, 215);
            this.btb_Cancel.Name = "btb_Cancel";
            this.btb_Cancel.Size = new System.Drawing.Size(140, 60);
            this.btb_Cancel.TabIndex = 30;
            this.btb_Cancel.Text = "Cancel";
            this.btb_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form_NewRow
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btb_Cancel;
            this.ClientSize = new System.Drawing.Size(457, 409);
            this.Controls.Add(this.btb_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.checkBox_Default);
            this.Controls.Add(this.txtBox_Query);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form_NewRow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NewRow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Query;
        private System.Windows.Forms.CheckBox checkBox_Default;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btb_Cancel;
    }
}