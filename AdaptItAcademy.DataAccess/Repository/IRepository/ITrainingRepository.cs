using AdaptItAcademy.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Repository.IRepository
{
    public interface ITrainingRepository: IRepository<Training>
    {
        void Update(Training training);
    }
}
