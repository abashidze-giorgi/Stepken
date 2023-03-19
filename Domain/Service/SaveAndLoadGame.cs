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
            List<Character> playerList = GetSavedCharacters();
            foreach(var player in playerList)
            {
                if(player.Name == userName)
                {
                    GameList.Player = player;
                }
            }
        }

        public bool Save()
        {
            try
            {
                List<Character> myList = new List<Character>(); // new character list

                StringCollection stringList = new StringCollection();// new list of collections.specialized.string.list
                 
                StringCollection savedList = Settings.Settings1.Default.PlayerS; // get list from settings

                myList = GetSavedCharacters();

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
