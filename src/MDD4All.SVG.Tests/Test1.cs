/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels;

namespace MDD4All.SVG.Tests
{
    class Test1
    {
        public Test1()
        {
            ScalableVectorGraphics svg = new ScalableVectorGraphics();

            Group group = new Group();

            Group childGroup = new Group();

            for (int count = 0; count < 5; count++)
            {
                Rectangle rectangle = new Rectangle()
                {
                    X = "" + (100 * count),
                    Y = "10",
                    Width = "90",
                    Height = "80",
                    Fill = "white",
                    Stroke = "black",
                    StrokeWidth = "2"
                };

                childGroup.Rectangles.Add(rectangle);
            }

            group.Groups.Add(childGroup);

            svg.Groups.Add(group);

            svg.SaveToFile(@"c:\test\svg\test1.svg");
        }
    }
}
