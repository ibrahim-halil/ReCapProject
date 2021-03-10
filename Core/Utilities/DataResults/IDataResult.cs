using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.DataResults
{
    public interface IDataResult<T> : IResult
    {

        T Data { get; }
    }

}
