﻿using System;

namespace StringManipulationChallenge
{
  public class Program
  {
    static void Main(string[] args)
    {
      string userInputString;         // this will hold your users message.
      int numberLessThanStringLength; // this will hold the number from steps 6 and 7.
      int elementNum;                 // this will hold the element number within the message that your user indicates.
      string lowerCaseString;         // this will hold the return of StringToUpper()
      char char1;                     // this will hold the char value that your user wants to search for in the message.
      string fName;                   // this will hold the users first name.
      string lName;                   // this will hold the users last name.
      string userFullName;            // this will hold the users full name.

      /*
      *
      * implement the required code here and within the methods below.
      *
      */
    }

    /// <summary>
    /// This method has one string parameter and will: 
    /// 1) change the string to all upper case and 
    /// 2) return the new string.
    /// </summary>
    /// <param name="usersString"></param>
    /// <returns></returns>
    public static string StringToUpper(string usersString)
    {
      // throw new NotImplementedException("StringToUpper method not implemented.");
      return usersString.ToUpper();
    }

    /// <summary>
    /// This method has one string parameter and will:
    /// 1) change the string to all lower case,
    /// 2) return the new string into the 'lowerCaseString' variable
    /// </summary>
    /// <param name="usersString"></param>
    /// <returns></returns>       
    public static string StringToLower(string usersString)
    {
      // throw new NotImplementedException("StringToUpper method not implemented.");
      return usersString.ToLower();
    }

    /// <summary>
    /// This method has one string parameter and will:
    /// 1) trim the whitespace from before and after the string, and
    /// 2) return the new string.
    /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
    /// </summary>
    /// <param name="usersStringWithWhiteSpace"></param>
    /// <returns></returns>
    public static string StringTrim(string usersStringWithWhiteSpace)
    {
      // throw new NotImplementedException("StringTrim method not implemented.");
      return usersStringWithWhiteSpace.Trim();
    }

    /// <summary>
    /// This method has three parameters, one string and two integers. It will:
    /// 1) get the substring based on the first integer element and the length 
    /// of the substring desired.
    /// 2) return the substring.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="firstElement"></param>
    /// <param name="lastElement"></param>
    /// <returns></returns>
    public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
    {
      // throw new NotImplementedException("StringSubstring method not implemented.");
      return x.Substring(firstElement, lengthOfSubsring);
    }

    /// <summary>
    /// This method has two parameters, one string and one char. It will:
    /// 1) search the string parameter for first occurrance of the char parameter and
    /// 2) return the index of the char.
    /// HINT: Think about how StringTrim() (above) would be useful in this situation
    /// when getting the char from the user. 
    /// </summary>
    /// <param name="userInputString"></param>
    /// <param name="charUserWants"></param>
    /// <returns></returns>
    public static int SearchChar(string userInputString, char charUserWants)
    {
      // throw new NotImplementedException("SearchChar method not implemented.");
      return StringTrim(userInputString).IndexOf(charUserWants);
    }

    /// <summary>
    /// This method has two string parameters. It will:
    /// 1) concatenate the two strings with a space between them.
    /// 2) return the new string.
    /// HINT: You will need to get the users first and last name in the 
    /// main method and send them as arguments.
    /// </summary>
    /// <param name="fName"></param>
    /// <param name="lName"></param>
    /// <returns></returns>
    public static string ConcatNames(string fName, string lName)
    {
      // throw new NotImplementedException("ConcatNames method not implemented.");
      return String.Concat(fName, " ", lName);
      // return $"{fName} {lName}";
    }
  }//end of program
}
