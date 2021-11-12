using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIXIE_PHOTOS.Models
{
    public class Photos
    {
        [Key]
        public  int photoId {get; set;}
        public string Album_Title { get; set; }
        public byte[] picture { get; set; }

        public Photos()
        {
            
        }
    }

    
}
