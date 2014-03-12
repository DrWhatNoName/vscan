Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports vscan.dbDataSetTableAdapters

Namespace vscan
	<DesignerGenerated()>
	Public Class player
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private components As IContainer

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("DbDataSet")>
		Private _DbDataSet As dbDataSet

		<AccessedThroughProperty("CordinBindingSource")>
		Private _CordinBindingSource As BindingSource

		<AccessedThroughProperty("CordinTableAdapter")>
		Private _CordinTableAdapter As cordinTableAdapter

		<AccessedThroughProperty("TableAdapterManager")>
		Private _TableAdapterManager As TableAdapterManager

		<AccessedThroughProperty("CordinDataGridView")>
		Private _CordinDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn3")>
		Private _DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn4")>
		Private _DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn5")>
		Private _DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn2")>
		Private _DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn1")>
		Private _DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn6")>
		Private _DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("Hero_allianceBindingSource")>
		Private _Hero_allianceBindingSource As BindingSource

		<AccessedThroughProperty("Hero_allianceTableAdapter")>
		Private _Hero_allianceTableAdapter As hero_allianceTableAdapter

		<AccessedThroughProperty("Hero_allianceDataGridView")>
		Private _Hero_allianceDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn7")>
		Private _DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn8")>
		Private _DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn11")>
		Private _DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn12")>
		Private _DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn13")>
		Private _DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn14")>
		Private _DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn10")>
		Private _DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn9")>
		Private _DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn

		Friend Overridable Property Label7() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property Label5() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property Button1() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button1_Click)
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					Me._Button1.Click -= value2
				End If
				Me._Button1 = value
				flag = (Me._Button1 IsNot Nothing)
				If flag Then
					Me._Button1.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property DbDataSet() As dbDataSet
			<DebuggerNonUserCode()>
			Get
				Return Me._DbDataSet
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dbDataSet)
				Me._DbDataSet = value
			End Set
		End Property

		Friend Overridable Property CordinBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._CordinBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._CordinBindingSource = value
			End Set
		End Property

		Friend Overridable Property CordinTableAdapter() As cordinTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._CordinTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As cordinTableAdapter)
				Me._CordinTableAdapter = value
			End Set
		End Property

		Friend Overridable Property TableAdapterManager() As TableAdapterManager
			<DebuggerNonUserCode()>
			Get
				Return Me._TableAdapterManager
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableAdapterManager)
				Me._TableAdapterManager = value
			End Set
		End Property

		Friend Overridable Property CordinDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._CordinDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.CordinDataGridView_CellFormatting)
				Dim flag As Boolean = Me._CordinDataGridView IsNot Nothing
				If flag Then
					Me._CordinDataGridView.CellFormatting -= value2
				End If
				Me._CordinDataGridView = value
				flag = (Me._CordinDataGridView IsNot Nothing)
				If flag Then
					Me._CordinDataGridView.CellFormatting += value2
				End If
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn3() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn3 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn4() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn4 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn5() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn5 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn2() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn2 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn1() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn1 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn6() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn6 = value
			End Set
		End Property

		Friend Overridable Property Hero_allianceBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._Hero_allianceBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._Hero_allianceBindingSource = value
			End Set
		End Property

		Friend Overridable Property Hero_allianceTableAdapter() As hero_allianceTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._Hero_allianceTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As hero_allianceTableAdapter)
				Me._Hero_allianceTableAdapter = value
			End Set
		End Property

		Friend Overridable Property Hero_allianceDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._Hero_allianceDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.Hero_allianceDataGridView_CellFormatting)
				Dim value3 As DataGridViewCellEventHandler = New DataGridViewCellEventHandler(Me.Hero_allianceDataGridView_CellContentClick)
				Dim flag As Boolean = Me._Hero_allianceDataGridView IsNot Nothing
				If flag Then
					Me._Hero_allianceDataGridView.CellFormatting -= value2
					Me._Hero_allianceDataGridView.CellContentClick -= value3
				End If
				Me._Hero_allianceDataGridView = value
				flag = (Me._Hero_allianceDataGridView IsNot Nothing)
				If flag Then
					Me._Hero_allianceDataGridView.CellFormatting += value2
					Me._Hero_allianceDataGridView.CellContentClick += value3
				End If
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn7() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn7 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn8() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn8 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn11() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn11 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn12() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn12 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn13() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn13 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn14() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn14 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn10() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn10 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn9() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn9 = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			MyBase.Load += New EventHandler(Me.player_Load)
			player.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = player.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = player.__ENCList.Count = player.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = player.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = player.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								player.__ENCList(num) = player.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					player.__ENCList.RemoveRange(num, player.__ENCList.Count - num)
					player.__ENCList.Capacity = player.__ENCList.Count
				End If
				player.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<DebuggerNonUserCode()>
		Protected Override Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Container()
			Dim DataGridViewCellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(player))
			Me.Label7 = New Label()
			Me.Label6 = New Label()
			Me.Label5 = New Label()
			Me.Label4 = New Label()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.Label3 = New Label()
			Me.Button1 = New Button()
			Me.DbDataSet = New dbDataSet()
			Me.CordinBindingSource = New BindingSource(Me.components)
			Me.CordinTableAdapter = New cordinTableAdapter()
			Me.TableAdapterManager = New TableAdapterManager()
			Me.CordinDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
			Me.Hero_allianceBindingSource = New BindingSource(Me.components)
			Me.Hero_allianceTableAdapter = New hero_allianceTableAdapter()
			Me.Hero_allianceDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn11 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn12 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn13 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn14 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn10 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
			(CType(Me.DbDataSet, ISupportInitialize)).BeginInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.CordinDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.Hero_allianceBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.Hero_allianceDataGridView, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_227_0 As Control = Me.Label7
			Dim location As Point = New Point(205, 13)
			arg_227_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_252_0 As Control = Me.Label7
			Dim size As Size = New Size(49, 16)
			arg_252_0.Size = size
			Me.Label7.TabIndex = 15
			Me.Label7.Text = "Label7"
			Me.Label7.Visible = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_2C6_0 As Control = Me.Label6
			location = New Point(153, 45)
			arg_2C6_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_2F1_0 As Control = Me.Label6
			size = New Size(49, 16)
			arg_2F1_0.Size = size
			Me.Label6.TabIndex = 14
			Me.Label6.Text = "Label6"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_358_0 As Control = Me.Label5
			location = New Point(150, 13)
			arg_358_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_383_0 As Control = Me.Label5
			size = New Size(49, 16)
			arg_383_0.Size = size
			Me.Label5.TabIndex = 13
			Me.Label5.Text = "Label5"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim arg_3E7_0 As Control = Me.Label4
			location = New Point(67, 41)
			arg_3E7_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_412_0 As Control = Me.Label4
			size = New Size(77, 20)
			arg_412_0.Size = size
			Me.Label4.TabIndex = 12
			Me.Label4.Text = "Alliance:"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim arg_476_0 As Control = Me.Label2
			location = New Point(81, 73)
			arg_476_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_4A1_0 As Control = Me.Label2
			size = New Size(54, 16)
			arg_4A1_0.Size = size
			Me.Label2.TabIndex = 11
			Me.Label2.Text = "Cities:"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim arg_505_0 As Control = Me.Label1
			location = New Point(30, 9)
			arg_505_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_530_0 As Control = Me.Label1
			size = New Size(114, 20)
			arg_530_0.Size = size
			Me.Label1.TabIndex = 10
			Me.Label1.Text = "Player Name:"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim arg_597_0 As Control = Me.Label3
			location = New Point(338, 73)
			arg_597_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_5C2_0 As Control = Me.Label3
			size = New Size(65, 16)
			arg_5C2_0.Size = size
			Me.Label3.TabIndex = 16
			Me.Label3.Text = "Heroes:"
			Dim arg_601_0 As Control = Me.Button1
			location = New Point(409, 402)
			arg_601_0.Location = location
			Me.Button1.Name = "Button1"
			Dim arg_62C_0 As Control = Me.Button1
			size = New Size(75, 23)
			arg_62C_0.Size = size
			Me.Button1.TabIndex = 17
			Me.Button1.Text = "Save (.txt)"
			Me.Button1.UseVisualStyleBackColor = True
			Me.DbDataSet.DataSetName = "dbDataSet"
			Me.DbDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.CordinBindingSource.DataMember = "cordin"
			Me.CordinBindingSource.DataSource = Me.DbDataSet
			Me.CordinTableAdapter.ClearBeforeFill = True
			Me.TableAdapterManager.altTableAdapter = Nothing
			Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
			Me.TableAdapterManager.cordinTableAdapter = Me.CordinTableAdapter
			Me.TableAdapterManager.enemiesTableAdapter = Nothing
			Me.TableAdapterManager.fieldTableAdapter = Nothing
			Me.TableAdapterManager.flatsTableAdapter = Nothing
			Me.TableAdapterManager.friendsTableAdapter = Nothing
			Me.TableAdapterManager.heroTableAdapter = Nothing
			Me.TableAdapterManager.huntTableAdapter = Nothing
			Me.TableAdapterManager.neutralTableAdapter = Nothing
			Me.TableAdapterManager.npcTableAdapter = Nothing
			Me.TableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
			Me.CordinDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle.BackColor = SystemColors.Control
			DataGridViewCellStyle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
			DataGridViewCellStyle.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle.WrapMode = DataGridViewTriState.[True]
			Me.CordinDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle
			Me.CordinDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.CordinDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6 })
			Me.CordinDataGridView.DataSource = Me.CordinBindingSource
			Dim arg_851_0 As Control = Me.CordinDataGridView
			location = New Point(12, 102)
			arg_851_0.Location = location
			Me.CordinDataGridView.Name = "CordinDataGridView"
			Dim arg_882_0 As Control = Me.CordinDataGridView
			size = New Size(242, 282)
			arg_882_0.Size = size
			Me.CordinDataGridView.TabIndex = 18
			Me.DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn3.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn3.HeaderText = "X"
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn4.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn4.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
			Me.DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn5.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn5.HeaderText = "Citie"
			Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
			Me.DataGridViewTextBoxColumn2.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn2.HeaderText = "player"
			Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
			Me.DataGridViewTextBoxColumn2.Visible = False
			Me.DataGridViewTextBoxColumn1.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn1.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn1.Visible = False
			Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
			Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
			Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
			Me.DataGridViewTextBoxColumn6.Visible = False
			Me.Hero_allianceBindingSource.DataMember = "hero_alliance"
			Me.Hero_allianceBindingSource.DataSource = Me.DbDataSet
			Me.Hero_allianceTableAdapter.ClearBeforeFill = True
			Me.Hero_allianceDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle2.BackColor = SystemColors.Control
			DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
			DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[True]
			Me.Hero_allianceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
			Me.Hero_allianceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.Hero_allianceDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9 })
			Me.Hero_allianceDataGridView.DataSource = Me.Hero_allianceBindingSource
			DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle3.BackColor = SystemColors.Window
			DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle3.WrapMode = DataGridViewTriState.[False]
			Me.Hero_allianceDataGridView.DefaultCellStyle = DataGridViewCellStyle3
			Dim arg_BCD_0 As Control = Me.Hero_allianceDataGridView
			location = New Point(269, 102)
			arg_BCD_0.Location = location
			Me.Hero_allianceDataGridView.Name = "Hero_allianceDataGridView"
			Dim arg_BFE_0 As Control = Me.Hero_allianceDataGridView
			size = New Size(613, 282)
			arg_BFE_0.Size = size
			Me.Hero_allianceDataGridView.TabIndex = 18
			Me.DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn7.DataPropertyName = "hero nr"
			Me.DataGridViewTextBoxColumn7.HeaderText = "Hero Nr"
			Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
			Me.DataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn8.DataPropertyName = "hero name"
			Me.DataGridViewTextBoxColumn8.HeaderText = "Hero "
			Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
			Me.DataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn11.DataPropertyName = "level"
			Me.DataGridViewTextBoxColumn11.HeaderText = "Level"
			Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
			Me.DataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn12.DataPropertyName = "polit"
			Me.DataGridViewTextBoxColumn12.HeaderText = "Polit"
			Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
			Me.DataGridViewTextBoxColumn13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn13.DataPropertyName = "att"
			Me.DataGridViewTextBoxColumn13.HeaderText = "Att"
			Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
			Me.DataGridViewTextBoxColumn14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn14.DataPropertyName = "intel"
			Me.DataGridViewTextBoxColumn14.HeaderText = "Intel"
			Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
			Me.DataGridViewTextBoxColumn10.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn10.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
			Me.DataGridViewTextBoxColumn10.Visible = False
			Me.DataGridViewTextBoxColumn9.DataPropertyName = "player name"
			Me.DataGridViewTextBoxColumn9.HeaderText = "player name"
			Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
			Me.DataGridViewTextBoxColumn9.Visible = False
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(896, 440)
			Me.ClientSize = size
			Me.Controls.Add(Me.Hero_allianceDataGridView)
			Me.Controls.Add(Me.CordinDataGridView)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
			Me.Name = "player"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "player"
			(CType(Me.DbDataSet, ISupportInitialize)).EndInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.CordinDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.Hero_allianceBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.Hero_allianceDataGridView, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub CordinBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.CordinBindingSource.EndEdit()
			Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
		End Sub

		Private Sub player_Load(sender As Object, e As EventArgs)
			Me.Hero_allianceTableAdapter.searchplayer1(Me.DbDataSet.hero_alliance, Me.Label7.Text)
			Me.CordinTableAdapter.searchplayer(Me.DbDataSet.cordin, Me.Label5.Text)
		End Sub

		Private Sub CordinDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.CordinDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.CordinDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Hero_allianceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		End Sub

		Private Sub Hero_allianceDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.Hero_allianceDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.Hero_allianceDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			Dim FileToSaveAs As String = thepath + "\" + Me.Label5.Text + ".txt"
			Dim objwriter As StreamWriter = New StreamWriter(FileToSaveAs, False)
			objwriter.WriteLine("Player Name:    " + Me.Label5.Text)
			objwriter.WriteLine("    ")
			objwriter.WriteLine("Cities:")
			objwriter.WriteLine(" X , Y, Cities ")
			objwriter.WriteLine("----------------")
			Dim arg_8D_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.CordinDataGridView.Rows.Count - 1
			Dim iRow As Integer = arg_8D_0
			While True
				Dim arg_10C_0 As Integer = iRow
				Dim num2 As Integer = num
				If arg_10C_0 > num2 Then
					Exit While
				End If
				Dim iCol As Integer = 0
				Dim arg_EB_0 As Integer
				Do
					Dim flag As Boolean = iCol > 0
					If flag Then
						objwriter.Write(",")
					End If
					objwriter.Write("{0}", RuntimeHelpers.GetObjectValue(Me.CordinDataGridView.Rows(iRow).Cells(iCol).Value))
					iCol += 1
					arg_EB_0 = iCol
					num2 = 2
				Loop While arg_EB_0 <= num2
				objwriter.WriteLine()
				objwriter.WriteLine("----------------")
				iRow += 1
			End While
			objwriter.WriteLine("    ")
			objwriter.WriteLine("        Heroes:")
			objwriter.WriteLine("    ")
			objwriter.WriteLine("Hero nr,Hero name,Lvl.,Pol.,Att,Int.")
			objwriter.WriteLine("----------------------------")
			Dim arg_15F_0 As Integer = 0
			Dim num3 As Integer = Me.Hero_allianceDataGridView.Rows.Count - 1
			Dim iRow2 As Integer = arg_15F_0
			While True
				Dim arg_1E3_0 As Integer = iRow2
				Dim num2 As Integer = num3
				If arg_1E3_0 > num2 Then
					Exit While
				End If
				Dim iCol2 As Integer = 0
				Dim arg_1BF_0 As Integer
				Do
					Dim flag As Boolean = iCol2 > 0
					If flag Then
						objwriter.Write(",")
					End If
					objwriter.Write("{0}", RuntimeHelpers.GetObjectValue(Me.Hero_allianceDataGridView.Rows(iRow2).Cells(iCol2).Value))
					iCol2 += 1
					arg_1BF_0 = iCol2
					num2 = 5
				Loop While arg_1BF_0 <= num2
				objwriter.WriteLine()
				objwriter.WriteLine("----------------------------")
				iRow2 += 1
			End While
			objwriter.Close()
			objwriter.Close()
			Interaction.MsgBox("Saved", MsgBoxStyle.OkOnly, Nothing)
		End Sub
	End Class
End Namespace
