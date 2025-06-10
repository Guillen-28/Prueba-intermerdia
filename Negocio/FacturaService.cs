using Entidad;
using Modelo;
namespace Negocio
{
    public class FacturaService
    {
        private readonly ApplicationDbContext _context;
        public FacturaService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<Factura> ObtenerTodos() 
        { 
            return _context.Factura.ToList();
        }
        public Factura ObtenerPorId(int id)
        {
           return _context.Factura.FirstOrDefault(d => d.Id == id)!;
        }
        public void Agregar(Factura factura)
        {
            _context.Factura.Add(factura);
            _context.SaveChanges();
        }
        public void Actualizar(Factura factura)
        {
            _context.Factura.Update(factura);
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            var factura = _context.Factura.Find(id);
            if (factura != null)
            {
                _context.Factura.Remove(factura);
                _context.SaveChanges();
            }

        }

    }
}
