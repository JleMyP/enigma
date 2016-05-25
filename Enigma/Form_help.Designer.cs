namespace Enigma {
    partial class Form_help {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_head = new System.Windows.Forms.Label();
            this.label_body = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.BackColor = System.Drawing.Color.Transparent;
            this.label_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_head.ForeColor = System.Drawing.SystemColors.Info;
            this.label_head.Location = new System.Drawing.Point(12, 27);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(96, 20);
            this.label_head.TabIndex = 0;
            this.label_head.Text = "заголовок";
            // 
            // label_body
            // 
            this.label_body.AutoSize = true;
            this.label_body.BackColor = System.Drawing.Color.Transparent;
            this.label_body.ForeColor = System.Drawing.SystemColors.Info;
            this.label_body.Location = new System.Drawing.Point(13, 64);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(30, 13);
            this.label_body.TabIndex = 1;
            this.label_body.Text = "тело";
            // 
            // Form_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma.Properties.Resources.wood_29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_body);
            this.Controls.Add(this.label_head);
            this.Name = "Form_help";
            this.Text = "помощь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_head;
        public System.Windows.Forms.Label label_body;
    }
}