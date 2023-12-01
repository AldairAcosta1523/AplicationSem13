using System.Diagnostics;

namespace AplicationSem13.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime DateTime { get; set; }
        public string INumber { get; set; }
        public float Total { get; set;}

        // Para el Producto
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
