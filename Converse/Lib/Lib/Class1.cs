using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lib
{
    /// <summary>
    /// Представляет метод перевода чисел из системы счисления p в систему счисления q, 
    /// где p, q находятся в диапозоне [2; 36],
    /// число представляет строку, содержащую целую и дробную часть, 
    /// разделенную точкой либо запятой.
    /// </summary>
    static public class Convertion
    {
        /// <summary>
        /// Представляет метод округления числа в меньшую сторону 
        /// до заданного количества знаков после запятой,
        /// где число представляет строку, содержащую целую и дробную часть,
        /// а количество знаков после запятой задается целым числом
        /// </summary>
        /// <param name="num">Округляемое число в формате строки</param>
        /// <param name="precisity">Количество знаков после запятой</param>
        /// <returns>Округленное число в формате строки</returns>
        /// </summary>
        static public string RoundAnything(string num, int precisity)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '.' || num[i] == ',')
                    return num.Substring(0,
                        i + precisity + 1 < num.Length - i ? i + precisity + 1 : num.Length);
            }
            return num;
        }
        /// <summary>
        /// Представляет метод, конвертирующий заданное число из системы счисления p
        /// в систему счисления q, где p, q находятся в диапозоне [2; 36],
        /// число представляет строку, содержащую целую и дробную часть, 
        /// разделенную точкой либо запятой. 
        /// </summary>
        /// <param name="num">Конвертируемое число в формате строки</param>
        /// <param name="baseOfNum">Система счисления конвертируемого числа</param>
        /// <param name="resBase">Желаемая система счисления</param>
        /// <returns>Число в необходимой системе счисления в формате строки</returns>
        /// </summary>
        static public string ConvertSysms(string num, int baseOfNum, int resBase)
        {
            string tempRes = ConvertToDec(num, baseOfNum);
            string res = ConvertFromDec(tempRes, resBase);
            return res;
        }
        /// <summary>
        /// Представляет модуль, который конвертирует целую и дробную часть заданного пользователем числа
        /// из системы счисления p в 10-ичную систему счисления,
        /// где число представляет из себя строку, а p находится в диапазоне [2;36]
        /// </summary>
        /// <param name="number">Конвертируемое число в формате строки</param>
        /// <param name="baseOfNum">Заданная пользователем система счисления</param>
        /// <returns>Число в десятичной системы счисления в формате строки</returns>
        /// </summary>
        static public string ConvertToDec(string number, int baseOfNum)
        {
            string s = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] buf = number.Split('.', ',');
            
            string numIntPart = buf[0];
            double res = 0;
            int dlina1 = numIntPart.Length - 1;
            for (int i = 0; i < numIntPart.Length; i++)
            {
                if (s.IndexOf(numIntPart[i]) >= baseOfNum)
                    throw new Exception();
                res += s.IndexOf(numIntPart[i]) * Math.Pow(baseOfNum, dlina1);
                dlina1--;
            }

            if (buf.Length > 1)
            {
                string numFloatPart = buf[1];
                int dlina2 = 1;
                for (int i = 0; i < numFloatPart.Length; i++)
                {
                    res += s.IndexOf(numFloatPart[i]) * Math.Pow(baseOfNum, -dlina2);
                    dlina2++;
                }
            }
            return res.ToString();
        }
        /// <summary>
        /// Представляет модуль, который конвертирует целую и дробную часть числа
        /// из 10-ичной системы счисления в систему счисления q
        /// где число представляет из себя строку, а q находится в диапазоне [2;36]
        /// </summary>
        /// <param name="number">Конвертируемое число в формате строки</param>
        /// <param name="resBase">Желаемая система счисления</param>
        /// <returns>Число в системе счисления q в формате сроки</returns>
        /// </summary>
        static public string ConvertFromDec(string number, int resultBase)
        {
            string Alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultInt = "";
            string resultFloat = "";
            string result;
            string[] Buf = number.Split('.', ',');
            int IntegerPart = int.Parse(Buf[0]);
            
            ///Целая часть

            if (IntegerPart == 0)
            {
                resultInt += "0";
            }
            while (IntegerPart > 0)
            {
                
                resultInt += Convert.ToString(Alphabet[IntegerPart % resultBase]);
                IntegerPart = IntegerPart / resultBase;
            }
            resultInt = ReverseString(resultInt);
            result = resultInt;
            
            ///Дробная часть

            if (Buf.Length > 1)
            {
                string doublePart = "0," + Convert.ToString(Buf[1]);
                for (int i = 0; i < 15; i++)
                {
                    double tValue = double.Parse(doublePart) * resultBase;
                    doublePart = Convert.ToString(tValue);
                    string[] Buff = doublePart.Split('.', ',');
                    resultFloat += Alphabet[int.Parse(Buff[0])];
                    if (Buff.Length == 1)
                        break;
                    doublePart = "0," + Buff[1];
                }

                result += "," + resultFloat;
            }
            return result;
        }


        /// <summary>
        /// Представляет метод, возвращающий строку в обратном порядке символов
        /// </summary>
        /// <param name="str">Данная строка</param>
        /// <returns>Строка в обратном порядке</returns>
        /// </summary>
        static private string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

    }
}