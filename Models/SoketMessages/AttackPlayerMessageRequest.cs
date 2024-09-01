
#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class AttackPlayerMessageRequest
    {
        public long PlayerId { get; set; } 
        public long SessionId { get; set; } 
        public long CardId { get; set; }
    }
}
