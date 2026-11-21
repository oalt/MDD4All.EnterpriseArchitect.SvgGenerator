/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
#if EA_FACADE
using MDD4All.SpecIF.DataModels.DiagramInterchange;
using EAAPI = MDD4All.EAFacade.DataModels.Contracts;
#else
using MDD4All.SpecIF.DataModels.DiagramInterchange;
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
        SpecIfMetadata CreateMetaDataForDiagram(EAAPI.Diagram diagram, int height, int width);

        SpecIfMetadata CreateMetaDataForDiagramObject(EAAPI.DiagramObject diagramObject,
                                                      EAAPI.Element element);

        SpecIfMetadata CreateMetaDataForDiagramLink(EAAPI.DiagramLink diagramLink,
                                                    EAAPI.Connector connector,
                                                    EAAPI.DiagramObject sourceDiagramObject,
                                                    EAAPI.DiagramObject targetDiagramObject,
                                                    EAAPI.Element sourceElement,
                                                    EAAPI.Element targetElement);
    }
}
