﻿Namespace Q183557
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet_Renamed = New Q183557.CarsDBDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiter = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.carsTableAdapter = New Q183557.CarsDBDataSetTableAdapters.CarsTableAdapter()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.AllowDrop = True
            Me.gridControl1.DataSource = Me.carsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(505, 307)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' carsBindingSource
            ' 
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet_Renamed
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTrademark, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 1
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.Caption = "Trademark"
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            ' 
            ' colModel
            ' 
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 0
            ' 
            ' colHP
            ' 
            Me.colHP.Caption = "HP"
            Me.colHP.FieldName = "HP"
            Me.colHP.Name = "colHP"
            Me.colHP.Visible = True
            Me.colHP.VisibleIndex = 2
            ' 
            ' colLiter
            ' 
            Me.colLiter.Caption = "Liter"
            Me.colLiter.FieldName = "Liter"
            Me.colLiter.Name = "colLiter"
            Me.colLiter.Visible = True
            Me.colLiter.VisibleIndex = 3
            ' 
            ' colCyl
            ' 
            Me.colCyl.Caption = "Cyl"
            Me.colCyl.FieldName = "Cyl"
            Me.colCyl.Name = "colCyl"
            Me.colCyl.Visible = True
            Me.colCyl.VisibleIndex = 4
            ' 
            ' carsTableAdapter
            ' 
            Me.carsTableAdapter.ClearBeforeFill = True
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 200
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(505, 307)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private carsDBDataSet_Renamed As CarsDBDataSet
        Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As Q183557.CarsDBDataSetTableAdapters.CarsTableAdapter
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
        Private colModel As DevExpress.XtraGrid.Columns.GridColumn
        Private colHP As DevExpress.XtraGrid.Columns.GridColumn
        Private colLiter As DevExpress.XtraGrid.Columns.GridColumn
        Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents timer1 As System.Windows.Forms.Timer
    End Class
End Namespace

