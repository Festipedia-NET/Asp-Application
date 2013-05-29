using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Festipedia.Models;


namespace Festipedia
{
    /// <summary>
    /// Klasse om elementen in te laden of te veranderen van de asp pagina.
    /// Of code uit te voeren.
    /// </summary>
    public partial class _Default : BasePage
    {

        /// <summary>
        /// Methode uitgevoerd als de pagina geladen wordt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {



        }


       /// <summary>
       /// Methode om de listview op te vullen met de data die we nodig hebben. We hebben hiervoor geen Wizard gebruikt.
       /// </summary>
       /// <returns>returns een lijst met de verschillende festivals met hun gegevens</returns>

        public List<Festipedia.Models.Festival> getListData(){

            using (var db = new groep15_festivalsContext())
            {
                DateTime now = new DateTime();            
                now = DateTime.Now;
                var query = from f in db.Festivals where f.fest_datum > now orderby f.fest_datum  select f;
                var limitQuery = query.Take(5); // neemt 5 eerste results van de query
                return limitQuery.ToList();
            }

        }
    }
}