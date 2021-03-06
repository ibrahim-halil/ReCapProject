using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult TransactionalOperation(Car car);
        IResult AddTransactionalTest(Car car);
    }
}
