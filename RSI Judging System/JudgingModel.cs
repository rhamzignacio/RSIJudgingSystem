using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_Judging_System
{
    class JudgingModel
    {
    }

    public class Top5Model
    {
        public string contestantNo { get; set; }
        public decimal panelInterview { get; set; }
        public decimal PIScore
        {
            get
            {
                return (panelInterview / 100) * 50;
            }
        }

        //JudgeNo1
        public decimal? beauty1 { get; set; }
        public decimal? intelligence1 { get; set; }
        public decimal? delivery1 { get; set; }
        public decimal? total1
        {
            get
            {
                return beauty1 + intelligence1 + delivery1 + PIScore;
            }
        }

        //JudgeNo2
        public decimal? beauty2 { get; set; }
        public decimal? intelligence2 { get; set; }
        public decimal? delivery2 { get; set; }
        public decimal? total2
        {
            get
            {
                return beauty2 + intelligence2 + delivery2 + PIScore;
            }
        }

        //JudgeNo3
        public decimal? beauty3 { get; set; }
        public decimal? intelligence3 { get; set; }
        public decimal? delivery3 { get; set; }
        public decimal? total3
        {
            get
            {
                return beauty3 + intelligence3 + delivery3 + PIScore;
            }
        }

        //JudgeNo4 
        public decimal? beauty4 { get; set; }
        public decimal? intelligence4 { get; set; }
        public decimal? delivery4 { get; set; }
        public decimal? total4
        {
            get
            {
                return beauty4 + intelligence4 + delivery4 + PIScore;
            }
        }

        //JudgeNo5
        public decimal? beauty5 { get; set; }
        public decimal? intelligence5 { get; set; }
        public decimal? delivery5 { get; set; }
        public decimal? total5
        {
            get
            {
                return beauty5 + intelligence5 + delivery5 + PIScore;
            }
        }

        //JudgeNo6
        public decimal? beauty6 { get; set; }
        public decimal? intelligence6 { get; set; }
        public decimal? delivery6 { get; set; }
        public decimal? total6
        {
            get
            {
                return beauty6 + intelligence6 + delivery6 + PIScore;
            }
        }

        //JudgeNo7
        public decimal? beauty7 { get; set; }
        public decimal? intelligence7 { get; set; }
        public decimal? delivery7 { get; set; }
        public decimal? total7
        {
            get
            {
                return beauty7 + intelligence7 + delivery7 + PIScore;
            }
        }

        public decimal? TotalScore
        {
            get
            {
                return (total1 + total2 + total3 + total4 + total5 + total6 + total7) / 7;
            }
        }
    }
}
