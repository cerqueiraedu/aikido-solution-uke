using System;
using Aikido.Domain.Uke.Entities;
using Aikido.Application.Uke.Models;

namespace Aikido.Application.Uke.Interfaces
{
    public interface IDoAtemi
    {
        AtemiModel ExecuteAtemi();
    }
}
