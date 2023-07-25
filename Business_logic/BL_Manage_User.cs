using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_logic;
using Utility_object;

namespace Business_logic
{
    public class BL_App_Manage_User
    {
        DA_App_Manage_User da_obj = new DA_App_Manage_User();
        public List<App_manage_user> bl_get_user_details(App_manage_user bo_obj)
        {
            return da_obj.get_user_list(bo_obj);
        }

        public List<App_manage_user_role> bl_get_role_list(App_manage_user_role bo_obj)
        {
            return da_obj.da_get_role_list(bo_obj);
        }

        public string bl_update_user_details(App_manage_user bo)
        {
            return da_obj.da_update_user_details(bo);
        }
        public string bl_Create_user_details(App_manage_user bo)
        {
            return da_obj.da_Create_user_details(bo);
        }

        public string bl_Delete_user_details(App_manage_user bo)
        {
            return da_obj.da_Delete_user_details(bo);
        }

    }
}
