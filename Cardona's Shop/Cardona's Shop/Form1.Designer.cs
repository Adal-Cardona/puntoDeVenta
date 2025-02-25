namespace Cardona_s_Shop
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
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNTRADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEVISARSTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIARINFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOSEMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATOSDEEMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOSPUESTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cERRARSESIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem,
            this.iNVENTARIOToolStripMenuItem,
            this.rEGISTRODEToolStripMenuItem,
            this.cAMBIOSToolStripMenuItem,
            this.cERRARSESIONToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            this.vENTASToolStripMenuItem.Click += new System.EventHandler(this.vENTASToolStripMenuItem_Click);
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            this.iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNTRADAToolStripMenuItem,
            this.rEVISARSTOCKToolStripMenuItem});
            this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // eNTRADAToolStripMenuItem
            // 
            this.eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            this.eNTRADAToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.eNTRADAToolStripMenuItem.Text = "ENTRADAS";
            this.eNTRADAToolStripMenuItem.Click += new System.EventHandler(this.eNTRADAToolStripMenuItem_Click);
            // 
            // rEVISARSTOCKToolStripMenuItem
            // 
            this.rEVISARSTOCKToolStripMenuItem.Name = "rEVISARSTOCKToolStripMenuItem";
            this.rEVISARSTOCKToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.rEVISARSTOCKToolStripMenuItem.Text = "REVISAR STOCK";
            this.rEVISARSTOCKToolStripMenuItem.Click += new System.EventHandler(this.rEVISARSTOCKToolStripMenuItem_Click);
            // 
            // rEGISTRODEToolStripMenuItem
            // 
            this.rEGISTRODEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUCTOSToolStripMenuItem,
            this.eMPLEADOSToolStripMenuItem});
            this.rEGISTRODEToolStripMenuItem.Name = "rEGISTRODEToolStripMenuItem";
            this.rEGISTRODEToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.rEGISTRODEToolStripMenuItem.Text = "REGISTROS";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.cAMBIARINFORMACIONToolStripMenuItem});
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(372, 36);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // cAMBIARINFORMACIONToolStripMenuItem
            // 
            this.cAMBIARINFORMACIONToolStripMenuItem.Name = "cAMBIARINFORMACIONToolStripMenuItem";
            this.cAMBIARINFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(372, 36);
            this.cAMBIARINFORMACIONToolStripMenuItem.Text = "CAMBIAR INFORMACION";
            this.cAMBIARINFORMACIONToolStripMenuItem.Click += new System.EventHandler(this.cAMBIARINFORMACIONToolStripMenuItem_Click);
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOSEMPLEADOSToolStripMenuItem,
            this.dATOSDEEMPLEADOSToolStripMenuItem});
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            // 
            // nUEVOSEMPLEADOSToolStripMenuItem
            // 
            this.nUEVOSEMPLEADOSToolStripMenuItem.Name = "nUEVOSEMPLEADOSToolStripMenuItem";
            this.nUEVOSEMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(350, 36);
            this.nUEVOSEMPLEADOSToolStripMenuItem.Text = "NUEVOS EMPLEADOS";
            this.nUEVOSEMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.nUEVOSEMPLEADOSToolStripMenuItem_Click);
            // 
            // dATOSDEEMPLEADOSToolStripMenuItem
            // 
            this.dATOSDEEMPLEADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERToolStripMenuItem,
            this.cAMBIARToolStripMenuItem});
            this.dATOSDEEMPLEADOSToolStripMenuItem.Name = "dATOSDEEMPLEADOSToolStripMenuItem";
            this.dATOSDEEMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(350, 36);
            this.dATOSDEEMPLEADOSToolStripMenuItem.Text = "DATOS DE EMPLEADOS";
            // 
            // vERToolStripMenuItem
            // 
            this.vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            this.vERToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.vERToolStripMenuItem.Text = "VER";
            this.vERToolStripMenuItem.Click += new System.EventHandler(this.vERToolStripMenuItem_Click);
            // 
            // cAMBIARToolStripMenuItem
            // 
            this.cAMBIARToolStripMenuItem.Name = "cAMBIARToolStripMenuItem";
            this.cAMBIARToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.cAMBIARToolStripMenuItem.Text = "CAMBIAR";
            this.cAMBIARToolStripMenuItem.Click += new System.EventHandler(this.cAMBIARToolStripMenuItem_Click);
            // 
            // cAMBIOSToolStripMenuItem
            // 
            this.cAMBIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERENCIAToolStripMenuItem,
            this.nUEVOSPUESTOSToolStripMenuItem,
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem});
            this.cAMBIOSToolStripMenuItem.Name = "cAMBIOSToolStripMenuItem";
            this.cAMBIOSToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.cAMBIOSToolStripMenuItem.Text = "CAMBIOS";
            // 
            // gERENCIAToolStripMenuItem
            // 
            this.gERENCIAToolStripMenuItem.Name = "gERENCIAToolStripMenuItem";
            this.gERENCIAToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.gERENCIAToolStripMenuItem.Text = "GERENCIA";
            this.gERENCIAToolStripMenuItem.Click += new System.EventHandler(this.gERENCIAToolStripMenuItem_Click);
            // 
            // nUEVOSPUESTOSToolStripMenuItem
            // 
            this.nUEVOSPUESTOSToolStripMenuItem.Name = "nUEVOSPUESTOSToolStripMenuItem";
            this.nUEVOSPUESTOSToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.nUEVOSPUESTOSToolStripMenuItem.Text = "NUEVOS PUESTOS";
            this.nUEVOSPUESTOSToolStripMenuItem.Click += new System.EventHandler(this.nUEVOSPUESTOSToolStripMenuItem_Click);
            // 
            // nUEVOSDEPARTAMENTOSToolStripMenuItem
            // 
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem.Name = "nUEVOSDEPARTAMENTOSToolStripMenuItem";
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem.Text = "NUEVOS DEPARTAMENTOS";
            this.nUEVOSDEPARTAMENTOSToolStripMenuItem.Click += new System.EventHandler(this.nUEVOSDEPARTAMENTOSToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.White;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(1356, 5);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(86, 31);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "label1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cERRARSESIONToolStripMenuItem
            // 
            this.cERRARSESIONToolStripMenuItem.Name = "cERRARSESIONToolStripMenuItem";
            this.cERRARSESIONToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.cERRARSESIONToolStripMenuItem.Text = "CERRAR SESION";
            this.cERRARSESIONToolStripMenuItem.Click += new System.EventHandler(this.cERRARSESIONToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 554);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNTRADAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEVISARSTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMBIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOSEMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATOSDEEMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOSPUESTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOSDEPARTAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMBIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMBIARINFORMACIONToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ToolStripMenuItem cERRARSESIONToolStripMenuItem;
    }
}

