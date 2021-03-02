#if EA_FACADE
using EAAPI = MDD4All.EAFacade.DataModels.Contracts;
#else
using MDD4All.SpecIF.DataModels.DiagramInterchange;
using MDD4All.SVG.DataModels;
using EAAPI = EA;
#endif

#if EA_FACADE
namespace MDD4All.EAFacade.SvgGenerator.Contracts
#else
namespace MDD4All.EnterpriseArchitect.SvgGenerator.Contracts
#endif
{
    public interface IMetaDataCreator
    {
        Shape CreateMetaDataForDiagram(EAAPI.Diagram diagram, int height, int width);

        Shape CreateMetaDataForDiagramObject(EAAPI.DiagramObject diagramObject,
                                              EAAPI.Element element);

        Edge CreateMetaDataForDiagramLink(EAAPI.DiagramLink diagramLink,
                                            EAAPI.Connector connector,
                                            EAAPI.DiagramObject sourceDiagramObject,
                                            EAAPI.DiagramObject targetDiagramObject,
                                            EAAPI.Element sourceElement,
                                            EAAPI.Element targetElement);
    }
}
