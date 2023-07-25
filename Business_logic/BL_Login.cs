using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_logic;
using Utility_object;
using System.Data;

namespace Business_logic
{
    public class BL_Login
    {
        DA_Login obTA_DataLogic = new DA_Login();
        public List<cln_get_login> Application_Login(Application_login objlogin)
        {
            try
            {
               return obTA_DataLogic.Application_Login(objlogin);
            }
            catch (Exception )
            {
            }
            return null;
        }
    }
}
