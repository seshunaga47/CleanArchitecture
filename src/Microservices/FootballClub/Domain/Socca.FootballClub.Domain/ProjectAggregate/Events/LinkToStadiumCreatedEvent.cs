﻿using Socca.Domain.Core.Events;

namespace Socca.FootballClub.Domain.ProjectAggregate.Events
{
    public class LinkToStadiumCreatedEvent: Event
    {
        public int FootballClubId { get; private set; }
        public int StadiumId { get; private set; }
        public LinkToStadiumCreatedEvent(int footballClubId, int stadiumId)
        {
            FootballClubId = footballClubId;
            StadiumId = stadiumId;
        }
    }
}
