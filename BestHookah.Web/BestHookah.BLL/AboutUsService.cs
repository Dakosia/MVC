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
    }
}
