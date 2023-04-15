using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class CorrectProgrammer: Programmer
    {
        public int NumberOfCorrectPrograms { get; set; }

        public CorrectProgrammer(string lastName, int numberOfWrittenPrograms, int numberOfProgrammingLanguages, int numberOfCorrectPrograms) 
                                : base(lastName, numberOfWrittenPrograms, numberOfProgrammingLanguages) 
        {
            NumberOfCorrectPrograms = numberOfCorrectPrograms;
        }

        public override double GetQuantityOfProgramsLanguages()
        {
            return (base.GetQuantityOfProgramsLanguages() * NumberOfCorrectPrograms) / NumberOfWrittenPrograms;
        }

        public override string ToString()
        {
            return $"[lastName: {LastName}\nnumberOfWrittenPrograms: {NumberOfWrittenPrograms}\n" +
                    $"numberOfProgrammingLanguages: {NumberOfProgrammingLanguages}\nQ: {GetQuantityOfProgramsLanguages()}]\n";
        }
    }
}
