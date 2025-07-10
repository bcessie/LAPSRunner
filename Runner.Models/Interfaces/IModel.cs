using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Models.Interfaces
{
    public interface IModel
    {
        public int Id { get; set; }
        public string Description { get; }
        public string Validate();
        public string?[] SubItem { get; }
    }
}
