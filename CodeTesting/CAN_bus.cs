using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAN
{
    class HeaderFrame
    {
        public uint StdID { get; set; }
        public byte DLC { get; set; }
        public byte IDE { get; set; }
        public byte TransmitGlobalTime { get; set; }
        public byte RTR { get; set; }
    }

    internal class CAN_bus
    {
        private
        byte[]? data = new byte[8];
        int a = 0;
        HeaderFrame header;

        public CAN_bus(uint stdID, byte DLC, byte IDE, byte TransmitGlobalTime, byte RTR)
        {
            if (this.header == null) throw new ArgumentNullException(nameof(this.header));
            this.header.StdID = stdID;
            this.header.DLC = DLC;
            this.header.IDE = IDE;
            this.header.RTR = (byte)RTR;

            this.header.TransmitGlobalTime = TransmitGlobalTime;
        }

        public ushort MakeFrame(HeaderFrame header)
        {
            ushort result = 0;
            if (this.header == null) throw new ArgumentNullException(nameof(this.header));
            result = (ushort)(
                  (ushort)header.StdID << 5
                | (ushort)header.RTR << 4
                | (ushort)header.IDE << 3);
            return result;
        }

        public void PutMessage(byte[] inputData)
        {
            this.data = inputData;


        }

        public byte[] Send()
        {
            byte[] outputData = { 0 };
            if (this.data != null)
            {
                outputData = this.data;

            }
            Console.WriteLine("Sending CAN packet data");
            return outputData;

        }






    }
}
