namespace Canon_VsCanon
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_JugA = new System.Windows.Forms.Button();
            this.button2_JugA = new System.Windows.Forms.Button();
            this.button3_JugA = new System.Windows.Forms.Button();
            this.button4_JugB = new System.Windows.Forms.Button();
            this.button5_JugB = new System.Windows.Forms.Button();
            this.button6_JugB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comenzarToolStripMenuItem
            // 
            this.comenzarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarToolStripMenuItem,
            this.finalizarToolStripMenuItem1,
            this.creditosToolStripMenuItem});
            this.comenzarToolStripMenuItem.Name = "comenzarToolStripMenuItem";
            this.comenzarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.comenzarToolStripMenuItem.Text = "Menu";
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.finalizarToolStripMenuItem.Text = "Comenzar";
            this.finalizarToolStripMenuItem.Click += new System.EventHandler(this.finalizarToolStripMenuItem_Click);
            // 
            // finalizarToolStripMenuItem1
            // 
            this.finalizarToolStripMenuItem1.Name = "finalizarToolStripMenuItem1";
            this.finalizarToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.finalizarToolStripMenuItem1.Text = "Finalizar";
            this.finalizarToolStripMenuItem1.Click += new System.EventHandler(this.finalizarToolStripMenuItem1_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1_JugA
            // 
            this.button1_JugA.Location = new System.Drawing.Point(38, 440);
            this.button1_JugA.Name = "button1_JugA";
            this.button1_JugA.Size = new System.Drawing.Size(75, 23);
            this.button1_JugA.TabIndex = 2;
            this.button1_JugA.Text = "-";
            this.button1_JugA.UseVisualStyleBackColor = true;
            // 
            // button2_JugA
            // 
            this.button2_JugA.Location = new System.Drawing.Point(119, 440);
            this.button2_JugA.Name = "button2_JugA";
            this.button2_JugA.Size = new System.Drawing.Size(75, 23);
            this.button2_JugA.TabIndex = 3;
            this.button2_JugA.Text = "+";
            this.button2_JugA.UseVisualStyleBackColor = true;
            // 
            // button3_JugA
            // 
            this.button3_JugA.Location = new System.Drawing.Point(200, 440);
            this.button3_JugA.Name = "button3_JugA";
            this.button3_JugA.Size = new System.Drawing.Size(75, 23);
            this.button3_JugA.TabIndex = 4;
            this.button3_JugA.Text = "Boom";
            this.button3_JugA.UseVisualStyleBackColor = true;
            // 
            // button4_JugB
            // 
            this.button4_JugB.Location = new System.Drawing.Point(859, 440);
            this.button4_JugB.Name = "button4_JugB";
            this.button4_JugB.Size = new System.Drawing.Size(75, 23);
            this.button4_JugB.TabIndex = 7;
            this.button4_JugB.Text = "Boom";
            this.button4_JugB.UseVisualStyleBackColor = true;
            // 
            // button5_JugB
            // 
            this.button5_JugB.Location = new System.Drawing.Point(778, 440);
            this.button5_JugB.Name = "button5_JugB";
            this.button5_JugB.Size = new System.Drawing.Size(75, 23);
            this.button5_JugB.TabIndex = 6;
            this.button5_JugB.Text = "+";
            this.button5_JugB.UseVisualStyleBackColor = true;
            // 
            // button6_JugB
            // 
            this.button6_JugB.Location = new System.Drawing.Point(697, 440);
            this.button6_JugB.Name = "button6_JugB";
            this.button6_JugB.Size = new System.Drawing.Size(75, 23);
            this.button6_JugB.TabIndex = 5;
            this.button6_JugB.Text = "-";
            this.button6_JugB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 500);
            this.Controls.Add(this.button4_JugB);
            this.Controls.Add(this.button5_JugB);
            this.Controls.Add(this.button6_JugB);
            this.Controls.Add(this.button3_JugA);
            this.Controls.Add(this.button2_JugA);
            this.Controls.Add(this.button1_JugA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cañon Vs Cañon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_JugA;
        private System.Windows.Forms.Button button2_JugA;
        private System.Windows.Forms.Button button3_JugA;
        private System.Windows.Forms.Button button4_JugB;
        private System.Windows.Forms.Button button5_JugB;
        private System.Windows.Forms.Button button6_JugB;
    }
}

