using System;
using System.Collections.Generic;

namespace HemisCB.Models;

public partial class DmKhuVuc
{
    public int IdKhuVuc { get; set; }

    public string? KhuVuc { get; set; }

    public virtual ICollection<TbDuLieuTrungTuyen> TbDuLieuTrungTuyens { get; set; } = new List<TbDuLieuTrungTuyen>();
}
