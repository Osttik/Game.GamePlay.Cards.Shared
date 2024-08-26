using Game.GamePlay.Cards.Shared.Models.Enums;

namespace Game.GamePlay.Cards.Shared.Models.DTO
{
    public class CardDTO
    {
        public long Id { get; set; }
        public CardSuits Suit { get; set; }
        public CardSeniority Seniority { get; set; }
    }
}
