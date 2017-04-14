using Excel;
using NegoShoePH.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string imageBasePath = @"C:\Users\vd2\Source\Repos\negoshoe-inventory\NegoshoeInventory\ImagesUpload";
            string imageBasePath = @"C:\Users\Valiant\Desktop\Item Pictures";
            //string filePath = "Upload_Template_N.xlsx";
            string filePath = "test1.xlsx";
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

            //IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(stream);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            reader.IsFirstRowAsColumnNames = true;
            int ctr = 0;
            
            while (reader.Read())
            {
                if (ctr == 0) { ctr++; reader.Read(); }
                string itemName = reader.GetString(0);
                string description = reader.GetString(1);
                string brand = reader.GetString(2);
                string type = reader.GetString(3);
                
                string totalQuantity = reader.GetString(4);
                string officeQuantity = reader.GetString(5);
                string houseQuantity = reader.GetString(6);
                string filename = reader.GetString(7);
                string remarks = reader.GetString(8);
                byte[] imgBinary =ImageResizeHelper.ProcessResizeImage(Path.Combine(imageBasePath, filename));
                var base64image = Convert.ToBase64String(imgBinary);
                //string imageBase64 = reader.GetString(6);

                string sql= 
                    "INSERT INTO Items([ItemName],[Brand],[ProductType],[Description],[TotalQuantity],[OfficeQuantity],[HouseQuantity],[Filename],[ImageBase64],[Remarks]) "+
                    "VALUES('"+itemName+"',"+brand+","+type+",'"+description+"',"+totalQuantity+","+officeQuantity+","+houseQuantity+",'"+filename+"','"+base64image+"','"+remarks+"');";

                File.AppendAllText("output.sql", sql);

                ctr++;
            }

            reader.Close();
        }
    }
}
