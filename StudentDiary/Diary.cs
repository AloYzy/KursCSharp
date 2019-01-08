using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<double> marks = new List<double>();

        public void AddMark(double mark)
        {
            marks.Add(mark);
        }

        public double CalculateAverage()
        {
            double sum = 0;
            foreach(double item in marks)
            {
                sum += item;
            }
            return sum / marks.Count();
        }

        public double ReturnMax()
        {
            return marks.Max();
        }

        public double ReturnMin()
        {
            return marks.Min();
        }
    }
}
