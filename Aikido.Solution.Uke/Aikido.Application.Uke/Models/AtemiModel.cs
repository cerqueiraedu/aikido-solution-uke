using Aikido.Domain.Uke.Entities;

namespace Aikido.Application.Uke.Models
{
    public class AtemiModel
    {
        public string Name { get; }

        public AtemiModel(Atemi atemi)
        {
            Name = atemi.Name;
        }

        public override string ToString()
        {
            return $"uke attacks using {Name}";
        }
    }
}