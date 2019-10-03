/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using log4net;
using MDD4All.EnterpriseArchitect.SvgGenerator;
using MDD4All.SVG.DataModels;

namespace MDD4All.SVG.Tests
{
    public class Test2
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Test2));

        public Test2()
        {
            EA.Repository repository = new EA.Repository();

            //bool openResult = repository.OpenFile(@"C:\Users\olli\Documents\EA\SVGTest.EAP");

            bool openResult = repository.OpenFile(@"C:\Users\olli\Documents\EA\FMC4EA.EAP");



            if (openResult)
            {
                logger.Debug("Modell offen");

                EA.Diagram diagram = repository.GetDiagramByID(20);

                DiagramToSvgConverter converter = new DiagramToSvgConverter(repository);

                ScalableVectorGraphics svg = converter.ConvertDiagramToSVG(diagram);

                svg.SaveToFile(@"c:\test\svg\test3.svg");



                repository.Exit();

                logger.Info("Fertig");
            }


        }
    }
}
