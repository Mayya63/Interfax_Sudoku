using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SudocuData.Entities;
using System.Data.Entity;

namespace SudocuServices.Services
{
    public interface INumberService
    {
        List<NumberResponse> GetNumbers();
        List<NumberResultResponse> GetNumbersResult();

        bool Verify(List<NumberResponse> data);

        NumberResultResponse Get(int id);

        List<NumberResponse> Load(int level);

        int Open(int id, string col);


    }
}