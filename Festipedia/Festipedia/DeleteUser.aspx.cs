using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Festipedia
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext())
            {
                var query = from g in db.GeregistreerdeGebruikers select g;
                deleteView.DataSource = query.ToList();
                deleteView.DataBind();
            }
        }
        protected void deleteView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void deleteView_DeleteItem(int id)
        {

        }
    }
}