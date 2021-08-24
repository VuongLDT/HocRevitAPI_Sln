using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace Lesson04_SelectionFiltering
{
    class FilterCylindricalFace : ISelectionFilter
    {
        private Document pdoc;
        public FilterCylindricalFace(Document doc)
        {
            pdoc = doc;
        }
        public bool AllowElement(Element elem)
        {
            return true;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            Element elem = pdoc.GetElement(reference);
            GeometryObject geometryObject = elem.GetGeometryObjectFromReference(reference);
            Face face = geometryObject as Face;
            if (face is CylindricalFace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
