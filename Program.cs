using System;
// M.A. Nunes
namespace GotoPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Base: ");
            int iBase = int.Parse(Console.ReadLine());
            Console.Write("The Power: ");
            int iPower = int.Parse(Console.ReadLine());
            Console.Write(GoPowerTo(iBase,iPower));
        }
        static UInt32 GoPowerTo(in int Base, in int Power)
        {
            Int32 x = 1,iItor = 0;
            goto LoopEntry;
        LoopBegin:
            iItor++;
            x *= Base;
            LoopEntry:
            if (iItor <Power)
                   goto LoopBegin;
            return (UInt32)x;
        }
    }
}
