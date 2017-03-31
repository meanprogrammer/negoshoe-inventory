using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputPath = @"C:\Users\vd2\OUTPUT_IMG\";
            string path = @"C:\Users\vd2\Pleiades_large.jpg";
            ImageResizeHelper.ProcessResizeImage(path);
            GetImageAndSave(outputPath);

        }


        public static void GetImageAndSave(string outputPath)
        {
            using (SqlConnection connection = new SqlConnection(@"Data source=.\SQL2012;Initial Catalog=NegoShoeInventory;Integrated Security=true;"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM ItemWithImage", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var bn = reader.GetSqlBinary(4);

                        byte[] imgarr = (byte[])reader["Image"];
                        File.WriteAllBytes(string.Concat(outputPath,"Pleiades_large.jpg"), bn.Value);

                    }
                }
            }
        }

  

       



        public static bool SaveImageToDatabase(byte[] img, string filename, string extension)
        {
            /*
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, ImageFormat.Png); // change to other format
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[1000000];
            tmpStream.Read(imgBytes, 0, 1000000);
            */

            using (SqlConnection connection = new SqlConnection(@"Data source=.\SQL2012;Initial Catalog=NegoShoeInventory;Integrated Security=true;")) {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ItemWithImage(Name,Filename,Extension,Image) VALUES (@name,@filename,@extension,@Image)", connection))
                {
                    connection.Open();
                    SqlParameter p1 = new SqlParameter("@name", Guid.NewGuid().ToString());
                    p1.DbType = System.Data.DbType.String;
                    SqlParameter p2 = new SqlParameter();
                    p2.DbType = System.Data.DbType.Binary;
                    p2.ParameterName = "@Image";
                    p2.Value = img
;

                    SqlParameter p3 = new SqlParameter("@filename", filename);
                    p3.DbType = System.Data.DbType.String;

                    SqlParameter p4 = new SqlParameter("@extension", extension);
                    p4.DbType = System.Data.DbType.String;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
