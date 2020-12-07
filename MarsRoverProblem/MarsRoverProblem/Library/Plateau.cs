using MarsRoverProblem.ILibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem.Library
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
