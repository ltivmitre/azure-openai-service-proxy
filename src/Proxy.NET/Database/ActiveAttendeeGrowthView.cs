﻿using System;
using System.Collections.Generic;

namespace AzureOpenAIProxy.Management.Database;

public partial class ActiveAttendeeGrowthView
{
    public string EventId { get; set; } = null!;

    public DateTime DateStamp { get; set; }

    public decimal Attendees { get; set; }
}
