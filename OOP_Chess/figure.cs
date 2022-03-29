using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Chess
{
    public class Figure
    {
        public FigureType Type { get; set; }
        public int MyProperty { get; set; }
        public Figure()
    {

    }
    }
//výčtový datový typ - seznam hodnot - interně jsou to hodnoty integer (od 0)
    public enum FigureType
    {
        Pawn,  //pěšec
        Rook,  //věž
        Knight,//jezdec
        Bishop,//střelec
        Qeen,  //dáma
        King,  //král

    }
}
