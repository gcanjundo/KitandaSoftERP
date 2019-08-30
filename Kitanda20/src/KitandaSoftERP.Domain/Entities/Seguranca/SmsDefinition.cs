  
namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class SmsConfig
    {
        public string api_key_app { get; set; }
        public string phone_number { get; set; }
        public string message_body { get; set; }
        public int CompanyID { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
