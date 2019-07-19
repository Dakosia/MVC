using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;

namespace BestHookah.BLL
{
    public class AboutUsService
    {
        static BestHookahEntities db = new BestHookahEntities();

        #region Add/Edit/Delete Menu Sections
        public static bool AddMenuSection(MenuSections menuSection, out string message)
        {
            try
            {
                db.MenuSections.Add(menuSection);
                db.SaveChanges();

                message = "Menu section was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditMenuSection(MenuSections menuSection, out string message)
        {
            try
            {
                MenuSections ms = db.MenuSections.Find(menuSection.MenuSectionId);

                if (ms != null)
                {
                    var oldMenuSectionName = ms.MenuSectionName;
                    ms.MenuSectionName = menuSection.MenuSectionName;

                    List<MenuPoints> menuPoints = db.MenuPoints.Where(mp => mp.MenuSectionName == oldMenuSectionName).ToList();
                    foreach (MenuPoints menuPoint in menuPoints)
                    {
                        menuPoint.MenuSectionName = menuSection.MenuSectionName;
                    }

                    db.SaveChanges();

                    message = "Menu section was edited successfully";
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

        public static bool DeleteMenuSection(int MenuSectionId, out string message)
        {
            try
            {
                MenuSections menuSection = db.MenuSections.Find(MenuSectionId);
                if (menuSection != null)
                {
                    db.MenuSections.Remove(menuSection);

                    List<MenuPoints> menuPoints = db.MenuPoints.Where(mp => mp.MenuSectionName == menuSection.MenuSectionName).ToList();
                    foreach (MenuPoints menuPoint in menuPoints)
                    {
                        db.MenuPoints.Remove(menuPoint);
                    }

                    db.SaveChanges();

                    message = "Menu section was deleted successfully";
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


        #region Add/Edit/Delete Menu Points
        public static bool AddMenuPoint(MenuPoints menuPoint, out string message)
        {
            try
            {
                db.MenuPoints.Add(menuPoint);
                db.SaveChanges();

                message = "Menu point was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditMenuPoint(MenuPoints menuPoint, out string message)
        {
            try
            {
                MenuPoints mp = db.MenuPoints.Find(menuPoint.MenuPointId);

                if (mp != null)
                {
                    mp.MenuPointName = menuPoint.MenuPointName;
                    mp.MenuPointPrice = menuPoint.MenuPointPrice;
                    mp.MenuPointDescription = menuPoint.MenuPointDescription;
                    mp.MenuPointImagePath = menuPoint.MenuPointImagePath;
                    mp.MenuSectionName = menuPoint.MenuSectionName;
                    db.SaveChanges();

                    message = "Menu point was edited successfully";
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

        public static bool DeleteMenuPoint(int MenuPointId, out string message)
        {
            try
            {
                MenuPoints menuPoint = db.MenuPoints.Find(MenuPointId);
                if (menuPoint != null)
                {
                    db.MenuPoints.Remove(menuPoint);
                    db.SaveChanges();

                    message = "Menu point was deleted successfully";
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


        #region Add Blog Articles
        public static bool AddBlogArticle(BlogArticles blogArticle, out string message)
        {
            try
            {
                db.BlogArticles.Add(blogArticle);
                db.SaveChanges();

                message = "Blog article was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        #endregion


        #region Add/Edit/Delete Branches
        public static bool AddBranch(Branches branch, out string message)
        {
            try
            {
                db.Branches.Add(branch);
                db.SaveChanges();

                message = "Branch was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditBranch(Branches branch, out string message)
        {
            try
            {
                Branches br = db.Branches.Find(branch.BranchId);

                if (br != null)
                {
                    br.BranchName = branch.BranchName;
                    br.BranchDescription = branch.BranchDescription;
                    br.BranchAddress = branch.BranchAddress;
                    br.BranchPhone = branch.BranchPhone;
                    br.BranchHoursOfOperations = branch.BranchHoursOfOperations;
                    db.SaveChanges();

                    message = "Branch was edited successfully";
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

        public static bool DeleteBranch(int BranchId, out string message)
        {
            try
            {
                Branches branch = db.Branches.Find(BranchId);
                if (branch != null)
                {
                    db.Branches.Remove(branch);
                    db.SaveChanges();

                    message = "Branch was deleted successfully";
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
