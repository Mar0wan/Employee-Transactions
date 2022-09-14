using Microsoft.AspNetCore.Components.Forms;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace t_emp.api.Models
{
    public class EmpTran
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Type { get; set; }
        public int EmpId { get; set; }

    }
}
