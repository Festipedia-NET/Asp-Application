using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Festipedia.Models;


namespace Festipedia
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

    


        // haalt de data voor de listview uit de models van entity framework en neemt er de 5 eerste van van de festivals die nog moeten komen.

        public List<Festipedia.Models.Festival> getListData(){

            using (var db = new groep15_festivalsContext())
            {
                DateTime now = new DateTime();
                DateTime dan = new DateTime(); // deze lijn moet nog weg.
                now = DateTime.Now;

                // deze 3 lijnen moeten nog weg.
                System.Diagnostics.Debug.WriteLine("DATE = " + Convert.ToString(now));
                dan = now.AddDays(30);
                System.Diagnostics.Debug.WriteLine("DATE + days = " + Convert.ToString(dan));
                // tot hier
               
                var query = from f in db.Festivals where f.fest_datum > dan orderby f.fest_datum  select f;
                var limitQuery = query.Take(5); // neemt 5 eerste results van de query
                return limitQuery.ToList();
            }

        }
    }
}