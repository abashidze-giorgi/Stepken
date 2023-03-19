using Domain.GameCharacter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class GetUserList
    {
        public List<string> GetUsers()
        {
            List<string> userList = new List<string>();
            StringCollection stringList = Settings.Settings1.Default.PlayerS; // get list from settings
            if (stringList == null)
            {
                return userList;
            }
            else
            {
                foreach (string characterJson in stringList)
                {
                    var character = JsonConvert.DeserializeObject<Character>(characterJson);
                    userList.Add(character.Name);
                }
                return userList;
            }
        }
    }
}
