using CustomWin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Models
{
    public class Lottery
    {

        public int LotteryId { get; set; }
        
        public string LottoSignature { get; set; }
        
        public string Name { get; set; }
        
        public string Prizes { get; set; }
        
        public string Price { get; set; }
        
        public DateTime DrawDate { get; set; }
        
        public LottoCategory LottoCategory { get; set; }

        //relations
        public List<PurchasedLottery> PurchasedLotteries { get; set; }

        //winner
        public int WinnerId { get; set; }
        [ForeignKey("WinnerId")]

        public  Winner Winner { get; set; }

        //Symanager
        public int SyManagerId { get; set; }
        [ForeignKey("SyManagerId")]
         

        public SystemManager SystemManager { get; set; }

    }
}
