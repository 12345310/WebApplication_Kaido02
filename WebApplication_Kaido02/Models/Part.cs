using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido02.Models
{
    public class Part
    {
        [Key]
        public int PartNo  { get; set; }  

        public string PartName { get; set; }

        public int Tanka { get; set; }

        public DateTime SeizoYMD { get; set; }

        public string Memo { get; set; }

    }
}