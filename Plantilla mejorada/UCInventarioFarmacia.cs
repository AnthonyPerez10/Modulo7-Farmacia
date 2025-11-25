using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    public partial class UCInventarioFarmacia: UserControl
    {
        private Label lblTitulo;
        private Button btnInventario;
        private Button btnDispensación;
        private Label lblTitulo2;
        private Label lblTitulo3;
        private Panel pnlContenedorTitulo;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorTitulo = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnDispensación = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.pnlContenedorTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(319, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Farmacia";
            // 
            // pnlContenedorTitulo
            // 
            this.pnlContenedorTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.pnlContenedorTitulo.Controls.Add(this.lblTitulo);
            this.pnlContenedorTitulo.Location = new System.Drawing.Point(-11, 0);
            this.pnlContenedorTitulo.Name = "pnlContenedorTitulo";
            this.pnlContenedorTitulo.Size = new System.Drawing.Size(867, 101);
            this.pnlContenedorTitulo.TabIndex = 1;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Location = new System.Drawing.Point(121, 523);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(229, 48);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnDispensación
            // 
            this.btnDispensación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.btnDispensación.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispensación.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDispensación.Location = new System.Drawing.Point(483, 523);
            this.btnDispensación.Name = "btnDispensación";
            this.btnDispensación.Size = new System.Drawing.Size(229, 48);
            this.btnDispensación.TabIndex = 3;
            this.btnDispensación.Text = "Dispensación";
            this.btnDispensación.UseVisualStyleBackColor = false;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(77, 180);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(137, 20);
            this.lblTitulo2.TabIndex = 4;
            this.lblTitulo2.Text = "Lista de inventario: ";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(524, 180);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(153, 20);
            this.lblTitulo3.TabIndex = 5;
            this.lblTitulo3.Text = "Lista de dispensación:\r\n";
            // 
            // UCInventarioFarmacia
            // 
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.btnDispensación);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.pnlContenedorTitulo);
            this.Name = "UCInventarioFarmacia";
            this.Size = new System.Drawing.Size(856, 609);
            this.pnlContenedorTitulo.ResumeLayout(false);
            this.pnlContenedorTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Realizar aqui dentro todo el codigo de su interfaz

    }
}
