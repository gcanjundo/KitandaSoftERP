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
    public class CommuneRepository : BaseReposity<Commune>, ICommuneRepository
    {

        public CommuneRepository(ContextApp pContext) : base(pContext)
        {

        }

        public override Commune GetById(Commune pCommune)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<Commune>("stp_GER_GetCommuneByID", new { CommuneID = pCommune.ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }


        public override IEnumerable<Commune> GetByFilter(Commune pCommune)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@pDesignation", pCommune.Designation);
                queryParameters.Add("@pCityID", pCommune.CityID);
                return connection.Query<Commune>("stp_GER_GetCommuneByFilter", queryParameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
