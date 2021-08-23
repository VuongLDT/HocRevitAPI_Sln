using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace Lesson04_SelectionFiltering
{
    class FilterColumn : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            int categoryID = elem.Category.Id.IntegerValue;
            int structureColumnId = (int)BuiltInCategory.OST_StructuralColumns;
            if (categoryID == structureColumnId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return true;
        }
    }
}
