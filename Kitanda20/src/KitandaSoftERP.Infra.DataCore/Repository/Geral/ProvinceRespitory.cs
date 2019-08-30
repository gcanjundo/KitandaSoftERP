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
    public class ProvinceRepository : BaseReposity<Province>, IProvinceRepository
    {

        public ProvinceRepository(ContextApp pContext):base(pContext)
        {

        }

        public override Province GetById(Province pProvince)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<Province>("stp_GER_GetProvinceByID", new { ProvinceID = pProvince.ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            } 
        }


        public override IEnumerable<Province> GetByFilter(Province pProvince)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@pDesignation", pProvince.Designation);
                queryParameters.Add("@pCountryID", pProvince.CountryID); 
                return connection.Query<Province>("stp_GER_GetProvinceByFilter", queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
