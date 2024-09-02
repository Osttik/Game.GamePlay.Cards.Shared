using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class StartGameSessionMessageRequest
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long RoomId { get; set; }
    }
}
