using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace DarrenBlogSamples.UI.Controllers
{
    public class D3Controller : Controller
    {
        // GET: D3
        public ActionResult Index()
        {
            return View();
        }

        // GET: D3/BarChart
        public ActionResult BarChart()
        {
            return View();
        }

        // GET: D3/RealTimeMap
        public ActionResult RealTimeMap()
        {
            return View();
        }

        // GET: D3/RealTimeMapAdmin
        public ActionResult RealTimeMapAdmin()
        {
            ViewBag.States = this.GetStateListItems();

            return View();
        }

        public ActionResult GunClubSeason2017() {
            return View();
        }

        [HttpPost]
        public ActionResult RealTimeMapAdmin(Models.D3.RealTimeMapAdmin model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalR.RealTimeMapHub>();
            hubContext.Clients.All.mapUpdate(model.Name, model.StateFipsCode, model.Color, model.Note);

            return RedirectToAction("RealTimeMapAdmin");
        }


        private List<SelectListItem> GetStateListItems()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "Alabama", Value = "1" });
            items.Add(new SelectListItem() { Text = "Alaska", Value = "2" });
            items.Add(new SelectListItem() { Text = "Arizona", Value = "4" });
            items.Add(new SelectListItem() { Text = "Arkansas", Value = "5" });
            items.Add(new SelectListItem() { Text = "California", Value = "6" });
            items.Add(new SelectListItem() { Text = "Colorodo", Value = "8" });
            items.Add(new SelectListItem() { Text = "Connecticut", Value = "9" });
            items.Add(new SelectListItem() { Text = "Delaware", Value = "10" });
            items.Add(new SelectListItem() { Text = "District of Columbia", Value = "11" });
            items.Add(new SelectListItem() { Text = "Florida", Value = "12" });
            items.Add(new SelectListItem() { Text = "Georgia", Value = "13" });
            items.Add(new SelectListItem() { Text = "Hawaii", Value = "15" });
            items.Add(new SelectListItem() { Text = "Idaho", Value = "16" });
            items.Add(new SelectListItem() { Text = "Illinois", Value = "17" });
            items.Add(new SelectListItem() { Text = "Indiana", Value = "18" });
            items.Add(new SelectListItem() { Text = "Iowa", Value = "19" });
            items.Add(new SelectListItem() { Text = "Kansas", Value = "20" });
            items.Add(new SelectListItem() { Text = "Kentucky", Value = "21" });
            items.Add(new SelectListItem() { Text = "Louisiana", Value = "22" });
            items.Add(new SelectListItem() { Text = "Maine", Value = "23" });
            items.Add(new SelectListItem() { Text = "Maryland", Value = "24" });
            items.Add(new SelectListItem() { Text = "Massachusetts", Value = "25" });
            items.Add(new SelectListItem() { Text = "Michigan", Value = "26" });
            items.Add(new SelectListItem() { Text = "Minnesota", Value = "27" });
            items.Add(new SelectListItem() { Text = "Mississippi", Value = "28" });
            items.Add(new SelectListItem() { Text = "Missouri", Value = "29" });
            items.Add(new SelectListItem() { Text = "Montana", Value = "30" });
            items.Add(new SelectListItem() { Text = "Nebraska", Value = "31" });
            items.Add(new SelectListItem() { Text = "Nevada", Value = "32" });
            items.Add(new SelectListItem() { Text = "New Hampshire", Value = "33" });
            items.Add(new SelectListItem() { Text = "New Jersey", Value = "34" });
            items.Add(new SelectListItem() { Text = "New Mexico", Value = "35" });
            items.Add(new SelectListItem() { Text = "New York", Value = "36" });
            items.Add(new SelectListItem() { Text = "North Carolina", Value = "37" });
            items.Add(new SelectListItem() { Text = "North Dakota", Value = "38" });
            items.Add(new SelectListItem() { Text = "Ohio", Value = "39" });
            items.Add(new SelectListItem() { Text = "Oklahoma", Value = "40" });
            items.Add(new SelectListItem() { Text = "Oregon", Value = "41" });
            items.Add(new SelectListItem() { Text = "Pennsylvania", Value = "42" });
            items.Add(new SelectListItem() { Text = "Rhode Island", Value = "44" });
            items.Add(new SelectListItem() { Text = "South Carolina", Value = "45" });
            items.Add(new SelectListItem() { Text = "South Dakota", Value = "46" });
            items.Add(new SelectListItem() { Text = "Tennessee", Value = "47" });
            items.Add(new SelectListItem() { Text = "Texas", Value = "48" });
            items.Add(new SelectListItem() { Text = "Utah", Value = "49" });
            items.Add(new SelectListItem() { Text = "Vermont", Value = "50" });
            items.Add(new SelectListItem() { Text = "Virginia", Value = "51" });
            items.Add(new SelectListItem() { Text = "Washington", Value = "53" });
            items.Add(new SelectListItem() { Text = "West Virginia", Value = "54" });
            items.Add(new SelectListItem() { Text = "Wisconsin", Value = "55" });
            items.Add(new SelectListItem() { Text = "Wyoming", Value = "56" });

            return items;
        }
    }

    
}