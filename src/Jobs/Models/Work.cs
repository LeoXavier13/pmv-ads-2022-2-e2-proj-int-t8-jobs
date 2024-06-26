﻿using Jobs.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jobs.Models {
    public class Work {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Título")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Sobre")]
        public string Description { get; set; }
        [DisplayName("Preço")]
        public decimal Price { get; set; }
        [DisplayName("Horário")]
        [Required(ErrorMessage = "*")]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Endereço")]
        public string Address { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Telefone")]
        public string Phone { get; set; }
        
        public string ImageUrl { get; set; }
        public string LastUpdate { get; set; }
    }
}
