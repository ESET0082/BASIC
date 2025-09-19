using System;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void message_set(byte[] obis_voltage, int voltage)
        {
            Console.WriteLine($"you obis code {BitConverter.ToString(obis_voltage)} change to {voltage}");
        }

        public static void message_action(byte[] obis_voltage, string action)
        {
            Console.WriteLine($"you obis code {BitConverter.ToString(obis_voltage)} take action {action}");
        }

        public static void message_GET(byte[] obis_voltage)
        {
            Console.WriteLine($"you obis code {BitConverter.ToString(obis_voltage)} was requested (GET)");
        }

        static void Main(string[] args)
        {
            DlmsService.MeterObject[] meterObjects = new DlmsService.MeterObject[]
            {
                new DlmsService.MeterObject { OBIS = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 }, Name = "Voltage Meter", Value = 220 },
                new DlmsService.MeterObject { OBIS = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x07 }, Name = "Energy Meter", Value = 150 },
            };

            DlmsService dlmsService = new DlmsService(meterObjects);

            byte[] obis_voltage = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 };
            byte[] obis_energy = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x07 };

            dlmsService.DlmsSet(obis_voltage, 240);
            System.Threading.Thread.Sleep(500);// add de;lay
            message_set(obis_voltage, 240);

            dlmsService.DlmsAction(obis_energy, "RESET");
            System.Threading.Thread.Sleep(500);// add de;lay
            message_action(obis_energy, "RESET");

            dlmsService.DlmsGet(obis_voltage);
            System.Threading.Thread.Sleep(500);// add de;lay
            message_GET(obis_voltage);

            byte[] obis_energy_temp = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x08 };
            dlmsService.DlmsGet(obis_energy_temp);
        }
    }
}
