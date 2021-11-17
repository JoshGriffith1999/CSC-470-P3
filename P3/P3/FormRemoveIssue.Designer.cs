
namespace P3
{
    partial class FormRemoveIssue
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel_click = new System.Windows.Forms.Button();
            this.Confirm_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(560, 30);
            this.textBox1.TabIndex = 0;
            // 
            // Cancel_click
            // 
            this.Cancel_click.Location = new System.Drawing.Point(535, 242);
            this.Cancel_click.Name = "Cancel_click";
            this.Cancel_click.Size = new System.Drawing.Size(125, 35);
            this.Cancel_click.TabIndex = 1;
            this.Cancel_click.Text = "No";
            this.Cancel_click.UseVisualStyleBackColor = true;
            this.Cancel_click.Click += new System.EventHandler(this.Cancel_click_Click);
            // 
            // Confirm_click
            // 
            this.Confirm_click.Location = new System.Drawing.Point(353, 242);
            this.Confirm_click.Name = "Confirm_click";
            this.Confirm_click.Size = new System.Drawing.Size(118, 35);
            this.Confirm_click.TabIndex = 2;
            this.Confirm_click.Text = "Yes";
            this.Confirm_click.UseVisualStyleBackColor = true;
            this.Confirm_click.Click += new System.EventHandler(this.Confirm_click_Click);
            // 
            // FormRemoveIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm_click);
            this.Controls.Add(this.Cancel_click);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRemoveIssue";
            this.Text = "FormRemoveIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel_click;
        private System.Windows.Forms.Button Confirm_click;
    }
}