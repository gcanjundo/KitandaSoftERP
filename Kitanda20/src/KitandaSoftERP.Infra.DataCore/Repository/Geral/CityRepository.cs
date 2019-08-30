using Dapper;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Interfaces.Repository.Geral;
using KitandaSoftERP.Infra.DataCore.Context;
using KitandaSoftERP.Infra.DataCore.Repository.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace KitandaSoftERP.Infra.DataCore.Repository.Geral
{
    public class CityRepository : BaseReposity<City>, ICityRepository
    {

        public CityRepository(ContextApp pContext):base(pContext)
        {

        }

        public override City GetById(City pCity)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<City>("stp_GER_GetCityByID", new { CityID = pCity.ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }


        public override IEnumerable<City> GetByFilter(City pCity)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@pDesignation", pCity.Designation);
                queryParameters.Add("@pProvinceID", pCity.ProvinceID);
                return connection.Query<City>("stp_GER_GetCityByFilter", queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
