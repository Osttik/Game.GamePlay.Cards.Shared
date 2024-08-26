namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameMessageRequest
    {
        public required long PlayerId { get; set; } 
        public required long SessionId { get; set; }
    }
}
