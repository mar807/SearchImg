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
            this.SuspendLayout();
            // 
            // addPwrBtn
            // 
            this.addPwrBtn.Location = new System.Drawing.Point(669, 429);
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
            this.imgView.Location = new System.Drawing.Point(1, 1);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(799, 422);
            this.imgView.TabIndex = 1;
            this.imgView.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgView);
            this.Controls.Add(this.addPwrBtn);
            this.Name = "Form2";
            this.Text = "Google Pictures";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPwrBtn;
        private System.Windows.Forms.ListView imgView;
    }
}