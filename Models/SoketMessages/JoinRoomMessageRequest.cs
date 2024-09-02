using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class JoinRoomMessageRequest
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long RoomId { get; set; }
        public string Password { get; set; }
    }
}
