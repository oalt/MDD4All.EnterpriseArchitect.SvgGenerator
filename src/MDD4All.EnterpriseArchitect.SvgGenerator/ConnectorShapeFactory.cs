using MDD4All.EnterpriseArchitect.SvgGenerator.DataModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using EAAPI = EA;

namespace MDD4All.EnterpriseArchitect.SvgGenerator
{
    public class ConnectorShapeFactory
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static ConnectorShape GetElementShape(EAAPI.Connector connector, EAAPI.Repository repository)
        {
            string type = connector.Type;
            string stereotype = connector.Stereotype;

            ConnectorShape result = _connectorShapes.Find(shape => shape.Type == type && shape.Stereotype == stereotype);

            if (result == null)
            {
                logger.Debug("Not found " + type + " " + stereotype);

                result = _defaultShape;
                result.Type = type;
                result.Stereotype = stereotype;

            }


            return result;
        }

        private static List<ConnectorShape> _connectorShapes = new List<ConnectorShape>
        {
            new ConnectorShape
            {
                Type = "Dependency",
                StrokeDashArray = "8 4"
            },
            new ConnectorShape
            {
                Type = "Connector",
                Stereotype = "access type"
            },
            new ConnectorShape
            {
                Type = "Association"
            }
        };

        private static ConnectorShape _defaultShape = new ConnectorShape
        {
            Color = "#FFC1C1",
            StrokeDashArray = "20 5 5 5 5 5 5 5"
        };
    }
}
