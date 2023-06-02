namespace U16Task3.Forms
{
    partial class AddGCSE
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Initializes the controls and their properties on the form
        private void InitializeComponent()
        {
            // TextBox controls for title and grade input
            this.titleBox = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.TextBox();

            // Label controls for displaying instructions
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();

            // Button control for confirmation
            this.button1 = new System.Windows.Forms.Button();

            // ...
            // Code omitted for brevity
            // ...

            // Sets properties for the form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.titleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddGCSE";
            this.Text = "AddGCSE";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Declaration of controls as private variables
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}