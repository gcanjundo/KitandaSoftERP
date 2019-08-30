using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Interfaces.Repository.Geral;
using KitandaSoftERP.Domain.Interfaces.Services.Geral;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KitandaSoftERP.Domain.Services.Geral
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;
        public CountryService(ICountryRepository pCountryRepository)
        {
            countryRepository = pCountryRepository;
        }
        public Country AddNew(Country pCountry)
        {
            pCountry = ModelValidateToInsert(pCountry);
            
            if(pCountry.IsValid())
              countryRepository.AddNew(pCountry);

            return pCountry;
        }

        public Country Update(Country pCountry)
        {
            pCountry = ModelValidateToEdit(pCountry);

            if (pCountry.IsValid())
                countryRepository.Update(pCountry);
            return pCountry;
        }

        public Country Delete(Country pCountry)
        {
            countryRepository.Delete(pCountry);
            return pCountry;
        } 

        public IEnumerable<Country> GetByFilter(Expression<Func<Country, bool>> predicate)
        {
            return countryRepository.GetByFilter(predicate);
        }

        public Country GetById(int pID)
        {
            return countryRepository.GetById(pID);
        }
        
        private Country ModelValidateToInsert(Country pCountry)
        {

            if (GetByDesignation(pCountry) != null)
                pCountry.ErrorList.Add("Já exitem um país designado " + pCountry.Designation);
            else if (string.IsNullOrEmpty(pCountry.Nationality))
                pCountry.Nationality = pCountry.Designation;

            return pCountry;
        }

        private Country ModelValidateToEdit(Country pCountry)
        {
            var getCountry = GetByDesignation(pCountry);
            if (getCountry != null && getCountry.ID != pCountry.ID)
                pCountry.ErrorList.Add("Já um outro país designado " + pCountry.Designation);
            else if (string.IsNullOrEmpty(pCountry.Nationality))
                pCountry.Nationality = pCountry.Designation;

            return pCountry;
        }

        public Country GetByDesignation(Country pCountry)
        {
            return countryRepository.GetByDesignation(pCountry.Designation);
        }

        public void Dispose()
        {
            countryRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
