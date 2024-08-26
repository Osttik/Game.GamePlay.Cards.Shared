using Game.GamePlay.Cards.Shared.Models.Enums;

namespace Game.GamePlay.Cards.Shared.Models.DTO
{
    public class CardGameSessionDTO
    {
        public long Id { get; set; }
        public GameMode GameMode { get; set; }

        public required CardDTO TrumpCard { get; set; }

        public required ICollection<CardDTO> Cards { get; set; }
        public ICollection<BoardCardDTO> BoardCards { get; set; } = new List<BoardCardDTO>();
        public required ICollection<CardPlayerGameInfoDTO> PlayersGameInfos { get; set; }
    }
}
