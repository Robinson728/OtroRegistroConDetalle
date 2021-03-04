
namespace OtroRegistroConDetalle.UI.Consultas
{
    partial class rConsultas
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
            this.FiltroFechacheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.FechaDesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaHastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechapanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrarTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fechapanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroFechacheckBox
            // 
            this.FiltroFechacheckBox.AutoSize = true;
            this.FiltroFechacheckBox.Location = new System.Drawing.Point(12, 24);
            this.FiltroFechacheckBox.Name = "FiltroFechacheckBox";
            this.FiltroFechacheckBox.Size = new System.Drawing.Size(134, 19);
            this.FiltroFechacheckBox.TabIndex = 0;
            this.FiltroFechacheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechacheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(52, 60);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 23);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // FechaDesdedateTimePicker
            // 
            this.FechaDesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDesdedateTimePicker.Location = new System.Drawing.Point(79, 7);
            this.FechaDesdedateTimePicker.Name = "FechaDesdedateTimePicker";
            this.FechaDesdedateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.FechaDesdedateTimePicker.TabIndex = 3;
            // 
            // FechaHastadateTimePicker
            // 
            this.FechaHastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaHastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHastadateTimePicker.Location = new System.Drawing.Point(283, 8);
            this.FechaHastadateTimePicker.Name = "FechaHastadateTimePicker";
            this.FechaHastadateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.FechaHastadateTimePicker.TabIndex = 4;
            // 
            // Fechapanel
            // 
            this.Fechapanel.Controls.Add(this.label2);
            this.Fechapanel.Controls.Add(this.label3);
            this.Fechapanel.Controls.Add(this.FechaHastadateTimePicker);
            this.Fechapanel.Controls.Add(this.FechaDesdedateTimePicker);
            this.Fechapanel.Location = new System.Drawing.Point(192, 12);
            this.Fechapanel.Name = "Fechapanel";
            this.Fechapanel.Size = new System.Drawing.Size(383, 37);
            this.Fechapanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // FiltrarTextBox
            // 
            this.FiltrarTextBox.Location = new System.Drawing.Point(192, 60);
            this.FiltrarTextBox.Name = "FiltrarTextBox";
            this.FiltrarTextBox.Size = new System.Drawing.Size(383, 23);
            this.FiltrarTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(447, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltrarTextBox);
            this.Controls.Add(this.Fechapanel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroFechacheckBox);
            this.Name = "rConsultas";
            this.Text = "Consultas";
            this.Fechapanel.ResumeLayout(false);
            this.Fechapanel.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}