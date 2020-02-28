using FluentNHibernate.Mapping;
using NHibernatePractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernatePractice.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            References(x => x.Store);
        }
    }
}
