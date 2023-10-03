namespace BaumarktSystem.Common
{
    public static class GeneralApplicationConstants
    {
        public const int ReleaseYear = 2023;

        public const string roleAdmin = "Admin";

        public const string  roleCustomer = "Customer";

        public const string AdminAreaName = "Admin";

        public static string EmeilDevelopment = "admin@admin.bg";

        public static string EmeilSender = "momchil.palazov@protonmail.com";  

        public const string SuccessMessage = "Success";

        public const string ErrorMessage = "Error";

        public const string SessionInquiryId = "InquiryId";


        public const string StatusPending = "Pending";

        public const string StatusApproved = "Approved";

        public const string StatusInProcess = "Processing";

        public const string StatusShipped = "Shipped";

        public const string StatusCancelled = "Cancelled";

        public const string StatusRefunded = "Refunded";


        public static readonly IEnumerable<string> StatusList = new List<string>()
        {
            StatusApproved, StatusCancelled, StatusInProcess, StatusPending, StatusRefunded, StatusShipped
        };



    }
}