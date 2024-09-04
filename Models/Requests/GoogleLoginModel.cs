using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.Requests
{
    public class GoogleLoginModel
    {
        [Required]
        public string Token { get; set; }
    }
}
