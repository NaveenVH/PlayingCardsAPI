using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlayingCardsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        public static readonly Dictionary<string, int> CardRank = new Dictionary<string, int>()
    {
            {"4T", 1 },
            {"2T",2 },
            {"ST",3 },
            {"PT",4 },
            {"RT",5 },
            {"2D",6 },
            {"3D",7 },
            {"4D",8 },
            {"5D",9 },
            {"6D",10 },
            {"7D",11 },
            {"8D",12 },
            {"9D",13 },
            {"10D",14 },
            {"JD", 15 },
            {"QD", 16 },
            {"KD", 17 },
            {"AD",18 },
            {"2S",19 },
            {"3S",20 },
            {"4S",21 },
            {"5S",22 },
            {"6S",23 },
            {"7S",24 },
            {"8S",25 },
            {"9S",26 },
            {"10S",27 },
            {"JS", 28 },
            {"QS", 29 },
            {"KS", 30 },
            {"AS",31 },
            {"2C",32 },
            {"3C",33 },
            {"4C",34 },
            {"5C",35 },
            {"6C",36 },
            {"7C",37 },
            {"8C",38 },
            {"9C",39 },
            {"10C",40 },
            {"JC", 41 },
            {"QC", 42 },
            {"KC", 43 },
            {"AC",44 },
            {"2H",45 },
            {"3H",46 },
            {"4H",47 },
            {"5H",48 },
            {"6H",49 },
            {"7H",50 },
            {"8H",51 },
            {"9H",52 },
            {"10H",53 },
            {"JH", 54 },
            {"QH", 55 },
            {"KH", 56 },
            {"AH",57 }

    };

        [HttpPost(Name = "SortCards")]
        public IEnumerable<string> SortCards([FromBody] List<string> cards)
        {
            var done = false;
            while (!done)
            {
                done = true;
                for (int i = 1; i <= cards.Count - 1; i++)
                {
                    if (CardRank.GetValueOrDefault(cards[i - 1]) > CardRank.GetValueOrDefault(cards[i]))
                    {
                        done = false;
                        var temp = cards[i - 1];
                        cards[i - 1] = cards[i];
                        cards[i] = temp;
                    }   
                }
            }
            return cards;
        }
    }
}
