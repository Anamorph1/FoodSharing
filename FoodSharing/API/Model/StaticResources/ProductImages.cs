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
            new Uri(@"https://lh6.googleusercontent.com/rmBCpGPyrv_mPY3aDc3fpXvms8W-tfYd75vsaFSrBE76tNTXQL0dGIErJ9vWVDskSaFkxovWWr9PJy8=w1366-h662"),
            new Uri(@"https://lh3.googleusercontent.com/1tbK_OfbnR5FFYoZCn0LO2v3wUCd1HF-XAXsFJ60vB5DaNTtPaMhN2UMPr2Q279erBorTD1F7ry2CUk=w1366-h662"),
            new Uri(@"https://lh3.googleusercontent.com/og55Z3gVexGeNH7cC7a5TDePpMtR2U3YbqWdDqK9lwjtDfFi5UNujZYi3mF5PrK9etH-CotGrYQbm6c=w1366-h662"),
            new Uri(@"https://lh4.googleusercontent.com/h2jkdbVh0Dn_DX56Bc4FJ0VAyvOyXGpJH5QiE8dvztkb1NS5i0ksewGNyRKJLNPpHz71D0aJRLTlZvs=w1366-h662")
        };
        private static readonly int imageCount = ImageUris.Count;

        public static int ImageCount => imageCount;
    }
}
