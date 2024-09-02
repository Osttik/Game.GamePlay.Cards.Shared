#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerLoadedMessage
    {
        public long SessionId { get; set; }
        public long PlayerId { get; set; }
    }
}
