using Microsoft.Win32;

namespace HardwareSO
{
    public class Registro
    {
        public static string Regedit(string fuente, string llave, int opc, string valor = "")
        {
            try
            {
                switch (opc)
                {
                    case 1:
                        return Registry.GetValue(fuente, llave, "Registro no encontrado.").ToString();

                    case 2:
                        Registry.SetValue(fuente, llave, valor);
                        return Registry.GetValue(fuente, llave, "Registro no encontrado.").ToString();
                    case 3:
                        Registry.SetValue(fuente, llave, "Sin definir.");
                        return Registry.GetValue(fuente, llave, "Registro no encontrado.").ToString();
                }
                return "Registro no encontrado.";
            }
            catch { return "Registro no encontrado."; }
        }
    }
}
