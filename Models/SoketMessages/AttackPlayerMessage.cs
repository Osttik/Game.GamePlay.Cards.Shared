﻿using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class AttackPlayerMessage : ISocketMessage
    {
        [Required]
        public long CardId { get; set; }
    }
}
