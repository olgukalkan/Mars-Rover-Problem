using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem.ILibrary
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string ToString();
        void TurnLeft();
        void TurnRight();
        void Move();
    }

    public enum Directions
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }
}
