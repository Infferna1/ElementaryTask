using System;
using Xunit;

namespace SortingTriangles.Test
{
    public class SortingTrianglesTests
    {
        [Fact]
        public void TriangleExists_ASideBiggerThanOtherSides_Exception()
        {
            double ASide = 50;
            double BSide = 5.5;
            double CSide = 5.2;
            SortingTriangles sortingTriangles = new SortingTriangles(ASide, BSide, CSide);
            var ex = Assert.Throws<Exception> (() => sortingTriangles.TriangleExist());
        }


    }
}
