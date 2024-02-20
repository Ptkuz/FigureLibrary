using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTests
{
    public abstract class FigureTests
    {

        [Fact]
        public abstract void EqualsValues();

        [Fact]
        public abstract void CheckIncorrectArguments();

    }
}
