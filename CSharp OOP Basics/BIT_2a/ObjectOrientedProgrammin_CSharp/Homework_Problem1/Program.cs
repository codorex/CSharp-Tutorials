using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Problem1
{
  enum Gender
  {
    Unassigned = 0,
    Female = 1,
    Male = 2
  }

  enum Direction
  {
    Right = 0,
    Down = 1,
    Left = 2,
    Up = 3
  }

  class Program
  {
    static void Main(string[] args)
    {
      string egn = Console.ReadLine();

      DateTime date;
      Gender gender;
      bool extractionResult = ExtractData(egn, out date, out gender);
      
      Console.WriteLine(date);
      Console.WriteLine(gender);

      Console.ReadKey();
    }

    public static bool ExtractData(string egn, out DateTime date, out Gender gender)
    {
      bool isValid = ValidateEgn(egn);
      if (isValid)
      {
        int genderInt = Int32.Parse(egn[8].ToString());

        if (genderInt % 2 == 0)
        {
          gender = Gender.Male;
        }
        else
        {
          gender = Gender.Female;
        }

        int year = Int32.Parse(egn.Substring(0, 2));
        int month = Int32.Parse(egn.Substring(2, 2));
        int day = Int32.Parse(egn.Substring(4, 2));

        year += 1900;

        date = new DateTime(year, month, day);
      }
      else
      {
        date = new DateTime();
        gender = Gender.Unassigned;
      }

      return isValid;
    }

    public static bool ValidateEgn(string egn)
    {
      if(egn.Length != 10)
      {
        return false;
      }

      for (int i = 0; i < egn.Length; i++)
      {
        if(Char.IsDigit(egn[i]) == false)
        {
          return false;
        }
      }

      return true;
    }
  }
}
