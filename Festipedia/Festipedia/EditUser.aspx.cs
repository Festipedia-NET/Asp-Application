using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Festipedia
{
    public partial class EditUser : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext())
            {
                var query = from g in db.GeregistreerdeGebruikers orderby g.gebr_id select g;
                grdEdit.DataSource = query.ToList();
                grdEdit.DataBind();
            }
        }
    }
}