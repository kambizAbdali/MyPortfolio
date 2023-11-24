using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
            new Article(1,"آموزش برنامه نویسی دات نت کور", "مدرس این آموزش کامبیز ابدالی است","blog-post-thumb-card-1.jpg"),
            new Article(2,"آموزش الگوهای طراحی", "این آموزش شامل انواع الگوهای طراحی در زبان برنانه نویسی است مانند singleton","blog-post-thumb-card-2.jpg"),
            new Article(3,"آموزش دوآپس", "مدرس این آموزش احمدعلی باقری است","blog-post-thumb-card-3.jpg"),
            new Article(4,"آموزش تست اتومیشن", "در این آموزش به تست اتوماتیک به زبان سی شارپ و ابزار تست سلنیوم پرداخته می شود","blog-post-thumb-card-4.jpg")
            };
            return View("_LatestArticles", articles);
        }
    }
}
