using Game.Shared.Models.Enums;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class ConnectPlayerMessageRequest : ISocketMessage
    {
        public AuthType AuthType { get; set; }
    }
}
