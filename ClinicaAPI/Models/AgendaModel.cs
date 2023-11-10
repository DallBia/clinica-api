﻿using ClinicaAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClinicaAPI.Models
{
    public class AgendaModel
    {
        [Key]
        public int id { get; set; }
        public int? idCliente { get; set; }
        public string nome { get; set; }
        public int idFuncAlt { get; set; }
        public DateTime dtAlt { get; set; } = DateTime.UtcNow;
        public string horario { get; set; }
        public int sala { get; set; }
        public int unidade { get; set; }
        public DateOnly dia { get; set; }
        public string diaDaSemana
        {
            get
            {
                return DiaDaSemanaParaPortugues(dia.DayOfWeek);
            }
        }

        private string DiaDaSemanaParaPortugues(DayOfWeek dia1)
        {
            switch (dia1)
            {
                case DayOfWeek.Sunday: return "DOM";
                case DayOfWeek.Monday: return "SEG";
                case DayOfWeek.Tuesday: return "TER";
                case DayOfWeek.Wednesday: return "QUA";
                case DayOfWeek.Thursday: return "QUI";
                case DayOfWeek.Friday: return "SEX";
                case DayOfWeek.Saturday: return "SÁB";
                default: throw new ArgumentException("dia inválido");
            }
        }
        public ReptEnum repeticao { get; set; }
        public string? subtitulo { get; set; }
        public StatusEnum status { get; set; } = 0;
        public string? historico { get; set; }
        public string? obs { get; set; }

    }
}
