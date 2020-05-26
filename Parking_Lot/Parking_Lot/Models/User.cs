using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class User
    {
        public int      Id        { get; set; }
        public String   FirstName { get; set; }
        public String   LastName  { get; set; }
        public String   Email     { get; set; }
        public String   Password  { get; set; }
        public DateTime Date      { get; set; }
        public String   Genero    { get; set; }

        public List<Tarjeta>  Tarjetas   { get; set; }
        public List<Vehiculo> Vehiculos  { get; set; }
    }
}