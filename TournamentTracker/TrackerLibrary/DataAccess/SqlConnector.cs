using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //TODO - make the CreatePrize method actually save to db
        /// <summary>
        /// Save a new prize to the database 
        /// </summary>
        /// <param name="model">The prize info</param>
        /// <returns>The prize info, including unique identifer</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {

            }
        }
    }
}
