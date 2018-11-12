using System;
using Aikido.Domain.Uke.Entities;
using Aikido.Application.Uke.Interfaces;
using System.Collections.Generic;

namespace Aikido.Persistence.Uke
{
    public class AtemiProvider : IProvideAtemi
    {
        private readonly IList<string> _atemiCollection;
        private readonly Random _random;
        
        public AtemiProvider()
        {
            _atemiCollection = new List<string> {
                "tsuki", 
                "shomen uchi", 
                "yokomen uchi"
            };
            _random = new Random();
        }

        public Atemi Get()
        {
            return new Atemi(_atemiCollection[_random.Next(_atemiCollection.Count)]);
        }
    }
}
