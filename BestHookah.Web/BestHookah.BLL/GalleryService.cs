using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;

namespace BestHookah.BLL
{
    public class GalleryService
    {
        static BestHookahEntities db = new BestHookahEntities();

        public static bool AddImage(Gallery image, out string message)
        {
            try
            {
                db.Gallery.Add(image);
                db.SaveChanges();

                message = "Image was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditImage(Gallery image, out string message)
        {
            try
            {
                Gallery img = db.Gallery.Find(image.ImageId);

                if (img != null)
                {
                    img = image;
                    db.Entry(img).State = EntityState.Modified;
                    db.SaveChanges();

                    message = "Image was edited successfully";
                    return true;
                }
                message = "";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeleteImage(int imageId, out string message)
        {
            try
            {
                Gallery image = db.Gallery.Find(imageId);
                if (image != null)
                {
                    db.Gallery.Remove(image);
                    db.SaveChanges();

                    message = "Image was deleted successfully";
                    return true;
                }
                message = "";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
