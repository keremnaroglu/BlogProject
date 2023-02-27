using BlogProject.DAL.Abstract;
using BlogProject.DAL.Repositories;
using BlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDAL
    {
    }
}
