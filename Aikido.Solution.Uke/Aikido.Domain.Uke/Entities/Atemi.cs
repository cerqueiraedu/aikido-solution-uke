using System;

namespace Aikido.Domain.Uke.Entities
{
    public class Atemi
    {
        public string Name { get; private set; }

        public Atemi(string name)
        {
            Name = name;
        }
    }
}