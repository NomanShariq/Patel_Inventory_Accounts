using System.ComponentModel.DataAnnotations;

namespace Patel_Inventory_Accounts.Models
{
    public class Class_Companies
    {
        [Key]
        public int master_id { get; set; }
        public string company_name { get; set; }
        public string company_code { get; set; }
        public string company_address { get; set; }
        public string company_contact { get; set; }
        public string company_logo { get; set; }
        public string company_email { get; set; }
        public string company_password { get; set; }
        public string db_server { get; set; }
        public string db_server_password { get; set; }
        public string db_username { get; set; }
        public string db_name { get; set; }
    }
}
