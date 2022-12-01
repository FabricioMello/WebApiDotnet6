using BackendAVMB.Dtos;
using Microsoft.EntityFrameworkCore;

namespace BackendAVMB.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ResponseGetDadosEnvelope.Response> Envelopes { get; set; }
    }
}
