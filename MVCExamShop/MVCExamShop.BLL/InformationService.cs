using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MVCExamShop.DAL;


namespace MVCExamShop.BLL
{
    public class InformationService
    {
        static MVCExamOnlineShopEntities db = new MVCExamOnlineShopEntities();

        public static bool AddContact(Contact contact, out string message)
        {
            try
            {
                SendEmail(contact, out message);
                db.Contacts.Add(contact);
                db.SaveChanges();
                //message = "Message was sent successfully";

                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static void SendEmail(Contact contact, out string msg)
        {
            try
            {
                MailMessage message = new MailMessage(contact.UserEmail, "dana.kerey@gmail.com");
                message.Subject = string.Format("Enquiry from {0} - {1}", contact.UserName, contact.UserEmail);
                message.Body = contact.UserMessage;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("natsu22dragneel55@gmail.com", "88natsu22dragneel55");
                client.Send(message);
                msg = "Message was sent successfully";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }

        public static bool AddComment(Comment comment, int BlogId, out string message)
        {
            try
            {
                comment.BlogId = BlogId;
                comment.CommentCreationDate = DateTime.Now;
                db.Comments.Add(comment);
                db.SaveChanges();

                message = "Comment was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }


        #region Blogs
        public static bool AddBlog(Blog blog, out string message)
        {
            try
            {
                db.Blogs.Add(blog);
                db.SaveChanges();

                message = "Blog was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditBlog(Blog blog, out string message)
        {
            try
            {
                Blog bl = db.Blogs.Find(blog.BlogId);

                if (bl != null)
                {
                    bl.BlogName = blog.BlogName;
                    bl.BlogShortDescription = blog.BlogShortDescription;
                    bl.BlogCreationDate = blog.BlogCreationDate;
                    bl.BlogContent = blog.BlogContent;
                    bl.BlogImagePath = blog.BlogImagePath;
                    db.SaveChanges();

                    message = "Blog was edited successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeleteBlog(int BlogId, out string message)
        {
            try
            {
                Blog blog = db.Blogs.Find(BlogId);
                if (blog != null)
                {
                    db.Blogs.Remove(blog);
                    db.SaveChanges();

                    message = "Blog was deleted successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        #endregion

        #region Comments
        public static bool EditComment(Comment comment, out string message)
        {
            try
            {
                Comment c = db.Comments.Find(comment.CommentId);

                if (c != null)
                {
                    c.Author = comment.Author;
                    c.UserEmail = comment.UserEmail;
                    c.UserComment = comment.UserComment;
                    c.CommentCreationDate = comment.CommentCreationDate;
                    db.SaveChanges();

                    message = "Comment was edited successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeleteComment(int CommentId, out string message)
        {
            try
            {
                Comment comment = db.Comments.Find(CommentId);

                if (comment != null)
                {
                    db.Comments.Remove(comment);
                    db.SaveChanges();

                    message = "Comment was deleted successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
