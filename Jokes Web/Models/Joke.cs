using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace JokesWeb.Models
{
    public class Joke
    {

        public int Id { get; set; }
        public string JokeQn { get; set; }
        public string JokeAns { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        public Joke()
        {
                
        }

    }
}
