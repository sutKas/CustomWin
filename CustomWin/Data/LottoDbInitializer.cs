using CustomWin.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Data
{
    public class LottoDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LottoDbContext>();

                context.Database.EnsureCreated();

                //data winner
                if (!context.Winners.Any())
                {
                    context.Winners.AddRange(new List<Winner>()
                    {
                        new Winner()
                        {
                           Profile = "~/Images/profilePic1.jpg",
                           FirstName = "Abel",
                           LastName = "Kebede",
                           Prize = "ETB 5,000"
                        },
                        new Winner()
                        {
                           Profile = "~/Images/profilePic2.jpg",
                           FirstName = "Jerry",
                           LastName = "Jhon",
                           Prize = "ETB 3,000"
                        },
                        new Winner()
                        {
                           Profile = "~/Images/profilePic4.jpg",
                           FirstName = "Alex",
                           LastName = "Jhon",
                           Prize = "ETB 2,000"
                        },
                        new Winner()
                        {
                           Profile = "~/Images/profilePic5.jpg",
                           FirstName = "Sofia",
                           LastName = "Green",
                           Prize = "ETB 1,000"
                        },
                        new Winner()
                        {
                           Profile = "~/Images/profilePic4.jpg",
                           FirstName = "Robert",
                           LastName = "Alex",
                           Prize = "ETB 500"
                        },
                     });
                    context.SaveChanges();
                    
                    
                }
                //data player
                if (!context.Players.Any())
                {
                    context.Players.AddRange(new List<Player>()
                    {
                        new Player()
                        {
                           Profile = "~/Images/profilePic1.jpg",
                           FirstName = "Abel",
                           LastName = "Kebede",
                           Email = "abelkebede@gmail.com"
                        },
                        new Player()
                        {
                           Profile = "~/Images/profilePic2.jpg",
                           FirstName = "Jerry",
                           LastName = "Jhon",
                           Email = "jerry@gmail.com"
                        },
                        new Player()
                        {
                           Profile = "~/Images/profilePic3.jpg",
                           FirstName = "Gwen",
                           LastName = "Mark",
                           Email = "gwenmark@gmail.com"
                        },
                        new Player()
                        {
                           Profile = "~/Images/profilePic4.jpg",
                           FirstName = "Alex",
                           LastName = "Jhon",
                           Email = "alexjhon@gmail.com"
                        },
                        new Player()
                        {
                           Profile = "~/Images/profilePic5.jpg",
                           FirstName = "Sofia",
                           LastName = "Green",
                           Email = "sofia@gmail.com"
                        },
                          new Player()
                        {
                           Profile = "~/Images/profilePic6.jpg",
                           FirstName = "Ben",
                           LastName = "Blue",
                           Email = "ben@gmail.com"
                        },
                         new Player()
                        {
                           Profile = "~/Images/profilePic7.jpg",
                           FirstName = "Smith",
                           LastName = "Ken",
                           Email = "smithken21@gmail.com"
                        },
                         new Player()
                        {
                           Profile = "~/Images/profilePic8.jpg",
                           FirstName = "Jully",
                           LastName = "Will",
                           Email = "jullywill545@gmail.com"
                        },
                        new Player()
                        {
                           Profile = "~/Images/profilePic9.jpg",
                           FirstName = "Robert",
                           LastName = "Alex",
                           Email = "robertalex@gmail.com"
                        },
                         new Player()
                        {
                           Profile = "~/Images/profilePic10.jpg",
                           FirstName = "Kevin",
                           LastName = "Bekam",
                           Email = "kevinbekam@gmail.com"
                        },
                     });
                    context.SaveChanges();
                }

                //data sysManager
               
                //data LOTTO
                if (!context.Lotteries.Any())
                {
                    context.Lotteries.AddRange(new List<Lottery>()
                    {
                        new Lottery()
                        {
                           LottoSignature = "~/Images/customLoto1.jpg",
                           Name = "Lottery1",
                           Prizes = "1. First Prize 100,000"+
                                    "2. Second Prize 70,000" +
                                    "3. Third Prize 50,000" +
                                    "4. Fourth Prize 25,000" +
                                    "5. Fifth Prize 10,000",
                           Price = "15.00",
                           DrawDate = DateTime.Now.AddDays(+60),
                           LottoCategory = LottoCategory.Regular,
                           WinnerId = 2,
                           SyManagerId = 2
                        },
                        new Lottery()
                        {
                           LottoSignature = "~/Images/customLoto2.jpg",
                           Name = "Lottery2",
                           Prizes = "1. First Prize 500,00" +
                                    "2. Second Prize 250,000" +
                                    "3. Third Prize 150,000" +
                                    "4. Fourth Prize 75,000" +
                                    "5. Fifth Prize 50,000",
                           Price = "55.00",
                           DrawDate = DateTime.Now.AddDays(+70),
                           LottoCategory = LottoCategory.Regular,
                           WinnerId = 1,
                           SyManagerId = 1
                        },
                        new Lottery()
                        {
                           LottoSignature = "~/Images/customLoto1.jpg",
                           Name = "Lottery3",
                           Prizes = "1. First Prize 1,000" +
                                    "2. Second Prize 700" +
                                    "3. Third Prize 500" +
                                    "4. Fourth Prize 250" +
                                    "5. Fifth Prize 100",
                           Price ="5.00",
                           DrawDate = DateTime.Now.AddDays(+21),
                           LottoCategory = LottoCategory.Group,
                           WinnerId = 3,
                           SyManagerId = 3
                        },
                        new Lottery()
                        {
                           LottoSignature = "~/Images/customLoto4.jpg",
                           Name = "Lottery4",
                           Prizes = "1. First Prize 1,000,000" +
                                    "2. Second Prize 500,000" +
                                    "3. Third Prize 250,000" +
                                    "4. Fourth Prize 100,000" +
                                    "5. Fifth Prize 50,000",
                           Price = "30.00",
                           DrawDate = DateTime.Now.AddDays(+30),
                           LottoCategory = LottoCategory.Custom,
                           WinnerId = 1,
                           SyManagerId = 1,
                        },
                        new Lottery()
                        {
                           LottoSignature = "~/Images/customLoto5.jpg",
                           Name = "Lottery5",
                           Prizes = "1. First Prize 10,000,000" +
                                    "2. Second Prize 5,000,000" +
                                    "3. Third Prize 1,000,000" +
                                    "4. Fourth Prize 500,000" +
                                    "5. Fifth Prize 100,000",
                           Price = "50.00",
                           DrawDate = DateTime.Now.AddDays(+45),
                           LottoCategory = LottoCategory.Custom,
                           WinnerId = 3,
                           SyManagerId = 3,
                        },
                       
                     });
                   // context.SaveChanges();
                   
                }
                //PURCHASED
                if (!context.PurchasedLotteries.Any())
                {
                    context.PurchasedLotteries.AddRange(new List<PurchasedLottery>()
                    {
                        new PurchasedLottery()
                        {
                           LotteryId = 1,
                           PlayerId = 1
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 2,
                           PlayerId = 2
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 3,
                           PlayerId = 3
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 4,
                           PlayerId = 4
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 5
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 6
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 7
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 8
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 9
                        },
                        new PurchasedLottery()
                        {
                           LotteryId = 5,
                           PlayerId = 10
                        },



                     });
                    //context.SaveChanges();

                }
                //data sysManager
                if (!context.SystemManagers.Any())
                {
                    context.SystemManagers.AddRange(new List<SystemManager>()
                    {
                        new SystemManager()
                        {
                           Profile = "~/Images/profilePic11.jpg",
                           FirstName = "Alexander",
                           LastName = "Jhon"
                        },
                        new SystemManager()
                        {
                           Profile = "~/Images/profilePic12.jpg",
                           FirstName = "Micheal",
                           LastName = "Zenix"
                        },
                        new SystemManager()
                        {
                           Profile = "~/Images/profilePic13.jpg",
                           FirstName = "Rhav",
                           LastName = "Alex"
                        },
                         new SystemManager()
                        {
                           Profile = "~/Images/profilePic13.jpg",
                           FirstName = "Akma",
                           LastName = "Alex"
                        },
                          new SystemManager()
                        {
                           Profile = "~/Images/profilePic13.jpg",
                           FirstName = "Yaya",
                           LastName = "Alex"
                        },


                     });
                    context.SaveChanges();

                }
            }
        }
    }
}
