using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDeDatos
{
    public interface InterfaceDA
    {
        ListaMetas GetById(int id);
        IEnumerable<ListaMetas> GetAll();
        void Insert(ListaMetas data);
        void Update(ListaMetas data);
        void Delete(int id);
    }
}