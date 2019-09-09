using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Abstract
{
   public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
