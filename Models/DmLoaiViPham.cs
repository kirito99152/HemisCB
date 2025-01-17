﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmLoaiViPham
{
    public int IdLoaiViPham { get; set; }

    public string? LoaiViPham { get; set; }

    public virtual ICollection<TbThongTinViPham> TbThongTinViPhams { get; set; } = new List<TbThongTinViPham>();
}
