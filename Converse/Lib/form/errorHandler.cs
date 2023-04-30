using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    static class errorHandler
    {
        static private string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static private int errHand_inputStrCorrect(string inputNumber)
        {
            string[] buff = inputNumber.Split(',', '.');
            
            if (buff.Length > 2 ) { return 1; }
            if (buff.Length > 1 ) 
            {
                alphabet += ".,";
            }
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (!alphabet.Contains(inputNumber[i]))
                {
                    return 1;
                }
            }
            return 0;
        }
        static private int errHand_ScaleOfNotCorrect(string inputNumber, string inputScale, string outScale, string N)
        {
            int inpCC;
            int outCC;
            int NDigits;
            if (!int.TryParse(inputScale, out inpCC))
            {
                return 2;
            }

            if (!int.TryParse(outScale, out outCC))
            {
                return 5;
            }
            if (!int.TryParse(N, out NDigits))
            {
                return 6;
            }

            if (NDigits > 17 || NDigits < 0)
                return 7;
            if (outCC < 2 || outCC > 36)
                return 8;

            if (inpCC < 2 || inpCC > 36)
            {
                return 3;
            }
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (alphabet.IndexOf(inputNumber[i]) >= inpCC && (inputNumber[i] != '.' && inputNumber[i] != ','))
                {
                    return 4;
                }
            }
            return 0;
        }
        
        static public int[] dataCorrect(string inputNumber, string inputScale, string outScale, string N)
        {
            int[] log = new int[9];
            log[errHand_inputStrCorrect(inputNumber)] += 1;
            log[errHand_ScaleOfNotCorrect(inputNumber, inputScale, outScale, N)] += 1;
            return log;
        }
    }
}
