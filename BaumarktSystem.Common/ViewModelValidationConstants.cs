

namespace BaumarktSystem.Common
{
    public static class ViewModelValidationConstants
    {
        public static class Category
        {
            //NameValidation
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int ShowOrderMinValue = 0;
            public const int ShowOrderMaxValue = 1000;   
            
           
            
                  
        
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

            public const int QuantityMinValue = 1;
            public const int QuantityMaxValue = 1000000;

            public const int OrderMinValue = 1;
            public const int OrderMaxValue = 1000000;

            public const int CategoryIdMinValue = 1;
            public const int CategoryIdMaxValue = 1000000;

            public const int ApplicationTypeIdMinValue = 1;
            public const int ApplicationTypeIdMaxValue = 1000000;

            public const int ProductTypeIdMinValue = 1;
            public const int ProductTypeIdMaxValue = 1000000;

            public const int ProductBrandIdMinValue = 1;
            public const int ProductBrandIdMaxValue = 1000000;

            public const int ProductColorIdMinValue = 1;
            public const int ProductColorIdMaxValue = 1000000;

            public const int ProductSizeIdMinValue = 1;
            public const int ProductSizeIdMaxValue = 1000000;

            public const int ProductMaterialIdMinValue = 1;
            public const int ProductMaterialIdMaxValue = 1000000;

            public const int ProductCountryOfOriginIdMinValue = 1;
            public const int ProductCountryOfOriginIdMaxValue = 1000000;

            public const int ProductManufacturerIdMinValue = 1;
            public const int ProductManufacturerIdMaxValue = 1000000;
        }










    }
}
