using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class ReadyStatusMessage : ISocketMessage
    {
        public long PlayerId { get; set; }
        public bool IsReady { get; set; }
    }
}
