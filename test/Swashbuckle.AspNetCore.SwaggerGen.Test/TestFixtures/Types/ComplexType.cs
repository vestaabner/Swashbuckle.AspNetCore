using System;
using System.ComponentModel.DataAnnotations;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class ComplexType
    {
        public bool Property1 { get; set; }

        public DateTime? Property2 { get; set; }

        public DateTimeOffset Property3 { get; set; }

        [Required]
        public string Property4 { get; set; }

        public char Property5 { get; set; }
    }
}