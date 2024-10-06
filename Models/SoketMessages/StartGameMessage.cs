using System.Collections.Generic;
using Game.GamePlay.Cards.Shared.Models.DTO;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessage : ISocketMessage
    {
        public List<CardDTO> Cards { get; set; }
    }
}
