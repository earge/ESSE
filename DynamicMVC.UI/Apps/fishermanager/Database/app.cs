using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {


    [Table("fishes")]
    public class fish : base_entity_name_desc_systemname {

        public string fish_name { get; set; }

        public string fish_desc { get; set; }

    }


}