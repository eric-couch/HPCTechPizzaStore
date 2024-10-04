using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HPCTechPizzaStore.Models;

public class Product
{
    // Id or <classname>Id field by convention is the primary key
    public int Id { get; set; }

    // create table Product (Id int primary key, Name varchar(100) Null, price decimal(6,2))
    [MaxLength(100)]
    public string? Name { get; set; } = null;
    [Column(TypeName ="decimal(6,2)")]
    public decimal Price { get; set; }
}
