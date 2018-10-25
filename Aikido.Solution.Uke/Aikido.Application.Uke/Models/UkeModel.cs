using System;
using Aikido.Application.Uke.Interfaces;
using Aikido.Application.Uke.Models;
using Aikido.Domain.Uke.Entities;

namespace Aikido.Application.Uke.Models
{
    public class UkeModel : IDoAtemi
    {
        private readonly IProvideAtemi _atemiProvider;

        public UkeModel(IProvideAtemi atemiProvider)
        {
            _atemiProvider = atemiProvider;
        }
        public AtemiModel ExecuteAtemi()
        {
            return new AtemiModel(_atemiProvider.Get());
        }
    }
}
