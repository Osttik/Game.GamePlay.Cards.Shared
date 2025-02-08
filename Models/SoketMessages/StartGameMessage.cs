using System;
using System.Collections.Generic;
using Game.GamePlay.Cards.Shared.Models.DTO;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;
using Game.Shared.Models.Enums;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessage : ISocketMessage
    {
        public List<CardDTO> Cards { get; set; }
        public CardDTO TrumpCard { get; set; }
        public long GameSessionId { get; set; }
        public PlayerGameSessionState PlayerGameSessionState { get; set; }
    }
}