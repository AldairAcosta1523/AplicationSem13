namespace AplicationSem13.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public string Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }

        // Para el Producto
        public int ProductID { get; set; }
        public Product? Product { get; set; }

        // Para el Invoice
        public int InvoiceID { get; set; }
        public Invoice? Invoice { get; set; }


    }
}
