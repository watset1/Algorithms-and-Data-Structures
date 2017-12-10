using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere
{
    //Class that processes the Vigenere algorithm
    public class VigenereController
    {
        const int MODVALUE = 26;  //Holds the value to be used in modulo method (The length of the alphabet)
        const int ASCII_MINVALUE = 65; //The value used to set the value given to the modulo method in the correct numbe range

        public VigenereController() { }
       
        //Returns a modded passed in value
        public int Modulo(int value)
        {
            if (value < 0)
                return MODVALUE + value;
            else
                return value % MODVALUE;
        }

        //Method to encrypt an individual character
        public char EncryptOneLetter(char currentLetter, char keyValue)
        {
            //Returns a space if space is passed in
            if (currentLetter.Equals(' '))
                return ' ';
            else
                return SetCharacterValue(Modulo(GetOrdinalValue(currentLetter) + GetOrdinalValue(keyValue))); //Method gets ordinal values of letters given, mods the resulting value then returns a value converted to char
        }

        //Method to decrypt an individual character - Functionality the same as encrypt above except to minus the given ordinal values
        public char DecryptOneLetter(char currentLetter, char keyValue)
        {
            if (currentLetter.Equals(' '))
                return ' ';
            else
                return SetCharacterValue(Modulo(GetOrdinalValue(currentLetter) - GetOrdinalValue(keyValue)));
        }

        //Encrypts an entire given string
        public String EncryptWholeString(String enteredString, String key)
        {
            String encryptedString = "";
            int keyValue = 0; //Number representing key character value
            for (int stringIndex = 0; stringIndex < enteredString.Length; stringIndex++)
			{
                encryptedString += EncryptOneLetter(enteredString[stringIndex], key[keyValue]);
                if (enteredString[stringIndex] != ' ') //Statement used to deny the enumeration of the keyValue if a space is decrypted
                    if ((keyValue + 1) < key.Length)
                        keyValue++;
                    else
                        keyValue = 0;
			}
            return encryptedString;
        }

        //Decrypts and entire given string
        public String DecryptWholeString(String enteredString, String key)
        {
            String decryptedString = "";
            int keyValue = 0;
            for (int stringIndex = 0; stringIndex < enteredString.Length; stringIndex++)
            {
                decryptedString += DecryptOneLetter(enteredString[stringIndex], key[keyValue]);
                if(enteredString[stringIndex] != ' ')
                    if ((keyValue + 1) < key.Length)
                        keyValue++;
                    else
                        keyValue = 0;
            }
            return decryptedString;
        }

        //Method to calculate ordinal value of character
        public int GetOrdinalValue(char letter)
        {
            return letter - ASCII_MINVALUE;
        }

        //Method to convert ordinal value of character to its character equivilant
        public char SetCharacterValue(int ordValue)
        {
            return Convert.ToChar(ordValue + ASCII_MINVALUE);
        }
    }
}
