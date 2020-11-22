/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */

using MDD4All.SVG.DataModels;
using NLog;
#if EA_FACADE
using EAAPI = MDD4All.EAFacade.DataModels.Contracts;
using EAC = MDD4All.EnterpriseArchitect.CachedDataProvider;
using MDD4All.EAFacade.SvgGenerator;
#else
using EAAPI = EA;
using MDD4All.EnterpriseArchitect.SvgGenerator;
using EAC = EA;
#endif

namespace MDD4All.SVG.Tests
{
    public class Test2
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Test2()
        {
#if EA_FACADE
            EAC.EaCachedRepository repository = new EAC.EaCachedRepository();
#else
            EAAPI.Repository repository = new EAAPI.Repository();
#endif

            //bool openResult = repository.OpenFile(@"C:\Users\olli\Documents\EA\SVGTest.EAP");

            bool openResult = repository.OpenFile(@"D:\work\github\fmc4se\Models\FMC4EA.EAP");



            if (openResult)
            {
                logger.Debug("Modell offen");

                EAAPI.Diagram diagram = repository.GetDiagramByID(20);

                DiagramToSvgConverter converter = new DiagramToSvgConverter(repository);

                ScalableVectorGraphics svg = converter.ConvertDiagramToSVG(diagram);

                svg.SaveToFile(@"d:\test\svg\test3.svg");



                repository.Exit();

                logger.Info("Fertig");
            }


        }
    }
}
