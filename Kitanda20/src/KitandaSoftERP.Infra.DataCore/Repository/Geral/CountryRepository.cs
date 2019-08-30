using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Dapper;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Interfaces.Repository.Geral;
using KitandaSoftERP.Infra.DataCore.Context;
using KitandaSoftERP.Infra.DataCore.Repository.Shared;
using Microsoft.EntityFrameworkCore;

namespace KitandaSoftERP.Infra.DataCore.Repository.Geral
{
    public class CountryRepository : BaseReposity<Country>, ICountryRepository
    {

        public CountryRepository(ContextApp pContext):base(pContext)
        {

        }

        public override Country GetById(Country pCountry)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<Country>("stp_GER_GetCountryByID", new { CountryID = pCountry.ID }, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            //return base.GetById(pID);
        } 
        

        public override IEnumerable<Country> GetByFilter(Country pCountry)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<Country>("stp_GER_GetCountryByFilter", new { pDesignation = pCountry.Designation }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
