using Core.Utilities.Results;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {

        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
