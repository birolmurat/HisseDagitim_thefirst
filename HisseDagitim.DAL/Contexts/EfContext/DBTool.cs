using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisseDagitim.DAL.Contexts.EfContext
{
    public class DBTool 
    {
		private static HisseDagitimEntities _dbInstance;

		public static HisseDagitimEntities DBInstance
		{
			get
			{
				if (_dbInstance == null)
				{
					_dbInstance = new HisseDagitimEntities();
				}
				return _dbInstance;
			}
		}
	}
}
