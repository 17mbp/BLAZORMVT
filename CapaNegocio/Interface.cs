using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public interface Interface
    {
        CapaEntidades.ListaMetas GetLista(int id);
        IEnumerable<CapaEntidades.ListaMetas> GetAllMetas();
        void CreateMeta(CapaEntidades.ListaMetas DATA);
        void UpdateMeta(CapaEntidades.ListaMetas DATA);
        void DeleteMeta(int id);
    }
}