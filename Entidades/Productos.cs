using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace DetalleyConsulta.Entidades
{
    public partial class Productos
    {
        public Productos()
        {
            this.ProductosDetalles = new HashSet<ProductosDetalle>();
        }

        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la descripción.")]
        [MinLength(3, ErrorMessage = " La descripcion debe tener al menos {1} caracteres")]
        [MaxLength(40, ErrorMessage = "La descripcion no puede pasarse de {1} caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la existencia")]
        public float Existencia { get; set; }

        [Required(ErrorMessage = "El Campo \"Costo\"está vacío. Por favor indique un costo.")]
        [Range(1, float.MaxValue, ErrorMessage = "El costo debe estar dentro del rango permitido (Mayor que {1})")]
        public float Costo { get; set; }
        public float ValorInventario { get; set; }

        public float Precio { get; set; }

        public int Ganancia { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }

        public virtual ICollection<ProductosDetalle> ProductosDetalles { get; set; }


        [ForeignKey("ProductoId")]

        public virtual List<ProductosDetalle> ProductosDetalle { get; set; } = new List<ProductosDetalle>();

    }
}