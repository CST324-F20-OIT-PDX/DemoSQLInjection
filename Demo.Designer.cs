namespace DemoSQLInjection
{
    partial class DemoSQLInjection
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblEnterNickName = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.lblParmaterOutput = new System.Windows.Forms.Label();
            this.lblNoParameters = new System.Windows.Forms.Label();
            this.lblCheatSheet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(96, 415);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblEnterNickName
            // 
            this.lblEnterNickName.AutoSize = true;
            this.lblEnterNickName.Location = new System.Drawing.Point(15, 12);
            this.lblEnterNickName.Name = "lblEnterNickName";
            this.lblEnterNickName.Size = new System.Drawing.Size(124, 17);
            this.lblEnterNickName.TabIndex = 5;
            this.lblEnterNickName.Text = "Enter a nick Name";
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(169, 12);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(100, 22);
            this.nickName.TabIndex = 6;
            // 
            // lblParmaterOutput
            // 
            this.lblParmaterOutput.AutoSize = true;
            this.lblParmaterOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblParmaterOutput.Location = new System.Drawing.Point(15, 39);
            this.lblParmaterOutput.Name = "lblParmaterOutput";
            this.lblParmaterOutput.Size = new System.Drawing.Size(145, 34);
            this.lblParmaterOutput.TabIndex = 7;
            this.lblParmaterOutput.Text = "With Paramter Output\r\nDogID NickName";
            this.lblParmaterOutput.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNoParameters
            // 
            this.lblNoParameters.AutoSize = true;
            this.lblNoParameters.BackColor = System.Drawing.SystemColors.Info;
            this.lblNoParameters.Location = new System.Drawing.Point(553, 12);
            this.lblNoParameters.Name = "lblNoParameters";
            this.lblNoParameters.Size = new System.Drawing.Size(164, 34);
            this.lblNoParameters.TabIndex = 8;
            this.lblNoParameters.Text = "Select without Paramters\r\nDogID NickName";
            // 
            // lblCheatSheet
            // 
            this.lblCheatSheet.AutoSize = true;
            this.lblCheatSheet.Location = new System.Drawing.Point(417, 314);
            this.lblCheatSheet.Name = "lblCheatSheet";
            this.lblCheatSheet.Size = new System.Drawing.Size(300, 34);
            this.lblCheatSheet.TabIndex = 9;
            this.lblCheatSheet.Text = "Use \r\nBones\';select * from dogs where color = \'mixed";
            // 
            // DemoSQLInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCheatSheet);
            this.Controls.Add(this.lblNoParameters);
            this.Controls.Add(this.lblParmaterOutput);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.lblEnterNickName);
            this.Controls.Add(this.btnGo);
            this.Name = "DemoSQLInjection";
            this.Text = "Demo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblEnterNickName;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Label lblParmaterOutput;
        private System.Windows.Forms.Label lblNoParameters;
        private System.Windows.Forms.Label lblCheatSheet;
    }
}

