using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Festipedia.Admin
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext())
            {
                String[] query = Roles.GetAllRoles();
                RoleList.DataSource = query.ToList();
                RoleList.DataBind();
            }
        }

        protected void CreateUser_CreatedUser(object sender, EventArgs e)
        {
            string continueUrl =  "~/Admin/adminPage.aspx";
            Response.Redirect(continueUrl);
        }

        protected void RoleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectRole = RoleList.Text;
            String[] allUsers = Roles.GetUsersInRole(selectRole);
            UserRoleList.DataSource = allUsers.ToList();
            UserRoleList.DataBind();
        }

    }


}