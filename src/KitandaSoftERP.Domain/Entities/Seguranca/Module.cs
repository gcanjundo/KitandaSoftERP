

using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class Module: BaseEntity
    { 
        public string Link { get; set; }
        public int TAG { get; set; }  
        public int Indice { get; set; }
        public string Imagem { get; set; } // Classe CSS do Ícone do Módulo 
        public int SystemID { get; set; }
        public virtual Module System { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Module> ModuluesList { get; set; }
        public Module()
        {
            System = new Module();
            Pages = new HashSet<Page>();
            ModuluesList = new HashSet<Module>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
