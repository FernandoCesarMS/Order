using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities.Enums
{
    enum OrderStatus
    {
        Pending_Pay = 0,
        Processing = 1,
        Shiipped = 2,
        Delivered = 3
    };
}
