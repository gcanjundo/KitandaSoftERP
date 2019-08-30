 
using System; 

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
        
    public class CurrentSession 
    {   
        public int SessionID { get; set; }  
        public string GuestName { get; set; }  
        public string GuestIPAddress { get; set; } 
        public DateTime LoginDate { get; set; } 
        public DateTime LogoutDate { get; set; } 
        public string SessionStatus { get; set; } 
        public DateTime LoginTime { get; set; }  
        public DateTime LogoutTime { get; set; }
        public string UserLogged { get; set; }
        public string CurrentPassword { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }

        public CurrentSession()
        {
            Branch = new Branch();
        }
    }
}
