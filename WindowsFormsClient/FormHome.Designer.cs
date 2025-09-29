namespace WindowsFormsClient
{
    partial class FormHome
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
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this._userControlHome = new WindowsFormsClient.UserControlHome();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlAzul.Controls.Add(this.btnSobre);
            this.pnlAzul.Controls.Add(this.btnSair);
            this.pnlAzul.Controls.Add(this.btnFAQ);
            this.pnlAzul.Controls.Add(this.btnLivros);
            this.pnlAzul.Controls.Add(this.pbxLogo);
            this.pnlAzul.Controls.Add(this.btnInicio);
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(300, 700);
            this.pnlAzul.TabIndex = 9;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnInicio.FlatAppearance.BorderSize = 2;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInicio.Location = new System.Drawing.Point(70, 250);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(160, 40);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnLivros.FlatAppearance.BorderSize = 2;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLivros.Location = new System.Drawing.Point(70, 320);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(160, 40);
            this.btnLivros.TabIndex = 9;
            this.btnLivros.Text = "Lista de Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnFAQ.FlatAppearance.BorderSize = 2;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFAQ.Location = new System.Drawing.Point(70, 393);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(160, 40);
            this.btnFAQ.TabIndex = 10;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(70, 619);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 40);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSobre.FlatAppearance.BorderSize = 2;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSobre.Location = new System.Drawing.Point(70, 471);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(160, 40);
            this.btnSobre.TabIndex = 12;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsClient.Properties.Resources.online_library;
            this.pbxLogo.Location = new System.Drawing.Point(78, 63);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // _userControlHome
            // 
            this._userControlHome.Location = new System.Drawing.Point(300, 0);
            this._userControlHome.Name = "_userControlHome";
            this._userControlHome.Size = new System.Drawing.Size(600, 700);
            this._userControlHome.TabIndex = 10;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this._userControlHome);
            this.Controls.Add(this.pnlAzul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.pnlAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.PictureBox pbxLogo;
        private UserControlHome _userControlHome;
    }
}