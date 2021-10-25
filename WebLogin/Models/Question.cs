using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLogin.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string CustomerQuestion { get; set; }
        public string SpecialistName { get; set; }

        public Question()
        {
        }
    }
}
