using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Models
{
    public class PurchasedLottery
    {
        public int LotteryId { get; set; }
        public Lottery Lottery { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

    }
}
