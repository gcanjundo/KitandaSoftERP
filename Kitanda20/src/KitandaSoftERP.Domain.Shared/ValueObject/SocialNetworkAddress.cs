using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Shared.ValueObject
{
    public class SocialNetworkAddress
    {
        public SocialNetWork NetWork { get; set; }
        public string AddressLink { get; set; }

        public enum SocialNetWork
        {
            Facebook,
            Skype,
            Twitter,
            LinkdIN,
            Instagram,
            Youtube

        }
    }
}
