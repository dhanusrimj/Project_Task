using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_logic;
using Utility_object;

namespace Business_logic
{
    public class BL_App_Manage_Role
    {
        DA_App_Manage_Role da_obj = new DA_App_Manage_Role();
        public List<App_manage_role> bl_get_role_list(App_manage_role bo_obj)
        {
            return da_obj.da_get_role_list(bo_obj);
        }

        public List<App_manage_role> bl_get_permission_selected_list(App_manage_role bo_obj)
        {
            return da_obj.da_get_permission_selected_list(bo_obj);
        }

        public List<App_manage_role> bl_get_permission_list(App_manage_role bo_obj)
        {
            return da_obj.da_get_permission_list(bo_obj);
        }
        public string bl_delete_role_list(App_manage_role bo_obj)
        {
            return da_obj.da_Delete_role_details(bo_obj);
        }
        public string bl_delete_confirmation(App_manage_role bo_obj)
        {
            return da_obj.da_delete_confirmation(bo_obj);
        }
        public string bl_create_permission_list(App_manage_role bo_obj)
        {
            return da_obj.da_create_permission_list(bo_obj);
        }
        public string bl_update_permission_list(App_manage_role bo_obj)
        {
            return da_obj.da_update_permission_list(bo_obj);
        }
    }
}
