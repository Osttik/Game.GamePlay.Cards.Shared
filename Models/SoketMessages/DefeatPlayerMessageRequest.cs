namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class DefeatPlayerMessageRequest
    {
        public required long PlayerId { get; set; } 
        public required long SessionId { get; set; } 
        public required long DefeatCardId { get; set; }
        public required long BoardCardId { get; set; }
    }
}
