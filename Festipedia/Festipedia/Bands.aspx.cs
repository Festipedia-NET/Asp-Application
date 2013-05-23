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
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new groep15_festivalsContext())
            {
                var query = from b in db.Bands orderby b.band_naam select b;
                bandView.DataSource = query.ToList();
                bandView.DataBind();
            }
        }

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

        protected void bandView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            bandView.PageIndex = e.NewPageIndex;
            bandView.DataBind();
        }

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