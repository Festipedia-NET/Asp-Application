using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Festipedia.Edit
{
    public partial class editPage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext())
            {
                var query = from f in db.Festivals orderby f.fest_datum select f;
                festView.DataSource = query.ToList();
                festView.DataBind();
            }
        }
    }
}