using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerLoadedMessageRequest : ISocketMessage
    {
        public long SessionId { get; set; }
        public long PlayerId { get; set; }
    }
}