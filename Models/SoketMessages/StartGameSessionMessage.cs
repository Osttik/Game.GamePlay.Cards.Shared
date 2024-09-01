using Game.GamePlay.Cards.Shared.Models.DTO;
using System.Collections.Generic;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameSessionMessage
    {
        public List<CardDTO> Cards;
        public CardDTO TrumpCard { get; set; }
        public long SessionId { get; set; }
    }
}
