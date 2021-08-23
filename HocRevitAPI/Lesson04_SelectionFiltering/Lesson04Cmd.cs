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
            //List<Element> allCot = new List<Element>();

            //foreach (ElementId zzzzz in ids)
            //{
            //    Element e = doc.GetElement(zzzzz);

            //    // Cách 1 để lọc đối tượng: Dùng Category Name
            //    string categoryName = e.Category.Name;

            //    if (categoryName.Equals("Structural Columns"))
            //    {
            //        allCot.Add(e);
            //        Parameter p = e.get_Parameter(BuiltInParameter.HOST_VOLUME_COMPUTED);
            //        tong = tong + p.AsDouble();
            //    }

            //    // Cách 2 để lọc đối tượng: Dùng CategoryId
            //    int categoryId = e.Category.Id.IntegerValue;
            //    int structuralColumnId = (int)BuiltInCategory.OST_StructuralColumns;

            //    if (categoryId == structuralColumnId)
            //    {
            //        allCot.Add(e);
            //    }
            //}

            //tong = UnitUtils.ConvertFromInternalUnits(tong, UnitTypeId.CubicMeters);
            //MessageBox.Show(Math.Round(tong, 3).ToString());

            #endregion 1.1: Lấy về các elements đang được chọn trước

            #region 1.2: PickObject

            #region 1.2.1 Pick một đối tượng, dùng bộ lọc

            /* 1. Lọc Element
             * 2. Lọc Face
             */

            //uidoc.Selection.PickObject(ObjectType.Element);
            //uidoc.Selection.PickObject(ObjectType.Element, "Hay chon Dam");

            //Reference r = uidoc.Selection.PickObject(ObjectType.Face);

            //FilterColumn loc1 = new FilterColumn();
            //Reference r_Column = uidoc.Selection.PickObject(ObjectType.Element, loc1, "Chọn Cột");

            //FilterColumn locCot = new FilterColumn();
            //Reference r_FaceColumn = uidoc.Selection.PickObject(ObjectType.Face, locCot, "Hay chon Face cot");

            //FilterCylindricalFace locFaceCylindrical = new FilterCylindricalFace(doc);
            //Reference r_FaceCylindrical = uidoc.Selection.PickObject(ObjectType.Face, locFaceCylindrical, "Hay chon Face Cylindrical");

            //Element e_Col = doc.GetElement(r_FaceColumn);
            //GeometryObject geometryObject = e_Col.GetGeometryObjectFromReference(r_FaceColumn);
            //Face face = geometryObject as Face;

            //if (face != null)
            //{
            //    double dienTich = UnitUtils.ConvertFromInternalUnits(face.Area, UnitTypeId.SquareMeters);
            //    MessageBox.Show(dienTich.ToString());
            //}

            #endregion 1.2.1 Pick một đối tượng, dùng bộ lọc

            #region 1.2.2 Pick nhiều đối tượng

            //IList<Reference> references = uidoc.Selection.PickObjects(ObjectType.Element);
            //foreach (Reference reference in references)
            //{
            //    //Xử lý các đối tượng vừa được chọn
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
