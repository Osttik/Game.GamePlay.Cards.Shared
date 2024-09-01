using Game.GamePlay.Cards.Shared.Models.Enums;
using System.Collections.Generic;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.DTO
{
    public class CardGameSessionDTO
    {
        public long Id { get; set; }
        public GameMode GameMode { get; set; }

        public CardDTO TrumpCard { get; set; }

        public ICollection<CardDTO> Cards { get; set; }
        public ICollection<BoardCardDTO> BoardCards { get; set; } = new List<BoardCardDTO>();
        public ICollection<CardPlayerGameInfoDTO> PlayersGameInfos { get; set; }
    }
}
