using HisseDagitim.BLL.Soyut;
using HisseDagitim.DAL.Soyut;
using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.BLL.Somut
{
    public class LogManager : ILogService
    {
        private ILogDal _logDal;

        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public void Add(Log log)
        {
            _logDal.Add(log);
        }

        public void Delete(Log log)
        {
            try
            {
                _logDal.Delete(log);
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<Log> GetAll()
        {
            return _logDal.GetAll();
        }

        public void Update(Log log)
        {
            _logDal.Update(log);
        }
    }
}
