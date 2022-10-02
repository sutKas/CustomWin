using CustomWin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Data
{
    public class LottoDbContext : DbContext
    {
        public LottoDbContext(DbContextOptions<LottoDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchasedLottery>().HasKey(pl => new
            {
                pl.PlayerId,
                pl.LotteryId
            });

            modelBuilder.Entity<PurchasedLottery>().HasOne(l => l.Lottery).WithMany(pl => pl.PurchasedLotteries).HasForeignKey(
                        l => l.LotteryId);
            modelBuilder.Entity<PurchasedLottery>().HasOne(l => l.Player).WithMany(pl => pl.PurchasedLotteries).HasForeignKey(
                        l => l.PlayerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Lottery> Lotteries { get; set; }
        public DbSet<PurchasedLottery> PurchasedLotteries { get; set; }
        public DbSet<Winner> Winners { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
    }
}
