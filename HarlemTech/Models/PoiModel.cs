using HarlemTech.DataAccess.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarlemTech.Models
{
    public class PoiModel
    {
        public List<HarlemPOI> POIs { get; set; }
        public List<HarlemImage> Images { get; set; }
    }
}