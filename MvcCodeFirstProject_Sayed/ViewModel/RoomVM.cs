using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcCodeFirstProject_Sayed.ViewModel
{
    public class RoomVM
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public DateTime BookingDate { get; set; }
        public string ImagePath { get; set; }


        public HttpPostedFileBase ImageFile { get; set; }

    }
}