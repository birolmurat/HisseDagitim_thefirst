using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Soyut
{
    public interface ILogService
    {
        List<Log> GetAll();
        
        void Add(Log log);

        void Update(Log log);

        void Delete(Log log);
    }
}
