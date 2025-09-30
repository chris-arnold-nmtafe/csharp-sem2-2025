using System;
using Friday;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday
{
    class SurveyItem
    {
        private static Random rnd = new Random();
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RecordDate { get; set; }
        public int AnswerToQuestion { get; set; }
        public SurveyItem() {
            Id = rnd.Next();
            AnswerToQuestion = rnd.Next();
            Name = "🍔".Repeat(rnd.Next(4));
            RecordDate = DateTime.Now.AddDays(rnd.Next(100));
        }

    }
}
