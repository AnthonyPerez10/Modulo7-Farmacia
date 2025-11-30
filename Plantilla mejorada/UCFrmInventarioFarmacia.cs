using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    public partial class UCFrmInventarioFarmacia : UserControl
    {
        public UCFrmInventarioFarmacia()
        {
            InitializeComponent();
        }

        //Conexion de interfaz de inventario 
        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Limpiar panel antes de cargar UCInventarioFarmacia
            //pnlContent.Controls.Clear(); -- Error de conexion PanelContenedor

            // Crear instancia del UserControl
            UCInventarioFarmacia ucInventario = new UCInventarioFarmacia();

            // Ajustar tamaño y dock para que llene el panel
            ucInventario.Dock = DockStyle.Fill;

            // Agregar User control al principal
            //pnlContent.Controls.Add(ucInventario); --- Marca Error 
        }

        //Conexion a interfaz Dispensacion UCFrmInvetarioFarmaica
        private void btnDispensación_Click(object sender, EventArgs e)
        {
            // Limpiar panel antes de cargar UCInventarioFarmacia
            //pnlContent.Controls.Clear(); -- Error de conexion PanelContenedor

            // Crear instancia del UserControl
            UCFrmInventarioFarmacia ucInventario = new UCFrmInventarioFarmacia();

            // Ajustar tamaño y dock para que llene el panel
            ucInventario.Dock = DockStyle.Fill;

            // Agregar User control al principal
            //pnlContent.Controls.Add(ucInventario); --- Marca Error 
        }

    }
}
