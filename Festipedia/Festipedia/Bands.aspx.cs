using Festipedia.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Festipedia
{
    public partial class Bands : BasePage
    {
        /// <summary>
        /// Alle bands worden uit de databank gehaald
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new groep15_festivalsContext())
                {
                    var query = from b in db.Bands orderby b.band_naam select b;
                    bandView.DataSource = query.ToList();
                    bandView.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("~/errorPage.aspx");
            }
        }

        /// <summary>
        /// tabel sorteren
        /// </summary>
        /// <param name="sortDirection"></param>
        /// <returns></returns>
        private string ConvertSortDirectionToSql(SortDirection sortDirection)
        {
            string newSortDirection = String.Empty;

            switch (sortDirection)
            {
                case SortDirection.Ascending:
                    newSortDirection = "ASC";
                    break;

                case SortDirection.Descending:
                    newSortDirection = "DESC";
                    break;
            }

            return newSortDirection;
        }

        /// <summary>
        ///  Zorgen dat de inhoud opnieuw gebind word na selectie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bandView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            bandView.PageIndex = e.NewPageIndex;
            bandView.DataBind();
        }

        /// <summary>
        /// Bind gesorteerde waarden aan de tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bandView_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dataTable = bandView.DataSource as DataTable;

            if (dataTable != null)
            {
                DataView dataView = new DataView(dataTable);
                dataView.Sort = e.SortExpression + " " + ConvertSortDirectionToSql(e.SortDirection);

                bandView.DataSource = dataView;
                bandView.DataBind();
            }
        }
    }
}