namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class AttackPlayerMessageRequest
    {
        public required long PlayerId { get; set; } 
        public required long SessionId { get; set; } 
        public required long CardId { get; set; }
    }
}
