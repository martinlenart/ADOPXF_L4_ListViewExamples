using System;
using System.Collections.Generic;
using System.Linq;

namespace ListViewExamples.Models
{
    public enum RectColor
    {
        red, blue, yellow, white, pink, orange, green
    }
    public class Rectangle : IEquatable<Rectangle>
    {
        public RectColor Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area => Height * Width;
        public bool Equals(Rectangle other) => (Height, Width, Color) == (other.Height, other.Width, other.Color);
        public override int GetHashCode() => (Width, Height, Color).GetHashCode();  //Needed to implement as part of IEquatable
        public override bool Equals(object obj) => Equals(obj as Rectangle); //Needed to implement as part of IEquatable
        public override string ToString() => $"Color: {Color}  Height: {Height}  Width: {Width}  Area: {Area}";
    }
    class RectangleModel
    {
        List<Rectangle> originalList = new List<Rectangle>() {
                new Rectangle() { Color = RectColor.yellow, Height = 100, Width = 100 },
                new Rectangle() { Color = RectColor.white, Height = 15, Width = 200 },
                new Rectangle() { Color = RectColor.red, Height = 10, Width = 20 },
                new Rectangle() { Color = RectColor.pink, Height = 45, Width =15 },
                new Rectangle() { Color = RectColor.red, Height = 55, Width = 95 },
                new Rectangle() { Color = RectColor.pink, Height = 75, Width = 150 },
                new Rectangle() { Color = RectColor.orange, Height = 75, Width = 40 },
                new Rectangle() { Color = RectColor.green, Height = 30, Width = 15 },
                new Rectangle() { Color = RectColor.orange, Height = 45, Width =15 },
                new Rectangle() { Color = RectColor.red, Height = 10, Width = 20 }};
        public List<Rectangle> Rectangles => originalList;
    }
}
