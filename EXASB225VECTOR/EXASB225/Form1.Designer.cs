namespace EXASB225
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregunta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuV1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuV3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(834, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 229);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(834, 20);
            this.textBox5.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examenToolStripMenuItem,
            this.menuV1ToolStripMenuItem,
            this.menuV2ToolStripMenuItem,
            this.menuV3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregunta1ToolStripMenuItem});
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.examenToolStripMenuItem.Text = "Examen";
            // 
            // pregunta1ToolStripMenuItem
            // 
            this.pregunta1ToolStripMenuItem.Name = "pregunta1ToolStripMenuItem";
            this.pregunta1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregunta1ToolStripMenuItem.Text = "Pregunta 1";
            this.pregunta1ToolStripMenuItem.Click += new System.EventHandler(this.pregunta1ToolStripMenuItem_Click);
            // 
            // menuV1ToolStripMenuItem
            // 
            this.menuV1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRndToolStripMenuItem,
            this.descargarToolStripMenuItem});
            this.menuV1ToolStripMenuItem.Name = "menuV1ToolStripMenuItem";
            this.menuV1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuV1ToolStripMenuItem.Text = "Menu v1";
            // 
            // cargarRndToolStripMenuItem
            // 
            this.cargarRndToolStripMenuItem.Name = "cargarRndToolStripMenuItem";
            this.cargarRndToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cargarRndToolStripMenuItem.Text = "Cargar Rnd";
            this.cargarRndToolStripMenuItem.Click += new System.EventHandler(this.cargarRndToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // menuV2ToolStripMenuItem
            // 
            this.menuV2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargarToolStripMenuItem1});
            this.menuV2ToolStripMenuItem.Name = "menuV2ToolStripMenuItem";
            this.menuV2ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuV2ToolStripMenuItem.Text = "Menu v2";
            // 
            // descargarToolStripMenuItem1
            // 
            this.descargarToolStripMenuItem1.Name = "descargarToolStripMenuItem1";
            this.descargarToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.descargarToolStripMenuItem1.Text = "Descargar";
            this.descargarToolStripMenuItem1.Click += new System.EventHandler(this.descargarToolStripMenuItem1_Click);
            // 
            // menuV3ToolStripMenuItem
            // 
            this.menuV3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargarToolStripMenuItem2});
            this.menuV3ToolStripMenuItem.Name = "menuV3ToolStripMenuItem";
            this.menuV3ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuV3ToolStripMenuItem.Text = "Menu v3";
            // 
            // descargarToolStripMenuItem2
            // 
            this.descargarToolStripMenuItem2.Name = "descargarToolStripMenuItem2";
            this.descargarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.descargarToolStripMenuItem2.Text = "Descargar";
            this.descargarToolStripMenuItem2.Click += new System.EventHandler(this.descargarToolStripMenuItem2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(834, 20);
            this.textBox6.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 420);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregunta1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuV1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuV3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox6;
    }
}

