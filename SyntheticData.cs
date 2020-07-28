﻿using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SynthticData
    {
        public List<Shirt> Shirts { get; set; } = new List<Shirt>();
        public SynthticData()
        {
            Shirt s1 = new Shirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            Shirt s2 = new Shirt(Color.BLUE, Size.M, Fabric.COTTON);
            Shirt s3 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s4 = new Shirt(Color.ORANGE, Size.M, Fabric.SILK);
            Shirt s5 = new Shirt(Color.GREEN, Size.XS, Fabric.WOOL);
            Shirt s6 = new Shirt(Color.VIOLET, Size.M, Fabric.CASHMERE);
            Shirt s7 = new Shirt(Color.GREEN, Size.L, Fabric.COTTON);
            Shirt s8 = new Shirt(Color.BLUE, Size.S, Fabric.LINEN);
            Shirt s9 = new Shirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            Shirt s10 = new Shirt(Color.RED, Size.L, Fabric.WOOL);
            Shirt s11 = new Shirt(Color.RED, Size.M, Fabric.RAYON);
            Shirt s12 = new Shirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            Shirt s13 = new Shirt(Color.INDIGO, Size.L, Fabric.COTTON);
            Shirt s14 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s15 = new Shirt(Color.ORANGE, Size.S, Fabric.SILK);
            Shirt s16 = new Shirt(Color.VIOLET, Size.M, Fabric.CASHMERE);
            Shirt s17 = new Shirt(Color.RED, Size.XS, Fabric.LINEN);
            Shirt s18 = new Shirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            Shirt s19 = new Shirt(Color.RED, Size.L, Fabric.POLYESTER);
            Shirt s20 = new Shirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            Shirt s21 = new Shirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            Shirt s22 = new Shirt(Color.INDIGO, Size.M, Fabric.COTTON);
            Shirt s23 = new Shirt(Color.RED, Size.S, Fabric.RAYON);
            Shirt s24 = new Shirt(Color.VIOLET, Size.M, Fabric.POLYESTER);
            Shirt s25 = new Shirt(Color.GREEN, Size.XS, Fabric.COTTON);
            Shirt s26 = new Shirt(Color.YELLOW, Size.M, Fabric.CASHMERE);
            Shirt s27 = new Shirt(Color.GREEN, Size.L, Fabric.COTTON);
            Shirt s28 = new Shirt(Color.BLUE, Size.S, Fabric.LINEN);
            Shirt s29 = new Shirt(Color.YELLOW, Size.M, Fabric.CASHMERE);
            Shirt s30 = new Shirt(Color.ORANGE, Size.L, Fabric.SILK);
            Shirt s31 = new Shirt(Color.RED, Size.M, Fabric.RAYON);
            Shirt s32 = new Shirt(Color.BLUE, Size.L, Fabric.RAYON);
            Shirt s33 = new Shirt(Color.INDIGO, Size.L, Fabric.COTTON);
            Shirt s34 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s35 = new Shirt(Color.VIOLET, Size.S, Fabric.COTTON);
            Shirt s36 = new Shirt(Color.BLUE, Size.M, Fabric.SILK);
            Shirt s37 = new Shirt(Color.YELLOW, Size.XS, Fabric.LINEN);
            Shirt s38 = new Shirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            Shirt s39 = new Shirt(Color.RED, Size.L, Fabric.POLYESTER);
            Shirt s40 = new Shirt(Color.BLUE, Size.L, Fabric.WOOL);
            Shirt s41 = new Shirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            Shirt s42 = new Shirt(Color.BLUE, Size.M, Fabric.COTTON);
            Shirt s43 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s44 = new Shirt(Color.ORANGE, Size.M, Fabric.SILK);
            Shirt s45 = new Shirt(Color.GREEN, Size.XS, Fabric.WOOL);
            Shirt s46 = new Shirt(Color.VIOLET, Size.M, Fabric.CASHMERE);
            Shirt s47 = new Shirt(Color.GREEN, Size.L, Fabric.COTTON);
            Shirt s48 = new Shirt(Color.BLUE, Size.S, Fabric.LINEN);
            Shirt s49 = new Shirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            Shirt s50 = new Shirt(Color.RED, Size.L, Fabric.WOOL);
            Shirt s51 = new Shirt(Color.RED, Size.M, Fabric.RAYON);
            Shirt s52 = new Shirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            Shirt s53 = new Shirt(Color.INDIGO, Size.L, Fabric.COTTON);
            Shirt s54 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s55 = new Shirt(Color.ORANGE, Size.S, Fabric.SILK);
            Shirt s56 = new Shirt(Color.VIOLET, Size.M, Fabric.CASHMERE);
            Shirt s57 = new Shirt(Color.RED, Size.XS, Fabric.LINEN);
            Shirt s58 = new Shirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            Shirt s59 = new Shirt(Color.RED, Size.L, Fabric.POLYESTER);
            Shirt s60 = new Shirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            Shirt s61 = new Shirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            Shirt s62 = new Shirt(Color.INDIGO, Size.M, Fabric.COTTON);
            Shirt s63 = new Shirt(Color.RED, Size.S, Fabric.RAYON);
            Shirt s64 = new Shirt(Color.VIOLET, Size.M, Fabric.POLYESTER);
            Shirt s65 = new Shirt(Color.GREEN, Size.XS, Fabric.COTTON);
            Shirt s66 = new Shirt(Color.YELLOW, Size.M, Fabric.CASHMERE);
            Shirt s67 = new Shirt(Color.GREEN, Size.L, Fabric.COTTON);
            Shirt s68 = new Shirt(Color.BLUE, Size.S, Fabric.LINEN);
            Shirt s69 = new Shirt(Color.YELLOW, Size.M, Fabric.CASHMERE);
            Shirt s70 = new Shirt(Color.ORANGE, Size.L, Fabric.SILK);
            Shirt s71 = new Shirt(Color.RED, Size.M, Fabric.RAYON);
            Shirt s72 = new Shirt(Color.BLUE, Size.L, Fabric.RAYON);
            Shirt s73 = new Shirt(Color.INDIGO, Size.L, Fabric.COTTON);
            Shirt s74 = new Shirt(Color.RED, Size.S, Fabric.LINEN);
            Shirt s75 = new Shirt(Color.VIOLET, Size.S, Fabric.COTTON);
            Shirt s76 = new Shirt(Color.BLUE, Size.M, Fabric.SILK);
            Shirt s77 = new Shirt(Color.YELLOW, Size.XS, Fabric.LINEN);
            Shirt s78 = new Shirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            Shirt s79 = new Shirt(Color.RED, Size.L, Fabric.POLYESTER);
            Shirt s80 = new Shirt(Color.BLUE, Size.L, Fabric.WOOL);

            Shirts.Add(s1);
            Shirts.Add(s2);
            Shirts.Add(s3);
            Shirts.Add(s4);
            Shirts.Add(s5);
            Shirts.Add(s6);
            Shirts.Add(s7);
            Shirts.Add(s8);
            Shirts.Add(s9);
            Shirts.Add(s10);
            Shirts.Add(s11);
            Shirts.Add(s12);
            Shirts.Add(s13);
            Shirts.Add(s14);
            Shirts.Add(s15);
            Shirts.Add(s16);
            Shirts.Add(s17);
            Shirts.Add(s18);
            Shirts.Add(s19);
            Shirts.Add(s20);
            Shirts.Add(s21);
            Shirts.Add(s22);
            Shirts.Add(s23);
            Shirts.Add(s24);
            Shirts.Add(s25);
            Shirts.Add(s26);
            Shirts.Add(s27);
            Shirts.Add(s28);
            Shirts.Add(s29);
            Shirts.Add(s30);
            Shirts.Add(s31);
            Shirts.Add(s32);
            Shirts.Add(s33);
            Shirts.Add(s34);
            Shirts.Add(s35);
            Shirts.Add(s36);
            Shirts.Add(s37);
            Shirts.Add(s38);
            Shirts.Add(s39);
            Shirts.Add(s40);
            Shirts.Add(s41);
            Shirts.Add(s42);
            Shirts.Add(s43);
            Shirts.Add(s44);
            Shirts.Add(s45);
            Shirts.Add(s46);
            Shirts.Add(s47);
            Shirts.Add(s48);
            Shirts.Add(s49);
            Shirts.Add(s50);
            Shirts.Add(s51);
            Shirts.Add(s52);
            Shirts.Add(s53);
            Shirts.Add(s54);
            Shirts.Add(s55);
            Shirts.Add(s56);
            Shirts.Add(s57);
            Shirts.Add(s58);
            Shirts.Add(s59);
            Shirts.Add(s60);
            Shirts.Add(s61);
            Shirts.Add(s62);
            Shirts.Add(s63);
            Shirts.Add(s64);
            Shirts.Add(s65);
            Shirts.Add(s66);
            Shirts.Add(s67);
            Shirts.Add(s68);
            Shirts.Add(s69);
            Shirts.Add(s70);
            Shirts.Add(s71);
            Shirts.Add(s72);
            Shirts.Add(s73);
            Shirts.Add(s74);
            Shirts.Add(s75);
            Shirts.Add(s76);
            Shirts.Add(s77);
            Shirts.Add(s78);
            Shirts.Add(s79);
            Shirts.Add(s80);
        }
    }
}
