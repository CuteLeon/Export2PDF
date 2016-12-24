Imports System.Environment
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

'需要引用 /* iTextSharp.dll */

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExportPDF()
        Application.Exit()
    End Sub

    Private Sub ExportPDF()
        Dim FileName As String = Application.StartupPath & "\Test.pdf"
        Dim Document As Document = New Document(PageSize.NOTE)
        Dim Writer As PdfWriter = PdfWriter.GetInstance(Document, New FileStream(FileName, FileMode.Create))
        Dim BaseFont As BaseFont
        Dim PDFFont As Font, PDFBoldFont As Font

        'BaseFont = BaseFont.CreateFont(GetFolderPath(SpecialFolder.Fonts) & "\simsun.ttc,0", "Identity-H", False)
        BaseFont = BaseFont.CreateFont(GetFolderPath(SpecialFolder.Fonts) & "\MSYH.ttc,0", "Identity-H", False)
        PDFFont = New Font(BaseFont, 15)
        PDFBoldFont = New Font(BaseFont, 15, FontStyle.Bold)

        Document.Open()
        Dim Title As Paragraph = New Paragraph("XXX检查报告", PDFBoldFont)
        Title.Alignment = Element.ALIGN_CENTER
        Document.Add(Title)

        Dim BasicInfoTable As PdfPTable = New PdfPTable(2)
        BasicInfoTable.WidthPercentage = 90.0F
        BasicInfoTable.SetWidths(New Integer() {30, 70})

        Dim BasicInfoCell As PdfPCell = New PdfPCell()
        BasicInfoCell.Border = 0
        BasicInfoCell.Padding = 1
        BasicInfoCell.Padding = 5
        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.VerticalAlignment = Element.ALIGN_TOP

        BasicInfoCell.Phrase = New Phrase("报告基本信息：", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)
        BasicInfoCell.Phrase = New Phrase(vbNullString, PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        PDFFont = New Font(BaseFont, 15)
        PDFBoldFont = New Font(BaseFont, 12, 1)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_RIGHT
        BasicInfoCell.Phrase = New Phrase("标签一：", PDFFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.Phrase = New Phrase("数据一", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_RIGHT
        BasicInfoCell.Phrase = New Phrase("标签二：", PDFFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.Phrase = New Phrase("数据二", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_RIGHT
        BasicInfoCell.Phrase = New Phrase("标签三：", PDFFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.Phrase = New Phrase("数据三", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_RIGHT
        BasicInfoCell.Phrase = New Phrase("标签四：", PDFFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.Phrase = New Phrase("数据四", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_RIGHT
        BasicInfoCell.Phrase = New Phrase("标签五：", PDFFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        BasicInfoCell.HorizontalAlignment = Element.ALIGN_LEFT
        BasicInfoCell.Phrase = New Phrase("数据五", PDFBoldFont)
        BasicInfoTable.AddCell(BasicInfoCell)

        Document.Add(BasicInfoTable)

        Dim JobDataTable As PdfPTable = New PdfPTable(3)
        JobDataTable.WidthPercentage = 90.0F
        JobDataTable.SetWidths(New Integer() {40, 25, 35})
        Dim JobDataCell As PdfPCell = New PdfPCell()
        JobDataCell.Border = 0
        JobDataCell.VerticalAlignment = Element.ALIGN_TOP
        JobDataCell.HorizontalAlignment = Element.ALIGN_LEFT

        PDFBoldFont = New Font(BaseFont, 15, 1)
        JobDataCell.HorizontalAlignment = Element.ALIGN_LEFT
        JobDataCell.Padding = 5
        JobDataCell.Phrase = New Phrase("检查结果：", PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase(vbNullString, PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase(vbNullString, PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)

        PDFBoldFont = New Font(BaseFont, 12, 1)
        JobDataCell.Border = 15
        JobDataCell.Padding = 1
        JobDataCell.BorderColor = BaseColor.GRAY
        JobDataCell.HorizontalAlignment = Element.ALIGN_CENTER
        JobDataCell.BackgroundColor = BaseColor.LIGHT_GRAY

        JobDataCell.Phrase = New Phrase("文件名", PDFFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase("创建时间", PDFFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase("检查结果", PDFFont)
        JobDataTable.AddCell(JobDataCell)

        JobDataCell.HorizontalAlignment = Element.ALIGN_LEFT
        JobDataCell.BackgroundColor = BaseColor.WHITE
        JobDataCell.Phrase = New Phrase("文件名一", PDFFont)
        JobDataTable.AddCell(JobDataCell)

        JobDataCell.Phrase = New Phrase("创建时间一", PDFFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase("检查结果一", PDFFont)
        JobDataTable.AddCell(JobDataCell)

        PDFFont = New Font(BaseFont, 1, 1)

        JobDataCell.Border = 0
        JobDataCell.Padding = 5
        JobDataCell.HorizontalAlignment = Element.ALIGN_LEFT
        JobDataCell.Phrase = New Phrase("检查结果：XXX", PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase(vbNullString, PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)
        JobDataCell.Phrase = New Phrase(vbNullString, PDFBoldFont)
        JobDataTable.AddCell(JobDataCell)
        Document.Add(JobDataTable)

        Document.Close()
    End Sub
End Class
