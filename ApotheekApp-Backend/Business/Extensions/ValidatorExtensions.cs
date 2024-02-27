using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApotheekApp.Business.Extensions
{
    public static class ValidatorExtensions
    {
        public static bool IsValidEmail(this string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException("Value cannot be empty");
            }

            if (Regex.IsMatch(email, "^\\w+(?:\\w+|\\.)\\w+\\@\\w+\\.\\w{2,4}$"))
            {
                return true;
            }

            throw new ArgumentException("This email is not valid.");
        }

        public static bool IsValidPassword(this string? password)
        {
            string pattern = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%\\^&(){}[\\]:;<>,.?/~_+\\-=|\\\\]).{8,}$";
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Value cannot be empty");
            }

            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }

            throw new ArgumentException("This password is not valid.");
        }

        public static bool IsValidNlPhoneNumber(this string? nlPhoneNumber)
        {
            string pattern = "(?:00|\\+)31(\\d){9}$";
            if (string.IsNullOrWhiteSpace(nlPhoneNumber))
            {
                throw new ArgumentNullException("Value cannot be empty");
            }
            if (Regex.IsMatch(nlPhoneNumber, pattern))
            {
                return true;
            }

            throw new ArgumentException("This phone number is not valid.");
        }

        public static bool IsValidUsername(this string? username)
        {
            if (string.IsNullOrWhiteSpace(username))
            { throw new ArgumentNullException("Username cannot be empty."); }

            return true;
        }
    }
}
