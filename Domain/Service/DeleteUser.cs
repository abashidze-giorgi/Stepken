using Domain.GameCharacter;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class DeleteUser
    {
        public void DeleteUserSave(string name)
        {
            if (name != null) 
            {
                try
                {
                    var list = _users();
                    StringCollection stringList = new StringCollection();
                    foreach (Character character in list)
                    {
                        if (character.Name != name)
                        {
                            string oldCharacter = JsonConvert.SerializeObject(character);
                            stringList.Add(oldCharacter);
                        }
                    }

                    Settings.Settings1.Default.PlayerS = stringList;
                    Settings.Settings1.Default.Save();
                }
                catch
                {

                }
            }
        }

        private List<Character> _users()
        {
            StringCollection stringList = Settings.Settings1.Default.PlayerS; // get list from settings
            List<Character> myList = new List<Character>();
            foreach (string characterJson in stringList)
            {
                var character = JsonConvert.DeserializeObject<Character>(characterJson);
                myList.Add(character);
            }

            return myList;


        }
    }
}
