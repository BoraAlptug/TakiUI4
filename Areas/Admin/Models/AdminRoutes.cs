namespace TakiUI4.Areas.Admin.Models
{
    public static class AdminRoutes
    {
        private const string MainRoute = "/Admin/";

        // ----------------- Product -----------------
        public const string AddProductRoute = MainRoute + "Product/Add";
        public const string GetProductListRoute = MainRoute + "Product/GetList";
        public const string DeleteProductRoute = MainRoute + "Product/Delete";
        public const string AddProductImageRoute = MainRoute + "Product/AddImage";
        public const string DeleteProductImageRoute = MainRoute + "Product/DeleteImage";
        public const string GetByIDRoute = MainRoute + "Product/GetById";

        // ----------------- Category -----------------
        public const string AddCategoryRoute = MainRoute + "Category/Add";
        public const string GetCategoryListRoute = MainRoute + "Category/GetList";
        public const string DeleteCategoryRoute = MainRoute + "Category/Delete";

        // ----------------- Payment -----------------
        public const string AddPaymentRoute = MainRoute + "Payment/Add";
        public const string GetPaymentListRoute = MainRoute + "Payment/GetList";
        public const string DeletePaymentRoute = MainRoute + "Payment/Delete";

        // ----------------- User -----------------
        public const string AddUserRoute = MainRoute + "Users/Add";
        public const string GetUserListRoute = MainRoute + "Users/GetList";
        public const string DeleteUserRoute = MainRoute + "Users/Delete";

        // ----------------- Product Image -----------------
        public const string GetImageListRoute = MainRoute + "ProductImage/GetList";
        public const string DeleteImageAsyncRoute = MainRoute + "ProductImage/Delete";
        public const string GetProductImageForProductRoute = MainRoute + "ProductImage/GetForProduct";

        // ----------------- Image Path -----------------
        public const string AddImagePathRoute = MainRoute + "ImagePath/Add";
        public const string GetImagePathListRoute = MainRoute + "ImagePath/GetList";
        public const string DeleteImagePathRoute = MainRoute + "ImagePath/Delete";

        // ----------------- Slider -----------------
        public const string AddSliderRoute = MainRoute + "Slider/Add";
        public const string GetSliderListRoute = MainRoute + "Slider/GetList";
        public const string DeleteSliderRoute = MainRoute + "Slider/Delete";
        public const string AddSliderMediaRoute = MainRoute + "Slider/AddMedia";
        public const string DeleteSliderMediaRoute = MainRoute + "Slider/DeleteMedia";
       
    }
}
