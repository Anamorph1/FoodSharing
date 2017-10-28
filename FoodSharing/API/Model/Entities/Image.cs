using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string Payload { get; set; }
    }
}
