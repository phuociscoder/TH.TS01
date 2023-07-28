using System;
using System.Collections.Generic;

namespace TH.TS01.Models;

public partial class TimeSheet
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public bool IsApproved { get; set; }

    public virtual User User { get; set; } = null!;
}
