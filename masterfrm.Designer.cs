namespace GST
{
    partial class Masterfrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(660, 13);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(106, 37);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(497, 13);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 37);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(334, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 37);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(823, 13);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(106, 37);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(171, 13);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(106, 37);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 52);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Masterfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1016, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Masterfrm";
            this.Text = "masterfrm";
            this.Load += new System.EventHandler(this.Masterfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnshow;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Button btnexit;
        public System.Windows.Forms.Button btnnew;
        public System.Windows.Forms.Label label1;


    }
}