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
        protected string redirectUrl = "~/Admin/adminPage.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext()){            
                if (!IsPostBack){
                    bindAllUsers();
                    bindAllRoles();
                    CheckRolesForSelectedUser();
                }              
            }
        }

        /// <summary>
        /// redirect naar de admin pagina als een user is aangemaakt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CreateUser_CreatedUser(object sender, EventArgs e)
        {
            Response.Redirect(redirectUrl);
        }

        /// <summary>
        /// Vult de dropdown lists met alle users
        /// </summary>
        protected void bindAllUsers()
        {
            MembershipUserCollection query = Membership.GetAllUsers();
            UserList.DataSource = query;
            UserList.DataBind();
            deleteUserList.DataSource = query;
            deleteUserList.DataBind();
        }

        /// <summary>
        /// Haal alle roles op en toont die met checkboxes.
        /// </summary>
        protected void bindAllRoles()
        {
            String[] query = Roles.GetAllRoles();
            UsersRoleList.DataSource = query.ToList();
            UsersRoleList.DataBind();
        }

        /// <summary>
        /// Vinkt de checkboxen aan als de geselecteerde user tot die role behoort
        /// </summary>
        protected void CheckRolesForSelectedUser()
        {
            String selectedUser = UserList.SelectedValue;
            String[] selectedUsersRoles = Roles.GetRolesForUser(selectedUser);
            for (int i = 0; i < UsersRoleList.Items.Count; i++ )
            {
                CheckBox roleCheckbox = UsersRoleList.Items[i].FindControl("RoleCheckBox") as CheckBox;
                if(selectedUsersRoles.Contains(roleCheckbox.Text)){
                    roleCheckbox.Checked = true;
                }else{
                    roleCheckbox.Checked = false;
                }
            }
            var user = Membership.GetUser(selectedUser);
            EmailChange.Text = user.Email;
        }

        /// <summary>
        /// Roept bevenstaande functie op als een nieuwe gebruiker gekozen is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRolesForSelectedUser();
        }

        /// <summary>
        /// Verwijderen van de geselecteerde gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void deleteUser_Click(object sender, EventArgs e)
        {
            String user = deleteUserList.SelectedValue;
            Membership.DeleteUser(user);

            Response.Redirect(redirectUrl);
        }

        /// <summary>
        /// Update het wachtwoord en het emailadres van de gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void changeUser_Click(object sender, EventArgs e)
        {
            String selectedUser = UserList.SelectedValue;
            MembershipUser user = Membership.GetUser(selectedUser);
            String email = EmailChange.Text;
            user.Email = email;

            if (!String.IsNullOrEmpty(PasswordChange.Text))
            {
                user.ChangePassword(user.ResetPassword(), PasswordChange.Text);
            }
            Membership.UpdateUser(user);
        }

        /// <summary>
        /// update de roles van de user als er worden aangevinkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RoleCheckBox_CheckChanged(object sender, EventArgs e)
        {
            CheckBox RoleCheckBox = (CheckBox)sender;
            string selectedUserName = UserList.SelectedValue;
            string roleName = RoleCheckBox.Text;
            if (RoleCheckBox.Checked){
                Roles.AddUserToRole(selectedUserName, roleName);
            }else{
                Roles.RemoveUserFromRole(selectedUserName, roleName);
            }
        }
    }
}