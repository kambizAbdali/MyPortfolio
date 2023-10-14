using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
            new Project(1,"سامانه برگزاری آزمون های آنلاین","این پروژه برای برگزاری آزمون های آزمایشی آنلاین سراسری کشور پیاده شده است است","مدرسان شریف","project-1.jpg"),
            new Project(2, "تست اتوماسیون سامانه های خودپرداز بانک ملت و پاسارگاد", "این پروژه برای تست اتوماسیون سامانه های خودپرداز بانک ملت و پاسارگاد پیاده شده است است", "بانک پاسارگاد و ملت", "project-2.jpg"),
            new Project(3, "مدیریت تیم نرم افزاری و سیستم ارتباط با مشتری", "این پروژه برای مدیریت تیم نرم افزاری و سیستم ارتباط با مشتری پیاده شده است است", "شرکت زئوس","project-3.jpg"),
            new Project(4, "سرویس مکان یاب و ضد سرقت خودرو", "این پروژه برای سرویس مکان یاب و ضد سرقت خودرو پیاده شده است است", " شرکت ایرانخودرو", "project-4.jpg")
        };
           
            return View("_Projects", projects);
        }
    }
}