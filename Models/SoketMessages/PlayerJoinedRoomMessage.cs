﻿using Game.GamePlay.Cards.Shared.Models.DTO;
using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class PlayerJoinedRoomMessage : ISocketMessage
    {
        [Required]
        public CardPlayerDTO NewPlayer { get; set; }
    }
}
