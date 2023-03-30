using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class sys_config
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public tb_config getItem(string name)
        {
            return db.tb_config.FirstOrDefault(x => x.NAME == name);
        }
    }
}
