using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Farm_Tracker
{
    public static class Utility_Functions
    {
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public static byte[] ImageToByteArray(Image img, PictureBox picture)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (picture.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
        public static Image GetDataToImage(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new ImageConverter();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public static void createEmailMessage(string subjectString, string messageString, List<string> emails)
        {
            string server = "mail.highlandbeef.com";
            
            string to = "";
            string from = "postmaster@highlandbeef.com";

            for (int i = 0; i < emails.Count; i++)
            {
                to = emails[i].ToString().Trim();

                MailMessage message = new MailMessage(from, to);
                
                message.Subject = subjectString;
                message.Body = messageString;
                SmtpClient client = new SmtpClient(server);
                // Credentials are necessary if the server requires the client  
                // to authenticate before it will send e-mail on the client's behalf.
                client.Port = 2525;
                client.Credentials = CredentialCache.DefaultNetworkCredentials;

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in createEmailMessage(): {0}",
                          ex.ToString());
                }
            }
        }
        public static List<string> get_Email_List()
        {
            List<string> emails = new List<string>();
            var objects = JArray.Parse(API.retrieveAllOperatorEmails());
            foreach (JObject root in objects)
            {
                emails.Add(root.GetValue("Email").ToString().Trim());
            }
            return emails;
        }        
        public static List<string> get_Email_List(string postion)
        {
            List<string> emails = new List<string>();
            var objects = JArray.Parse(API.retrieveAllOfOnePostionsEmails(postion));
            foreach (JObject root in objects)
            {
                emails.Add(root.GetValue("Email").ToString().Trim());
            }
            //objects = JArray.Parse(API.retrieveAllOfOnePostionsEmails("Owner"));
            //foreach (JObject root in objects)
            //{
            //    emails.Add(root.GetValue("Email").ToString().Trim());
            //}
            return emails;
        }        
    }
}
