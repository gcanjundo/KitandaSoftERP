namespace KitandaSoftERP.Domain.Shared.ValueObject
{
    public class Permission
    {
        public bool AllowInsert { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowSelect { get; set; }
        public bool AllowPrint { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowFullAccess { get; set; }
    }
}
