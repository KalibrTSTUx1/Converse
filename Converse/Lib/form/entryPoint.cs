using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    internal class entryPoint
    {
        
        private string inputNumber;
        private string outputNumber;
        private int n;
        private int inputScale;
        private int outputScale;
        public entryPoint(string inputNumber, string outputNumber, int n, int inputScale, int outputScale)
        {
            this.inputNumber = inputNumber;
            this.outputNumber = outputNumber;
            this.n = n;
            this.inputScale = inputScale;
            this.outputScale = outputScale;
        }

        public string getResult()
        {   
            try
            { 
                inputNumber = inputNumber.Trim().Replace(",", ".");
                outputNumber = Convertion.ConvertSysms(inputNumber, inputScale, outputScale);
                outputNumber = Convertion.RoundAnything(outputNumber, n);
                return outputNumber;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
