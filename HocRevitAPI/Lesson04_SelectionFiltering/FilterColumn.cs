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
            int elem_CategoryId = elem.Category.Id.IntegerValue;
            int categoryId = (int)BuiltInCategory.OST_StructuralColumns;
            if (elem_CategoryId == categoryId)
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
