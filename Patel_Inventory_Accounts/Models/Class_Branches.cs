using System.ComponentModel.DataAnnotations;

namespace Patel_Inventory_Accounts.Models
{
    public class Class_Branches
    {
        [Key]
        public int branch_id { get; set; }
        public string branch_code { get; set; }
        public string company_id { get; set; }
        public string branch_username { get; set; }
        public string branch_password { get; set; }
        public string db_username { get; set; }
        public string db_server { get; set; }
        public string db_server_password { get; set; }
        public string db_name { get; set; }
    }
}
