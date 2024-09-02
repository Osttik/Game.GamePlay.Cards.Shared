using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class AttackPlayerMessageRequest
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long SessionId { get; set; }
        [Required]
        public long CardId { get; set; }
    }
}
