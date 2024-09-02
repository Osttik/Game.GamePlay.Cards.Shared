using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessageRequest
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long SessionId { get; set; }
    }
}
