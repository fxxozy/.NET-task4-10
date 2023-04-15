using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Programmer
    {
        public string LastName { get; set; }
        public int NumberOfWrittenPrograms { get; set; }
        public int NumberOfProgrammingLanguages { get; set; }

        public Programmer(string lastName, int numberOfWrittenPrograms, int numberOfProgrammingLanguages)
        {
            LastName = lastName;
            NumberOfWrittenPrograms = numberOfWrittenPrograms;
            NumberOfProgrammingLanguages = numberOfProgrammingLanguages;
        }

        public virtual double GetQuantityOfProgramsLanguages() {
            return NumberOfWrittenPrograms * NumberOfProgrammingLanguages;
        }

        public override string ToString()
        {
            return $"[lastName: {LastName}\nnumberOfWrittenPrograms: {NumberOfWrittenPrograms}\n" +
                    $"numberOfProgrammingLanguages: {NumberOfProgrammingLanguages}\nQ: {GetQuantityOfProgramsLanguages()}]\n";
        }
    }
}
