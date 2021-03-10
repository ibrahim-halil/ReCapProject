﻿using System;
using System.Collections.Generic;

using System.Text;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
    IDataResult<List<Color>> GetAll();
    IDataResult<Color> GetCarsByColorId(int colorId);

    IResult Add(Color color);
    IResult Delete(Color color);
    IResult Update(Color color);
  }
}
