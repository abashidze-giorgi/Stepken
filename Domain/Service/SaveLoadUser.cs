using Domain.GameCharacter;
using Domain.Interface;
using Newtonsoft.Json;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Domain.Service
{
    public class SaveLoadUser : ISaveLoadUser
    {
        public Character LoadUser(string userName)
        {
            throw new NotImplementedException();
        }

        public bool SaveUser(Character user)
        {
            try
            {
                List<Character> myList = new List<Character>(); // new character list

                StringCollection stringList = new StringCollection();// new list of collections.specialized.string.list
                 
                StringCollection savedList = Settings.Settings1.Default.PlayerS; // get list from settings

                if(savedList != null)
                {
                    myList = GetSavedCharacters();
                    bool exist = ChecUserExist(myList, user);
                    if (!exist)
                    {
                        string newCharacter = JsonConvert.SerializeObject(user);
                        stringList.Add(newCharacter);
                    }
                    else
                    {
                        foreach (Character character in myList)
                        {
                            if (character.Name != user.Name)
                            {
                                string oldCharacter = JsonConvert.SerializeObject(character);
                                stringList.Add(oldCharacter);
                            }
                        }
                        string characterJson = JsonConvert.SerializeObject(user);
                        stringList.Add(characterJson);
                    }
                }
                else
                {
                    
                }
                
                Settings.Settings1.Default.PlayerS = stringList;
                Settings.Settings1.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ChecUserExist(List<Character> list, Character user)
        {
            var exist = list.Where(u => u.Name == user.Name).FirstOrDefault();
            return exist==null ? false : true;
        }
        private List<Character> GetSavedCharacters()
        {
            StringCollection stringList = Settings.Settings1.Default.PlayerS;
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
