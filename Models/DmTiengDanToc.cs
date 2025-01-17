﻿using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmTiengDanToc
{
    public int IdTiengDanToc { get; set; }

    public string? TiengDanToc { get; set; }

    public virtual ICollection<TbTrinhDoTiengDanToc> TbTrinhDoTiengDanTocs { get; set; } = new List<TbTrinhDoTiengDanToc>();
}
