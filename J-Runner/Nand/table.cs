﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JRunner.Nand
{
    class ntable
    {
        public struct _nand
        {
            private readonly int cb;
            public int CB { get { return cb; } }

            private readonly string mobo;
            public string MotherBoard { get { return mobo; } }

            private readonly int minDash;
            public int minDashVersion { get { return minDash; } }

            private readonly int maxDash;
            public int maxDashVersion { get { return maxDash; } }

            private readonly int minCseq;
            public int minCsequence { get { return minCseq; } }

            private readonly int maxCseq;
            public int maxCsequence { get { return maxCseq; } }

            private readonly Classes.xebuild.hacktypes hack;
            public Classes.xebuild.hacktypes preferredHackType { get { return hack; } }

            private readonly consoles console;
            public consoles Cunt { get { return console; } }

            public _nand(int cb, string mobo, int mindash, int maxdash, int mincseq, int maxcseq, Classes.xebuild.hacktypes ht, consoles cunt)
            {
                this.cb = cb;
                this.mobo = mobo;
                this.minDash = mindash;
                this.maxDash = maxdash;
                this.minCseq = mincseq;
                this.maxCseq = maxcseq;
                this.hack = ht;
                this.console = cunt;
            }
        }

        static int latestDash = 17489;
        #region table
        public static _nand[] Table = new _nand[]
        {
            new _nand(1888, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(1902, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(1903, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(1920, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(1921, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(8192, "Xenon", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[8]),
            new _nand(4558, "Zephyr", 4532, 7371, 1, 4, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(4540, "Zephyr", 4532, 7371, 1, 4, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(4570, "Zephyr", 4532, 7371, 1, 4, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(4580, "Zephyr", 4532, 7371, 1, 4, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(5760, "Falcon/Opus", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[2]),
            new _nand(5761, "Falcon/Opus", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[2]),
            new _nand(5766, "Falcon/Opus", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[2]),
            new _nand(5770, "Falcon/Opus", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[2]),
            new _nand(6712, "Jasper", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[4]),
            new _nand(6723, "Jasper", 4532, 7371, 1, 5, Classes.xebuild.hacktypes.jtag, variables.cunts[4]),
            new _nand(1922, "Xenon", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[8]),
            new _nand(1923, "Xenon", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[8]),
            new _nand(1940, "Xenon", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[8]),
            new _nand(7373, "Xenon", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[8]),
            new _nand(7375, "Xenon", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[8]),
            new _nand(4571, "Zephyr", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[3]),
            new _nand(4572, "Zephyr", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[3]),
            new _nand(4578, "Zephyr", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[3]),
            new _nand(4579, "Zephyr", 8498, 14699, 6, 6, Classes.xebuild.hacktypes.glitch, variables.cunts[3]),
            new _nand(5771, "Falcon/Opus", 8498, 14699, 7, 7, Classes.xebuild.hacktypes.glitch, variables.cunts[2]),
            new _nand(6750, "Jasper", 8498, 14699, 7, 7, Classes.xebuild.hacktypes.glitch, variables.cunts[4]),
            new _nand(6751, "Jasper", 8498, 14699, 7, 7, Classes.xebuild.hacktypes.glitch, variables.cunts[4]),
            new _nand(9188, "Trinity", 8498, 14699, 1, 1, Classes.xebuild.hacktypes.glitch2, variables.cunts[1]),
            new _nand(13121, "Corona", 8498, 14699, 1, 1, Classes.xebuild.hacktypes.glitch2, variables.cunts[10]),
            new _nand(1941, "Xenon", 14717, 14719, 9, 9, Classes.xebuild.hacktypes.nothing, variables.cunts[8]),
            new _nand(4576, "Zephyr", 14717, 14719, 9, 9, Classes.xebuild.hacktypes.glitch2, variables.cunts[3]),
            new _nand(4577, "Zephyr", 14717, 14719, 9, 9, Classes.xebuild.hacktypes.glitch2, variables.cunts[3]),
            new _nand(5772, "Falcon/Opus", 14717, 14719, 9, 9, Classes.xebuild.hacktypes.glitch2, variables.cunts[2]),
            new _nand(5773, "Falcon/Opus", 14717, 14719, 10, 10, Classes.xebuild.hacktypes.glitch2, variables.cunts[2]),
            new _nand(6752, "Jasper", 14717, 14719, 10, 10, Classes.xebuild.hacktypes.glitch2, variables.cunts[4]),
            new _nand(6753, "Jasper", 14717, 14719, 10, 10, Classes.xebuild.hacktypes.glitch2, variables.cunts[4]),
            new _nand(9230, "Trinity", 14717, 14719, 3, 3, Classes.xebuild.hacktypes.glitch2, variables.cunts[1]),
            new _nand(13180, "Corona", 14717, 14719, 3, 3, Classes.xebuild.hacktypes.glitch2, variables.cunts[10]),
            new _nand(1942, "Xenon", 15572, latestDash, 11, 11, Classes.xebuild.hacktypes.nothing, variables.cunts[8]),
            new _nand(4569, "Zephyr", 15572, latestDash, 11, 11, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(4574, "Zephyr", 15572, latestDash, 11, 11, Classes.xebuild.hacktypes.jtag, variables.cunts[3]),
            new _nand(5774, "Falcon/Opus", 15572, latestDash, 12, 12, Classes.xebuild.hacktypes.jtag, variables.cunts[2]),
            new _nand(6754, "Jasper", 15572, latestDash, 12, 12, Classes.xebuild.hacktypes.jtag, variables.cunts[4]),
            new _nand(9231, "Trinity", 15572, latestDash, 4, 4, Classes.xebuild.hacktypes.glitch2, variables.cunts[1]),
            new _nand(13181, "Corona", 15572, latestDash, 4, 4, Classes.xebuild.hacktypes.glitch2, variables.cunts[10]),
            new _nand(13182, "Corona", 15572, latestDash, 4, 4, Classes.xebuild.hacktypes.glitch2, variables.cunts[10])
        };
        #endregion

        public static Classes.xebuild.hacktypes getHackfromCB(int CB)
        {
            int c = CB;
            if (CB > 4 && CB <= 7) c = 4;
            if (c == 11) c = 10;
            if (c == 9) c = 2;
            foreach (_nand n in Table)
            {
                if (n.CB == c) return n.preferredHackType;
            }
            return Classes.xebuild.hacktypes.nothing;
        }

        public static int getCBFromDash(consoles c, int dash)
        {
            foreach (_nand n in Table)
            {
                if (n.Cunt.ID == c.ID && dash >= n.minDashVersion && dash <= n.maxDashVersion) return n.CB;
            }
            return 0;
        }


    }
}
