using System;
using Aikido.Domain.Uke.Entities;

namespace Aikido.Application.Uke.Models
{
    public class AtemiModel
    {
        public string Name { get; private set; }

        public AtemiModel(Atemi atemi)
        {
            this.Name = atemi.Name;
        }

        public override string ToString()
        {
            return string.Format ("uke attacks using {0}", this.Name);
        }
    }
}