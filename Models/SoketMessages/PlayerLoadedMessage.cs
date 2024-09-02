using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerLoadedMessage : ISocketMessage
    {
        public long SessionId { get; set; }
        public long PlayerId { get; set; }
    }
}
