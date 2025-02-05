using Diplom.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DAL.Interfaces
{
    internal interface IVideoInterface
    {
        Task<Video> GetAllVideos();
        Task<Video> GetVideoById(int id);
    }
}
