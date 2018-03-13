using System.Web.Mvc;


//Area-> Projeyi ev olarak düşün. Area evin odaları. Örneğin adminarea yaratıp bunun anahtarını sadece yönetici rolündekilere vereceğiz.
//Arealar kendilerine has controller view lardan oluşur.


namespace SimpleBlogGece.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName  //deger atamazsın sadece okuyabilirsin. Readonly
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //Admin Area Default Route
            context.MapRoute(
                "Admin_default", //RouteName
                "Admin/{controller}/{action}", //Url. Variable(Özel değişkenler, tanımlamak için süslü parantez gerek.)
                                                    //Debug ettiğinde localhost.../Admin/ olduğunda seni burası karşılayacak.
                                                    // /Admin/Products/New
                new { action = "Index" }
            );
        }
    }
}