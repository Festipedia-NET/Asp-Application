using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;
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
            using (var db = new groep15_festivalsContext())
            {
                var query = from f in db.Festivals orderby f.fest_datum select f;
                festView.DataSource = query.ToList();
                festView.DataBind();
            }
        }

        /// <summary>
        /// Deleten van de huidige rij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void festView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            String idT = ((Label)festView.Rows[e.RowIndex-1].FindControl("Label5")).Text;
            int id = Convert.ToInt32(idT);

            using (var db = new groep15_festivalsContext())
            {
                Festival fest = db.Festivals.First(i => i.fest_id == id);
                db.Festivals.Remove(fest);
                db.SaveChanges();
            }

            festView.DataBind();

        }

        /// <summary>
        /// Zorgen dat de knoppen update en cancel zichtbaar worden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void festView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            festView.EditIndex = e.NewEditIndex;
            festView.DataBind();
        }

        /// <summary>
        /// Updaten van de huidige rij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void festView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String idT = ((Label)festView.Rows[e.RowIndex-1].FindControl("Label5")).Text;
            int id = Convert.ToInt32(idT);

            String festName = ((TextBox)festView.Rows[e.RowIndex-1].FindControl("TextBox1")).Text;
            String festLoc = ((TextBox)festView.Rows[e.RowIndex - 1].FindControl("TextBox2")).Text;
            String festDatumT = ((TextBox)festView.Rows[e.RowIndex - 1].FindControl("TextBox3")).Text;


            String festDuurT = ((TextBox)festView.Rows[e.RowIndex].FindControl("TextBox4")).Text;
            int festDuur = Int32.Parse(festDuurT);

            using (var db = new groep15_festivalsContext())
            {
                Festival fest = db.Festivals.Single(i => i.fest_id == id);
                fest.fest_naam = festName;
                fest.fest_locatie = festLoc;
                fest.fest_datum = DateTime.ParseExact(festDatumT + " 00:00:00", "dd/MM/yyyy HH:mm:ss", null);
                fest.fest_duur = festDuur;

                db.SaveChanges();
            }

            festView.EditIndex = -1;

            festView.DataBind();
            
        }

        /// <summary>
        /// Het updaten onderbreken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void festView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            festView.EditIndex = -1;
            festView.DataBind();
        }

        /// <summary>
        /// Toevoegen van een festival
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Insert_Click(object sender, GridViewCommandEventArgs e)
        {

            TextBox txtFestName = festView.FooterRow.FindControl("TextBox8") as TextBox;
            string festName = txtFestName.Text;
            TextBox txtFestLoc = festView.FooterRow.FindControl("TextBox7") as TextBox;
            string festLoc = txtFestLoc.Text;
            TextBox txtfestDatum = festView.FooterRow.FindControl("TextBox6") as TextBox;

            TextBox txtFestDuur = festView.FooterRow.FindControl("TextBox5") as TextBox;
            string festDuurTemp = txtFestDuur.Text;
            int festDuur = Int32.Parse(festDuurTemp);

            
            using (var db = new groep15_festivalsContext())
            {

                Festival fest = new Festival();
                fest.fest_naam = festName.ToString();
                fest.fest_locatie = festLoc.ToString();
                fest.fest_datum = DateTime.ParseExact(txtfestDatum + " 00:00:00", "dd/MM/yyyy HH:mm:ss", null);
                fest.fest_duur = festDuur;

                db.Festivals.Add(fest);

                db.SaveChanges();
            }

            festView.EditIndex = -1;
            festView.DataBind();
        }

        protected void festView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

    }
}