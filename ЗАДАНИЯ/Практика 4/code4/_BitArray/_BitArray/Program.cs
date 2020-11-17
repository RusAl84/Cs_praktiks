using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace _BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#
            //BitArray bits = new BitArray(3);
            //bits[0] = false;
            //bits[1] = true;
            //bits[2] = false;


            //#2
            //BitArray bits = new BitArray(3);
            //bits[0] = true;
            //bits[1] = true;
            //bits[2] = true;

            //BitArray moreBits = new BitArray(3);
            //moreBits[0] = true;
            //moreBits[1] = true;
            //moreBits[2] = false;

            //BitArray xorBits = bits.Xor(moreBits);
            //foreach (bool bit in xorBits)
            //{
            //    Console.WriteLine(bit);
            //}

            // #3
            //BitVector32 vector = new BitVector32(0);

            //int firstBit = BitVector32.CreateMask();
            //int secondBit = BitVector32.CreateMask(firstBit);
            //int thirdBit = BitVector32.CreateMask(secondBit);
            ////
            //vector[firstBit] = true;
            //vector[thirdBit] = true;

            //Console.WriteLine("{0} should be 3", vector.Data);
            //Console.WriteLine(vector);  // BitVector32{00000000000000000000000000000011}

            ////# 4
            BitVector32 newVector = new BitVector32(191);
            //Console.WriteLine(newVector);
 
            //bool bit1 = newVector[firstBit];
            //bool bit2 = newVector[secondBit];
            //bool bit3 = newVector[0x40];

            // bit1 = false, bit2 = false, bit3 = true

            // #4
            BitVector32.Section firstSection = BitVector32.CreateSection(10);
            BitVector32.Section secondSection = BitVector32.CreateSection(50, firstSection);
            BitVector32.Section thirdSection = BitVector32.CreateSection(500, secondSection);

            BitVector32 packedBits = new BitVector32(0);

            packedBits[firstSection] = 10;
            packedBits[secondSection] = 1;
            packedBits[thirdSection] = 192;

            Console.WriteLine(packedBits[firstSection]);
            Console.WriteLine(packedBits[secondSection]);
            Console.WriteLine(packedBits[thirdSection]);


            Console.WriteLine(packedBits.Data); // 98314

            Console.WriteLine(packedBits); // BitVector32{00000000000000011000000000001010}



        }
    }
}
