using System.IO;

namespace ChatbutlerTest
{
    internal class Butler
    {
        public Butler()
        {
            string json = File.ReadAllText("greetings.json"); //click op File en ctrl+. en kies eerste
        }

        //maak een butler die kan groeten
        public string Greet()
        {
            return "Bonjour";
        }

        // maak daarna een greetings json file. file>new file> kies txt file> save as greetings.json
    }
}