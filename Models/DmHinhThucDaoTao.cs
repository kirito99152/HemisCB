﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmHinhThucDaoTao
{
    public int IdHinhThucDaoTao { get; set; }

    public string? HinhThucDaoTao { get; set; }

    public virtual ICollection<TbHinhThucDaoTaoCuaNganh> TbHinhThucDaoTaoCuaNganhs { get; set; } = new List<TbHinhThucDaoTaoCuaNganh>();

    public virtual ICollection<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai> TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoais { get; set; } = new List<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai>();
}
