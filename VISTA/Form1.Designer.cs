
namespace VISTA
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
            this.dgwALQUILERES = new System.Windows.Forms.DataGridView();
            this.gbxCARGA = new System.Windows.Forms.GroupBox();
            this.pnlTIPO = new System.Windows.Forms.Panel();
            this.rbtCASA = new System.Windows.Forms.RadioButton();
            this.rbtDEPARTAMENTO = new System.Windows.Forms.RadioButton();
            this.gbxACCIONES = new System.Windows.Forms.GroupBox();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.tbxDOMICILIO = new System.Windows.Forms.TextBox();
            this.tbxTELEFONO = new System.Windows.Forms.TextBox();
            this.tbxNOMBRE = new System.Windows.Forms.TextBox();
            this.tbxCUBIERTA = new System.Windows.Forms.TextBox();
            this.tbxDESCUBIERTA = new System.Windows.Forms.TextBox();
            this.txtGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.lblDOMICILIO = new System.Windows.Forms.Label();
            this.lblTELEFONO = new System.Windows.Forms.Label();
            this.lblCUBIERTA = new System.Windows.Forms.Label();
            this.lblDESCUBIERTA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwALQUILERES)).BeginInit();
            this.gbxCARGA.SuspendLayout();
            this.pnlTIPO.SuspendLayout();
            this.gbxACCIONES.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwALQUILERES
            // 
            this.dgwALQUILERES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwALQUILERES.Location = new System.Drawing.Point(13, 13);
            this.dgwALQUILERES.Name = "dgwALQUILERES";
            this.dgwALQUILERES.Size = new System.Drawing.Size(709, 526);
            this.dgwALQUILERES.TabIndex = 0;
            // 
            // gbxCARGA
            // 
            this.gbxCARGA.Controls.Add(this.lblDESCUBIERTA);
            this.gbxCARGA.Controls.Add(this.lblCUBIERTA);
            this.gbxCARGA.Controls.Add(this.lblTELEFONO);
            this.gbxCARGA.Controls.Add(this.lblDOMICILIO);
            this.gbxCARGA.Controls.Add(this.lblNOMBRE);
            this.gbxCARGA.Controls.Add(this.btnCANCELAR);
            this.gbxCARGA.Controls.Add(this.txtGUARDAR);
            this.gbxCARGA.Controls.Add(this.tbxDESCUBIERTA);
            this.gbxCARGA.Controls.Add(this.tbxCUBIERTA);
            this.gbxCARGA.Controls.Add(this.tbxNOMBRE);
            this.gbxCARGA.Controls.Add(this.tbxTELEFONO);
            this.gbxCARGA.Controls.Add(this.tbxDOMICILIO);
            this.gbxCARGA.Controls.Add(this.pnlTIPO);
            this.gbxCARGA.Location = new System.Drawing.Point(728, 13);
            this.gbxCARGA.Name = "gbxCARGA";
            this.gbxCARGA.Size = new System.Drawing.Size(419, 589);
            this.gbxCARGA.TabIndex = 1;
            this.gbxCARGA.TabStop = false;
            this.gbxCARGA.Text = "Carga de Datos";
            // 
            // pnlTIPO
            // 
            this.pnlTIPO.Controls.Add(this.rbtCASA);
            this.pnlTIPO.Controls.Add(this.rbtDEPARTAMENTO);
            this.pnlTIPO.Location = new System.Drawing.Point(7, 20);
            this.pnlTIPO.Name = "pnlTIPO";
            this.pnlTIPO.Size = new System.Drawing.Size(406, 48);
            this.pnlTIPO.TabIndex = 0;
            // 
            // rbtCASA
            // 
            this.rbtCASA.AutoSize = true;
            this.rbtCASA.Location = new System.Drawing.Point(71, 17);
            this.rbtCASA.Name = "rbtCASA";
            this.rbtCASA.Size = new System.Drawing.Size(49, 17);
            this.rbtCASA.TabIndex = 1;
            this.rbtCASA.TabStop = true;
            this.rbtCASA.Text = "Casa";
            this.rbtCASA.UseVisualStyleBackColor = true;
            // 
            // rbtDEPARTAMENTO
            // 
            this.rbtDEPARTAMENTO.AutoSize = true;
            this.rbtDEPARTAMENTO.Location = new System.Drawing.Point(277, 17);
            this.rbtDEPARTAMENTO.Name = "rbtDEPARTAMENTO";
            this.rbtDEPARTAMENTO.Size = new System.Drawing.Size(92, 17);
            this.rbtDEPARTAMENTO.TabIndex = 0;
            this.rbtDEPARTAMENTO.TabStop = true;
            this.rbtDEPARTAMENTO.Text = "Departamento";
            this.rbtDEPARTAMENTO.UseVisualStyleBackColor = true;
            // 
            // gbxACCIONES
            // 
            this.gbxACCIONES.Controls.Add(this.btnSALIR);
            this.gbxACCIONES.Controls.Add(this.btnMODIFICAR);
            this.gbxACCIONES.Controls.Add(this.btnELIMINAR);
            this.gbxACCIONES.Controls.Add(this.btnCONSULTAR);
            this.gbxACCIONES.Controls.Add(this.btnAGREGAR);
            this.gbxACCIONES.Location = new System.Drawing.Point(13, 545);
            this.gbxACCIONES.Name = "gbxACCIONES";
            this.gbxACCIONES.Size = new System.Drawing.Size(709, 57);
            this.gbxACCIONES.TabIndex = 2;
            this.gbxACCIONES.TabStop = false;
            this.gbxACCIONES.Text = "Acciones";
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(569, 19);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(134, 32);
            this.btnSALIR.TabIndex = 4;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(426, 19);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(134, 32);
            this.btnMODIFICAR.TabIndex = 3;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(286, 19);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(134, 32);
            this.btnELIMINAR.TabIndex = 2;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(146, 19);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(134, 32);
            this.btnCONSULTAR.TabIndex = 1;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 19);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(134, 32);
            this.btnAGREGAR.TabIndex = 0;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // tbxDOMICILIO
            // 
            this.tbxDOMICILIO.Location = new System.Drawing.Point(280, 100);
            this.tbxDOMICILIO.Name = "tbxDOMICILIO";
            this.tbxDOMICILIO.Size = new System.Drawing.Size(100, 20);
            this.tbxDOMICILIO.TabIndex = 1;
            // 
            // tbxTELEFONO
            // 
            this.tbxTELEFONO.Location = new System.Drawing.Point(280, 250);
            this.tbxTELEFONO.Name = "tbxTELEFONO";
            this.tbxTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.tbxTELEFONO.TabIndex = 2;
            // 
            // tbxNOMBRE
            // 
            this.tbxNOMBRE.Location = new System.Drawing.Point(280, 175);
            this.tbxNOMBRE.Name = "tbxNOMBRE";
            this.tbxNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.tbxNOMBRE.TabIndex = 3;
            // 
            // tbxCUBIERTA
            // 
            this.tbxCUBIERTA.Location = new System.Drawing.Point(280, 325);
            this.tbxCUBIERTA.Name = "tbxCUBIERTA";
            this.tbxCUBIERTA.Size = new System.Drawing.Size(100, 20);
            this.tbxCUBIERTA.TabIndex = 4;
            // 
            // tbxDESCUBIERTA
            // 
            this.tbxDESCUBIERTA.Location = new System.Drawing.Point(280, 400);
            this.tbxDESCUBIERTA.Name = "tbxDESCUBIERTA";
            this.tbxDESCUBIERTA.Size = new System.Drawing.Size(100, 20);
            this.tbxDESCUBIERTA.TabIndex = 5;
            // 
            // txtGUARDAR
            // 
            this.txtGUARDAR.Location = new System.Drawing.Point(6, 551);
            this.txtGUARDAR.Name = "txtGUARDAR";
            this.txtGUARDAR.Size = new System.Drawing.Size(134, 32);
            this.txtGUARDAR.TabIndex = 5;
            this.txtGUARDAR.Text = "Guardar";
            this.txtGUARDAR.UseVisualStyleBackColor = true;
            this.txtGUARDAR.Click += new System.EventHandler(this.txtGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(279, 551);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(134, 32);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(40, 175);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(44, 13);
            this.lblNOMBRE.TabIndex = 7;
            this.lblNOMBRE.Text = "Nombre";
            // 
            // lblDOMICILIO
            // 
            this.lblDOMICILIO.AutoSize = true;
            this.lblDOMICILIO.Location = new System.Drawing.Point(40, 100);
            this.lblDOMICILIO.Name = "lblDOMICILIO";
            this.lblDOMICILIO.Size = new System.Drawing.Size(49, 13);
            this.lblDOMICILIO.TabIndex = 8;
            this.lblDOMICILIO.Text = "Domicilio";
            // 
            // lblTELEFONO
            // 
            this.lblTELEFONO.AutoSize = true;
            this.lblTELEFONO.Location = new System.Drawing.Point(40, 250);
            this.lblTELEFONO.Name = "lblTELEFONO";
            this.lblTELEFONO.Size = new System.Drawing.Size(49, 13);
            this.lblTELEFONO.TabIndex = 9;
            this.lblTELEFONO.Text = "Telefono";
            // 
            // lblCUBIERTA
            // 
            this.lblCUBIERTA.AutoSize = true;
            this.lblCUBIERTA.Location = new System.Drawing.Point(40, 332);
            this.lblCUBIERTA.Name = "lblCUBIERTA";
            this.lblCUBIERTA.Size = new System.Drawing.Size(96, 13);
            this.lblCUBIERTA.TabIndex = 10;
            this.lblCUBIERTA.Text = "Superficie Cubierta";
            // 
            // lblDESCUBIERTA
            // 
            this.lblDESCUBIERTA.AutoSize = true;
            this.lblDESCUBIERTA.Location = new System.Drawing.Point(40, 407);
            this.lblDESCUBIERTA.Name = "lblDESCUBIERTA";
            this.lblDESCUBIERTA.Size = new System.Drawing.Size(114, 13);
            this.lblDESCUBIERTA.TabIndex = 11;
            this.lblDESCUBIERTA.Text = "Superficie Descubierta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 614);
            this.Controls.Add(this.gbxACCIONES);
            this.Controls.Add(this.gbxCARGA);
            this.Controls.Add(this.dgwALQUILERES);
            this.Name = "Form1";
            this.Text = "      ";
            ((System.ComponentModel.ISupportInitialize)(this.dgwALQUILERES)).EndInit();
            this.gbxCARGA.ResumeLayout(false);
            this.gbxCARGA.PerformLayout();
            this.pnlTIPO.ResumeLayout(false);
            this.pnlTIPO.PerformLayout();
            this.gbxACCIONES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwALQUILERES;
        private System.Windows.Forms.GroupBox gbxCARGA;
        private System.Windows.Forms.GroupBox gbxACCIONES;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Panel pnlTIPO;
        private System.Windows.Forms.RadioButton rbtCASA;
        private System.Windows.Forms.RadioButton rbtDEPARTAMENTO;
        private System.Windows.Forms.TextBox tbxNOMBRE;
        private System.Windows.Forms.TextBox tbxTELEFONO;
        private System.Windows.Forms.TextBox tbxDOMICILIO;
        private System.Windows.Forms.TextBox tbxDESCUBIERTA;
        private System.Windows.Forms.TextBox tbxCUBIERTA;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button txtGUARDAR;
        private System.Windows.Forms.Label lblDESCUBIERTA;
        private System.Windows.Forms.Label lblCUBIERTA;
        private System.Windows.Forms.Label lblTELEFONO;
        private System.Windows.Forms.Label lblDOMICILIO;
        private System.Windows.Forms.Label lblNOMBRE;
    }
}

