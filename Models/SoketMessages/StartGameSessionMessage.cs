using Game.GamePlay.Cards.Shared.Models.DTO;

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameSessionMessage
    {
        public required List<CardDTO> Cards;
        public required CardDTO TrumpCard { get; set; }
        public required long SessionId { get; set; }
    }
}
