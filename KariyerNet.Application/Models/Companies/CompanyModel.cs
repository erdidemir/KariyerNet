using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Application.Models.Companies
{
    public class CompanyModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastMofiedDate { get; set; }

        public int DisplarOrder { get; set; }

        public bool IsActive { get; set; }
    }
}
