using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Concreate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorRentDal;


        public ColorManager(IColorDal colorRentDal)
        {
            _colorRentDal = colorRentDal;
        }




        public IResult Add(Color color)
        {
            _colorRentDal.Add(color);
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Color color)
        {
            _colorRentDal.Update(color);
            return new SuccessResult("Güncellendi");
        }

        public IResult Delete(Color color)
        {
            _colorRentDal.Delete(color);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorRentDal.GetAll(), "Renkler listelendi");
        }


    }
}
