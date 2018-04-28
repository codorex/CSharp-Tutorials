using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Problem1
{

	// Declaring enums
	enum Gender
	{
		Unassigned = 0,
		Female = 1,
		Male = 2
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please, enter an EGN to operate on: ");
			string egn = Console.ReadLine();

			DateTime dateOfBirth;
			Gender gender;
			bool extractionResult = ExtractData(egn, out dateOfBirth, out gender);

			Console.WriteLine(dateOfBirth);
			Console.WriteLine(gender);

			Console.ReadKey();
		}

		public static bool ExtractData(string egn, out DateTime dateOfBirth, out Gender gender)
		{

			dateOfBirth = ExtractDate(egn);
			gender = ExtractGender(egn);

			return ValidateEgn(egn);
		}

		public static bool ValidateEgn(string egn)
		{
			bool isValid = false;

			// a valid EGN will contain exactly 10 symbols, all of which are digits (not letters or other characters)
			// any other EGNs should be treated as invalid, so in such cases return false

			return isValid;
		}

		private static Gender ExtractGender(string egn)
		{
			Gender gender = Gender.Unassigned;
			// validate EGN before making extracting the gender
			// for isValid call your ValidateEgn function/method
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
			}
			
			return gender;
		}

		private static DateTime ExtractDate(string egn)
		{
			DateTime date = new DateTime();

			bool isValid = ValidateEgn(egn);
			// valdiate EGN first
			// for isValid call your ValidateEgn function/method

			if (isValid)
			{
				string dateOfBirth;
				dateOfBirth = egn.Substring(0, 6);

				// convert the extracted symbols to integers and then create the DateTime object;
				// for example:
				// the following code returns the month digits and converts them from string to an integer:

				int month;
				Int32.TryParse(dateOfBirth.Substring(2, 2), out month);

				// then pass the three integers as arguments to the below class' constructor
				date = new DateTime();
			}
			
			return date;
		}
	}
}
