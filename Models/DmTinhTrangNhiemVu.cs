﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmTinhTrangNhiemVu
{
    public int IdTinhTrangNhiemVu { get; set; }

    public string? TinhTrangNhiemVu { get; set; }

    public virtual ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public virtual ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();
}
