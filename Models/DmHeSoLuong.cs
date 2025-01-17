﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmHeSoLuong
{
    public int IdHeSoLuong { get; set; }

    public string? HeSoLuong { get; set; }

    public virtual ICollection<TbDienBienLuong> TbDienBienLuongs { get; set; } = new List<TbDienBienLuong>();

    public virtual ICollection<TbPhuCap> TbPhuCaps { get; set; } = new List<TbPhuCap>();
}
