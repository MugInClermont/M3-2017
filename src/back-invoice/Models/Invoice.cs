using System.ComponentModel.DataAnnotations.Schema;

namespace back_mug_invoice.Models
{
    public class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        public string Name { get; set; }

        public float Cost { get; set; }
        
        public string Owner { get; set; }
    }
}