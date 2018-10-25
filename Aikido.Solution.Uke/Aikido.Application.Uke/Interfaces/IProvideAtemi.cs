using System;
using Aikido.Domain.Uke.Entities;

namespace Aikido.Application.Uke.Interfaces
{
    public interface IProvideAtemi
    {
        Atemi Get();
    }
}
