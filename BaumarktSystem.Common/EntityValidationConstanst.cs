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
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
            public const int ShortProductDescriptionMinLength = 3;
            public const int ShortProductDescriptionMaxLength = 50;
            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 1000;
            public const int PriceMinValue = 0;
            public const int PriceMaxValue = 1000000;
            public const int ImageUrlMinLength = 3;
            public const int ImageUrlMaxLength = 1000;
            public const int CategoryIdMinValue = 1;
            public const int CategoryIdMaxValue = 1000;
            public const int TypeIdMinValue = 1;
            public const int TypeIdMaxValue = 1000;
        }


      

    }
}
