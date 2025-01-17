﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmSinhVienNam
{
    public int IdSinhVienNam { get; set; }

    public string? SinhVienNam { get; set; }

    public virtual ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
