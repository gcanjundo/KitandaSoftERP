

using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class SystemModule : BaseEntity
    { 
        public string Link { get; set; }
        public int TAG { get; set; }  
        public int Indice { get; set; }
        public string Imagem { get; set; } // Classe CSS do Ícone do Módulo  
        public virtual ICollection<SystemPages > PagesList { get; set; } 
        public SystemModule ()
        { 
            PagesList = new HashSet<SystemPages >(); 
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
