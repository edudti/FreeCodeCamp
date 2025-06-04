namespace JwtClientApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.TextEdit textBoxUsername;
        private DevExpress.XtraEditors.MemoEdit textBoxResponse;
        private DevExpress.XtraEditors.SimpleButton buttonGetToken;
        private DevExpress.XtraEditors.SimpleButton buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxUsername = new DevExpress.XtraEditors.TextEdit();
            this.textBoxResponse = new DevExpress.XtraEditors.MemoEdit();
            this.buttonGetToken = new DevExpress.XtraEditors.SimpleButton();
            this.buttonClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResponse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 12);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(260, 20);
            // 
            // buttonGetToken
            // 
            this.buttonGetToken.Location = new System.Drawing.Point(12, 38);
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.Size = new System.Drawing.Size(75, 23);
            this.buttonGetToken.Text = "Obtener";
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(197, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(12, 67);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(260, 152);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGetToken);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Form1";
            this.Text = "JWT Client";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResponse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
