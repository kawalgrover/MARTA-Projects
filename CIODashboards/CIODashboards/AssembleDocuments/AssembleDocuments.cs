using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Linq;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using Draw = DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using WP = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Excel = DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using PPT = DocumentFormat.OpenXml.Presentation;
using Dgm = DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.SharePoint.Administration;
using System.Collections;



namespace CIODashboards
{
    [ToolboxItemAttribute(false)]
    public class AssembleDocuments : WebPart
    {
        string libraryName;
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/CIODashboards/AssembleDocuments/AssembleDocumentsUserControl.ascx";

        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties.Contains("ContentAggregatorLibrary"))
            {
                libraryName = webApplication.Properties["ContentAggregatorLibrary"].ToString();
            }

        }

        protected override void CreateChildControls()
        {
            Control control = this.Page.LoadControl(_ascxPath);
            Controls.Add(control);
            base.CreateChildControls();
            Button btnSubmit = new Button();
            btnSubmit.Text = "Assemble Documents";
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            Controls.Add(btnSubmit);
        }

        void btnSubmit_Click(object sender, EventArgs e)
        {
            InitializeWebAppProperties();

            SPFolder folder = SPContext.Current.ListItem.Folder;
            char[] splitter = { '/' };
            string[] folderName = folder.Name.Split(splitter);
            //string filePrefix = @"Stock Analysis Demo/" + folderName[0] + "/" + folderName[0];

            string filePrefix = string.Format(@"{0}/{1}/{2}", libraryName, folderName[0], folderName[0]);

            SPFile template = folder.Files[filePrefix + " - Template.docx"];
            SPFile file;
            byte[] byteArray = template.OpenBinary();

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);

                using (WordprocessingDocument myDoc = WordprocessingDocument.Open(mem, true))
                {
                    MainDocumentPart mainPart = myDoc.MainDocumentPart;

                    foreach (Word.SdtElement sdt in mainPart.Document.Descendants<Word.SdtElement>().ToList())
                    {
                        Word.SdtAlias alias = sdt.Descendants<Word.SdtAlias>().FirstOrDefault();
                        if (alias != null)
                        {
                            string sdtTitle = alias.Val.Value;

                            if (sdtTitle == "Word:Activities")
                            {
                                file = folder.Files[filePrefix + " - " + sdt.InnerText + ".docx"];
                                AddAltChunk(mainPart, sdt, file);
                            }
                            else if (sdtTitle == "Spreadsheet:ProjectsAndMilestones")
                            {
                                file = folder.Files[filePrefix + " - " + sdt.InnerText + ".xlsx"];
                                ImportProjectsAndMilestones(mainPart, sdt, file);
                            }
                            else if (sdtTitle == "Spreadsheet:ProjectsAndOutcomes")
                            {
                                file = folder.Files[filePrefix + " - " + sdt.InnerText + ".xlsx"];
                                ImportProjectsAndMilestones(mainPart, sdt, file);
                            }
                            else if (sdtTitle == "Spreadsheet:KPIs")
                            {
                                file = folder.Files[filePrefix + " - " + sdt.InnerText + ".xlsx"];
                                ImportKPIs(mainPart, sdt, file);
                            }
                        }
                    }
                }



                HttpResponse resp = HttpContext.Current.Response;
                resp.Clear();
                //resp.ClearContent();
                //resp.ClearHeaders();
                resp.AddHeader("Content-Disposition", "attachment; filename=GM Report.docx");
                resp.AddHeader("Content-Length", mem.Length.ToString());
                resp.ContentEncoding = System.Text.Encoding.UTF8;
                resp.OutputStream.Write(mem.ToArray(), 0, (int)mem.Length);
                resp.Flush();
                resp.Close();
                resp.End();

            }
        }

        protected int id = 1;

        void AddAltChunk(MainDocumentPart mainPart, Word.SdtElement sdt, SPFile filename)
        {
            string altChunkId = "AltChunkId" + id;
            id++;
            byte[] byteArray = filename.OpenBinary();

            AlternativeFormatImportPart chunk = mainPart.AddAlternativeFormatImportPart(
            AlternativeFormatImportPartType.WordprocessingML, altChunkId);

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);
                mem.Seek(0, SeekOrigin.Begin);
                chunk.FeedData(mem);
            }

            Word.AltChunk altChunk = new Word.AltChunk();
            altChunk.Id = altChunkId;

            // Replace content control with altChunk information.  
            OpenXmlElement parent = sdt.Parent;
            parent.InsertAfter(altChunk, sdt);
            sdt.Remove();

        }

        void ImportSmartArtFromPowerPoint(MainDocumentPart mainPart, Word.SdtElement sdt, SPFile filename)
        {
            string docLayoutPartId = "";
            string docDataPartId = "";
            string docColorsPartId = "";
            string docStylePartId = "";

            byte[] byteArray = filename.OpenBinary();

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);

                using (PresentationDocument myPres = PresentationDocument.Open(mem, true))
                {
                    PresentationPart presPart = myPres.PresentationPart;
                    // Get the slide that contains the SmartArt graphic. 
                    SlidePart slide = (SlidePart)presPart.GetPartById("rId3");
                    // Get all the appropriate parts associated with the SmartArt. 
                    DiagramLayoutDefinitionPart layoutPart =
                       slide.DiagramLayoutDefinitionParts.First();
                    DiagramDataPart dataPart = slide.DiagramDataParts.First();
                    DiagramColorsPart colorsPart = slide.DiagramColorsParts.First();
                    DiagramStylePart stylePart = slide.DiagramStyleParts.First();

                    // Get some of the appropriate properties off the SmartArt graphic. 
                    PPT.GraphicFrame graphicFrame =
                       slide.Slide.Descendants<PPT.GraphicFrame>().First();
                    PPT.NonVisualDrawingProperties drawingPr = graphicFrame
                       .Descendants<PPT.NonVisualDrawingProperties>().First();
                    Draw.Extents extents =
                       graphicFrame.Descendants<Draw.Extents>().First();

                    // Import SmartArt into the Word document. 
                    // Add the SmartArt parts to the Word document. 
                    DiagramLayoutDefinitionPart docLayoutPart =
                       mainPart.AddPart<DiagramLayoutDefinitionPart>(layoutPart);
                    DiagramDataPart docDataPart =
                       mainPart.AddPart<DiagramDataPart>(dataPart);
                    DiagramColorsPart docColorsPart =
                       mainPart.AddPart<DiagramColorsPart>(colorsPart);
                    DiagramStylePart docStylePart =
                       mainPart.AddPart<DiagramStylePart>(stylePart);
                    // Get all the relationship ids of the added parts. 
                    docLayoutPartId = mainPart.GetIdOfPart(docLayoutPart);
                    docDataPartId = mainPart.GetIdOfPart(docDataPart);
                    docColorsPartId = mainPart.GetIdOfPart(docColorsPart);
                    docStylePartId = mainPart.GetIdOfPart(docStylePart);

                    // Use the document reflector to figure out how to add a SmartArt 
                    // graphic to Word. 
                    // Change attribute values based on specifics related to the SmartArt. 
                    Word.Paragraph p = new Word.Paragraph(
                       new Word.Run(
                       new Word.Drawing(
                       new WP.Inline(
                       new WP.Extent() { Cx = extents.Cx, Cy = extents.Cy },
                       new WP.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L },
                       new WP.DocProperties() { Id = drawingPr.Id, Name = drawingPr.Name },
                       new WP.NonVisualGraphicFrameDrawingProperties(),
                       new Draw.Graphic(
                       new Draw.GraphicData(
                       new Dgm.RelationshipIds()
                       {
                           DataPart = docDataPartId,
                           LayoutPart = docLayoutPartId,
                           StylePart = docStylePartId,
                           ColorPart = docColorsPartId
                       }) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/diagram" }))
                       {
                           DistanceFromTop = (UInt32Value)0U,
                           DistanceFromBottom = (UInt32Value)0U,
                           DistanceFromLeft = (UInt32Value)0U,
                           DistanceFromRight = (UInt32Value)0U
                       })));

                    // Swap out the content control for the SmartArt. 
                    OpenXmlElement parent = sdt.Parent;
                    parent.InsertAfter(p, sdt);
                    sdt.Remove();
                }
            }
        }

        void ImportChartFromSpreadsheet(MainDocumentPart mainPart, Word.SdtElement sdt,
   SPFile spreadsheetFileName)
        {
            // Create a paragraph that has an inline drawing object. 
            Word.Paragraph p = new Word.Paragraph();
            Word.Run r = new Word.Run();
            p.Append(r);
            Word.Drawing drawing = new Word.Drawing();
            r.Append(drawing);
            // These dimensions work perfectly for the template document. 
            WP.Inline inline = new WP.Inline(new WP.Extent() { Cx = 5486400, Cy = 3200400 });
            byte[] byteArray = spreadsheetFileName.OpenBinary();

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);

                // Open the Excel spreadsheet. 
                using (SpreadsheetDocument mySpreadsheet = SpreadsheetDocument.Open(mem, true))
                {
                    // Get all of the appropriate parts. 
                    WorkbookPart workbookPart = mySpreadsheet.WorkbookPart;
                    WorksheetPart worksheetPart = XLGetWorksheetPartByName(mySpreadsheet,
                       "Sheet2");
                    DrawingsPart drawingPart = worksheetPart.DrawingsPart;
                    ChartPart chartPart = (ChartPart)drawingPart.GetPartById("rId1");

                    // Clone the chart part and add it to the Word document. 
                    ChartPart importedChartPart = mainPart.AddPart<ChartPart>(chartPart);
                    string relId = mainPart.GetIdOfPart(importedChartPart);

                    // The frame element contains information for the chart. 
                    GraphicFrame frame =
                       drawingPart.WorksheetDrawing.Descendants<GraphicFrame>().First();
                    string chartName = frame.NonVisualGraphicFrameProperties.NonVisualDrawingProperties.Name;
                    // Clone this node so that you can add it to the Word document. 
                    Draw.Graphic clonedGraphic = (Draw.Graphic)frame.Graphic.CloneNode(true);
                    ChartReference c = clonedGraphic.GraphicData.GetFirstChild<ChartReference>();
                    c.Id = relId;

                    // Give the chart a unique ID and name. 
                    WP.DocProperties docPr = new WP.DocProperties();
                    docPr.Name = chartName;
                    docPr.Id = GetMaxDocPrId(mainPart) + 1;

                    // Add the chart data to the inline drawing object. 
                    inline.Append(docPr, clonedGraphic);
                    drawing.Append(inline);
                }
            }
            OpenXmlElement parent = sdt.Parent;
            parent.InsertAfter(p, sdt);
            sdt.Remove();
        }

        WorksheetPart XLGetWorksheetPartByName(SpreadsheetDocument document, string sheetName)
        {
            WorkbookPart wbPart = document.WorkbookPart;

            // Find the sheet with the supplied name, and then use that Sheet object 
            // to retrieve a reference to the appropriate worksheet. 
            Excel.Sheet theSheet = wbPart.Workbook.Descendants<Excel.Sheet>()
               .Where(s => s.Name == sheetName).FirstOrDefault();

            if (theSheet == null)
            {
                throw new ArgumentException("sheetName");
            }

            return (WorksheetPart)(wbPart.GetPartById(theSheet.Id));
        }

        uint GetMaxDocPrId(MainDocumentPart mainPart)
        {
            uint max = 1;

            // Get the maximum ID value of the docPr elements. 
            foreach (WP.DocProperties docPr in mainPart.Document.Descendants<WP.DocProperties>())
            {
                uint id = docPr.Id;
                if (id > max) max = id;
            }
            return max;
        }

        void ImportProjectsAndMilestones(MainDocumentPart mainPart, Word.SdtElement sdt, SPFile spreadsheetFileName)
        {
            ArrayList cellText = new ArrayList();

            // Create a Word table. 
            Word.Table tbl = new Word.Table();
            Word.TableProperties tblPr = new Word.TableProperties();
            Word.TableStyle tblStyle = new Word.TableStyle();
            tblStyle.Val = "LightShading-Accent1";
            tblPr.AppendChild(tblStyle);

            Word.TableWidth tblW = new Word.TableWidth();
            tblW.Width = "5000";
            tblW.Type = Word.TableWidthUnitValues.Pct;
            tblPr.Append(tblW);
            tbl.AppendChild(tblPr);
            byte[] byteArray = spreadsheetFileName.OpenBinary();

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);

                using (SpreadsheetDocument mySpreadsheet = SpreadsheetDocument.Open(mem, true))
                {
                    WorkbookPart workbookPart = mySpreadsheet.WorkbookPart;
                    WorksheetPart worksheetPart = XLGetWorksheetPartByName(mySpreadsheet, "Sheet1");

                    Excel.SheetData sheetData =
                       worksheetPart.Worksheet.GetFirstChild<Excel.SheetData>();

                    foreach (Excel.Row r in sheetData)
                    {
                        foreach (Excel.Cell c in r)
                        {
                            cellText.Add(XLGetCellValue(c, workbookPart));
                        }
                        Word.TableRow tr = CreateRow(cellText);
                        tbl.Append(tr);
                        cellText = new ArrayList();
                    }
                }
            }
            // Swap out the content control for the SmartArt. 
            OpenXmlElement parent = sdt.Parent;
            parent.InsertAfter(tbl, sdt);
            sdt.Remove();
        }

        void ImportKPIs(MainDocumentPart mainPart, Word.SdtElement sdt, SPFile spreadsheetFileName)
        {
            ArrayList cellText = new ArrayList();

            // Create a Word table. 
            Word.Table tbl = new Word.Table();
            Word.TableProperties tblPr = new Word.TableProperties();
            Word.TableStyle tblStyle = new Word.TableStyle();
            tblStyle.Val = "LightShading-Accent1";
            tblPr.AppendChild(tblStyle);

            Word.TableWidth tblW = new Word.TableWidth();
            tblW.Width = "5000";
            tblW.Type = Word.TableWidthUnitValues.Pct;
            tblPr.Append(tblW);
            tbl.AppendChild(tblPr);
            byte[] byteArray = spreadsheetFileName.OpenBinary();

            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);

                using (SpreadsheetDocument mySpreadsheet = SpreadsheetDocument.Open(mem, true))
                {
                    WorkbookPart workbookPart = mySpreadsheet.WorkbookPart;
                    WorksheetPart worksheetPart = XLGetWorksheetPartByName(mySpreadsheet, "KPIs");

                    Excel.SheetData sheetData =
                       worksheetPart.Worksheet.GetFirstChild<Excel.SheetData>();

                    foreach (Excel.Row r in sheetData)
                    {
                        foreach (Excel.Cell c in r)
                        {
                            cellText.Add(XLGetCellValue(c, workbookPart));
                        }
                        Word.TableRow tr = CreateRow(cellText);
                        tbl.Append(tr);
                        cellText = new ArrayList();
                    }
                }
            }
            // Swap out the content control for the SmartArt. 
            OpenXmlElement parent = sdt.Parent;
            parent.InsertAfter(tbl, sdt);
            sdt.Remove();
        }


        Word.TableRow CreateRow(ArrayList cellText)
        {
            Word.TableRow tr = new Word.TableRow();
            // Create cells with simple text. 
            foreach (string s in cellText)
            {
                Word.TableCell tc = new Word.TableCell();
                Word.Paragraph p = new Word.Paragraph();
                Word.Run r = new Word.Run();
                Word.Text t = new Word.Text(s);
                r.AppendChild(t);
                p.AppendChild(r);
                tc.AppendChild(p);
                tr.AppendChild(tc);
            }
            return tr;
        }

        // Get the value of a cell, given a file name, sheet name, and address name. 
        string XLGetCellValue(Excel.Cell c, WorkbookPart wbPart)
        {
            string value = null;
            // If the cell does not exist, return an empty string. 
            if (c != null)
            {
                value = c.InnerText;

                // If the cell represents an integer number, you are finished. 
                // For dates, this code returns the serialized value that 
                // represents the date. The code handles strings and Boolean values 
                // individually. For shared strings, the code looks up the corresponding 
                // value in the shared string table. For Boolean values, the code converts 
                // the value into the words TRUE or FALSE. 
                if (c.DataType != null)
                {
                    switch (c.DataType.Value)
                    {
                        case Excel.CellValues.SharedString:
                            // For shared strings, look up the value in the shared strings table. 
                            var stringTable = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                            // If the shared string table is missing, something is wrong. 
                            // Just return the index that you found in the cell. 
                            // Otherwise, look up the correct text in the table. 
                            if (stringTable != null)
                            {
                                value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                            }
                            break;
                        case Excel.CellValues.Boolean:
                            switch (value)
                            {
                                case "0":
                                    value = "FALSE";
                                    break;
                                default:
                                    value = "TRUE";
                                    break;
                            }
                            break;
                    }
                }
            }

            return value;
        }

    }
}
