﻿using System.ComponentModel.DataAnnotations;

namespace WebApiPractica.Models
{
    public class estados_reserva
    {
        [Key]
        public int estado_res_id { get; set; }
        public string?  estado { get; set; }
         
    }
}
