using BlogForProgrammers.Entities.Concrete;
using BlogForProgrammers.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForProgrammers.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
