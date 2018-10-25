using System;
using Aikido.Domain.Uke.Entities;
using Aikido.Application.Uke.Interfaces;
using System.Collections.Generic;

namespace Aikido.Persistence.Uke
{
    public class AtemiProvider : IProvideAtemi
    {
        private readonly IList<string> _atemiCollection;
        private Random _rnd;
        public AtemiProvider()
        {
            _atemiCollection = new List<string>() {
                "tsuki", 
                "shomen uchi", 
                "yokomen uchi"
            };
            _rnd = new Random();
        }

        public Atemi Get()
        {
            return new Atemi(_atemiCollection[_rnd.Next(_atemiCollection.Count)]);
        }
    }
}
