using Domain.GameCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ISaveLoadUser
    {
        public bool SaveUser(Character user);

        public Character LoadUser(string userName);
    }
}
