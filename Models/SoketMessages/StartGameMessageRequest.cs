
#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessageRequest
    {
        public long PlayerId { get; set; } 
        public long SessionId { get; set; }
    }
}
