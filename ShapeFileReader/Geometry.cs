﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class Geometry
    {
        private List<int> parts = new List<int> ();
        private List<Point> points = new List<Point> ();
        private int id;
        private int geometryType;

        public List<int> Parts
        {
            get { return parts; }

            set { parts = value; }
        }

        public List<Point> Points
        {
            get { return points; }

            set { points = value; }
        }

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public int GeometryType
        {
            get { return geometryType; }

            set { geometryType = value; }
        }

        public Geometry() { }

        public Geometry(List<Point> points)
        {
            this.points = points;
        }

        public Geometry(List<int> parts, List<Point> points)
        {
            this.parts = parts;
            this.points = points;
        }

        public void GetArea()
        { }

        public void GerPerimeter()
        { }
    }
}
