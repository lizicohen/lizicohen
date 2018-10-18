using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSinema
{
    public class InitialDB
    {
        public void SetDataBase()
        {
            DAL.DbTabels context = DAL.DbTabels.GetInstance();

            try
            {
               // if (!context.Database.Exists())
               // {
                   if (!context.Moveis.Any())
                   {
                        context.Moveis.Add(new Moveis
                        {
                            MoveiID = 1001,
                            MoveiName = "The Lion King",
                            RatingAvg = 4.2M,
                            Description = "The Lion King tells the story of Simba, a young lion who is to succeed his father, Mufasa, as King of the Pride Lands; however, after Simba's uncle Scar (Mufasa's jealous younger brother), murders Mufasa, Simba is manipulated into thinking he was responsible and flees into exile. Upon maturation living with two wastrels, Simba is given some valuable perspective from his childhood friend, Nala, and his shaman, Rafiki, before returning to challenge Scar to end his tyranny and take his place in the Circle of Life as the rightful King.",
                            Janer = "childen, animals",
                        });
                    context.Moveis.Add(new Moveis
                    {
                        MoveiID = 1002,
                        MoveiName = "The firman sami",
                        RatingAvg = 3.8M,
                        Description = "Sam is a competent and brave firefighter, who helps keep the people of Pontypandy safe. He considers his job to be 'the best job in the world', and often helps out in emergencies even on his days off. However, he does have an inventive streak which sometimes gets him in trouble when one of his inventions goes haywire: since Series 6 , he has stopped inventing, though he can be creative from time to time, such as fashioning a barbeque out of an oil drum in Sausages vs. Shrimps .",
                        Janer = "childen"
                    });
                    context.Moveis.Add(new Moveis
                    {
                        MoveiID = 1003,
                        MoveiName = "bob the building",
                        RatingAvg = 4.7M,
                        Description = "Bob the Builder is a British children's animated television show created by Keith Chapman. In the original series, Bob appears in a stop motion animated programme as a building contractor, specialising in masonry, along with his colleague Wendy, various neighbours and friends, and their gang of anthropomorphised work-vehicles and equipment. The show is broadcast in many countries, but originates from the United Kingdom where Bob is voiced by English actor Neil Morrissey. The show was later created using CGIanimation starting with the spin-off series Ready, Steady, Build!.In each episode,\n  Bob and his group help with renovations, construction, and repairs and with other projects as needed.The show emphasises conflict resolution, co - operation, socialisation and various learning skills.Bob\'s catchphrase is 'Can we fix it ? ', to which the other characters respond with 'Yes we can!' This phrase is also the title of the show\'s theme song, which was a million - selling number one hit in the UK.",
                        Janer = "childen"
                    });

                }
                    if (!context.TimeAndPlace.Any())
                    {
                        context.TimeAndPlace.Add(new TimeAndPlace
                        {
                            Date = DateTime.Parse("25/05/2018 17:45:00"),
                            Place = "Sinema Sity Cholon",
                            Region = "Center",
                            PriceCard = 50,
                            AmountCardsLeft = 75,
                            MoveiID = 1001,
                            AmountCardsToSell = 250

                        });

                    }
                    if (!context.Users.Any())
                    {
                        context.Users.Add(new Users
                        {
                            UserName = "AviRon",
                            Password = "Avi1234",
                            IsAdmin = false,
                            Phone = "050998877",
                            Email = "ramzor@kvish.com",
                            FirstName = "Ram",
                            LastName = "Zor",
                            OwnerId = "200333444",
                            NumCard = "50041765899321",
                            Cvv="523",
                            ExpirtyDate = DateTime.Parse("01,2020"),
                            CreditCard = CreditCompany.AmericanExpress,


                        });

                    }
                    if (!context.Orders.Any())
                    {
                        context.Orders.Add(new Orders
                        {
                            AmountCardsIsBuy = 4,
                            SumPrice = 50,
                            //MoveiID = 1001,
                            DateOrders = DateTime.Parse("28,06,2018,17:50:00"),


                        });
                    }

                    if (!context.FeedBack.Any())
                    {
                        context.FeedBack.Add(new Feedback
                        {
                            MoveiID = 1001,
                            FeedbackText = "Muvie wonderfull. for childern and all family",
                            Rating = 4.5M


                        });
                    }
                    context.SaveChanges();

              //  }

            }
            catch (Exception) {}

        }
    }
}