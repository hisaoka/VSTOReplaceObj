namespace ReplaceText
{
    partial class ReplaceObjectForm
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
            this.buttonAsReplaceAll = new System.Windows.Forms.Button();
            this.textBoxAsFrom = new System.Windows.Forms.TextBox();
            this.labelAsFrom = new System.Windows.Forms.Label();
            this.labelAsTo = new System.Windows.Forms.Label();
            this.textBoxAsTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAsReplaceAll
            // 
            this.buttonAsReplaceAll.Location = new System.Drawing.Point(12, 105);
            this.buttonAsReplaceAll.Name = "buttonAsReplaceAll";
            this.buttonAsReplaceAll.Size = new System.Drawing.Size(116, 23);
            this.buttonAsReplaceAll.TabIndex = 5;
            this.buttonAsReplaceAll.Text = "すべて置換(&A)";
            this.buttonAsReplaceAll.UseVisualStyleBackColor = true;
            this.buttonAsReplaceAll.Click += new System.EventHandler(this.buttonAsReplaceAll_Click);
            // 
            // textBoxAsFrom
            // 
            this.textBoxAsFrom.Location = new System.Drawing.Point(139, 24);
            this.textBoxAsFrom.Name = "textBoxAsFrom";
            this.textBoxAsFrom.Size = new System.Drawing.Size(275, 19);
            this.textBoxAsFrom.TabIndex = 2;
            this.textBoxAsFrom.TextChanged += new System.EventHandler(this.textBoxAsFrom_TextChanged);
            // 
            // labelAsFrom
            // 
            this.labelAsFrom.AutoSize = true;
            this.labelAsFrom.Location = new System.Drawing.Point(15, 27);
            this.labelAsFrom.Name = "labelAsFrom";
            this.labelAsFrom.Size = new System.Drawing.Size(100, 12);
            this.labelAsFrom.TabIndex = 1;
            this.labelAsFrom.Text = "検索する文字列(&N)";
            // 
            // labelAsTo
            // 
            this.labelAsTo.AutoSize = true;
            this.labelAsTo.Location = new System.Drawing.Point(15, 67);
            this.labelAsTo.Name = "labelAsTo";
            this.labelAsTo.Size = new System.Drawing.Size(102, 12);
            this.labelAsTo.TabIndex = 3;
            this.labelAsTo.Text = "置換後の文字列(&E)";
            // 
            // textBoxAsTo
            // 
            this.textBoxAsTo.Location = new System.Drawing.Point(139, 64);
            this.textBoxAsTo.Name = "textBoxAsTo";
            this.textBoxAsTo.Size = new System.Drawing.Size(275, 19);
            this.textBoxAsTo.TabIndex = 4;
            // 
            // ReplaceObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 138);
            this.Controls.Add(this.textBoxAsTo);
            this.Controls.Add(this.labelAsTo);
            this.Controls.Add(this.labelAsFrom);
            this.Controls.Add(this.textBoxAsFrom);
            this.Controls.Add(this.buttonAsReplaceAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReplaceObjectForm";
            this.Text = "オブジェクトの文字列を置換する";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAsReplaceAll;
        private System.Windows.Forms.TextBox textBoxAsFrom;
        private System.Windows.Forms.Label labelAsFrom;
        private System.Windows.Forms.Label labelAsTo;
        private System.Windows.Forms.TextBox textBoxAsTo;
    }
}