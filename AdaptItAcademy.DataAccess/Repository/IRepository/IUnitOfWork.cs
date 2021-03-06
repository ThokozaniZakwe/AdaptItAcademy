using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICourseRepository Course { get; }
        public ITrainingRepository Training { get; set; }
        void Save();
    }
}
