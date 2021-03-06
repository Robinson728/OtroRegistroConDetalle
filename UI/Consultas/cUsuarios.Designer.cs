
namespace OtroRegistroConDetalle.UI.Consultas
{
    partial class cUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cUsuarios));
            this.FiltroFechacheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.FechaDesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaHastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechapanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrarTextBox = new System.Windows.Forms.TextBox();
            this.EsActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultasDataGridView = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.Fechapanel.SuspendLayout();
            this.EsActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroFechacheckBox
            // 
            this.FiltroFechacheckBox.AutoSize = true;
            this.FiltroFechacheckBox.Location = new System.Drawing.Point(2, 22);
            this.FiltroFechacheckBox.Name = "FiltroFechacheckBox";
            this.FiltroFechacheckBox.Size = new System.Drawing.Size(134, 19);
            this.FiltroFechacheckBox.TabIndex = 0;
            this.FiltroFechacheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechacheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Álias",
            "Nombre",
            "Email",
            "Rol"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(42, 56);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 23);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // FechaDesdedateTimePicker
            // 
            this.FechaDesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDesdedateTimePicker.Location = new System.Drawing.Point(48, 9);
            this.FechaDesdedateTimePicker.Name = "FechaDesdedateTimePicker";
            this.FechaDesdedateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.FechaDesdedateTimePicker.TabIndex = 3;
            // 
            // FechaHastadateTimePicker
            // 
            this.FechaHastadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaHastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaHastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHastadateTimePicker.Location = new System.Drawing.Point(203, 9);
            this.FechaHastadateTimePicker.Name = "FechaHastadateTimePicker";
            this.FechaHastadateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.FechaHastadateTimePicker.TabIndex = 4;
            // 
            // Fechapanel
            // 
            this.Fechapanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechapanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechapanel.Controls.Add(this.label2);
            this.Fechapanel.Controls.Add(this.label3);
            this.Fechapanel.Controls.Add(this.FechaHastadateTimePicker);
            this.Fechapanel.Controls.Add(this.FechaDesdedateTimePicker);
            this.Fechapanel.Location = new System.Drawing.Point(169, 7);
            this.Fechapanel.Name = "Fechapanel";
            this.Fechapanel.Size = new System.Drawing.Size(308, 42);
            this.Fechapanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // FiltrarTextBox
            // 
            this.FiltrarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrarTextBox.Location = new System.Drawing.Point(169, 55);
            this.FiltrarTextBox.Name = "FiltrarTextBox";
            this.FiltrarTextBox.Size = new System.Drawing.Size(308, 23);
            this.FiltrarTextBox.TabIndex = 6;
            // 
            // EsActivoGroupBox
            // 
            this.EsActivoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EsActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.EsActivoGroupBox.Location = new System.Drawing.Point(481, -1);
            this.EsActivoGroupBox.Name = "EsActivoGroupBox";
            this.EsActivoGroupBox.Size = new System.Drawing.Size(91, 80);
            this.EsActivoGroupBox.TabIndex = 7;
            this.EsActivoGroupBox.TabStop = false;
            this.EsActivoGroupBox.Text = "esActivo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(13, 56);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(72, 19);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(14, 35);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(64, 19);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(14, 16);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(56, 19);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(578, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 71);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultasDataGridView
            // 
            this.ConsultasDataGridView.AllowUserToAddRows = false;
            this.ConsultasDataGridView.AllowUserToDeleteRows = false;
            this.ConsultasDataGridView.AllowUserToOrderColumns = true;
            this.ConsultasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDataGridView.Location = new System.Drawing.Point(2, 84);
            this.ConsultasDataGridView.Name = "ConsultasDataGridView";
            this.ConsultasDataGridView.ReadOnly = true;
            this.ConsultasDataGridView.RowTemplate.Height = 25;
            this.ConsultasDataGridView.Size = new System.Drawing.Size(658, 288);
            this.ConsultasDataGridView.TabIndex = 9;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(2, 378);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(100, 45);
            this.ImprimirButton.TabIndex = 10;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 428);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.ConsultasDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsActivoGroupBox);
            this.Controls.Add(this.FiltrarTextBox);
            this.Controls.Add(this.Fechapanel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroFechacheckBox);
            this.MinimumSize = new System.Drawing.Size(662, 300);
            this.Name = "cUsuarios";
            this.Text = "Consulta de Usuarios";
            this.Fechapanel.ResumeLayout(false);
            this.Fechapanel.PerformLayout();
            this.EsActivoGroupBox.ResumeLayout(false);
            this.EsActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroFechacheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.DateTimePicker FechaDesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaHastadateTimePicker;
        private System.Windows.Forms.Panel Fechapanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FiltrarTextBox;
        private System.Windows.Forms.GroupBox EsActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultasDataGridView;
        private System.Windows.Forms.Button ImprimirButton;
    }
}