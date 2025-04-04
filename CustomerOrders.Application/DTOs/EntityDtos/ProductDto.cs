﻿/// <summary>
/// Represents the primary details of a product, including barcode and pricing.
/// </summary>
public class ProductDto
{
    public int Id { get; set; }
    public string Barcode { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
