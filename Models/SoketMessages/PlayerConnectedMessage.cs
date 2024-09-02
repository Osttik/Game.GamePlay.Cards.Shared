#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerConnectedMessage
    {
        public long PlayerId { get; set; }
        public string Name { get; set; }
    }
}
