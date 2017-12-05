using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPB2_MBO.Models
{
    public class CartaoDeCredito
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o número do cartão.")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string Cliente { get; set; }
        public Bandeira Bandeira { get; set; }


    }
}