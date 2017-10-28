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
            new Uri(@"http://www.mojegotowanie.pl/media/cache/default_view/uploads/media/default/0001/76/1f52b486f01de6f770d6b97cca1880a695376c2e.jpeg"),
            new Uri(@"https://4.bp.blogspot.com/-3s4L2hp-IQM/U4154FTXZgI/AAAAAAAAi68/JtbVzCFAqcg/s1600/frytki+domowe+%25285%2529.JPG"),
            new Uri(@"http://www.mojegotowanie.pl/media/cache/default_view/uploads/media/default/0001/55/9be3cacf21797f8a11cd16553962d4e6e2ad82d4.jpeg"),
            new Uri(@"https://img.grouponcdn.com/deal/mbyUEW6TfTGgb28PJUor/fG-2048x1229/v1/c700x420.jpg"),
            new Uri(@"https://www.kwestiasmaku.com/sites/kwestiasmaku.com/files/bigos_z_kiszonej_kapusty_01_0.jpg")
        };
        private static readonly int imageCount = ImageUris.Count;

        public static int ImageCount => imageCount;
    }
}
