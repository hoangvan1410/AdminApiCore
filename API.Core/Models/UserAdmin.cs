using System;
using System.Collections.Generic;

namespace API.Core.Models;

public partial class UserAdmin
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public bool? IsDelete { get; set; }
}
