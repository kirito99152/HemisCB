﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmNoiDungHoatDongTaiVietNam
{
    public int IdNoiDungHoatDongTaiVietNam { get; set; }

    public string? NoiDungHoatDongTaiVietNam { get; set; }

    public virtual ICollection<TbGiangVienNn> TbGiangVienNns { get; set; } = new List<TbGiangVienNn>();
}
