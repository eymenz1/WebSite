using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IRepositroy<T>
    {
        List<T> List();

        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        //güncellemek için bir şeyi o bloğa aiit id lazım (getbyid)
        T GetByID(int id);

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T, bool>> where);
    }
}
