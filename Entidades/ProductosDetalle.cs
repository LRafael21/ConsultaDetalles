using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using DetalleyConsulta.Detalle;

namespace DetalleyConsulta.Detalle
{
    public partial class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public string Presentacion { get; set; }

        public decimal Cantidad { get; set; } 
        public decimal Precio { get; set; }
        public decimal ExistenciaEmpaque { get; set; }
     

        public ProductosDetalle(int productoId, string presentacion ,decimal cantidad, decimal precio,decimal existenciaEmpaque)
        {
            ProductoId = productoId;
            Presentacion = presentacion;
            Cantidad = cantidad;
            Precio = precio;
            ExistenciaEmpaque = existenciaEmpaque;

        }
    }
}