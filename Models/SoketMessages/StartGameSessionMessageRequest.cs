namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameSessionMessageRequest
    {
        public required long PlayerId { get; set; }
        public required long RoomId { get; set; }
    }
}
