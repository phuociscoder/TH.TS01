using System;
using System.Collections.Generic;

namespace TH.TS01.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public long BasicSal { get; set; }

    public virtual ICollection<TimeSheet> TimeSheets { get; set; } = new List<TimeSheet>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
