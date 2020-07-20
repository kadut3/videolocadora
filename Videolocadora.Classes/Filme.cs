using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Videolocadora.Classes
{
    public class Filme: DbContext
    {
        public Filme(DbContextOptions<Filme> options): base(options)
        {

        }

        public DbSet<FilmeAtributos> FilmeAtributos { get; set; }

    }
}
