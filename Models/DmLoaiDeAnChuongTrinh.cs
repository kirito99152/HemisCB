﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmLoaiDeAnChuongTrinh
{
    public int IdLoaiDeAnChuongTrinh { get; set; }

    public string? LoaiDeAnChuongTrinh { get; set; }

    public virtual ICollection<TbPhongHocGiangDuongHoiTruong> TbPhongHocGiangDuongHoiTruongs { get; set; } = new List<TbPhongHocGiangDuongHoiTruong>();

    public virtual ICollection<TbToChucHopTacDoanhNghiep> TbToChucHopTacDoanhNghieps { get; set; } = new List<TbToChucHopTacDoanhNghiep>();
}
