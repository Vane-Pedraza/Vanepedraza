using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Tarea
{
    internal class Accion
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void LlenarCombo(String consulta, ComboBox combo, string id, string campo)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);

            DataRow r = dt.NewRow();
            r[0] = 0;
            r[1] = "Todos Los Datos";
            dt.Rows.InsertAt(r, 0);

            if (dt == null)
            {
                return;
            }
            combo.Items.Clear();
            combo.DataSource = dt;
            combo.ValueMember = id;
            combo.DisplayMember = campo;

        }
    }
}
