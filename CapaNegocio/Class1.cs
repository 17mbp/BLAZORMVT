using CapaDeDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class Class1 : Interface
    {
        private readonly InterfaceDA _interface;

        public Class1(InterfaceDA crud)
        {
            _interface = crud;
        }

        public void CreateMeta(ListaMetas DATA)
        {
            _interface.Insert(DATA);
        }

        public void DeleteMeta(int id)
        {
            _interface.Delete(id);
        }

        public IEnumerable<ListaMetas> GetAllMetas()
        {
            return _interface.GetAll();
        }

        public ListaMetas GetLista(int id)
        {
            return _interface.GetById(id);
        }

        public void UpdateMeta(ListaMetas DATA)
        {
            _interface.Update(DATA);
        }
    }
}