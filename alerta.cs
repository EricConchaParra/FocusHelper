using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusHelper
{
    public static class alerta
    {
        public static void informacion(string texto)
        {
            MessageBox.Show(
            texto,
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        public static void debug(string texto)
        {
            MessageBox.Show(
            texto,
            "Debug",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }


        public static void error(string texto)
        {
            MessageBox.Show(
            texto,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        public static void advertencia(string texto)
        {
            MessageBox.Show(
            texto,
            "Advertencia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

        public static DialogResult PreguntaOkCancel(string texto)
        {
            DialogResult respuesta = MessageBox.Show(
                                        texto,
                                        "Responda por favor",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Question);
            return respuesta;

        }

    }
}
