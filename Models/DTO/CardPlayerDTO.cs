namespace Game.GamePlay.Cards.Shared.Models.DTO
{
    public class CardPlayerDTO
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        //public PlayerStates PlayerState { get; set; }
        //public CardGameSession Session { get; set; }
        //public ICollection<CardPlayerGameInfo> GameInfos { get; set; }
    }
}
