﻿using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class DefeatPlayerMessageRequest
    {
        [Required]
        public long PlayerId { get; set; }
        [Required]
        public long SessionId { get; set; }
        [Required]
        public long DefeatCardId { get; set; }
        [Required]
        public long BoardCardId { get; set; }
    }
}
