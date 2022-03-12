using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Data
{
    public class DataConstants
    {
        public const int IdMaxLength = 40;

        public const int BookTitleMaxLength = 50;
        public const int BookDescriptionMinLength = 5;
        public const int BookDescriptionMaxLength = 1000;
        public const int BookAuthorMaxLength = 40;
        public const int BookPublisherMaxLength = 30;


        public const int MinNameLength = 4;
        public const int MaxNameLength = 20;

        public const int UserMinPassword = 5;
        public const int PasswordMaxLength = 20;
        public const int PasswordMaxLengthInDb = 64;
        public const int UserMinEmail = 10;
        public const int UserMaxEmail = 60;
        public const string UserEmailRegEx =
            @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const int LanguageCodeMinLength = 2;
        public const int LanguageCodeMaxLength = 3;
       

    }
}
