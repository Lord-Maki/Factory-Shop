﻿namespace Factory_Shop.Data.Models
{
    public class Materials
    {
        //Creating a material model
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Group { get; set; }
        public string? ShortDesc { get; set; }
        public string? LongDesc { get; set; }
        public string? Img { get; set; }
        public ushort Price { get; set; }
        public bool Available { get; set; } 
        public int MaterialID { get; set; }
        public virtual Category Category { get; set; }

    }
}
