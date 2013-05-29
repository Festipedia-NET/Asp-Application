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
                
                if (!IsPostBack)
                {
                    bindAllUsers();
                }
                bindAllRoles();
                CheckRolesForSelectedUser();
            }
        }

        protected void CreateUser_CreatedUser(object sender, EventArgs e)
        {
            string continueUrl =  "~/Admin/adminPage.aspx";
            Response.Redirect(continueUrl);
        }

        protected void bindAllUsers()
        {
            MembershipUserCollection query = Membership.GetAllUsers();
            UserList.DataSource = query;
            UserList.DataBind();
            deleteUserList.DataSource = query;
            deleteUserList.DataBind();
        }

        protected void bindAllRoles()
        {
            String[] query = Roles.GetAllRoles();
            UsersRoleList.DataSource = query.ToList();
            UsersRoleList.DataBind();
        }

        protected void CheckRolesForSelectedUser()
        {
            String selectedUser = UserList.SelectedValue;
            String[] selectedUsersRoles = Roles.GetRolesForUser(selectedUser);
            for (int i = 0; i < UsersRoleList.Items.Count; i++ )
            {
                CheckBox roleCheckbox = UsersRoleList.Items[i].FindControl("RoleCheckBox") as CheckBox;
                if(selectedUsersRoles.Contains(roleCheckbox.Text))
                {
                    roleCheckbox.Checked = true;
                    System.Diagnostics.Debug.WriteLine("Variabele: User: " + selectedUser + " Role: " + roleCheckbox.Text);
                }
                else
                {
                    roleCheckbox.Checked = false;
                }
            }
        }

        protected void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRolesForSelectedUser();
        }

        protected void deleteUser_Click(object sender, EventArgs e)
        {
            String user = deleteUserList.SelectedValue;
            Membership.DeleteUser(user);
            string continueUrl = "~/Admin/adminPage.aspx";
            Response.Redirect(continueUrl);
        }

    }


}