using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SudocuData.Entities;
using SudocuData;
using System.Data.Entity;
using System.Data;


namespace SudocuServices.Services
{
    public class NumberService : INumberService
    {
        private NumberContext db = new NumberContext();
        private ContextResult dbResult = new ContextResult();

        private List<NumberResponse> _listNumbers;
        private List<NumberResultResponse> _listNumbersResult;


        public NumberService()
        {
            _listNumbers = GetNumbers();
            _listNumbersResult = GetNumbersResult();
        }
        public List<NumberResponse> GetNumbers()
        {
            return db.Numbers.ToList();
            
        }
        public List<NumberResultResponse> GetNumbersResult()
        {
            return dbResult.NumbersResult.ToList();
        }

        /// <summary>
        /// Найти запись из таблицы результатов по Id
        /// </summary>
        /// <param name="level">уровень</param>
        /// <returns></returns>
        public NumberResultResponse Get(int id)
        {
            return _listNumbersResult
                        .FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Загрузить таблицу исходя уз уровня сложности
        /// </summary>
        /// <param name="level">уровень</param>
        /// <returns></returns>
        public List<NumberResponse> Load(int level)
        {
            Func<NumberResponse, bool> filterFunc = x => x.Level == level;
            return _listNumbers.Where(filterFunc).ToList();
        }
        /// <summary>
        /// Проверить правильность заполнения таблицы
        /// <param name="data">Коллекция чисел</param>
        /// <returns></returns>
        public bool Verify(List<NumberResponse> data)
        {
            List<NumberResultResponse> result = GetNumbersResult();

            return  SequenceEquals(data, result);

        }
        public bool SequenceEquals(List<NumberResponse> A, List<NumberResultResponse> B)
        {
            if (A.Count() != B.Count())
                return false;
            for (int i = 0; i < A.Count(); i++)
             {
                    if (A[i].Id != B[i].Id || 
                        A[i].Level != B[i].Level ||
                        A[i].Num1 != B[i].Num1 ||
                        A[i].Num2 != B[i].Num2 ||
                        A[i].Num3 != B[i].Num3 ||
                        A[i].Num4 != B[i].Num4 ||
                        A[i].Num5 != B[i].Num5 ||
                        A[i].Num6 != B[i].Num6 ||
                        A[i].Num7 != B[i].Num7 ||
                        A[i].Num8 != B[i].Num8 ||
                        A[i].Num9 != B[i].Num9 )
                    return false;
             }
             return true;
            
        }

        /// <summary>
        /// Открыть ячейку
        /// <param name="id"></param>
        /// <param name="id">номер ячейки</param>
        /// <returns></returns>
        public int Open(int id, string col)
        {
            //получить запись из таблицы результатов по Id
            var response = _listNumbersResult
                           .Where(x => x.Id == id);
            int? CellValue=0; 
            switch(col)
            {
                case "num1":
                    CellValue = response.FirstOrDefault().Num1;
                    break;
                case "num2":
                    CellValue = response.FirstOrDefault().Num2;
                    break;
                case "num3":
                    CellValue = response.FirstOrDefault().Num3;
                    break;
                case "num4":
                    CellValue = response.FirstOrDefault().Num4;
                    break;
                case "num5":
                    CellValue = response.FirstOrDefault().Num5;
                    break;
                case "num6":
                    CellValue = response.FirstOrDefault().Num6;
                    break;
                case "num7":
                    CellValue = response.FirstOrDefault().Num7;
                    break;
                case "num8":
                    CellValue = response.FirstOrDefault().Num8;
                    break;
                case "num9":
                    CellValue = response.FirstOrDefault().Num9;
                    break;
            }
             return (int)CellValue;
        }


    }
}