using System.IdentityModel.Tokens.Jwt;
using System.Net;

using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using MinWebPage.Data;

namespace MinWebPage.Services
{
    public class BoardGameService 
    {
        private static string URL = "https://api.geekdo.com/xmlapi/search?search={0}";
        public static List<Game> SearchForGame(string searchName, List<Game> myGames) {

            var aRequest = WebRequest.Create(String.Format(URL, searchName));
            HttpWebResponse aResponse = (HttpWebResponse)aRequest.GetResponse();
            XmlSerializer serializer = new XmlSerializer(typeof(boardgames));

            boardgames deserializedData = null;
            List<Game> result = new List<Game>();
            using (Stream reader = aResponse.GetResponseStream())
            {
                // Call the Deserialize method to restore the object's state.
                if (serializer != null)
                {
                    deserializedData = (boardgames)serializer!.Deserialize(reader);

                    if (deserializedData != null)
                    {
                        foreach (var boardgame in deserializedData.boardgame)
                        {
                            result.Add(
                                new Game()
                                {
                                    Id = boardgame.objectid,
                                    Name = boardgame.name[0].Value,
                                    inCollection = myGames.Find( g => g.Id == boardgame.objectid ) != null
                                }
                            );
                            Console.Out.WriteLine(boardgame.objectid + " # " + boardgame.name[0].Value);
                        }
                    }
                }
            }

            return result;
        }
    }
}



