using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T:EntityBase
    {
        public BaseMap()
        {
            Property(p => p.OlusturmaTarihi).HasColumnType("datetime2").HasColumnName("Oluşturma Tarihi").IsOptional();
        }
    }
}
