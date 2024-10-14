﻿using InstitutoServices.Interfaces.MesasExamenes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace InstitutoServices.Models.Horarios
{
    public class Hora 
    {
        public int Id { get; set; }
        [NotMapped]


        public string Nombre
        {
            get {
                var recreo = EsRecreo ? "Recreo " : "";


<<<<<<< HEAD

=======
>>>>>>> 844d8020a62ae6526c3ea7ea20e9de7882a7576f
                return $"{recreo}{Desde.Hour} : {Desde.Minute} - {Hasta.Hour} : {Hasta.Minute}"; }
        }

        public DateTime Desde { get; set; } = DateTime.MinValue;
        public DateTime Hasta { get; set; } = DateTime.MinValue;
        public bool EsRecreo { get; set; } = false;
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return Nombre;
        }
    }
}
