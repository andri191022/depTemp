namespace pu.backend.inquiry.Models
{
    public class ObjectHeader
    {
        public string UserName { get; set; }
        public List<ObjectTransaction> objectTransactions { get; set; }

    }

    public class ObjectTransaction
    {
        public int Id { get; set; }
        public ObjectInvoice Invoice { get; set; }
    }

    public class ObjectInvoice
    {
        public int IdInvoice { get; set; }

    }
}


