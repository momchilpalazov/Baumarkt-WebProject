using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Common
{
    public static class EntityValidationConstanst
    {
        public static class Category
        {
            //NameValidation
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int ShowOrderMinValue = 0;
            public const int ShowOrderMaxValue = 1000;   
            
            //OrderValidation
            public const int OrderMinValue = 1;
            public const int OrderMaxValue = 1000;
                  
        
        }

        public static class Product
        {
            //NameValidation
            public const int FullNameMinLength = 3;
            public const int FullNameMaxLength = 10000;

            public const int ShortProductDescriptionMinLength = 3;
            public const int ShortProductDescriptionMaxLength = 10000;

            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 10000;

            public const int PriceMinValue = 1;
            public const int PriceMaxValue = 1000000;

           


          
        }


        public static class ApplicationType
        {
            //NameValidation
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class ApplicationUser
        {
            //NameValidation
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50; 
            
            public const int PasswordMinLength = 3;
            public const int PasswordMaxLength = 50;

            public const int AddressMinLength = 3;
            public const int AddressMaxLength = 50;

            public const int CityMinLength = 3;
            public const int CityMaxLength = 50;

            public const int PostalCodeMinLength = 3;
            public const int PostalCodeMaxLength = 50;

            public const int RoleMinLength = 3;
            public const int RoleMaxLength = 50;
            
        }    



      

    }
}
