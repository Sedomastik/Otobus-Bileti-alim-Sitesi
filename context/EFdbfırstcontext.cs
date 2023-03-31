using Otobüs_Bİleti_Alim_Satim_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobüs_Bİleti_Alim_Satim_Otomasyonu.context
{
    
    public class EFdbfırstcontext : DbContext
    {
        public EFdbfırstcontext() : base("Server=Sedo; Database=Otobusotomasyon;Trusted_Connection=true")
        {

        }
        public DbSet<bilet> biletler { get; set; }
    }
}

