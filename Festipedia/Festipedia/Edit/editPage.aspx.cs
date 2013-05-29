using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts; 

namespace Festipedia.Edit
{
    public partial class editPage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterForEventValidation(this.UniqueID);

            using (var db = new groep15_festivalsContext())
            {
                var query = from f in db.Festivals orderby f.fest_datum select f;
                festView.DataSource = query.ToList();
                festView.DataBind();
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Page.ClientScript.RegisterForEventValidation(.UniqueID);
            base.Render(writer);
        }

        protected void festView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
                        /**
             * Verwijderen 
             */

            String idT = ((Label)festView.Rows[e.RowIndex].FindControl("Label5")).Text;
            int id = Convert.ToInt32(idT);

            using (var db = new groep15_festivalsContext())
            {
                Festival fest = db.Festivals.Single(i => i.fest_id == id);
                db.Festivals.Remove(fest);
                db.SaveChanges();
            }

            DataBind();

        }

        protected void festView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            festView.EditIndex = e.NewEditIndex;
            DataBind();
        }

        protected void festView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String idT = ((Label)festView.Rows[e.RowIndex].FindControl("Label5")).Text;
            int id = Convert.ToInt32(idT);

            String festName = ((Label)festView.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            String festLoc = ((Label)festView.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            String festDatumT = ((Label)festView.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            DateTime festDatum = Convert.ToDateTime(festDatumT);

            String festDuurT = ((Label)festView.Rows[e.RowIndex].FindControl("TextBox4")).Text;
            int festDuur = Convert.ToInt32(festDuurT);

            using (var db = new groep15_festivalsContext())
            {
                Festival fest = db.Festivals.Single(i => i.fest_id == id);
                fest.fest_naam = festName;
                fest.fest_locatie = festLoc;
                fest.fest_datum = festDatum;
                fest.fest_duur = festDuur;

                db.SaveChanges();
            }

            festView.EditIndex = -1;
            DataBind();
            
        }

        protected void festView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            festView.EditIndex = -1;
            DataBind();
        }



    }
}