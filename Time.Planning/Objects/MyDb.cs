using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time.Planning.Objects; 

public class MyDb : DbContext
{
    public DbSet<Chick> Chicks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = . ;  DataBase = MyPlanning-v1 ; Integrated Security = true ;Trusted_Connection=true;Encrypt=false;Integrated Security=True;TrustServerCertificate=True ;");

}
