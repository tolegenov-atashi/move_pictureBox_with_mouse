namespace move_pictureBox_with_mouse
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
            this.components = new System.ComponentModel.Container();
            this.class11 = new move_pictureBox_with_mouse.Class1(this.components);
            this.class13 = new move_pictureBox_with_mouse.Class1(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.class11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class13)).BeginInit();
            this.SuspendLayout();
            // 
            // class11
            // 
            this.class11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.class11.Image = global::move_pictureBox_with_mouse.Properties.Resources.kross;
            this.class11.Location = new System.Drawing.Point(482, 250);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(198, 162);
            this.class11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class11.TabIndex = 3;
            this.class11.TabStop = false;
            // 
            // class13
            // 
            this.class13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.class13.Image = global::move_pictureBox_with_mouse.Properties.Resources.benzema;
            this.class13.Location = new System.Drawing.Point(77, 127);
            this.class13.Name = "class13";
            this.class13.Size = new System.Drawing.Size(198, 162);
            this.class13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class13.TabIndex = 2;
            this.class13.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 634);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.class13);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.class11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Class1 class13;
        private Class1 class11;
    }
}

