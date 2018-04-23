Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private xrLabel1 As XRLabel
    Private xrLabel2 As XRLabel
    Private xrLabel3 As XRLabel
    Private xrLabel4 As XRLabel
    Private xrLabel5 As XRLabel
    Private xrLabel6 As XRLabel
    Private xrLabel7 As XRLabel
    Private xrPictureBox1 As XRPictureBox
    Private xrLine1 As XRLine
    Private xrPageInfo1 As XRPageInfo
    Private xrPageInfo2 As XRPageInfo
    Private reportHeaderBand1 As ReportHeaderBand
    Private xrLabel8 As XRLabel
    Private Title As XRControlStyle
    Private FieldCaption As XRControlStyle
    Private PageInfo As XRControlStyle
    Private DataField As XRControlStyle
    Private topMarginBand1 As TopMarginBand
    Private bottomMarginBand1 As BottomMarginBand

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrPictureBox1, Me.xrLine1})
            Me.Detail.HeightF = 110F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel1.StyleName = "FieldCaption"
            Me.xrLabel1.Text = "Category ID"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel2.StyleName = "FieldCaption"
            Me.xrLabel2.Text = "Category Name"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6F, 57F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel3.StyleName = "FieldCaption"
            Me.xrLabel3.Text = "Description"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6F, 81F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(162F, 23F)
            Me.xrLabel4.StyleName = "FieldCaption"
            Me.xrLabel4.Text = "Picture"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryID")})
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel5.StyleName = "DataField"
            Me.xrLabel5.Text = "xrLabel5"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel6.StyleName = "DataField"
            Me.xrLabel6.Text = "xrLabel6"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174F, 57F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel7.StyleName = "DataField"
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(174F, 81F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(470F, 23F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox1.StyleName = "DataField"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 3F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(638F, 2F)
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "Northwind_Connection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel8})
            Me.reportHeaderBand1.HeightF = 45F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(638F, 33F)
            Me.xrLabel8.StyleName = "Title"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "17.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
