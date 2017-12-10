using System.ComponentModel.DataAnnotations;

public class Stock{

    [Key]
    public int StockID { get; set; }
    public string Name { get; set; }
}