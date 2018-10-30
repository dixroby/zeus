using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zeus.Models
{
    public class Product
    {
        //prop atajo para crear metodos

        //el atributo id ba a ser el codigo del proyecto autonumerica
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price  { get; set; }
        public DateTime LastBuy { get; set; }
        public float Stock { get; set; }
    }
}