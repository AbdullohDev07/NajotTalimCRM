using FileAPILesson.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Application.Services.ImageServices
{
    public interface IImageService
    {
        public Task<Picture> Create(Picture pix);
    }
}
