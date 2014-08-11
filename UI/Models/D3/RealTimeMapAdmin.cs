using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DarrenBlogSamples.UI.Models.D3
{
    public class RealTimeMapAdmin
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("State")]
        public string StateFipsCode { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Note { get; set; }
    }
}