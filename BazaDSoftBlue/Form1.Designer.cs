namespace BazaDSoftBlue
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
            this.kondensatoryButton = new System.Windows.Forms.Button();
            this.IndukcyjneButton = new System.Windows.Forms.Button();
            this.TranzIDioidyButton = new System.Windows.Forms.Button();
            this.UklScalButton = new System.Windows.Forms.Button();
            this.ZlaczaButton = new System.Windows.Forms.Button();
            this.ElMechButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kondensatoryButton
            // 
            this.kondensatoryButton.Location = new System.Drawing.Point(37, 24);
            this.kondensatoryButton.Name = "kondensatoryButton";
            this.kondensatoryButton.Size = new System.Drawing.Size(122, 23);
            this.kondensatoryButton.TabIndex = 0;
            this.kondensatoryButton.Text = "kondensatory";
            this.kondensatoryButton.UseVisualStyleBackColor = true;
            this.kondensatoryButton.Click += new System.EventHandler(this.kondensatoryButton_Click);
            // 
            // IndukcyjneButton
            // 
            this.IndukcyjneButton.Location = new System.Drawing.Point(37, 53);
            this.IndukcyjneButton.Name = "IndukcyjneButton";
            this.IndukcyjneButton.Size = new System.Drawing.Size(122, 23);
            this.IndukcyjneButton.TabIndex = 1;
            this.IndukcyjneButton.Text = "Elementy Indukcyjne";
            this.IndukcyjneButton.UseVisualStyleBackColor = true;
            this.IndukcyjneButton.Click += new System.EventHandler(this.IndukcyjneButton_Click);
            // 
            // TranzIDioidyButton
            // 
            this.TranzIDioidyButton.Location = new System.Drawing.Point(37, 111);
            this.TranzIDioidyButton.Name = "TranzIDioidyButton";
            this.TranzIDioidyButton.Size = new System.Drawing.Size(122, 23);
            this.TranzIDioidyButton.TabIndex = 2;
            this.TranzIDioidyButton.Text = "Tranzystory i Dioidy";
            this.TranzIDioidyButton.UseVisualStyleBackColor = true;
            this.TranzIDioidyButton.Click += new System.EventHandler(this.TranzIDioidyButton_Click);
            // 
            // UklScalButton
            // 
            this.UklScalButton.Location = new System.Drawing.Point(37, 140);
            this.UklScalButton.Name = "UklScalButton";
            this.UklScalButton.Size = new System.Drawing.Size(122, 23);
            this.UklScalButton.TabIndex = 3;
            this.UklScalButton.Text = "Układy";
            this.UklScalButton.UseVisualStyleBackColor = true;
            this.UklScalButton.Click += new System.EventHandler(this.UklScalButton_Click);
            // 
            // ZlaczaButton
            // 
            this.ZlaczaButton.Location = new System.Drawing.Point(37, 169);
            this.ZlaczaButton.Name = "ZlaczaButton";
            this.ZlaczaButton.Size = new System.Drawing.Size(122, 23);
            this.ZlaczaButton.TabIndex = 4;
            this.ZlaczaButton.Text = "Złącza";
            this.ZlaczaButton.UseVisualStyleBackColor = true;
            this.ZlaczaButton.Click += new System.EventHandler(this.ZlaczaButton_Click);
            // 
            // ElMechButton
            // 
            this.ElMechButton.Location = new System.Drawing.Point(37, 198);
            this.ElMechButton.Name = "ElMechButton";
            this.ElMechButton.Size = new System.Drawing.Size(122, 23);
            this.ElMechButton.TabIndex = 5;
            this.ElMechButton.Text = "Elementy ElMech";
            this.ElMechButton.UseVisualStyleBackColor = true;
            this.ElMechButton.Click += new System.EventHandler(this.ElMechButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "rezystory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElMechButton);
            this.Controls.Add(this.ZlaczaButton);
            this.Controls.Add(this.UklScalButton);
            this.Controls.Add(this.TranzIDioidyButton);
            this.Controls.Add(this.IndukcyjneButton);
            this.Controls.Add(this.kondensatoryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kondensatoryButton;
        private System.Windows.Forms.Button IndukcyjneButton;
        private System.Windows.Forms.Button TranzIDioidyButton;
        private System.Windows.Forms.Button UklScalButton;
        private System.Windows.Forms.Button ZlaczaButton;
        private System.Windows.Forms.Button ElMechButton;
        private System.Windows.Forms.Button button1;
    }
}

