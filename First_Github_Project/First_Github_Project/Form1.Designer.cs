namespace First_Github_Project
{
    partial class Form1
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
            this.btnSplash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSplash
            // 
            this.btnSplash.BackColor = System.Drawing.Color.LightCyan;
            this.btnSplash.FlatAppearance.BorderSize = 2;
            this.btnSplash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSplash.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplash.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSplash.Location = new System.Drawing.Point(291, 120);
            this.btnSplash.Name = "btnSplash";
            this.btnSplash.Size = new System.Drawing.Size(152, 53);
            this.btnSplash.TabIndex = 0;
            this.btnSplash.Text = "Splash";
            this.btnSplash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSplash.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSplash);
            this.Name = "Form1";
            this.Text = "SoundSplash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSplash;
    }
}

