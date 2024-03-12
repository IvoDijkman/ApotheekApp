﻿namespace ApotheekApp.Domain.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Manual { get; set; }
        public required string Type { get; set; }
        public int Stock { get; set; }
    }
}