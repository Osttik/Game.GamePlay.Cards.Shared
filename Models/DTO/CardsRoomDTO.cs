using Game.GamePlay.Cards.Shared.Models.Enums;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.DTO
{
    public class CardsRoomDTO
    {
        public long Id { get; set; }
        public GameMode GameMode { get; set; }
        public string Name { get; set; }
        public int MaxPlayersCount { get; set; }
        public int PlayersCount { get; set; }
        public bool IsOpen { get; set; }

        public CardPlayerDTO MasterPlayer { get; set; }

        public ICollection<CardPlayerDTO> Players { get; set; } = new List<CardPlayerDTO>();
    }
}
