namespace HardwareSO
{
    public class Disco
    {
        public static string unidadDisco()
        {

            DriveInfo[] Discos = DriveInfo.GetDrives();
            string discos = "";
            foreach (DriveInfo disk in Discos)
            {
                discos += ($"Drive {disk.Name} \n\r" +
                $"Drive type: {disk.DriveType} \n\r"
                );
                if (disk.IsReady == true)
                {
                    discos += ($"Etiqueta de volumen: {disk.VolumeLabel} \n\r" +
                        $"Sistema de archivos: {disk.DriveFormat} \n\r" +
                        $"Espacio disponible para el usuario actual: {Convert.ToDecimal(disk.AvailableFreeSpace) / 1073741824} GB \n\r" +
                        $"Espacio total disponible: {Convert.ToDecimal(disk.TotalFreeSpace) / 1073741824} GB \n\r" +
                        $"Tamaño total de la unidad: {Convert.ToDecimal(disk.TotalSize) / 1073741824} GB \n\r"
                        );
                }
            }
            return discos;
        }

    }
}