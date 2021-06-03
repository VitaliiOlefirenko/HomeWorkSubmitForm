using System;
using System.Collections.Generic;
using System.Text;
using TestProject2.Models;

namespace TestProject2.Utils
{
    public class Randomizer
    {
        public static string GenerateRandomString(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(ch);
            }

            if (lowerCase)
                return stringBuilder.ToString().ToLower();
            return stringBuilder.ToString();

        }

        public static string GenerateRandomEMail(string nameDomen, int size = 10)
        {
            string randomEMail = GenerateRandomString(size) + nameDomen;
            return randomEMail;
        }

        public static string GenerateRandomData(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                data += (char) array[i];
            }

            return data;
        }

        public static string GenerateRandomPassword(int size)
        {
            string randomPassword = GenerateRandomPassword(size);
            return randomPassword;
        }

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static string GenerateRandomPhoneNumber(string countryCode, int country)
        {
            var random = new Random();
            int[] array = new int[country];
            string phoneNumber = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 9);
                phoneNumber += array[i];
            }

            phoneNumber = countryCode + phoneNumber;
            return phoneNumber;
        }

        public static string GenerateRandomMonthDateOfBirth()
        {
            var random = new Random().Next(0, 11);
            return random.ToString();
        }

        public static string GenerateRandomYearDateOfBirth()
        {
            var random = new Random().Next(1900, DateTime.Now.Year);
            return random.ToString();
        }

        public static string GenerateRandomDayDateOfBirth()
        {
            var random = new Random().Next(1, 31);
            return random.ToString();
        }

        public static List<string> GenerateDateOfBirth()
        {
            List<string> dateOfbirth = new List<string>();
            dateOfbirth.Add(GenerateRandomMonthDateOfBirth());
            dateOfbirth.Add(GenerateRandomYearDateOfBirth());
            dateOfbirth.Add(GenerateRandomDayDateOfBirth());
            return dateOfbirth;
        }

        public static string GenerateRandomGender()
        {
            string[] allGenders = {"Male", "Female", "Other"};
            var random = new Random();
            return allGenders[random.Next(0, allGenders.Length)];
        }

        public static string GenerateRandomHobby()
        {
            string[] allHobbies = { "Sports", "Reading", "Music" };
            var random = new Random();
            return allHobbies[random.Next(0, allHobbies.Length)];
        }

        public static Student GenerateNewStudent()
        {
            Student student = new Student();
            int randomizerSize = 10;
            student.FirstName = GenerateRandomString(randomizerSize);
            student.LastName = GenerateRandomString(randomizerSize);
            student.Email = GenerateRandomEMail(NameDomen.Rumbler, randomizerSize);
            student.Phone = GenerateRandomPhoneNumber(CountryCode.Ukraine, 7);
            student.Subject = GenerateRandomString(randomizerSize);
            student.DateOfBirthList = GenerateDateOfBirth();
            student.CurrentAddress = GenerateRandomString(randomizerSize);
            student.Gender = GenerateRandomGender();
            student.Hobby = GenerateRandomHobby();
            return student;
        }
    }
}
