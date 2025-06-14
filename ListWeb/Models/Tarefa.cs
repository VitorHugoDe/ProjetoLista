﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ListWeb.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha a Data de vencimento!")]
        public DateTime? DataVencimento { get; set; }
        [Required(ErrorMessage = "Selecione uma categoria!")]
        public string CatergoriaId { get; set; }
        [ValidateNever]
        public Categoria Categoria { get; set; }
        [Required(ErrorMessage = "Selecione um status!")]
        public string StatusId { get; set; }
        [ValidateNever]
        public Status Status { get; set; }

        public bool Atrasado => StatusId == "aberto" && DataVencimento < DateTime.Today;
    }
}
