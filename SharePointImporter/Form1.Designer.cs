namespace SharePointImporter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSQLServer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEstadoSQL = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblCountInsert = new System.Windows.Forms.Label();
            this.lblCountUpdate = new System.Windows.Forms.Label();
            this.lblInserts = new System.Windows.Forms.Label();
            this.lblUpdates = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.RosyBrown;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(108, 86);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(262, 23);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Desconectado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://hartrodtperu.sharepoint.com/Prueba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL de Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Lista";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(97, 52);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(375, 20);
            this.txtLista.TabIndex = 1;
            this.txtLista.Text = "ListaPrueba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Items en la lista:";
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(376, 119);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(101, 20);
            this.txtItems.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstadoSQL);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSQLServer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtQuery);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origen SQL Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadena de Conexión SQL";
            // 
            // txtSQLServer
            // 
            this.txtSQLServer.Location = new System.Drawing.Point(142, 19);
            this.txtSQLServer.Name = "txtSQLServer";
            this.txtSQLServer.Size = new System.Drawing.Size(329, 20);
            this.txtSQLServer.TabIndex = 1;
            this.txtSQLServer.Text = "Data Source = AINTBDPER01\\AINTBDDESA; Initial Catalog = ERP_aenor_prod_jul2016; I" +
    "ntegrated Security = True";
            this.txtSQLServer.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Conectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEstadoSQL
            // 
            this.lblEstadoSQL.BackColor = System.Drawing.Color.RosyBrown;
            this.lblEstadoSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoSQL.ForeColor = System.Drawing.Color.White;
            this.lblEstadoSQL.Location = new System.Drawing.Point(109, 156);
            this.lblEstadoSQL.Name = "lblEstadoSQL";
            this.lblEstadoSQL.Size = new System.Drawing.Size(262, 23);
            this.lblEstadoSQL.TabIndex = 4;
            this.lblEstadoSQL.Text = "Desconectado";
            this.lblEstadoSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Iniciar Sync:   SQL--->Sharepoint Online";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Consulta SQL";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(6, 64);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(466, 86);
            this.txtQuery.TabIndex = 1;
            // 
            // lblCountInsert
            // 
            this.lblCountInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountInsert.Location = new System.Drawing.Point(255, 393);
            this.lblCountInsert.Name = "lblCountInsert";
            this.lblCountInsert.Size = new System.Drawing.Size(100, 23);
            this.lblCountInsert.TabIndex = 3;
            this.lblCountInsert.Text = "0";
            // 
            // lblCountUpdate
            // 
            this.lblCountUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountUpdate.Location = new System.Drawing.Point(372, 393);
            this.lblCountUpdate.Name = "lblCountUpdate";
            this.lblCountUpdate.Size = new System.Drawing.Size(100, 23);
            this.lblCountUpdate.TabIndex = 3;
            this.lblCountUpdate.Text = "0";
            // 
            // lblInserts
            // 
            this.lblInserts.AutoSize = true;
            this.lblInserts.Location = new System.Drawing.Point(256, 371);
            this.lblInserts.Name = "lblInserts";
            this.lblInserts.Size = new System.Drawing.Size(56, 13);
            this.lblInserts.TabIndex = 4;
            this.lblInserts.Text = "Insertados";
            // 
            // lblUpdates
            // 
            this.lblUpdates.AutoSize = true;
            this.lblUpdates.Location = new System.Drawing.Point(369, 371);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(67, 13);
            this.lblUpdates.TabIndex = 4;
            this.lblUpdates.Text = "Actualizados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 433);
            this.Controls.Add(this.lblUpdates);
            this.Controls.Add(this.lblInserts);
            this.Controls.Add(this.lblCountUpdate);
            this.Controls.Add(this.lblCountInsert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SharePoint Importer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSQLServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEstadoSQL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountInsert;
        private System.Windows.Forms.Label lblCountUpdate;
        private System.Windows.Forms.Label lblInserts;
        private System.Windows.Forms.Label lblUpdates;
    }
}

