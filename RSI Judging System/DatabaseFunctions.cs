using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RSI_Judging_System
{
    public class DatabaseFunctions
    {
        public static void SaveTop5(string _personality, string _wit, string _judgeNo, string _contestantNo, out string message)
        {
            message = "";

            try
            {
                using (var db = new RSIJudgingSystemEntities())
                {
                    if(_judgeNo == "1")
                    {
                        Top5Judge1 newTop5 = new Top5Judge1
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if(_judgeNo == "2")
                    {
                        Top5Judge2 newTop5 = new Top5Judge2
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "3")
                    {
                        Top5Judge3 newTop5 = new Top5Judge3
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "4")
                    {
                        Top5Judge4 newTop5 = new Top5Judge4
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "5")
                    {
                        Top5Judge5 newTop5 = new Top5Judge5
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "6")
                    {
                        Top5Judge6 newTop5 = new Top5Judge6
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "7")
                    {
                        Top5Judge7 newTop5 = new Top5Judge7
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }

                    db.SaveChanges();
                }
            }
            catch(Exception error)
            {
                message = error.Message;
            }
        }

        public static void SaveTop10(string _beauty, string _intelligence, string _delivery, string judgeNo,
            string _contestantNo, out string message)
        {
            message = "";

            try
            {
                using (var db = new RSIJudgingSystemEntities())
                {
                    if(judgeNo == "1")
                    {
                        Top10Judge1 newJ = new Top10Judge1
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "2")
                    {
                        Top10Judge2 newJ = new Top10Judge2
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "3")
                    {
                        Top10Judge3 newJ = new Top10Judge3
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "4")
                    {
                        Top10Judge4 newJ = new Top10Judge4
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "5")
                    {
                        Top10Judge5 newJ = new Top10Judge5
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "6")
                    {
                        Top10Judge6 newJ = new Top10Judge6
                        {
                            ContestantNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }
                    else if(judgeNo == "7")
                    {
                        Top10Judge7 newJ = new Top10Judge7
                        {
                            ContestanceNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Delivery = decimal.Parse(_delivery),
                            Intelligence = decimal.Parse(_intelligence)
                        };

                        db.Entry(newJ).State = EntityState.Added;
                    }


                    db.SaveChanges();
                }
            }
            catch(Exception error)
            {
                message = error.Message;
            }
        }
    }
}
