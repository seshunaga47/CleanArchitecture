﻿namespace Socca.DistributedCache.Domain.Entities
{
    public class PlayerTransfer
    {
        public int Id { get; set; }
        public int FromTeam { get; set; }
        public int ToTeam { get; set; }
        public int PlayerId { get; set; } // Key
    }
}
