﻿using Microsoft.PointOfService;

namespace PointOfService.Hardware.Receipt
{
    public class PrintTopLogo : ICommand
    {
        public string Name => nameof(PrintTopLogo);

        public void Execute(PosPrinter printer, PrinterStation station)
        {
            printer.PrintNormal(station, EscapeSequence.PrintTopLogo);
        }
    }
}
