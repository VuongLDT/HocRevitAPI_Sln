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
using Lesson04_SelectionFiltering;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace HocRevitAPI
{
    // Chỉ định từng phân đoạn cho Revit biết khi nào can thiệp, khi nào kết thúc để qua phân đoạn khác.
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    // IExternalCommand: Chứa các thủ tục để code liên kết với các thủ tục, đối tượng và tài nguyên trong Revit.
    public class Lesson04_SelectionFiltering : IExternalCommand
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

            // Code here

            #region A: Dùng class Selection

            #region 1.1: Lấy về các elements đang được chọn trước

            //ICollection<ElementId> ids = uidoc.Selection.GetElementIds();
            //double tong = 0;
            //List<Element> allColumn = new List<Element>();

            //foreach (ElementId zzzzz in ids)
            //{
            //    Element e = doc.GetElement(zzzzz);

            //    // Cách 1 để lọc đối tượng: Dùng Category Name
            //    string categoryName = e.Category.Name;

            //    if (categoryName.Equals("Structural Columns"))
            //    {
            //        allColumn.Add(e);
            //        Parameter p = e.get_Parameter(BuiltInParameter.HOST_VOLUME_COMPUTED);
            //        tong = tong + p.AsDouble();
            //    }

            //    // Cách 2 để lọc đối tượng: Dùng CategoryId
            //    int categoryId = e.Category.Id.IntegerValue;
            //    int structuralColumnId = (int)BuiltInCategory.OST_StructuralColumns;

            //    if (categoryId == structuralColumnId)
            //    {
            //        allColumn.Add(e);
            //    }
            //}

            //tong = UnitUtils.ConvertFromInternalUnits(tong, UnitTypeId.CubicMeters);
            //MessageBox.Show(Math.Round(tong, 3).ToString());

            #endregion 1.1: Lấy về các elements đang được chọn trước

            #region 1.2: PickObject

            #region 1.2.1 Pick một đối tượng, dùng bộ lọc

            ///* 1. Lọc Element
            // * 2. Lọc Face
            // */

            //// Pick chọn 1 đối tượng bất kì
            //Reference r1 = uidoc.Selection.PickObject(ObjectType.Element);
            //Reference r2 = uidoc.Selection.PickObject(ObjectType.Element, "Please Select Element");

            //// Pick chọn 1 face bất kì
            //Reference r_Face = uidoc.Selection.PickObject(ObjectType.Face);

            //// Chỉ chọn 1 cột
            //FilterColumn filterColumn = new FilterColumn();
            //Reference r_Column = uidoc.Selection.PickObject(ObjectType.Element, filterColumn, "Please Select Column");

            //Element elem_Column = doc.GetElement(r_Column);
            //ElementId elemId_Column = r_Column.ElementId;

            ////----------------------------------------------------
            //// Chỉ chọn 1 mặt cột
            //FilterColumn filterColumnFace = new FilterColumn();
            //Reference r_FaceColumn = uidoc.Selection.PickObject(ObjectType.Face, filterColumnFace, "Please Select Column Face");

            //Element elem_containFace = doc.GetElement(r_FaceColumn);
            //GeometryObject geometryObject = elem_containFace.GetGeometryObjectFromReference(r_FaceColumn);
            //Face face = geometryObject as Face;

            //if (face != null)
            //{
            //    //double area = face.Area;
            //    double area = UnitUtils.ConvertFromInternalUnits(face.Area, UnitTypeId.SquareMeters);
            //    MessageBox.Show(area.ToString());
            //}

            //// Chỉ chọn 1 mặt cong loại CylindricalFace
            //FilterCylindricalFace filterFaceCylindrical = new FilterCylindricalFace(doc);
            //Reference r_FaceCylindrical = uidoc.Selection.PickObject(ObjectType.Face, filterFaceCylindrical, "Please Select Cylindrical Face");

            #endregion 1.2.1 Pick một đối tượng, dùng bộ lọc

            #region 1.2.2 Pick nhiều đối tượng

            //IList<Reference> references = uidoc.Selection.PickObjects(ObjectType.Element);
            //List<Element> elems = new List<Element>();
            //List<ElementId> elemIds = new List<ElementId>();
            //foreach (Reference r in references)
            //{
            //    elems.Add(doc.GetElement((r)));
            //    elemIds.Add(r.ElementId);
            //}

            #endregion 1.2.2 Pick nhiều đối tượng

            #endregion 1.2: PickObject
            #endregion A: Dùng class Selection



            #region B: Dùng class FilteredElementCollector



            #endregion B: Dùng class FilteredElementCollector



            return Autodesk.Revit.UI.Result.Succeeded;  // Trả về kết quả thành công.xyz
        }
    }

}
