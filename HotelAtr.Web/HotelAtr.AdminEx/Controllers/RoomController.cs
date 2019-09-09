using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using HotelAtr.AdminEx.Models;
using HotelAtr.DAL;


namespace HotelAtr.AdminEx.Controllers
{

    //[ExceptionEx]
    [HandleError(ExceptionType = typeof(Exception), View = "SpecialViewError")]
    public class RoomController : Controller
    {
        HotelAtrEntities db = new HotelAtrEntities();

        // GET: Room

       
        public ActionResult Index()
        {
            throw new NullReferenceException("Test Exception");

            //if(Request.IsAuthenticated)
            //{

            //}
            List<Rooms> rooms = db.Rooms.ToList();

            //наша пр-ие я-ся строго типизированным
            return View(rooms);
        }

        //-
        //-
        [Authorize(Roles = "sales2, trader")]
        public ActionResult CreateRoom(Rooms room, string message)
        {
            ViewBag.Message = message;



            var data = db.RoomType.ToList();

            ViewBag.RoomTypes = data;

            return View(room);
        }

        [HttpPost]
        public ActionResult CreateRoom(Rooms room)
        {
            string message = "";

            if(room.Price <=0)
            {
                ModelState.AddModelError("Price", "Цена не должна быть меньше или равно 0");
            }
            if (room.Price <= 0 && room.Floor==0)
            {
                ModelState.AddModelError("", "нельзя что то делать");
            }


            if (ModelState.IsValid)
            {
                if (BLL.ServiceRoom.AddRoom(room, out message))
                    return RedirectToAction("Index");
                else
                    return RedirectToAction("CreateRoom", new { room = room, message = message });
            }



            var data = db.RoomType.ToList();

            ViewBag.RoomTypes = data;

            return View(room);
          
        }

        public JsonResult IsPicEvent(string PathBasePicture)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(PathBasePicture);
            return Json(directoryInfo.Exists, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditRoom(int RoomId)
        {
            ViewBag.RoomTypeList = db.RoomType.ToList();
            ViewBag.RoomOptionsList = db.RoomOptions.ToList();

             var room = db.Rooms.Find(RoomId);
            if (room != null)
            {
                return View(room);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult EditRoom(Rooms rooms, HttpPostedFileBase BasePhoto)
        {
            string path = "";
            string fileName = Guid.NewGuid().ToString();
            if (BasePhoto.ContentLength > 0)
            {
                fileName = fileName+BasePhoto.FileName
                    .Substring(BasePhoto.FileName.LastIndexOf("."), 
                    BasePhoto.FileName.Length - BasePhoto.FileName.LastIndexOf("."));

                string fullPath = @"C:\Users\ГерценЕ\Desktop\HotelAtr.Web\HotelAtr.Web\Uploads\Rooms";
                DirectoryInfo dir = new DirectoryInfo(fullPath+ @"\"+rooms.RoomId);
                if (!dir.Exists)
                    dir.Create();
                
                path = Path.Combine(dir.FullName, fileName);
                BasePhoto.SaveAs(path);
            }


            var room = db.Rooms.Find(rooms.RoomId);
            if (room != null)
            {
                room.PathBasePicture = @"\Uploads\Rooms\"+rooms.RoomId+ @"\"+fileName;
                room.Name = rooms.Name;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult RoomTypeList()
        {
            var data = db.RoomType.ToList();

            return View(data);
        }

        public ActionResult CreateRoomType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateRoomType(RoomType roomType)
        {
            db.RoomType.Add(roomType);
            db.SaveChanges();

            return RedirectToAction("RoomTypeList");
        }

        public ActionResult DeleteRoomType(int id)
        {
            var data = db.RoomType.Find(id);

            db.RoomType.Remove(data);
            db.SaveChanges();

            return RedirectToAction("RoomTypeList");
        }







        public JsonResult GetRoomList()
        {
            var data = db.Rooms.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ContentResult GetRoomListXml()
        {
            var data = db.Rooms.ToList();

            var rooms = db.Rooms.ToList()
                .Select(s => new XElement("room", s.Name));


            return Content(rooms.ToString(), "text/xml");
        }


        public FileResult RoomsReport()
        {
            //create report
            //dooo

            string fileUrl = @"\Uploads\Rooms Report.pdf";
            string ContentType = "application/pdf";
            string fileName = "RoomReport.pdf";

            return File(fileUrl, ContentType, fileName);
        }

        
     
        [AjaxAuthorizeAuth]
        [HttpPost]
        public ActionResult AddRoomOptions(int RoomId, int RoomOptionsId)
        {

            Options option = new Options();
            option.RoomId = RoomId;
            option.RoomOptionsId = RoomOptionsId;

          

            db.Options.Add(option);
            db.SaveChanges();

            List<Options> options = db.Options.ToList();

            return PartialView("_RoomOptions", options);
        }
    }
}