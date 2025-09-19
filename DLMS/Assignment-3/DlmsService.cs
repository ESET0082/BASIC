using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DlmsService
    {
        public class MeterObject
        {
            public byte[] OBIS { get; set; }
            public string Name { get; set; }
            public int Value { get; set; }
        }

        private MeterObject[] meterObjects;
        private int meterObjectCount;

        public void message_get(string message)
        {
            Console.WriteLine(message);
        }
        public DlmsService(MeterObject[] objects)
        {
            meterObjects = objects;
            meterObjectCount = objects.Length;
        }

        // Helper function to match OBIS codes
        private bool ObisMatch(byte[] obis1, byte[] obis2)
        {
            for (int i = 0; i < 6; i++)
            {
                if (obis1[i] != obis2[i])
                    return false;
            }
            return true;
        }

        // GET Service
        public void DlmsGet(byte[] obis)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisMatch(obis, meterObjects[i].OBIS))
                {
                    Console.WriteLine($"[GET] {meterObjects[i].Name} = {meterObjects[i].Value}");

                    //Console.WriteLine();?
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
            //message_get("your obis code present in database");
        }

        // SET Service
        public void DlmsSet(byte[] obis, int newValue)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisMatch(obis, meterObjects[i].OBIS))
                {
                    meterObjects[i].Value = newValue;
                    Console.WriteLine($"[SET] {meterObjects[i].Name} updated to {newValue}");
                    //message_get("your obis code value set in database");
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
            //message_get("your obis code not found so can not chnge  value ");
        }

        // ACTION Service
        public void DlmsAction(byte[] obis, string method)
        {
            if (method.Equals("RESET", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                for (int i = 0; i < meterObjectCount; i++)
                {
                    meterObjects[i].Value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
                //message_get("your obis code action completed ");
            }
            else if (method.Equals("SYNC_TIME", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
                // Time sync logic here (e.g., update clock based on system time)
                Console.WriteLine("[ACTION] Synchronization complete.");
                //message_get("your obis code action Synchronization completed ");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }
    }
}
