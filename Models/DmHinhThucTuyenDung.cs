﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmHinhThucTuyenDung
{
    public int IdHinhThucTuyenDung { get; set; }

    public string? HinhThucTuyenDung { get; set; }

    public virtual ICollection<TbThongTinViecLamSauTotNghiep> TbThongTinViecLamSauTotNghieps { get; set; } = new List<TbThongTinViecLamSauTotNghiep>();
}
