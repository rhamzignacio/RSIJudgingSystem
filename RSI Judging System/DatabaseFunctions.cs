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
        public static void SaveTop5(string _beauty, string _intelligence, string _poise, string _judgeNo, string _contestantNo, out string message)
        {
            message = "";

            try
            {
                using (var db = new RSIJudgingSystemEntities())
                {
                    if(_judgeNo == "1")
                    {
                        Top5Judge1 j = new Top5Judge1
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }
                    else if (_judgeNo == "2")
                    {
                        Top5Judge2 j = new Top5Judge2
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }
                    else if (_judgeNo == "3")
                    {
                        Top5Judge3 j = new Top5Judge3
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }

                    else if (_judgeNo == "4")
                    {
                        Top5Judge4 j = new Top5Judge4
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }

                    else if (_judgeNo == "5")
                    {
                        Top5Judge5 j = new Top5Judge5
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }

                    else if (_judgeNo == "6")
                    {
                        Top5Judge6 j = new Top5Judge6
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }

                    else if (_judgeNo == "7")
                    {
                        Top5Judge7 j = new Top5Judge7
                        {
                            CandidateNo = _contestantNo,
                            Beauty = decimal.Parse(_beauty),
                            Intelligence = decimal.Parse(_intelligence),
                            Poise = decimal.Parse(_poise)
                        };

                        db.Entry(j).State = EntityState.Added;
                    }

                    db.SaveChanges();
                }
            }
            catch(Exception error)
            {
                message = error.Message;
            }
        }

        public static void SaveRanking(string _personality, string _wit, string _judgeNo, string _contestantNo, out string message)
        {
            message = "";

            try
            {
                using (var db = new RSIJudgingSystemEntities())
                {
                    if(_judgeNo == "1")
                    {
                        RankingJudge1 newTop5 = new RankingJudge1
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if(_judgeNo == "2")
                    {
                        RankingJudge2 newTop5 = new RankingJudge2
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "3")
                    {
                        RankingJudge3 newTop5 = new RankingJudge3
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "4")
                    {
                        RankingJudge4 newTop5 = new RankingJudge4
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "5")
                    {
                        RankingJudge5 newTop5 = new RankingJudge5
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "6")
                    {
                        RankingJudge6 newTop5 = new RankingJudge6
                        {
                            ContestantNo = _contestantNo,
                            Personality = decimal.Parse(_personality),
                            Wit = decimal.Parse(_wit)
                        };

                        db.Entry(newTop5).State = EntityState.Added;
                    }
                    else if (_judgeNo == "7")
                    {
                        RankingJudge7 newTop5 = new RankingJudge7
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
