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
        private decimal? _beauty1;
        public decimal? beauty1
        {
            get
            {
                if (_beauty1 == null)
                    return 0;
                else
                    return _beauty1;
            }
            set
            {
                _beauty1 = value;
            }
        }

        private decimal? _intelligence1;
        public decimal? intelligence1
        {
            get
            {
                if (_intelligence1 == null)
                    return 0;
                else
                    return _beauty1;
            }
            set
            {
                _intelligence1 = value;
            }
        }

        private decimal? _delivery1;
        public decimal? delivery1
        {
            get
            {
                if (_delivery1 == null)
                    return 0;
                else
                    return _delivery1;
            }
            set
            { 
                _delivery1 = value;
            }
        }
        public decimal? total1
        {
            get
            {
                return beauty1 + intelligence1 + delivery1 + PIScore;
            }
        }

        //JudgeNo2
        private decimal? _beauty2;
        public decimal? beauty2
        {
            get
            {
                if (_beauty2 == null)
                    return 0;
                else
                    return _beauty2;
            }
            set
            {
                _beauty2= value;
            }
        }

        private decimal? _intelligence2;
        public decimal? intelligence2
        {
            get
            {
                if (_intelligence2 == null)
                    return 0;
                else
                    return _beauty2;
            }
            set
            {
                _intelligence2 = value;
            }
        }

        private decimal? _delivery2;
        public decimal? delivery2
        {
            get
            {
                if (_delivery2 == null)
                    return 0;
                else
                    return _delivery2;
            }
            set
            {
                _delivery2 = value;
            }
        }
        public decimal? total2
        {
            get
            {
                return beauty2 + intelligence2 + delivery2 + PIScore;
            }
        }

        //JudgeNo3
        private decimal? _beauty3;
        public decimal? beauty3
        {
            get
            { 
                if (_beauty3 == null)
                    return 0;
                else
                    return _beauty3;
            }
            set
            {
                _beauty3 = value;
            }
        }

        private decimal? _intelligence3;
        public decimal? intelligence3
        {
            get
            {
                if (_intelligence3 == null)
                    return 0;
                else
                    return _beauty3;
            }
            set
            {
                _intelligence3 = value;
            }
        }

        private decimal? _delivery3;
        public decimal? delivery3
        {
            get
            {
                if (_delivery3 == null)
                    return 0;
                else
                    return _delivery3;
            }
            set
            {
                _delivery3 = value;
            }
        }
        public decimal? total3
        {
            get
            {
                return beauty3 + intelligence3 + delivery3 + PIScore;
            }
        }

        //JudgeNo4 
        private decimal? _beauty4;
        public decimal? beauty4
        {
            get
            {
                if (_beauty4 == null)
                    return 0;
                else
                    return _beauty4;
            }
            set
            {
                _beauty4 = value;
            }
        }

        private decimal? _intelligence4;
        public decimal? intelligence4
        {
            get
            {
                if (_intelligence4 == null)
                    return 0;
                else
                    return _beauty4;
            }
            set
            {
                _intelligence4 = value;
            }
        }

        private decimal? _delivery4;
        public decimal? delivery4
        {
            get
            {
                if (_delivery4 == null)
                    return 0;
                else
                    return _delivery4;
            }
            set
            {
                _delivery4 = value;
            }
        }
        public decimal? total4
        {
            get
            {
                return beauty4 + intelligence4 + delivery4 + PIScore;
            }
        }

        //JudgeNo5
        private decimal? _beauty5;
        public decimal? beauty5
        {
            get
            {
                if (_beauty5 == null)
                    return 0;
                else
                    return _beauty5;
            }
            set
            {
                _beauty5 = value;
            }
        }

        private decimal? _intelligence5;
        public decimal? intelligence5
        {
            get
            {
                if (_intelligence5 == null)
                    return 0;
                else
                    return _beauty5;
            }
            set
            {
                _intelligence5 = value;
            }
        }

        private decimal? _delivery5;
        public decimal? delivery5
        {
            get
            {
                if (_delivery5 == null)
                    return 0;
                else
                    return _delivery5;
            }
            set
            {
                _delivery5 = value;
            }
        }
        public decimal? total5
        {
            get
            {
                return beauty5 + intelligence5 + delivery5 + PIScore;
            }
        }

        //JudgeNo6
        private decimal? _beauty6;
        public decimal? beauty6
        {
            get
            {
                if (_beauty6 == null)
                    return 0;
                else
                    return _beauty6;
            }
            set
            {
                _beauty6 = value;
            }
        }

        private decimal? _intelligence6;
        public decimal? intelligence6
        {
            get
            {
                if (_intelligence6 == null)
                    return 0;
                else
                    return _beauty6;
            }
            set
            {
                _intelligence6 = value;
            }
        }

        private decimal? _delivery6;
        public decimal? delivery6
        {
            get
            {
                if (_delivery6 == null)
                    return 0;
                else
                    return _delivery6;
            }
            set
            {
                _delivery6 = value;
            }
        }
        public decimal? total6
        {
            get
            {
                return beauty6 + intelligence6 + delivery6 + PIScore;
            }
        }

        //JudgeNo7
        private decimal? _beauty7;
        public decimal? beauty7
        {
            get
            {
                if (_beauty7 == null)
                    return 0;
                else
                    return _beauty7;
            }
            set
            {
                _beauty7 = value;
            }
        }

        private decimal? _intelligence7;
        public decimal? intelligence7
        {
            get
            {
                if (_intelligence7 == null)
                    return 0;
                else
                    return _beauty7;
            }
            set
            {
                _intelligence7 = value;
            }
        }

        private decimal? _delivery7;
        public decimal? delivery7
        {
            get
            {
                if (_delivery7 == null)
                    return 0;
                else
                    return _delivery7;
            }
            set
            {
                _delivery7 = value;
            }
        }

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

        public decimal? TotalScoreLinq { get; set; }
    }
}
