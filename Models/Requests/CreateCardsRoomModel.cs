using Game.GamePlay.Cards.Shared.Models.Enums;
using Game.Shared.Models.Requests;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.Requests
{
    public class CreateCardsRoomModel : CreateRoomModel
    {
        [Required]
        public GameMode GameMode { get; set; }
    }
}