using System.ComponentModel.DataAnnotations;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class DefeatPlayerMessageRequest : ISocketMessage
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long SessionId { get; set; }
        [Required]
        public long DefeatCardId { get; set; }
        [Required]
        public long BoardCardId { get; set; }
    }
}
