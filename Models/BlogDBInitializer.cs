using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTask2.Models
{
    public class BlogDBInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article { Author = "Звездун Игорь", Content = "Бомжи сгорели под общагой.", Header = "ШОК-КОНТЕНТ ГОРЯТ БОМЖИ", Id = 0 });
            db.Articles.Add(new Article { Author = "Звездун Игорь", Content = "Тили тили трали вали мы ночуем на вокзале", Header = "КАК СТАТЬ БЕЗДОМНЫМ", Id = 1 });
            db.Articles.Add(new Article { Author = "Звездун Игорь", Content = "Никто не застрахован от... многомиллионного наследства. Бомж Эдик оказался единственным наследником почившего миллиардера из десятки Форбс. Из грязи в князи, как гврится!", Header = "ГРЕБЕШЬ, ГРЕБЕЦ? ДАЖЕ БОМЖ БОГАЧЕ ТЕБЯ", Id = 2 });


            base.Seed(db);
        }
    }
}