/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.EnterpriseArchitect.SvgGenerator;
using MDD4All.SVG.DataModels;
using NLog;

namespace MDD4All.SVG.Tests
{
    public class Test2
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Test2()
        {
            EA.Repository repository = new EA.Repository();

            //bool openResult = repository.OpenFile(@"C:\Users\olli\Documents\EA\SVGTest.EAP");

            bool openResult = repository.OpenFile(@"D:\work\github\fmc4se\Models\FMC4EA.EAP");



            if (openResult)
            {
                logger.Debug("Modell offen");

                EA.Diagram diagram = repository.GetDiagramByID(20);

                DiagramToSvgConverter converter = new DiagramToSvgConverter(repository);

                ScalableVectorGraphics svg = converter.ConvertDiagramToSVG(diagram);

                svg.SaveToFile(@"d:\test\svg\test3.svg");



                repository.Exit();

                logger.Info("Fertig");
            }


        }
    }
}
