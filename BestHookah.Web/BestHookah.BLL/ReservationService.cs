using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;
using OfficeOpenXml;

namespace BestHookah.BLL
{
    public class ReservationService
    {
        static BestHookahEntities db = new BestHookahEntities();

        public static bool AddReserve(Reserves reserve, out string message)
        {
            try
            {
                reserve.ReserveDate = DateTime.Now;
                db.Reserves.Add(reserve);
                db.SaveChanges();

                message = "Reserve was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static void Notify()
        {
            //Notify
        }

        public static List<Reserves> FilterByDate(DateTime? from, DateTime? to)
        {
            return db.Reserves.Where(r => r.ReserveDate >= from && r.ReserveDate <= to).ToList();
        }

        public static byte[] GetTodayReservesExcel(string path)
        {
            List<Reserves> reserves = db.Reserves.ToList().Where(r => r.ReserveDate.Date == DateTime.Now.Date).ToList();

            ExcelPackage excel = new ExcelPackage(new FileInfo(path));
            ExcelWorksheet excelWorksheet = excel.Workbook.Worksheets.FirstOrDefault();
            //ExcelWorksheet excelWorksheet = excel.Workbook.Worksheets["Sheet1"];

            int startRow = 2;
            foreach (Reserves reserve in reserves)
            {
                excelWorksheet.Cells[startRow, 1].Value = reserve.ClientName;
                excelWorksheet.Cells[startRow, 2].Value = reserve.ClientEmail;
                excelWorksheet.Cells[startRow, 3].Value = reserve.ClientPhone;
                excelWorksheet.Cells[startRow, 4].Value = reserve.ClientMessage;
                excelWorksheet.Cells[startRow, 5].Value = reserve.ReserveDate.Date;

                startRow++;
            }

            return excel.GetAsByteArray();
        }
    }
}
