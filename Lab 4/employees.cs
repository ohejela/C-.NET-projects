using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class employees
    {
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }

        // ── Default Constructor ───────────────────────────────
        public employees()
        {
            ID = 0;
            First = "";
            Last = "";
            Email = "";
            JobTitle = "";
        }

        public employees(int id, string first, string last,
                   string email, string jobTitle)
        {
            ID = id;
            First = first;
            Last = last;
            Email = email;
            JobTitle = jobTitle;
        }

        public string GetEmployeeInfo()
        {
            return $"{First} {Last} - {JobTitle}";
        }
    }
}
