using KitandaSoftERP.Domain.Entities.Geral;

using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Candidate: EntityPerson
    {
        public Candidate()
        {
            Person = new EntityPerson();
        }
        public int CandidateID { get; set; }
        public int PersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public virtual EntityPerson Person { get; set; }

        public override bool IsValid()
        {
            ConfirmaValidacaoEmail();
            return !ErrorList.Any();
        }
    }
}
