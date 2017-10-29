using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.StaticResources
{
    public class ProductImages
    {
        public static readonly List<Uri> ImageUris = new List<Uri>()
        {
            new Uri(@"https://4.bp.blogspot.com/-3s4L2hp-IQM/U4154FTXZgI/AAAAAAAAi68/JtbVzCFAqcg/s1600/frytki+domowe+%25285%2529.JPG"),
            new Uri(@"https://img.grouponcdn.com/deal/mbyUEW6TfTGgb28PJUor/fG-2048x1229/v1/c700x420.jpg"),
            new Uri(@"https://eat24hours.com/files/cuisines/v4/thai.jpg"),
            new Uri(@"https://media2.s-nbcnews.com/j/newscms/2017_10/1200234/10-healthy-fast-food-meals-008-subway-inline-today-170309_89a32509f1b93e969a831a913cc2a2d1.today-inline-large.jpg"),
            new Uri(@"https://www.kwestiasmaku.com/sites/kwestiasmaku.com/files/bigos_z_kiszonej_kapusty_01_0.jpg")
        };
        private static readonly int imageCount = ImageUris.Count;

        public static int ImageCount => imageCount;
    }
}
