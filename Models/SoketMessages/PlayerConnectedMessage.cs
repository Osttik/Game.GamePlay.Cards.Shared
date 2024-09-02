using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerConnectedMessage : ISocketMessage
    {
        public long PlayerId { get; set; }
        public string Name { get; set; }
    }
}
