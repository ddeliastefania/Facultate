using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul6
{
    public class Photograph
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public byte[] ThumbnailBits { get; set; }
        [ForeignKey("PhotoId")]
        public virtual PhotographFullImage PhotographFullImage { get; set; }

        public Photograph()
        {

        }
        public Photograph( int photoId, string title, byte[] thumbnail)
        {
            PhotoId = new Random().Next(1, 20000);
            Title = title;
            ThumbnailBits = thumbnail;
        }
    }
}
