using Runner.Models.Interfaces;
using System.Text;

namespace Runner.Models
{
    public class AppInstance : IModel
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int InstanceCount { get; set; } = 1;
        public string Path { get; set; } = string.Empty;

        public string Description
        {
            get
            {
                return this.Path;
            }
        }

        public string?[] SubItem
        {
            get
            {
                return this.GetType()
                    .GetProperties()
                    .Where(p => p.Name.ToLower() != "SubItem".ToLower())
                    .Select(prop => prop.GetValue(this)?.ToString())
                    .ToArray();
            }
        }

        public string Validate()
        {
            var errorBuilder = new StringBuilder();

            if (InstanceCount < 1)
            {
                errorBuilder.AppendLine("InstanceCount needs to be greater than 0");
            }

            if (String.IsNullOrEmpty(Name))
            {
                errorBuilder.AppendLine("Name cannot be empty");
            }

            if (String.IsNullOrEmpty(Path))
            {
                errorBuilder.AppendLine("Path cannot be empty");
            }

            return errorBuilder.ToString();
        }
    }
}
