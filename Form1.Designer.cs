namespace laboratorio3_gestion_tareas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbTareaUsuario = new System.Windows.Forms.ComboBox();
            this.dgvPanelTareas = new System.Windows.Forms.DataGridView();
            this.lblPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.boxAsignacion = new System.Windows.Forms.GroupBox();
            this.boxFiltros = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltroUsuario = new System.Windows.Forms.ComboBox();
            this.cmbFiltroTarea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelTareas)).BeginInit();
            this.boxAsignacion.SuspendLayout();
            this.boxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(339, 64);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(306, 29);
            this.cmbUsuario.TabIndex = 1;
            // 
            // cmbTareaUsuario
            // 
            this.cmbTareaUsuario.FormattingEnabled = true;
            this.cmbTareaUsuario.Location = new System.Drawing.Point(50, 85);
            this.cmbTareaUsuario.Name = "cmbTareaUsuario";
            this.cmbTareaUsuario.Size = new System.Drawing.Size(295, 24);
            this.cmbTareaUsuario.TabIndex = 2;
            // 
            // dgvPanelTareas
            // 
            this.dgvPanelTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanelTareas.Location = new System.Drawing.Point(35, 452);
            this.dgvPanelTareas.Name = "dgvPanelTareas";
            this.dgvPanelTareas.RowHeadersWidth = 51;
            this.dgvPanelTareas.RowTemplate.Height = 24;
            this.dgvPanelTareas.Size = new System.Drawing.Size(838, 132);
            this.dgvPanelTareas.TabIndex = 3;
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(46, 419);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(125, 21);
            this.lblPanel.TabIndex = 4;
            this.lblPanel.Text = "Panel de tareas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarea";
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAsignar.Location = new System.Drawing.Point(701, 50);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(106, 46);
            this.btnAsignar.TabIndex = 7;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseMnemonic = false;
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // boxAsignacion
            // 
            this.boxAsignacion.Controls.Add(this.btnAsignar);
            this.boxAsignacion.Controls.Add(this.label1);
            this.boxAsignacion.Controls.Add(this.cmbUsuario);
            this.boxAsignacion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAsignacion.Location = new System.Drawing.Point(35, 21);
            this.boxAsignacion.Name = "boxAsignacion";
            this.boxAsignacion.Size = new System.Drawing.Size(838, 134);
            this.boxAsignacion.TabIndex = 8;
            this.boxAsignacion.TabStop = false;
            this.boxAsignacion.Text = "Asignación de tareas";
            // 
            // boxFiltros
            // 
            this.boxFiltros.Controls.Add(this.button1);
            this.boxFiltros.Controls.Add(this.label6);
            this.boxFiltros.Controls.Add(this.cmbPrioridad);
            this.boxFiltros.Controls.Add(this.label5);
            this.boxFiltros.Controls.Add(this.label4);
            this.boxFiltros.Controls.Add(this.label3);
            this.boxFiltros.Controls.Add(this.cmbFiltroUsuario);
            this.boxFiltros.Controls.Add(this.cmbFiltroTarea);
            this.boxFiltros.Controls.Add(this.dateTimePicker1);
            this.boxFiltros.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFiltros.Location = new System.Drawing.Point(35, 193);
            this.boxFiltros.Name = "boxFiltros";
            this.boxFiltros.Size = new System.Drawing.Size(838, 189);
            this.boxFiltros.TabIndex = 9;
            this.boxFiltros.TabStop = false;
            this.boxFiltros.Text = "Filtrar tareas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(701, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(15, 137);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(255, 29);
            this.cmbPrioridad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarea";
            // 
            // cmbFiltroUsuario
            // 
            this.cmbFiltroUsuario.FormattingEnabled = true;
            this.cmbFiltroUsuario.Location = new System.Drawing.Point(295, 65);
            this.cmbFiltroUsuario.Name = "cmbFiltroUsuario";
            this.cmbFiltroUsuario.Size = new System.Drawing.Size(255, 29);
            this.cmbFiltroUsuario.TabIndex = 4;
            // 
            // cmbFiltroTarea
            // 
            this.cmbFiltroTarea.FormattingEnabled = true;
            this.cmbFiltroTarea.Location = new System.Drawing.Point(15, 60);
            this.cmbFiltroTarea.Name = "cmbFiltroTarea";
            this.cmbFiltroTarea.Size = new System.Drawing.Size(255, 29);
            this.cmbFiltroTarea.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.dgvPanelTareas);
            this.Controls.Add(this.cmbTareaUsuario);
            this.Controls.Add(this.boxAsignacion);
            this.Controls.Add(this.boxFiltros);
            this.Name = "Form1";
            this.Text = "Panel de tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelTareas)).EndInit();
            this.boxAsignacion.ResumeLayout(false);
            this.boxAsignacion.PerformLayout();
            this.boxFiltros.ResumeLayout(false);
            this.boxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbTareaUsuario;
        private System.Windows.Forms.DataGridView dgvPanelTareas;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox boxAsignacion;
        private System.Windows.Forms.GroupBox boxFiltros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltroUsuario;
        private System.Windows.Forms.ComboBox cmbFiltroTarea;
        private System.Windows.Forms.Button button1;
    }
}

