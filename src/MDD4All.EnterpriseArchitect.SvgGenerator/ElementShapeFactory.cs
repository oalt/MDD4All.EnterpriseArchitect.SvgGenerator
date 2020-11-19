using MDD4All.EnterpriseArchitect.SvgGenerator.DataModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using EAAPI = EA;
using MDD4All.EnterpriseArchitect.Manipulations;

namespace MDD4All.EnterpriseArchitect.SvgGenerator
{
    public class ElementShapeFactory
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static ElementShape GetElementShape(EAAPI.Element element, EAAPI.Repository repository)
        {

            string type = element.Type;
            string stereotype = element.Stereotype;

            ElementShape result = _elementShapes.Find(shape => shape.Type == type && shape.Stereotype == stereotype);

            if (result == null)
            {
                logger.Debug("Not found " + type + " " + stereotype);

                result = _defaultShape;
                result.Type = type;
                result.Stereotype = stereotype;
                result.MainLabel = "[" + type + "] " + element.Name;
                result.MainLabelFontWeight = "normal";
            }
            else
            {
                SetMainLabel(element, repository, ref result);
            }

            return result;
        }

        private static void SetMainLabel(EAAPI.Element element, EAAPI.Repository repository, ref ElementShape shape)
        {
            string classifierName = element.GetClassifierName(repository);

            string name = element.Name;

            string nameTextToShow = "";

            if (!string.IsNullOrEmpty(classifierName))
            {
                nameTextToShow = ": " + classifierName;
            }
            if (name != "")
            {
                nameTextToShow = name + nameTextToShow;
            }

            shape.MainLabel = nameTextToShow;

            // special cases:

            string type = element.Type;
            string stereotype = element.Stereotype;

            if (stereotype == "agent" || 
                stereotype == "storage" ||
                stereotype == "human agent")
            {
                nameTextToShow = classifierName;
                if (name != "")
                {
                    nameTextToShow = name + ": " + classifierName;
                }

                shape.MainLabel = nameTextToShow;
            }

            

        }


        private static List<ElementShape> _elementShapes = new List<ElementShape>
        {
            new ElementShape
            {
                Type = "Class"
                
            },
            new ElementShape
            {
                Type = "Object",
                Stereotype = "agent",
                BorderWidth = 2
            },
            new ElementShape
            {
                Type = "Object",
                Stereotype = "storage",
                CornerRadius = 20,
                BorderWidth = 2,
                MainLabelVerticalPosition = "center"
            },
            new ElementShape
            {
                Type = "Activity",
                CornerRadius = 20,
                FillColor = "#FFFF00"
            },
            new ElementShape
            {
                Type = "Port"
            },
            new ElementShape
            {
                Type = "Port",
                Stereotype = "channel",
                MainShape = "Circle",
                BorderWidth = 2,
                MainLabelFontWeight = "normal"
            },
            new ElementShape
            {
                Type = "State",
                CornerRadius = 20
            },
            new ElementShape
            {
                Type = "UseCase",
                MainShape = "Ellipse",
                MainLabelVerticalPosition = "center"
            }



        };

        private static ElementShape _defaultShape = new ElementShape
        {
            FillColor = "#FFC1C1",
            StrokeDashArray = "20 5 5 5 5 5 5 5"
        };

    }
}
