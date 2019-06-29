using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Project.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class IssueModel
    {
        private readonly RequestDelegate _next;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
