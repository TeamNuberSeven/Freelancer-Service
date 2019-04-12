using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class User
    {   
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
