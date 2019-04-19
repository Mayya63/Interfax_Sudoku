using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Sudoku
{
    public class Sudoku
    {
        /// <summary>
        /// Прочитать данные из таблицы
        /// </summary>
        /// <param name="command">Команда</param>
        /// <returns></returns>
        public static DataTable ReadToTable(SqlCommand command)
        {
            var dataTable = new DataTable();
            try
            {
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                return null;
                //return ex.Message;
            }
            return dataTable;
        }
        /// <summary>
        /// Получить запрос, 
        /// </summary>
        /// <param name="level">Уровень сложности, от 1 до 5</param>
        /// <returns>Текст запроса</returns>
        public static string GetQueryForTable(int level)
        {
            return string.Format(@"select * from tSudoku  where level = {0}", level);
        }

    }
}