﻿using Lucene.Net.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucene.Net.Util.Packed
{
    internal sealed class BulkOperationPacked9 : BulkOperationPacked
    {

        public BulkOperationPacked9()
            : base(9)
        {
        }

        public override void Decode(long[] blocks, int blocksOffset, int[] values, int valuesOffset, int iterations)
        {
            for (int i = 0; i < iterations; ++i)
            {
                long block0 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)Number.URShift(block0, 55);
                values[valuesOffset++] = (int)(Number.URShift(block0, 46) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block0, 37) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block0, 28) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block0, 19) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block0, 10) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block0, 1) & 511L);
                long block1 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block0 & 1L) << 8) | Number.URShift(block1, 56));
                values[valuesOffset++] = (int)(Number.URShift(block1, 47) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block1, 38) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block1, 29) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block1, 20) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block1, 11) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block1, 2) & 511L);
                long block2 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block1 & 3L) << 7) | Number.URShift(block2, 57));
                values[valuesOffset++] = (int)(Number.URShift(block2, 48) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block2, 39) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block2, 30) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block2, 21) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block2, 12) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block2, 3) & 511L);
                long block3 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block2 & 7L) << 6) | Number.URShift(block3, 58));
                values[valuesOffset++] = (int)(Number.URShift(block3, 49) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block3, 40) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block3, 31) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block3, 22) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block3, 13) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block3, 4) & 511L);
                long block4 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block3 & 15L) << 5) | Number.URShift(block4, 59));
                values[valuesOffset++] = (int)(Number.URShift(block4, 50) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block4, 41) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block4, 32) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block4, 23) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block4, 14) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block4, 5) & 511L);
                long block5 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block4 & 31L) << 4) | Number.URShift(block5, 60));
                values[valuesOffset++] = (int)(Number.URShift(block5, 51) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block5, 42) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block5, 33) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block5, 24) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block5, 15) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block5, 6) & 511L);
                long block6 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block5 & 63L) << 3) | Number.URShift(block6, 61));
                values[valuesOffset++] = (int)(Number.URShift(block6, 52) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block6, 43) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block6, 34) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block6, 25) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block6, 16) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block6, 7) & 511L);
                long block7 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block6 & 127L) << 2) | Number.URShift(block7, 62));
                values[valuesOffset++] = (int)(Number.URShift(block7, 53) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block7, 44) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block7, 35) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block7, 26) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block7, 17) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block7, 8) & 511L);
                long block8 = blocks[blocksOffset++];
                values[valuesOffset++] = (int)(((block7 & 255L) << 1) | Number.URShift(block8, 63));
                values[valuesOffset++] = (int)(Number.URShift(block8, 54) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block8, 45) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block8, 36) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block8, 27) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block8, 18) & 511L);
                values[valuesOffset++] = (int)(Number.URShift(block8, 9) & 511L);
                values[valuesOffset++] = (int)(block8 & 511L);
            }
        }

        public override void Decode(sbyte[] blocks, int blocksOffset, int[] values, int valuesOffset, int iterations)
        {
            for (int i = 0; i < iterations; ++i)
            {
                int byte0 = blocks[blocksOffset++] & 0xFF;
                int byte1 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = (byte0 << 1) | Number.URShift(byte1, 7);
                int byte2 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte1 & 127) << 2) | Number.URShift(byte2, 6);
                int byte3 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte2 & 63) << 3) | Number.URShift(byte3, 5);
                int byte4 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte3 & 31) << 4) | Number.URShift(byte4, 4);
                int byte5 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte4 & 15) << 5) | Number.URShift(byte5, 3);
                int byte6 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte5 & 7) << 6) | Number.URShift(byte6, 2);
                int byte7 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte6 & 3) << 7) | Number.URShift(byte7, 1);
                int byte8 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte7 & 1) << 8) | byte8;
            }
        }

        public override void Decode(long[] blocks, int blocksOffset, long[] values, int valuesOffset, int iterations)
        {
            for (int i = 0; i < iterations; ++i)
            {
                long block0 = blocks[blocksOffset++];
                values[valuesOffset++] = Number.URShift(block0, 55);
                values[valuesOffset++] = Number.URShift(block0, 46) & 511L;
                values[valuesOffset++] = Number.URShift(block0, 37) & 511L;
                values[valuesOffset++] = Number.URShift(block0, 28) & 511L;
                values[valuesOffset++] = Number.URShift(block0, 19) & 511L;
                values[valuesOffset++] = Number.URShift(block0, 10) & 511L;
                values[valuesOffset++] = Number.URShift(block0, 1) & 511L;
                long block1 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block0 & 1L) << 8) | Number.URShift(block1, 56);
                values[valuesOffset++] = Number.URShift(block1, 47) & 511L;
                values[valuesOffset++] = Number.URShift(block1, 38) & 511L;
                values[valuesOffset++] = Number.URShift(block1, 29) & 511L;
                values[valuesOffset++] = Number.URShift(block1, 20) & 511L;
                values[valuesOffset++] = Number.URShift(block1, 11) & 511L;
                values[valuesOffset++] = Number.URShift(block1, 2) & 511L;
                long block2 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block1 & 3L) << 7) | Number.URShift(block2, 57);
                values[valuesOffset++] = Number.URShift(block2, 48) & 511L;
                values[valuesOffset++] = Number.URShift(block2, 39) & 511L;
                values[valuesOffset++] = Number.URShift(block2, 30) & 511L;
                values[valuesOffset++] = Number.URShift(block2, 21) & 511L;
                values[valuesOffset++] = Number.URShift(block2, 12) & 511L;
                values[valuesOffset++] = Number.URShift(block2, 3) & 511L;
                long block3 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block2 & 7L) << 6) | Number.URShift(block3, 58);
                values[valuesOffset++] = Number.URShift(block3, 49) & 511L;
                values[valuesOffset++] = Number.URShift(block3, 40) & 511L;
                values[valuesOffset++] = Number.URShift(block3, 31) & 511L;
                values[valuesOffset++] = Number.URShift(block3, 22) & 511L;
                values[valuesOffset++] = Number.URShift(block3, 13) & 511L;
                values[valuesOffset++] = Number.URShift(block3, 4) & 511L;
                long block4 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block3 & 15L) << 5) | Number.URShift(block4, 59);
                values[valuesOffset++] = Number.URShift(block4, 50) & 511L;
                values[valuesOffset++] = Number.URShift(block4, 41) & 511L;
                values[valuesOffset++] = Number.URShift(block4, 32) & 511L;
                values[valuesOffset++] = Number.URShift(block4, 23) & 511L;
                values[valuesOffset++] = Number.URShift(block4, 14) & 511L;
                values[valuesOffset++] = Number.URShift(block4, 5) & 511L;
                long block5 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block4 & 31L) << 4) | Number.URShift(block5, 60);
                values[valuesOffset++] = Number.URShift(block5, 51) & 511L;
                values[valuesOffset++] = Number.URShift(block5, 42) & 511L;
                values[valuesOffset++] = Number.URShift(block5, 33) & 511L;
                values[valuesOffset++] = Number.URShift(block5, 24) & 511L;
                values[valuesOffset++] = Number.URShift(block5, 15) & 511L;
                values[valuesOffset++] = Number.URShift(block5, 6) & 511L;
                long block6 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block5 & 63L) << 3) | Number.URShift(block6, 61);
                values[valuesOffset++] = Number.URShift(block6, 52) & 511L;
                values[valuesOffset++] = Number.URShift(block6, 43) & 511L;
                values[valuesOffset++] = Number.URShift(block6, 34) & 511L;
                values[valuesOffset++] = Number.URShift(block6, 25) & 511L;
                values[valuesOffset++] = Number.URShift(block6, 16) & 511L;
                values[valuesOffset++] = Number.URShift(block6, 7) & 511L;
                long block7 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block6 & 127L) << 2) | Number.URShift(block7, 62);
                values[valuesOffset++] = Number.URShift(block7, 53) & 511L;
                values[valuesOffset++] = Number.URShift(block7, 44) & 511L;
                values[valuesOffset++] = Number.URShift(block7, 35) & 511L;
                values[valuesOffset++] = Number.URShift(block7, 26) & 511L;
                values[valuesOffset++] = Number.URShift(block7, 17) & 511L;
                values[valuesOffset++] = Number.URShift(block7, 8) & 511L;
                long block8 = blocks[blocksOffset++];
                values[valuesOffset++] = ((block7 & 255L) << 1) | Number.URShift(block8, 63);
                values[valuesOffset++] = Number.URShift(block8, 54) & 511L;
                values[valuesOffset++] = Number.URShift(block8, 45) & 511L;
                values[valuesOffset++] = Number.URShift(block8, 36) & 511L;
                values[valuesOffset++] = Number.URShift(block8, 27) & 511L;
                values[valuesOffset++] = Number.URShift(block8, 18) & 511L;
                values[valuesOffset++] = Number.URShift(block8, 9) & 511L;
                values[valuesOffset++] = block8 & 511L;
            }
        }

        public override void Decode(sbyte[] blocks, int blocksOffset, long[] values, int valuesOffset, int iterations)
        {
            for (int i = 0; i < iterations; ++i)
            {
                long byte0 = blocks[blocksOffset++] & 0xFF;
                long byte1 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = (byte0 << 1) | Number.URShift(byte1, 7);
                long byte2 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte1 & 127) << 2) | Number.URShift(byte2, 6);
                long byte3 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte2 & 63) << 3) | Number.URShift(byte3, 5);
                long byte4 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte3 & 31) << 4) | Number.URShift(byte4, 4);
                long byte5 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte4 & 15) << 5) | Number.URShift(byte5, 3);
                long byte6 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte5 & 7) << 6) | Number.URShift(byte6, 2);
                long byte7 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte6 & 3) << 7) | Number.URShift(byte7, 1);
                long byte8 = blocks[blocksOffset++] & 0xFF;
                values[valuesOffset++] = ((byte7 & 1) << 8) | byte8;
            }
        }

    }

}