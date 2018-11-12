using Aikido.Application.Uke.Interfaces;

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
