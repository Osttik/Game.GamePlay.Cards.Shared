﻿using Game.GamePlay.Cards.Shared.Models.SoketMessages.Abstraction;

namespace Game.GamePlay.Cards.Shared.Models.SoketMessages
{
    public class NewRoomMasterMessage : ISocketMessage
    {
        public long NewMasterId { get; set; }
    }
}
