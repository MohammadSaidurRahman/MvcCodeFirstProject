using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcCodeFirstProject_Sayed.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage ="This Field Must be fill!!")]
        public string RoomType { get; set; }
        [Required(ErrorMessage = "This Field Must be fill!!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This Field Must be fill!!")]
        [Display(Name ="Booking Date ")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BookingDate { get; set; }
        [Required(ErrorMessage = "This Field Must be fill!!")]
        [Display(Name = "Photo ")]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}