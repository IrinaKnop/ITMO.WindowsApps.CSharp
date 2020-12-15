using System.Reflection;

namespace Calculator
{

	using System;

	public class CalculatorEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			eSquaring = 5,
			eDegree = 6,
			eSqrt = 7,
			eCubeRoot = 8,
			eReverse = 9,
			eFactorial = 10
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v2.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalculatorEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static void CalcOperation (Operator calcOper)
		{
            
            if (stringAnswer != "" && !secondNumberAdded)
			{
				if (calcOper == Operator.eSquaring || calcOper == Operator.eFactorial || calcOper == Operator.eCubeRoot || calcOper == Operator.eReverse || calcOper == Operator.eSqrt)
				{
					secondNumberAdded = true;
				}
				firstNumber = System.Convert.ToDouble (stringAnswer);
				calcOperation = calcOper;
				if (!secondNumberAdded)
				{
					stringAnswer = "";
				}
				decimalAdded = false;
			}
			
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ",";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				if (secondNumberAdded != true)
				{
					secondNumber = System.Convert.ToDouble(stringAnswer);
					secondNumberAdded = true;
				}
				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

					case Operator.eSquaring:
						numericAnswer = Math.Pow(firstNumber, 2);
						validEquation = true;
						break;

					case Operator.eDegree:
						numericAnswer = Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;

					case Operator.eSqrt:
						if (firstNumber > 0)
						{
							numericAnswer = Math.Sqrt(firstNumber);
							validEquation = true;
						}
						else
                        {
							validEquation = false;
                        }
						break;

					case Operator.eCubeRoot:
						numericAnswer = Math.Round(Math.Pow(firstNumber, 1/3f), 2);
						validEquation = true;
						break;

					case Operator.eReverse:
						if (firstNumber > 0)
						{
							numericAnswer = 1 / firstNumber;
							validEquation = true;
						}
						else
						{
							validEquation = false;
						}
						break;

					case Operator.eFactorial:
						if (firstNumber > 0)
						{
							numericAnswer = 1;
							for (int i = 1; i < firstNumber+1; i++)
							{
								numericAnswer *= i;
							}
							validEquation = true;
						}
						else
						{
							validEquation = false;
						}
						break;

					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
	}
}