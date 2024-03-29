using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaForge.Utilities;

namespace MetaForge
{
    public partial class Main : Form
    {
        
        object[] GetMetadata(PropertyItem data)
        {
            object[] item = new object[2];
            item[0] = Dictionaries.MetadataNames[data.Id];
            switch (data.Id)
            {
                case 2:
                    item[1] = Bytes2Degrees(data.Value);
                    break;
                case 4:
                    item[1] = Bytes2Degrees(data.Value);
                    break;
                case 5:
                    item[1] = Dictionaries.AltitudRef[int.Parse(DecodePropertyValue(data))];
                    break;
                case 6:
                    item[1] = Bytes2Degrees(data.Value);
                    break;
                case 274:
                    item[1] = Dictionaries.Orientacion[int.Parse(DecodePropertyValue(data))];
                    break;
                default:
                    item[1] = DecodePropertyValue(data);
                    break;
            }
            return item;
        }
        void ListMetadata()
        {
            Image image = (Bitmap)pbImage.Image.Clone();
            foreach (PropertyItem property in image.PropertyItems)
            {
                try
                {
                    dgvMetadatos.Rows.Add(GetMetadata(property));
                }
                catch
                { 
                    //
                }
            }
            try
            {
                double latitud = Bytes2Degrees(image.GetPropertyItem(2).Value, image.GetPropertyItem(1).Value);
                double longitud = Bytes2Degrees(image.GetPropertyItem(4).Value, image.GetPropertyItem(3).Value);
                string URLGoogleMaps = $"https://www.google.com/maps/@{latitud},{longitud}z?entry=ttu";
                lMaps.Text = URLGoogleMaps;
            }
            catch
            {
                lMaps.Text = "";
            }
        }

        string DecodePropertyValue(PropertyItem property)
        {
            // La interpretación del valor depende del tipo de la propiedad
            // Este es un ejemplo básico que intenta decodificar valores comunes
            switch (property.Type)
            {
                case 1: // byte
                    if (property.Len == 1)
                    {
                        return property.Value[0].ToString();
                    }
                    return BitConverter.ToString(property.Value);
                case 2: // ASCII string
                    return Encoding.ASCII.GetString(property.Value).Trim('\0');
                case 3: // short
                    if (property.Len == 2)
                    {
                        return BitConverter.ToInt16(property.Value, 0).ToString();
                    }
                    break;
                case 4: // long
                    if (property.Len == 4)
                    {
                        return BitConverter.ToInt32(property.Value, 0).ToString();
                    }
                    break;
                case 5: // rational
                        // Un rational se compone de dos longs, el numerador y el denominador
                    if (property.Len == 8)
                    {
                        uint numerator = BitConverter.ToUInt32(property.Value, 0);
                        uint denominator = BitConverter.ToUInt32(property.Value, 4);
                        return $"{numerator}/{denominator}";
                    }
                    break;
                    // Puedes añadir más casos para otros tipos si es necesario
            }
            return "No se pudo interpretar el valor";
        }

        double Bytes2Degrees(byte[] bytes, byte[] orientation)
        {
            // Convierte los bytes en grados, minutos y segundos
            double degrees = BitConverter.ToInt32(bytes, 0) / (double)BitConverter.ToInt32(bytes, 4);
            double minutes = BitConverter.ToInt32(bytes, 8) / (double)BitConverter.ToInt32(bytes, 12);
            double seconds = BitConverter.ToInt32(bytes, 16) / (double)BitConverter.ToInt32(bytes, 20);

            degrees += (minutes / 60) + (seconds / 3600);
            return orientation[0] == 'W' || orientation[0] == 'S' ? -degrees: degrees;
        }
        double Bytes2Degrees(byte[] bytes)
        {
            // Convierte los bytes en grados, minutos y segundos
            double degrees = BitConverter.ToInt32(bytes, 0) / (double)BitConverter.ToInt32(bytes, 4);
            double minutes = BitConverter.ToInt32(bytes, 8) / (double)BitConverter.ToInt32(bytes, 12);
            double seconds = BitConverter.ToInt32(bytes, 16) / (double)BitConverter.ToInt32(bytes, 20);

            // Convierte a grados decimales
            return degrees + (minutes / 60) + (seconds / 3600);
        }
        public Main()
        {
            InitializeComponent();
        }

        private void pbImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbURLImage.Text = openFileDialog1.FileName;
                tbURLImage_KeyPress(btnUrl, new KeyPressEventArgs((char)13));
            }
        }


        private void pbImage_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lMaps.Text != "SIN UBICACION")
            {
                Clipboard.SetText(lMaps.Text);
                toolTip1.Show("Se ha copiado la liga", btnCopy, 3000);
            }
        }

        private void tbURLImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (System.IO.File.Exists(tbURLImage.Text))
                {
                    try
                    {
                        pbImage.Image = Image.FromFile(tbURLImage.Text);
                        ListMetadata();
                    }
                    catch
                    {
                        MessageBox.Show("No se puede cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La ruta no es un archivo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
