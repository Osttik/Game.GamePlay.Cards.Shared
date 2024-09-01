
#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class DefeatPlayerMessageRequest
    {
        public long PlayerId { get; set; } 
        public long SessionId { get; set; } 
        public long DefeatCardId { get; set; }
        public long BoardCardId { get; set; }
    }
}
