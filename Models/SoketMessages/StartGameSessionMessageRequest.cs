
#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameSessionMessageRequest
    {
        public long PlayerId { get; set; }
        public long RoomId { get; set; }
    }
}
