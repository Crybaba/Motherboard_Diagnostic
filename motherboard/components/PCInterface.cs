﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motherboard_Diagnostic.motherboard
{
    internal class PCInterface : Component
    {
        public PCInterface()
        {
            this.DiagnosticData = new()
            {
                new ElementDiagnosticData(
                    instrument: Instruments.Videotester,
                    faultId: 5,
                    getWorkingData: VideotesterWorkingMessage,
                    getBrokenData: VideotesterBrokenMessage
                )
            };
        }
        private string VideotesterWorkingMessage()
        {
            string message = "Работает";
            return message;
        }
        private string VideotesterBrokenMessage()
        {
            string message = "Не работает";
            return message;
        }
    }
}
