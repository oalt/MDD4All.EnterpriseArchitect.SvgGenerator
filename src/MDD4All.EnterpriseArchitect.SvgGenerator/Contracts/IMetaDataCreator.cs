#if EA_FACADE
using EAAPI = MDD4All.EAFacade.DataModels.Contracts;
#else
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
        object CreateMetaDataForDiagram(EAAPI.Diagram diagram, int height, int width);

        object CreateMetaDataForDiagramObject(EAAPI.DiagramObject diagramObject,
                                              EAAPI.Element element);

        object CreateMetaDataForDiagramLink(EAAPI.DiagramLink diagramLink,
                                            EAAPI.Connector connector,
                                            EAAPI.Element sourceElement,
                                            EAAPI.Element targetElement);
    }
}
