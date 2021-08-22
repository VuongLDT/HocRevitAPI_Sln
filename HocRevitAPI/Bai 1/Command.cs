#region Namespaces

using Autodesk.Revit;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace HocRevitAPI
{
    // Chỉ định từng phân đoạn cho Revit biết khi nào can thiệp, khi nào kết thúc để qua phân đoạn khác.
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    // IExternalCommand: Chứa các thủ tục để code liên kết với các thủ tục, đối tượng và tài nguyên trong Revit.
    public class Command : IExternalCommand
    {
        // Thủ tục kết nối lệnh, chứa các đối số mặc định, thông qua đó Revit gửi cho ta những dữ liệu,
        // tài nguyên của file Revit hay chương trình đang mở.
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData,
            ref string message, Autodesk.Revit.DB.ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Code here - testing update 2xx
            ICollection<ElementId> elementIds = uidoc.Selection.GetElementIds();

            return Autodesk.Revit.UI.Result.Succeeded;  // Trả về kết quả thành công.
        }
    }
}
