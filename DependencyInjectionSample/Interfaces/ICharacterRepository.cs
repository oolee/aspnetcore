using DependencyInjectionSample.Models;
using System.Collections.Generic;

namespace DependencyInjectionSample.Interfaces {
    public interface ICharacterRepository {
        IEnumerable<Character> ListAll();
        void Add(Character character);
    }
}
