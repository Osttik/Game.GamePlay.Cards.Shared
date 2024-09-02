using System.ComponentModel.DataAnnotations;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessageRequest : ISocketMessage
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long SessionId { get; set; }
    }
}
