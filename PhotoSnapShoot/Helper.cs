﻿using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PhotoSnapShoot
{
    class Helper
    {
        //Block Memory Leak
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr handle);
        public static BitmapSource Bs;
        public static IntPtr Ip;
        public static BitmapSource LoadBitmap(System.Drawing.Bitmap source)
        {

            Ip = source.GetHbitmap();

            Bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(Ip, IntPtr.Zero, System.Windows.Int32Rect.Empty,

                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

            DeleteObject(Ip);

            return Bs;

        }
        public static bool SaveImageCapture(BitmapSource bitmap, String temporalFileName)
        {
            try
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.QualityLevel = 100;


                //// Configure save file dialog box
                //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                //dlg.InitialDirectory = ValuesOdon.imagenesUsuarios;
                //dlg.FileName = "Profile"; // Default file name
                //dlg.DefaultExt = ".Jpg"; // Default file extension
                //dlg.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                //// Show save file dialog box
                //Nullable<bool> result = dlg.ShowDialog();

                //// Process save file dialog box results
                //if (result == true)
                //{
                // Save Image
                string filename = temporalFileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                encoder.Save(fstream);
                fstream.Close();
                //}
                return true;
            }
            catch (Exception sex)
            {
                MessageBox.Show("Error ({0}) : {1}" + sex.Source + sex.Message, "Error Interno. Intente salvar la imagen de nuevo");
                return false;
            }

        }
    }
}
