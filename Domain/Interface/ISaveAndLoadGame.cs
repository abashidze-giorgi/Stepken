using Domain.GameCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ISaveAndLoadGame
    {
        public bool Save(Character user);

        public void Load(string userName);
    }
}
