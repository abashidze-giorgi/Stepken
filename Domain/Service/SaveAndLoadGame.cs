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
    public class SaveAndLoadGame : ISaveAndLoadGame
    {
        public void Load(string userName)
        {
            List<Character> playerList = GetSavedCharacter();
            Character? character = playerList.FirstOrDefault(p => p.Name == userName);
            if(character != null)
            {
                GameList.Player = character;
            }
        }

        public bool Save()
        {
            try
            {
                List<Character> myList = new List<Character>(); // new character list

                StringCollection stringList = new StringCollection();// new list of collections.specialized.string.list
                 
                StringCollection savedList = Settings.Settings1.Default.PlayerS; // get list from settings

                myList = GetSavedCharacter();

                foreach (Character character in myList)
                {
                    if (character.Name != GameList.Player.Name)
                    {
                        string oldCharacter = JsonConvert.SerializeObject(character);
                        stringList.Add(oldCharacter);
                    }
                }
                string palayerJson = JsonConvert.SerializeObject(GameList.Player);
                stringList.Add(palayerJson);

                Settings.Settings1.Default.PlayerS = stringList;
                Settings.Settings1.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private List<Character> GetSavedCharacter()
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
