using System.ComponentModel.DataAnnotations;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class JoinRoomMessageRequest : ISocketMessage
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long RoomId { get; set; }
        public string Password { get; set; }
    }
}
