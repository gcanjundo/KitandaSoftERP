using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhFuncionarioCoordenadasBancarias
    {
        public int FunContaCodigoFuncionario { get; set; }
        public int FunContaCodigoBanco { get; set; }
        public string FunContaNumero { get; set; }
        public string FunContaIban { get; set; }
        public string FunContaNib { get; set; }
        public string FunContaSwift { get; set; }

        public virtual FinBanco FunContaCodigoBancoNavigation { get; set; }
        public virtual RhFuncionario FunContaCodigoFuncionarioNavigation { get; set; }
    }
}
