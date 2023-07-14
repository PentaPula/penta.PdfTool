using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penta.PdfTool.Shared.Dto;

public record InvoiceItemDto(Int32 rbr, ItemDto Item, Decimal UnitCost, Decimal Qty, Decimal Amount);
   
