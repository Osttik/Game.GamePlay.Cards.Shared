using Game.GamePlay.Cards.Shared.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Game.Shared.Models.Requests
{
    public class CreateCardsRoomModel: CreateRoomModel
    {
        [Required]
        public required GameMode GameMode { get; set; }
    }
}
