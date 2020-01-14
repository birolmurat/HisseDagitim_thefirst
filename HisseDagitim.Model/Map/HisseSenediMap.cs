﻿using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.Model.Map
{
    public class HisseSenediMap:BaseMap<HisseSenedi>
    {
        public HisseSenediMap()
        {
            Property(p => p.HisseYili).HasColumnName("Hisse Yılı").IsRequired();
         
            Property(p => p.isGecerli).HasColumnName("Hisse Geçerliliği").IsRequired();

        }
    }
}
