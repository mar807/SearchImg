namespace InterviewProblem
{
    partial class Form2
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
            this.addPwrBtn = new System.Windows.Forms.Button();
            this.imgView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descrText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPwrBtn
            // 
            this.addPwrBtn.Location = new System.Drawing.Point(778, 528);
            this.addPwrBtn.Name = "addPwrBtn";
            this.addPwrBtn.Size = new System.Drawing.Size(131, 23);
            this.addPwrBtn.TabIndex = 0;
            this.addPwrBtn.Text = "Add to powerpoint";
            this.addPwrBtn.UseVisualStyleBackColor = true;
            this.addPwrBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgView
            // 
            this.imgView.HideSelection = false;
            this.imgView.Location = new System.Drawing.Point(1, 112);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(908, 410);
            this.imgView.TabIndex = 1;
            this.imgView.UseCompatibleStateImageBehavior = false;
            this.imgView.SelectedIndexChanged += new System.EventHandler(this.imgView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(376, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "title";
            // 
            // descrText
            // 
            this.descrText.AutoSize = true;
            this.descrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrText.Location = new System.Drawing.Point(12, 34);
            this.descrText.Name = "descrText";
            this.descrText.Size = new System.Drawing.Size(69, 13);
            this.descrText.TabIndex = 6;
            this.descrText.Text = "description";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 563);
            this.Controls.Add(this.descrText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgView);
            this.Controls.Add(this.addPwrBtn);
            this.Name = "Form2";
            this.Text = "Google Pictures";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPwrBtn;
        private System.Windows.Forms.ListView imgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descrText;
    }
}