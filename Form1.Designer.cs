
namespace ComparadorDeMatriz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvUno = new System.Windows.Forms.DataGridView();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dtgvTras = new System.Windows.Forms.DataGridView();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUno
            // 
            this.dtgvUno.AllowUserToAddRows = false;
            this.dtgvUno.AllowUserToDeleteRows = false;
            this.dtgvUno.AllowUserToResizeRows = false;
            this.dtgvUno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvUno.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUno.ColumnHeadersVisible = false;
            this.dtgvUno.Location = new System.Drawing.Point(12, 61);
            this.dtgvUno.Name = "dtgvUno";
            this.dtgvUno.RowHeadersVisible = false;
            this.dtgvUno.RowHeadersWidth = 51;
            this.dtgvUno.RowTemplate.Height = 29;
            this.dtgvUno.Size = new System.Drawing.Size(318, 220);
            this.dtgvUno.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(245, 317);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(315, 43);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(336, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Dimensionar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dtgvTras
            // 
            this.dtgvTras.AllowUserToAddRows = false;
            this.dtgvTras.AllowUserToDeleteRows = false;
            this.dtgvTras.AllowUserToResizeRows = false;
            this.dtgvTras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvTras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTras.ColumnHeadersVisible = false;
            this.dtgvTras.Location = new System.Drawing.Point(488, 61);
            this.dtgvTras.Name = "dtgvTras";
            this.dtgvTras.ReadOnly = true;
            this.dtgvTras.RowHeadersVisible = false;
            this.dtgvTras.RowHeadersWidth = 51;
            this.dtgvTras.RowTemplate.Height = 29;
            this.dtgvTras.Size = new System.Drawing.Size(318, 220);
            this.dtgvTras.TabIndex = 4;
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(347, 61);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(125, 27);
            this.txtFilas.TabIndex = 6;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(347, 131);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(125, 27);
            this.txtColumnas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Columnas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.dtgvTras);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.dtgvUno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUno;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dtgvTras;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

