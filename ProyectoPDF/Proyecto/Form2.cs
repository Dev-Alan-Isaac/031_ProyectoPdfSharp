using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Preview : Form
    {
        public Preview(string client, string employee)
        {
            InitializeComponent();
            string HTMLTemplated = Properties.Resources.Index;
            Bitmap Image = Properties.Resources.shop_Logo;
            string base64ImageRepresentation = string.Empty;
            // Convert the image to a byte array
            using (MemoryStream m = new MemoryStream())
            {
                Image.Save(m, Image.RawFormat);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 string
                base64ImageRepresentation = Convert.ToBase64String(imageBytes);
            }

            HTMLTemplated = HTMLTemplated.Replace("@Client", client);
            HTMLTemplated = HTMLTemplated.Replace("@Employee", employee);
            HTMLTemplated = HTMLTemplated.Replace("@BASE64", base64ImageRepresentation);
            HTMLTemplated = HTMLTemplated.Replace("@Date", DateTime.Now.ToString());

            webBrowser1.DocumentText = HTMLTemplated;
        }
    }
}
