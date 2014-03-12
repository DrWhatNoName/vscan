Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports vscan.dbDataSetTableAdapters
Imports vscan.My.Resources

Namespace vscan
	<DesignerGenerated()>
	Public Class map
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private components As IContainer

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("CheckBox4")>
		Private _CheckBox4 As CheckBox

		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		<AccessedThroughProperty("CheckBox8")>
		Private _CheckBox8 As CheckBox

		<AccessedThroughProperty("CheckBox7")>
		Private _CheckBox7 As CheckBox

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		<AccessedThroughProperty("CheckBox6")>
		Private _CheckBox6 As CheckBox

		<AccessedThroughProperty("CheckBox5")>
		Private _CheckBox5 As CheckBox

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

		<AccessedThroughProperty("AltcoordBindingSource")>
		Private _AltcoordBindingSource As BindingSource

		<AccessedThroughProperty("AltcoordTableAdapter")>
		Private _AltcoordTableAdapter As altcoordTableAdapter

		<AccessedThroughProperty("AltcoordDataGridView")>
		Private _AltcoordDataGridView As DataGridView

		<AccessedThroughProperty("EnemiescoordBindingSource")>
		Private _EnemiescoordBindingSource As BindingSource

		<AccessedThroughProperty("EnemiescoordTableAdapter")>
		Private _EnemiescoordTableAdapter As enemiescoordTableAdapter

		<AccessedThroughProperty("EnemiescoordDataGridView")>
		Private _EnemiescoordDataGridView As DataGridView

		<AccessedThroughProperty("FriendscoordBindingSource")>
		Private _FriendscoordBindingSource As BindingSource

		<AccessedThroughProperty("FriendscoordTableAdapter")>
		Private _FriendscoordTableAdapter As friendscoordTableAdapter

		<AccessedThroughProperty("FriendscoordDataGridView")>
		Private _FriendscoordDataGridView As DataGridView

		<AccessedThroughProperty("NeutralcoordBindingSource")>
		Private _NeutralcoordBindingSource As BindingSource

		<AccessedThroughProperty("NeutralcoordTableAdapter")>
		Private _NeutralcoordTableAdapter As neutralcoordTableAdapter

		<AccessedThroughProperty("NeutralcoordDataGridView")>
		Private _NeutralcoordDataGridView As DataGridView

		<AccessedThroughProperty("FieldTableAdapter")>
		Private _FieldTableAdapter As fieldTableAdapter

		<AccessedThroughProperty("FieldBindingSource")>
		Private _FieldBindingSource As BindingSource

		<AccessedThroughProperty("FlatsTableAdapter")>
		Private _FlatsTableAdapter As flatsTableAdapter

		<AccessedThroughProperty("FieldDataGridView")>
		Private _FieldDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn30")>
		Private _DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn31")>
		Private _DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn32")>
		Private _DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn33")>
		Private _DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn34")>
		Private _DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("FlatsBindingSource")>
		Private _FlatsBindingSource As BindingSource

		<AccessedThroughProperty("NpcTableAdapter")>
		Private _NpcTableAdapter As npcTableAdapter

		<AccessedThroughProperty("FlatsDataGridView")>
		Private _FlatsDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn35")>
		Private _DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn36")>
		Private _DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn37")>
		Private _DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn38")>
		Private _DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("NpcBindingSource")>
		Private _NpcBindingSource As BindingSource

		<AccessedThroughProperty("NpcDataGridView")>
		Private _NpcDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn39")>
		Private _DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn40")>
		Private _DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn41")>
		Private _DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn42")>
		Private _DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("RadioButton2")>
		Private _RadioButton2 As RadioButton

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

		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		<AccessedThroughProperty("DataGridViewTextBoxColumn8")>
		Private _DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn9")>
		Private _DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn10")>
		Private _DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn11")>
		Private _DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn12")>
		Private _DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn7")>
		Private _DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn14")>
		Private _DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn15")>
		Private _DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn16")>
		Private _DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn17")>
		Private _DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn18")>
		Private _DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn13")>
		Private _DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn20")>
		Private _DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn21")>
		Private _DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn22")>
		Private _DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn23")>
		Private _DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn24")>
		Private _DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn19")>
		Private _DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn26")>
		Private _DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn27")>
		Private _DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn28")>
		Private _DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn29")>
		Private _DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn25")>
		Private _DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("ColorDialog1")>
		Private _ColorDialog1 As ColorDialog

		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		Private imageName As String

		Private i As Image

		Private g As Graphics

		Private thepath As String

		Private x As Integer

		Private y As Integer

		Private sk As Integer

		Friend Overridable Property Panel1() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property PictureBox1() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = New EventHandler(Me.PictureBox1_Click)
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					Me._PictureBox1.Click -= value2
				End If
				Me._PictureBox1 = value
				flag = (Me._PictureBox1 IsNot Nothing)
				If flag Then
					Me._PictureBox1.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property GroupBox2() As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
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

		Friend Overridable Property CheckBox4() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox4 = value
			End Set
		End Property

		Friend Overridable Property CheckBox3() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox3 = value
			End Set
		End Property

		Friend Overridable Property CheckBox2() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox2 = value
			End Set
		End Property

		Friend Overridable Property CheckBox1() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		Friend Overridable Property GroupBox3() As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox3 = value
			End Set
		End Property

		Friend Overridable Property CheckBox8() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox8 = value
			End Set
		End Property

		Friend Overridable Property CheckBox7() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox7 = value
			End Set
		End Property

		Friend Overridable Property Button2() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button2_Click)
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					Me._Button2.Click -= value2
				End If
				Me._Button2 = value
				flag = (Me._Button2 IsNot Nothing)
				If flag Then
					Me._Button2.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox6() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox6 = value
			End Set
		End Property

		Friend Overridable Property CheckBox5() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox5 = value
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
				Dim value3 As DataGridViewCellEventHandler = New DataGridViewCellEventHandler(Me.CordinDataGridView_CellContentClick)
				Dim flag As Boolean = Me._CordinDataGridView IsNot Nothing
				If flag Then
					Me._CordinDataGridView.CellFormatting -= value2
					Me._CordinDataGridView.CellContentClick -= value3
				End If
				Me._CordinDataGridView = value
				flag = (Me._CordinDataGridView IsNot Nothing)
				If flag Then
					Me._CordinDataGridView.CellFormatting += value2
					Me._CordinDataGridView.CellContentClick += value3
				End If
			End Set
		End Property

		Friend Overridable Property AltcoordBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._AltcoordBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._AltcoordBindingSource = value
			End Set
		End Property

		Friend Overridable Property AltcoordTableAdapter() As altcoordTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._AltcoordTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As altcoordTableAdapter)
				Me._AltcoordTableAdapter = value
			End Set
		End Property

		Friend Overridable Property AltcoordDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._AltcoordDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._AltcoordDataGridView = value
			End Set
		End Property

		Friend Overridable Property EnemiescoordBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiescoordBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._EnemiescoordBindingSource = value
			End Set
		End Property

		Friend Overridable Property EnemiescoordTableAdapter() As enemiescoordTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiescoordTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As enemiescoordTableAdapter)
				Me._EnemiescoordTableAdapter = value
			End Set
		End Property

		Friend Overridable Property EnemiescoordDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiescoordDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._EnemiescoordDataGridView = value
			End Set
		End Property

		Friend Overridable Property FriendscoordBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendscoordBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._FriendscoordBindingSource = value
			End Set
		End Property

		Friend Overridable Property FriendscoordTableAdapter() As friendscoordTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendscoordTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As friendscoordTableAdapter)
				Me._FriendscoordTableAdapter = value
			End Set
		End Property

		Friend Overridable Property FriendscoordDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendscoordDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._FriendscoordDataGridView = value
			End Set
		End Property

		Friend Overridable Property NeutralcoordBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralcoordBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._NeutralcoordBindingSource = value
			End Set
		End Property

		Friend Overridable Property NeutralcoordTableAdapter() As neutralcoordTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralcoordTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As neutralcoordTableAdapter)
				Me._NeutralcoordTableAdapter = value
			End Set
		End Property

		Friend Overridable Property NeutralcoordDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralcoordDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._NeutralcoordDataGridView = value
			End Set
		End Property

		Friend Overridable Property FieldTableAdapter() As fieldTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._FieldTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As fieldTableAdapter)
				Me._FieldTableAdapter = value
			End Set
		End Property

		Friend Overridable Property FieldBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._FieldBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._FieldBindingSource = value
			End Set
		End Property

		Friend Overridable Property FlatsTableAdapter() As flatsTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatsTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As flatsTableAdapter)
				Me._FlatsTableAdapter = value
			End Set
		End Property

		Friend Overridable Property FieldDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._FieldDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._FieldDataGridView = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn30() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn30
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn30 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn31() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn31
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn31 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn32() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn32
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn32 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn33() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn33
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn33 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn34() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn34
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn34 = value
			End Set
		End Property

		Friend Overridable Property FlatsBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatsBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._FlatsBindingSource = value
			End Set
		End Property

		Friend Overridable Property NpcTableAdapter() As npcTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._NpcTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As npcTableAdapter)
				Me._NpcTableAdapter = value
			End Set
		End Property

		Friend Overridable Property FlatsDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatsDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._FlatsDataGridView = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn35() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn35
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn35 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn36() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn36
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn36 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn37() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn37
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn37 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn38() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn38
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn38 = value
			End Set
		End Property

		Friend Overridable Property NpcBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._NpcBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._NpcBindingSource = value
			End Set
		End Property

		Friend Overridable Property NpcDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._NpcDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Me._NpcDataGridView = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn39() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn39
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn39 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn40() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn40
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn40 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn41() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn41
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn41 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn42() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn42
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn42 = value
			End Set
		End Property

		Friend Overridable Property Button7() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button7_Click)
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					Me._Button7.Click -= value2
				End If
				Me._Button7 = value
				flag = (Me._Button7 IsNot Nothing)
				If flag Then
					Me._Button7.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button6() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button6_Click)
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					Me._Button6.Click -= value2
				End If
				Me._Button6 = value
				flag = (Me._Button6 IsNot Nothing)
				If flag Then
					Me._Button6.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property GroupBox1() As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property RadioButton1() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton1 = value
			End Set
		End Property

		Friend Overridable Property TextBox1() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = New EventHandler(Me.TextBox1_TextChanged)
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					Me._TextBox1.TextChanged -= value2
				End If
				Me._TextBox1 = value
				flag = (Me._TextBox1 IsNot Nothing)
				If flag Then
					Me._TextBox1.TextChanged += value2
				End If
			End Set
		End Property

		Friend Overridable Property RadioButton2() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton2 = value
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

		Friend Overridable Property Button5() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button5_Click)
				Dim flag As Boolean = Me._Button5 IsNot Nothing
				If flag Then
					Me._Button5.Click -= value2
				End If
				Me._Button5 = value
				flag = (Me._Button5 IsNot Nothing)
				If flag Then
					Me._Button5.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button4() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button4_Click)
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					Me._Button4.Click -= value2
				End If
				Me._Button4 = value
				flag = (Me._Button4 IsNot Nothing)
				If flag Then
					Me._Button4.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button3() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button3_Click)
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					Me._Button3.Click -= value2
				End If
				Me._Button3 = value
				flag = (Me._Button3 IsNot Nothing)
				If flag Then
					Me._Button3.Click += value2
				End If
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

		Friend Overridable Property DataGridViewTextBoxColumn15() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn15 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn16() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn16 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn17() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn17 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn18() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn18 = value
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

		Friend Overridable Property DataGridViewTextBoxColumn20() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn20 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn21() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn21 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn22() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn22 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn23() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn23 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn24() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn24 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn19() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn19 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn26() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn26 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn27() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn27 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn28() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn28 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn29() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn29 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn25() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn25 = value
			End Set
		End Property

		Friend Overridable Property ColorDialog1() As ColorDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._ColorDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColorDialog)
				Me._ColorDialog1 = value
			End Set
		End Property

		Friend Overridable Property GroupBox4() As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox4 = value
			End Set
		End Property

		Friend Overridable Property Panel2() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		Public Sub New()
			MyBase.Load += New EventHandler(Me.map_Load)
			map.__ENCAddToList(Me)
			Me.imageName = Application.StartupPath + "\map.jpg"
			Me.i = Image.FromFile(Me.imageName)
			Me.g = Graphics.FromImage(Me.i)
			Me.thepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = map.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = map.__ENCList.Count = map.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = map.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = map.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								map.__ENCList(num) = map.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					map.__ENCList.RemoveRange(num, map.__ENCList.Count - num)
					map.__ENCList.Capacity = map.__ENCList.Count
				End If
				map.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(map))
			Me.Panel1 = New Panel()
			Me.PictureBox1 = New PictureBox()
			Me.GroupBox2 = New GroupBox()
			Me.Button1 = New Button()
			Me.CheckBox4 = New CheckBox()
			Me.CheckBox3 = New CheckBox()
			Me.CheckBox2 = New CheckBox()
			Me.CheckBox1 = New CheckBox()
			Me.GroupBox3 = New GroupBox()
			Me.CheckBox8 = New CheckBox()
			Me.CheckBox7 = New CheckBox()
			Me.Button2 = New Button()
			Me.CheckBox6 = New CheckBox()
			Me.CheckBox5 = New CheckBox()
			Me.DbDataSet = New dbDataSet()
			Me.CordinBindingSource = New BindingSource(Me.components)
			Me.CordinTableAdapter = New cordinTableAdapter()
			Me.TableAdapterManager = New TableAdapterManager()
			Me.FieldTableAdapter = New fieldTableAdapter()
			Me.FlatsTableAdapter = New flatsTableAdapter()
			Me.NpcTableAdapter = New npcTableAdapter()
			Me.CordinDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
			Me.AltcoordBindingSource = New BindingSource(Me.components)
			Me.AltcoordTableAdapter = New altcoordTableAdapter()
			Me.AltcoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn10 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn11 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn12 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
			Me.EnemiescoordBindingSource = New BindingSource(Me.components)
			Me.EnemiescoordTableAdapter = New enemiescoordTableAdapter()
			Me.EnemiescoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn14 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn15 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn16 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn17 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn18 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn13 = New DataGridViewTextBoxColumn()
			Me.FriendscoordBindingSource = New BindingSource(Me.components)
			Me.FriendscoordTableAdapter = New friendscoordTableAdapter()
			Me.FriendscoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn20 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn21 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn22 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn23 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn24 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn19 = New DataGridViewTextBoxColumn()
			Me.NeutralcoordBindingSource = New BindingSource(Me.components)
			Me.NeutralcoordTableAdapter = New neutralcoordTableAdapter()
			Me.NeutralcoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn26 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn27 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn28 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn29 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn25 = New DataGridViewTextBoxColumn()
			Me.FieldBindingSource = New BindingSource(Me.components)
			Me.FieldDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn30 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn31 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn32 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn33 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn34 = New DataGridViewTextBoxColumn()
			Me.FlatsBindingSource = New BindingSource(Me.components)
			Me.FlatsDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn35 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn36 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn37 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn38 = New DataGridViewTextBoxColumn()
			Me.NpcBindingSource = New BindingSource(Me.components)
			Me.NpcDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn39 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn40 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn41 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn42 = New DataGridViewTextBoxColumn()
			Me.Button7 = New Button()
			Me.Button6 = New Button()
			Me.GroupBox1 = New GroupBox()
			Me.RadioButton1 = New RadioButton()
			Me.TextBox1 = New TextBox()
			Me.RadioButton2 = New RadioButton()
			Me.Button5 = New Button()
			Me.Button4 = New Button()
			Me.Button3 = New Button()
			Me.ColorDialog1 = New ColorDialog()
			Me.GroupBox4 = New GroupBox()
			Me.Panel2 = New Panel()
			Me.Panel1.SuspendLayout()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			(CType(Me.DbDataSet, ISupportInitialize)).BeginInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.CordinDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.AltcoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.AltcoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.EnemiescoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.EnemiescoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.FriendscoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.FriendscoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.NeutralcoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.NeutralcoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.FieldBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.FieldDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.FlatsBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.FlatsDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.NpcBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.NpcDataGridView, ISupportInitialize)).BeginInit()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.AutoScroll = True
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Dim arg_613_0 As Control = Me.Panel1
			Dim location As Point = New Point(12, 12)
			arg_613_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_644_0 As Control = Me.Panel1
			Dim size As Size = New Size(803, 807)
			arg_644_0.Size = size
			Me.Panel1.TabIndex = 0
			Me.PictureBox1.Image = Resources.map
			Dim arg_67A_0 As Control = Me.PictureBox1
			location = New Point(0, 0)
			arg_67A_0.Location = location
			Dim arg_69A_0 As Control = Me.PictureBox1
			size = New Size(10000, 10000)
			arg_69A_0.MaximumSize = size
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_6CB_0 As Control = Me.PictureBox1
			size = New Size(800, 800)
			arg_6CB_0.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.GroupBox2.Controls.Add(Me.Button1)
			Me.GroupBox2.Controls.Add(Me.CheckBox4)
			Me.GroupBox2.Controls.Add(Me.CheckBox3)
			Me.GroupBox2.Controls.Add(Me.CheckBox2)
			Me.GroupBox2.Controls.Add(Me.CheckBox1)
			Dim arg_782_0 As Control = Me.GroupBox2
			location = New Point(918, 12)
			arg_782_0.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim arg_7B0_0 As Control = Me.GroupBox2
			size = New Size(164, 100)
			arg_7B0_0.Size = size
			Me.GroupBox2.TabIndex = 9
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "DiploMap"
			Dim arg_7F6_0 As Control = Me.Button1
			location = New Point(40, 67)
			arg_7F6_0.Location = location
			Me.Button1.Name = "Button1"
			Dim arg_821_0 As Control = Me.Button1
			size = New Size(86, 23)
			arg_821_0.Size = size
			Me.Button1.TabIndex = 4
			Me.Button1.Text = "Mark on Map"
			Me.Button1.UseVisualStyleBackColor = True
			Me.CheckBox4.AutoSize = True
			Me.CheckBox4.ForeColor = Color.Silver
			Dim arg_884_0 As Control = Me.CheckBox4
			location = New Point(88, 44)
			arg_884_0.Location = location
			Me.CheckBox4.Name = "CheckBox4"
			Dim arg_8AF_0 As Control = Me.CheckBox4
			size = New Size(60, 17)
			arg_8AF_0.Size = size
			Me.CheckBox4.TabIndex = 3
			Me.CheckBox4.Text = "Neutral"
			Me.CheckBox4.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.ForeColor = Color.Blue
			Dim arg_912_0 As Control = Me.CheckBox3
			location = New Point(88, 20)
			arg_912_0.Location = location
			Me.CheckBox3.Name = "CheckBox3"
			Dim arg_93D_0 As Control = Me.CheckBox3
			size = New Size(60, 17)
			arg_93D_0.Size = size
			Me.CheckBox3.TabIndex = 2
			Me.CheckBox3.Text = "Friends"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.ForeColor = Color.Red
			Dim arg_99F_0 As Control = Me.CheckBox2
			location = New Point(7, 43)
			arg_99F_0.Location = location
			Me.CheckBox2.Name = "CheckBox2"
			Dim arg_9CA_0 As Control = Me.CheckBox2
			size = New Size(66, 17)
			arg_9CA_0.Size = size
			Me.CheckBox2.TabIndex = 1
			Me.CheckBox2.Text = "Enemies"
			Me.CheckBox2.UseVisualStyleBackColor = True
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.ForeColor = Color.Green
			Dim arg_A2C_0 As Control = Me.CheckBox1
			location = New Point(7, 19)
			arg_A2C_0.Location = location
			Me.CheckBox1.Name = "CheckBox1"
			Dim arg_A57_0 As Control = Me.CheckBox1
			size = New Size(41, 17)
			arg_A57_0.Size = size
			Me.CheckBox1.TabIndex = 0
			Me.CheckBox1.Text = "Alt."
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.CheckBox8)
			Me.GroupBox3.Controls.Add(Me.CheckBox7)
			Me.GroupBox3.Controls.Add(Me.Button2)
			Me.GroupBox3.Controls.Add(Me.CheckBox6)
			Me.GroupBox3.Controls.Add(Me.CheckBox5)
			Dim arg_B12_0 As Control = Me.GroupBox3
			location = New Point(1088, 12)
			arg_B12_0.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim arg_B40_0 As Control = Me.GroupBox3
			size = New Size(190, 100)
			arg_B40_0.Size = size
			Me.GroupBox3.TabIndex = 10
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Fields"
			Me.CheckBox8.AutoSize = True
			Me.CheckBox8.Enabled = False
			Dim arg_BA0_0 As Control = Me.CheckBox8
			location = New Point(84, 44)
			arg_BA0_0.Location = location
			Me.CheckBox8.Name = "CheckBox8"
			Dim arg_BCB_0 As Control = Me.CheckBox8
			size = New Size(109, 17)
			arg_BCB_0.Size = size
			Me.CheckBox8.TabIndex = 7
			Me.CheckBox8.Text = "Only 5,10 lvl NPC"
			Me.CheckBox8.UseVisualStyleBackColor = True
			Me.CheckBox7.AutoSize = True
			Me.CheckBox7.Enabled = False
			Dim arg_C2A_0 As Control = Me.CheckBox7
			location = New Point(84, 20)
			arg_C2A_0.Location = location
			Me.CheckBox7.Name = "CheckBox7"
			Dim arg_C55_0 As Control = Me.CheckBox7
			size = New Size(62, 17)
			arg_C55_0.Size = size
			Me.CheckBox7.TabIndex = 6
			Me.CheckBox7.Text = "All NPC"
			Me.CheckBox7.UseVisualStyleBackColor = True
			Dim arg_C9A_0 As Control = Me.Button2
			location = New Point(59, 64)
			arg_C9A_0.Location = location
			Me.Button2.Name = "Button2"
			Dim arg_CC5_0 As Control = Me.Button2
			size = New Size(86, 23)
			arg_CC5_0.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.Text = "Mark on Map"
			Me.Button2.UseVisualStyleBackColor = True
			Me.CheckBox6.AutoSize = True
			Me.CheckBox6.ForeColor = Color.Red
			Dim arg_D27_0 As Control = Me.CheckBox6
			location = New Point(7, 44)
			arg_D27_0.Location = location
			Me.CheckBox6.Name = "CheckBox6"
			Dim arg_D52_0 As Control = Me.CheckBox6
			size = New Size(48, 17)
			arg_D52_0.Size = size
			Me.CheckBox6.TabIndex = 1
			Me.CheckBox6.Text = "Flats"
			Me.CheckBox6.UseVisualStyleBackColor = True
			Me.CheckBox5.AutoSize = True
			Me.CheckBox5.Enabled = False
			Me.CheckBox5.ForeColor = Color.Blue
			Dim arg_DC1_0 As Control = Me.CheckBox5
			location = New Point(7, 20)
			arg_DC1_0.Location = location
			Me.CheckBox5.Name = "CheckBox5"
			Dim arg_DEC_0 As Control = Me.CheckBox5
			size = New Size(53, 17)
			arg_DEC_0.Size = size
			Me.CheckBox5.TabIndex = 0
			Me.CheckBox5.Text = "Fields"
			Me.CheckBox5.UseVisualStyleBackColor = True
			Me.DbDataSet.DataSetName = "dbDataSet"
			Me.DbDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.CordinBindingSource.DataMember = "cordin"
			Me.CordinBindingSource.DataSource = Me.DbDataSet
			Me.CordinTableAdapter.ClearBeforeFill = True
			Me.TableAdapterManager.altTableAdapter = Nothing
			Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
			Me.TableAdapterManager.cordinTableAdapter = Me.CordinTableAdapter
			Me.TableAdapterManager.enemiesTableAdapter = Nothing
			Me.TableAdapterManager.fieldTableAdapter = Me.FieldTableAdapter
			Me.TableAdapterManager.flatsTableAdapter = Me.FlatsTableAdapter
			Me.TableAdapterManager.friendsTableAdapter = Nothing
			Me.TableAdapterManager.heroTableAdapter = Nothing
			Me.TableAdapterManager.huntTableAdapter = Nothing
			Me.TableAdapterManager.neutralTableAdapter = Nothing
			Me.TableAdapterManager.npcTableAdapter = Me.NpcTableAdapter
			Me.TableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
			Me.FieldTableAdapter.ClearBeforeFill = True
			Me.FlatsTableAdapter.ClearBeforeFill = True
			Me.NpcTableAdapter.ClearBeforeFill = True
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
			DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle2.BackColor = SystemColors.Window
			DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
			Me.CordinDataGridView.DefaultCellStyle = DataGridViewCellStyle2
			Dim arg_10B3_0 As Control = Me.CordinDataGridView
			location = New Point(827, 422)
			arg_10B3_0.Location = location
			Me.CordinDataGridView.Name = "CordinDataGridView"
			Dim arg_10E4_0 As Control = Me.CordinDataGridView
			size = New Size(454, 397)
			arg_10E4_0.Size = size
			Me.CordinDataGridView.TabIndex = 11
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
			Me.DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn2.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn2.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
			Me.DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn1.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn1.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
			Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
			Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
			Me.DataGridViewTextBoxColumn6.Visible = False
			Me.AltcoordBindingSource.DataMember = "altcoord"
			Me.AltcoordBindingSource.DataSource = Me.DbDataSet
			Me.AltcoordTableAdapter.ClearBeforeFill = True
			Me.AltcoordDataGridView.AutoGenerateColumns = False
			Me.AltcoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.AltcoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn7 })
			Me.AltcoordDataGridView.DataSource = Me.AltcoordBindingSource
			Dim arg_134D_0 As Control = Me.AltcoordDataGridView
			location = New Point(952, 108)
			arg_134D_0.Location = location
			Me.AltcoordDataGridView.Name = "AltcoordDataGridView"
			Dim arg_1378_0 As Control = Me.AltcoordDataGridView
			size = New Size(70, 64)
			arg_1378_0.Size = size
			Me.AltcoordDataGridView.TabIndex = 11
			Me.AltcoordDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn8.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn8.HeaderText = "player"
			Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
			Me.DataGridViewTextBoxColumn9.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn9.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
			Me.DataGridViewTextBoxColumn10.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn10.HeaderText = "x"
			Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
			Me.DataGridViewTextBoxColumn11.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn11.HeaderText = "y"
			Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
			Me.DataGridViewTextBoxColumn12.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn12.HeaderText = "citie"
			Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
			Me.DataGridViewTextBoxColumn7.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn7.HeaderText = "id"
			Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
			Me.EnemiescoordBindingSource.DataMember = "enemiescoord"
			Me.EnemiescoordBindingSource.DataSource = Me.DbDataSet
			Me.EnemiescoordTableAdapter.ClearBeforeFill = True
			Me.EnemiescoordDataGridView.AutoGenerateColumns = False
			Me.EnemiescoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.EnemiescoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn13 })
			Me.EnemiescoordDataGridView.DataSource = Me.EnemiescoordBindingSource
			Dim arg_159B_0 As Control = Me.EnemiescoordDataGridView
			location = New Point(1182, 108)
			arg_159B_0.Location = location
			Me.EnemiescoordDataGridView.Name = "EnemiescoordDataGridView"
			Dim arg_15C6_0 As Control = Me.EnemiescoordDataGridView
			size = New Size(70, 64)
			arg_15C6_0.Size = size
			Me.EnemiescoordDataGridView.TabIndex = 11
			Me.EnemiescoordDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn14.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn14.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
			Me.DataGridViewTextBoxColumn15.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn15.HeaderText = "player"
			Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
			Me.DataGridViewTextBoxColumn16.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn16.HeaderText = "x"
			Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
			Me.DataGridViewTextBoxColumn17.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn17.HeaderText = "y"
			Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
			Me.DataGridViewTextBoxColumn18.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn18.HeaderText = "citie"
			Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
			Me.DataGridViewTextBoxColumn13.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn13.HeaderText = "id"
			Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
			Me.FriendscoordBindingSource.DataMember = "friendscoord"
			Me.FriendscoordBindingSource.DataSource = Me.DbDataSet
			Me.FriendscoordTableAdapter.ClearBeforeFill = True
			Me.FriendscoordDataGridView.AutoGenerateColumns = False
			Me.FriendscoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.FriendscoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn19 })
			Me.FriendscoordDataGridView.DataSource = Me.FriendscoordBindingSource
			Dim arg_17E9_0 As Control = Me.FriendscoordDataGridView
			location = New Point(1030, 108)
			arg_17E9_0.Location = location
			Me.FriendscoordDataGridView.Name = "FriendscoordDataGridView"
			Dim arg_1814_0 As Control = Me.FriendscoordDataGridView
			size = New Size(70, 64)
			arg_1814_0.Size = size
			Me.FriendscoordDataGridView.TabIndex = 11
			Me.FriendscoordDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn20.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn20.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
			Me.DataGridViewTextBoxColumn21.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn21.HeaderText = "player"
			Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
			Me.DataGridViewTextBoxColumn22.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn22.HeaderText = "x"
			Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
			Me.DataGridViewTextBoxColumn23.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn23.HeaderText = "y"
			Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
			Me.DataGridViewTextBoxColumn24.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn24.HeaderText = "citie"
			Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
			Me.DataGridViewTextBoxColumn19.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn19.HeaderText = "id"
			Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
			Me.NeutralcoordBindingSource.DataMember = "neutralcoord"
			Me.NeutralcoordBindingSource.DataSource = Me.DbDataSet
			Me.NeutralcoordTableAdapter.ClearBeforeFill = True
			Me.NeutralcoordDataGridView.AutoGenerateColumns = False
			Me.NeutralcoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.NeutralcoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn25 })
			Me.NeutralcoordDataGridView.DataSource = Me.NeutralcoordBindingSource
			Dim arg_1A2F_0 As Control = Me.NeutralcoordDataGridView
			location = New Point(1030, 178)
			arg_1A2F_0.Location = location
			Me.NeutralcoordDataGridView.Name = "NeutralcoordDataGridView"
			Dim arg_1A5A_0 As Control = Me.NeutralcoordDataGridView
			size = New Size(70, 64)
			arg_1A5A_0.Size = size
			Me.NeutralcoordDataGridView.TabIndex = 11
			Me.NeutralcoordDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn26.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn26.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
			Me.DataGridViewTextBoxColumn27.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn27.HeaderText = "player"
			Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
			Me.DataGridViewTextBoxColumn28.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn28.HeaderText = "x"
			Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
			Me.DataGridViewTextBoxColumn29.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn29.HeaderText = "y"
			Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
			Me.DataGridViewTextBoxColumn25.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn25.HeaderText = "id"
			Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
			Me.FieldBindingSource.DataMember = "field"
			Me.FieldBindingSource.DataSource = Me.DbDataSet
			Me.FieldDataGridView.AutoGenerateColumns = False
			Me.FieldDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.FieldDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34 })
			Me.FieldDataGridView.DataSource = Me.FieldBindingSource
			Dim arg_1C35_0 As Control = Me.FieldDataGridView
			location = New Point(1106, 178)
			arg_1C35_0.Location = location
			Me.FieldDataGridView.Name = "FieldDataGridView"
			Dim arg_1C60_0 As Control = Me.FieldDataGridView
			size = New Size(70, 64)
			arg_1C60_0.Size = size
			Me.FieldDataGridView.TabIndex = 11
			Me.FieldDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn30.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn30.HeaderText = "x"
			Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
			Me.DataGridViewTextBoxColumn31.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn31.HeaderText = "y"
			Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
			Me.DataGridViewTextBoxColumn32.DataPropertyName = "level"
			Me.DataGridViewTextBoxColumn32.HeaderText = "level"
			Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
			Me.DataGridViewTextBoxColumn33.DataPropertyName = "field"
			Me.DataGridViewTextBoxColumn33.HeaderText = "field"
			Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
			Me.DataGridViewTextBoxColumn34.DataPropertyName = "ID"
			Me.DataGridViewTextBoxColumn34.HeaderText = "ID"
			Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
			Me.FlatsBindingSource.DataMember = "flats"
			Me.FlatsBindingSource.DataSource = Me.DbDataSet
			Me.FlatsDataGridView.AutoGenerateColumns = False
			Me.FlatsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.FlatsDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38 })
			Me.FlatsDataGridView.DataSource = Me.FlatsBindingSource
			Dim arg_1E2D_0 As Control = Me.FlatsDataGridView
			location = New Point(1106, 108)
			arg_1E2D_0.Location = location
			Me.FlatsDataGridView.Name = "FlatsDataGridView"
			Dim arg_1E58_0 As Control = Me.FlatsDataGridView
			size = New Size(70, 64)
			arg_1E58_0.Size = size
			Me.FlatsDataGridView.TabIndex = 11
			Me.FlatsDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn35.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn35.HeaderText = "x"
			Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
			Me.DataGridViewTextBoxColumn36.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn36.HeaderText = "y"
			Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
			Me.DataGridViewTextBoxColumn37.DataPropertyName = "level"
			Me.DataGridViewTextBoxColumn37.HeaderText = "level"
			Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
			Me.DataGridViewTextBoxColumn38.DataPropertyName = "ID"
			Me.DataGridViewTextBoxColumn38.HeaderText = "ID"
			Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
			Me.NpcBindingSource.DataMember = "npc"
			Me.NpcBindingSource.DataSource = Me.DbDataSet
			Me.NpcDataGridView.AutoGenerateColumns = False
			Me.NpcDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.NpcDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42 })
			Me.NpcDataGridView.DataSource = Me.NpcBindingSource
			Dim arg_1FF5_0 As Control = Me.NpcDataGridView
			location = New Point(955, 178)
			arg_1FF5_0.Location = location
			Me.NpcDataGridView.Name = "NpcDataGridView"
			Dim arg_2020_0 As Control = Me.NpcDataGridView
			size = New Size(70, 64)
			arg_2020_0.Size = size
			Me.NpcDataGridView.TabIndex = 11
			Me.NpcDataGridView.Visible = False
			Me.DataGridViewTextBoxColumn39.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn39.HeaderText = "x"
			Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
			Me.DataGridViewTextBoxColumn40.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn40.HeaderText = "y"
			Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
			Me.DataGridViewTextBoxColumn41.DataPropertyName = "level"
			Me.DataGridViewTextBoxColumn41.HeaderText = "level"
			Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
			Me.DataGridViewTextBoxColumn42.DataPropertyName = "ID"
			Me.DataGridViewTextBoxColumn42.HeaderText = "ID"
			Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
			Dim arg_2121_0 As Control = Me.Button7
			location = New Point(50, 36)
			arg_2121_0.Location = location
			Me.Button7.Name = "Button7"
			Dim arg_214C_0 As Control = Me.Button7
			size = New Size(29, 23)
			arg_214C_0.Size = size
			Me.Button7.TabIndex = 18
			Me.Button7.Text = "-"
			Me.Button7.UseVisualStyleBackColor = True
			Dim arg_2191_0 As Control = Me.Button6
			location = New Point(6, 36)
			arg_2191_0.Location = location
			Me.Button6.Name = "Button6"
			Dim arg_21BC_0 As Control = Me.Button6
			size = New Size(27, 23)
			arg_21BC_0.Size = size
			Me.Button6.TabIndex = 17
			Me.Button6.Text = "+"
			Me.Button6.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.RadioButton1)
			Me.GroupBox1.Controls.Add(Me.TextBox1)
			Me.GroupBox1.Controls.Add(Me.RadioButton2)
			Dim arg_224D_0 As Control = Me.GroupBox1
			location = New Point(827, 264)
			arg_224D_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_227E_0 As Control = Me.GroupBox1
			size = New Size(190, 152)
			arg_227E_0.Size = size
			Me.GroupBox1.TabIndex = 19
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Search by"
			Me.RadioButton1.AutoSize = True
			Me.RadioButton1.Checked = True
			Dim arg_22DE_0 As Control = Me.RadioButton1
			location = New Point(26, 31)
			arg_22DE_0.Location = location
			Me.RadioButton1.Name = "RadioButton1"
			Dim arg_2309_0 As Control = Me.RadioButton1
			size = New Size(54, 17)
			arg_2309_0.Size = size
			Me.RadioButton1.TabIndex = 3
			Me.RadioButton1.TabStop = True
			Me.RadioButton1.Text = "Player"
			Me.RadioButton1.UseVisualStyleBackColor = True
			Dim arg_235B_0 As Control = Me.TextBox1
			location = New Point(26, 102)
			arg_235B_0.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim arg_2386_0 As Control = Me.TextBox1
			size = New Size(100, 20)
			arg_2386_0.Size = size
			Me.TextBox1.TabIndex = 5
			Me.RadioButton2.AutoSize = True
			Dim arg_23BA_0 As Control = Me.RadioButton2
			location = New Point(26, 66)
			arg_23BA_0.Location = location
			Me.RadioButton2.Name = "RadioButton2"
			Dim arg_23E5_0 As Control = Me.RadioButton2
			size = New Size(62, 17)
			arg_23E5_0.Size = size
			Me.RadioButton2.TabIndex = 4
			Me.RadioButton2.Text = "Alliance"
			Me.RadioButton2.UseVisualStyleBackColor = True
			Dim arg_2430_0 As Control = Me.Button5
			location = New Point(1090, 324)
			arg_2430_0.Location = location
			Me.Button5.Name = "Button5"
			Dim arg_245B_0 As Control = Me.Button5
			size = New Size(75, 23)
			arg_245B_0.Size = size
			Me.Button5.TabIndex = 22
			Me.Button5.Text = "Save Map"
			Me.Button5.UseVisualStyleBackColor = True
			Dim arg_24A7_0 As Control = Me.Button4
			location = New Point(1145, 295)
			arg_24A7_0.Location = location
			Me.Button4.Name = "Button4"
			Dim arg_24D2_0 As Control = Me.Button4
			size = New Size(75, 23)
			arg_24D2_0.Size = size
			Me.Button4.TabIndex = 21
			Me.Button4.Text = "Clear"
			Me.Button4.UseVisualStyleBackColor = True
			Dim arg_251E_0 As Control = Me.Button3
			location = New Point(1030, 295)
			arg_251E_0.Location = location
			Me.Button3.Name = "Button3"
			Dim arg_2549_0 As Control = Me.Button3
			size = New Size(91, 23)
			arg_2549_0.Size = size
			Me.Button3.TabIndex = 20
			Me.Button3.Text = "Mark on Map"
			Me.Button3.UseVisualStyleBackColor = True
			Me.GroupBox4.Controls.Add(Me.Button6)
			Me.GroupBox4.Controls.Add(Me.Button7)
			Dim arg_25C0_0 As Control = Me.GroupBox4
			location = New Point(821, 12)
			arg_25C0_0.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim arg_25EB_0 As Control = Me.GroupBox4
			size = New Size(91, 100)
			arg_25EB_0.Size = size
			Me.GroupBox4.TabIndex = 23
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Zoom"
			Me.Panel2.AutoScroll = True
			Me.Panel2.Dock = DockStyle.Fill
			Dim arg_2649_0 As Control = Me.Panel2
			location = New Point(0, 0)
			arg_2649_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_267A_0 As Control = Me.Panel2
			size = New Size(1286, 824)
			arg_267A_0.Size = size
			Me.Panel2.TabIndex = 24
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			size = New Size(1286, 824)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox4)
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.NpcDataGridView)
			Me.Controls.Add(Me.FlatsDataGridView)
			Me.Controls.Add(Me.FieldDataGridView)
			Me.Controls.Add(Me.NeutralcoordDataGridView)
			Me.Controls.Add(Me.FriendscoordDataGridView)
			Me.Controls.Add(Me.EnemiescoordDataGridView)
			Me.Controls.Add(Me.AltcoordDataGridView)
			Me.Controls.Add(Me.CordinDataGridView)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Panel2)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
			Me.Name = "map"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "map"
			Me.Panel1.ResumeLayout(False)
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			(CType(Me.DbDataSet, ISupportInitialize)).EndInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.CordinDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.AltcoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.AltcoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.EnemiescoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.EnemiescoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.FriendscoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.FriendscoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.NeutralcoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.NeutralcoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.FieldBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.FieldDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.FlatsBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.FlatsDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.NpcBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.NpcDataGridView, ISupportInitialize)).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub map_Load(sender As Object, e As EventArgs)
			Me.PictureBox1.Image = Image.FromFile(Application.StartupPath + "\map.jpg")
		End Sub

		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.CheckBox1.Checked
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.AltcoordTableAdapter.Fill(Me.DbDataSet.altcoord)
				Dim pen_one As Pen = New Pen(Brushes.Green, 1F)
				Dim arg_51_0 As Integer = 0
				Dim num As Integer = Me.AltcoordDataGridView.Rows.Count - 1
				Dim iRow As Integer = arg_51_0
				While True
					Dim arg_194_0 As Integer = iRow
					Dim num2 As Integer = num
					If arg_194_0 > num2 Then
						Exit While
					End If
					Dim iCol As Integer = 0
					Dim arg_183_0 As Integer
					Do
						flag = (iCol > 0)
						If flag Then
							Dim arg_120_0 As Object = Me.g
							Dim arg_120_1 As Type = Nothing
							Dim arg_120_2 As String = "DrawRectangle"
							Dim array As Object() = New Object(5)
							array(0) = pen_one
							Dim arg_AD_0 As Object() = array
							Dim arg_AD_1 As Integer = 1
							Dim dataGridViewCell As DataGridViewCell = Me.AltcoordDataGridView.Rows(iRow).Cells(2)
							arg_AD_0(arg_AD_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							Dim arg_DC_0 As Object() = array
							Dim arg_DC_1 As Integer = 2
							Dim dataGridViewCell2 As DataGridViewCell = Me.AltcoordDataGridView.Rows(iRow).Cells(3)
							arg_DC_0(arg_DC_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							array(3) = 1
							array(4) = 1
							Dim array2 As Object() = array
							Dim arg_120_3 As Object() = array2
							Dim arg_120_4 As String() = Nothing
							Dim arg_120_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_120_0, arg_120_1, arg_120_2, arg_120_3, arg_120_4, arg_120_5, array3, True)
							If array3(0) Then
								pen_one = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array2(1))
							End If
							If array3(2) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array2(2))
							End If
						End If
						iCol += 1
						arg_183_0 = iCol
						num2 = 1
					Loop While arg_183_0 <= num2
					iRow += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox2.Checked
			If flag Then
				Me.EnemiescoordTableAdapter.Fill(Me.DbDataSet.enemiescoord)
				Dim pen_one2 As Pen = New Pen(Brushes.Red, 1F)
				Dim arg_208_0 As Integer = 0
				Dim num3 As Integer = Me.EnemiescoordDataGridView.Rows.Count - 1
				Dim iRow2 As Integer = arg_208_0
				While True
					Dim arg_356_0 As Integer = iRow2
					Dim num2 As Integer = num3
					If arg_356_0 > num2 Then
						Exit While
					End If
					Dim iCol2 As Integer = 0
					Dim arg_342_0 As Integer
					Do
						flag = (iCol2 > 0)
						If flag Then
							Dim arg_2DC_0 As Object = Me.g
							Dim arg_2DC_1 As Type = Nothing
							Dim arg_2DC_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one2
							Dim arg_268_0 As Object() = array2
							Dim arg_268_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.EnemiescoordDataGridView.Rows(iRow2).Cells(2)
							arg_268_0(arg_268_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_298_0 As Object() = array2
							Dim arg_298_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.EnemiescoordDataGridView.Rows(iRow2).Cells(3)
							arg_298_0(arg_298_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_2DC_3 As Object() = array
							Dim arg_2DC_4 As String() = Nothing
							Dim arg_2DC_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_2DC_0, arg_2DC_1, arg_2DC_2, arg_2DC_3, arg_2DC_4, arg_2DC_5, array3, True)
							If array3(0) Then
								pen_one2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol2 += 1
						arg_342_0 = iCol2
						num2 = 1
					Loop While arg_342_0 <= num2
					iRow2 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox3.Checked
			If flag Then
				Me.FriendscoordTableAdapter.Fill(Me.DbDataSet.friendscoord)
				Dim pen_one3 As Pen = New Pen(Brushes.Blue, 1F)
				Dim arg_3CB_0 As Integer = 0
				Dim num4 As Integer = Me.FriendscoordDataGridView.Rows.Count - 1
				Dim iRow3 As Integer = arg_3CB_0
				While True
					Dim arg_51B_0 As Integer = iRow3
					Dim num2 As Integer = num4
					If arg_51B_0 > num2 Then
						Exit While
					End If
					Dim iCol3 As Integer = 0
					Dim arg_507_0 As Integer
					Do
						flag = (iCol3 > 0)
						If flag Then
							Dim arg_4A0_0 As Object = Me.g
							Dim arg_4A0_1 As Type = Nothing
							Dim arg_4A0_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one3
							Dim arg_42C_0 As Object() = array2
							Dim arg_42C_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.FriendscoordDataGridView.Rows(iRow3).Cells(2)
							arg_42C_0(arg_42C_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_45C_0 As Object() = array2
							Dim arg_45C_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.FriendscoordDataGridView.Rows(iRow3).Cells(3)
							arg_45C_0(arg_45C_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_4A0_3 As Object() = array
							Dim arg_4A0_4 As String() = Nothing
							Dim arg_4A0_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_4A0_0, arg_4A0_1, arg_4A0_2, arg_4A0_3, arg_4A0_4, arg_4A0_5, array3, True)
							If array3(0) Then
								pen_one3 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol3 += 1
						arg_507_0 = iCol3
						num2 = 1
					Loop While arg_507_0 <= num2
					iRow3 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox4.Checked
			If flag Then
				Me.NeutralcoordTableAdapter.Fill(Me.DbDataSet.neutralcoord)
				Dim pen_one4 As Pen = New Pen(Brushes.Gray, 1F)
				Dim arg_590_0 As Integer = 0
				Dim num5 As Integer = Me.NeutralcoordDataGridView.Rows.Count - 1
				Dim iRow4 As Integer = arg_590_0
				While True
					Dim arg_6E0_0 As Integer = iRow4
					Dim num2 As Integer = num5
					If arg_6E0_0 > num2 Then
						Exit While
					End If
					Dim iCol4 As Integer = 0
					Dim arg_6CC_0 As Integer
					Do
						flag = (iCol4 > 0)
						If flag Then
							Dim arg_665_0 As Object = Me.g
							Dim arg_665_1 As Type = Nothing
							Dim arg_665_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one4
							Dim arg_5F1_0 As Object() = array2
							Dim arg_5F1_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.NeutralcoordDataGridView.Rows(iRow4).Cells(2)
							arg_5F1_0(arg_5F1_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_621_0 As Object() = array2
							Dim arg_621_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.NeutralcoordDataGridView.Rows(iRow4).Cells(3)
							arg_621_0(arg_621_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_665_3 As Object() = array
							Dim arg_665_4 As String() = Nothing
							Dim arg_665_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_665_0, arg_665_1, arg_665_2, arg_665_3, arg_665_4, arg_665_5, array3, True)
							If array3(0) Then
								pen_one4 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol4 += 1
						arg_6CC_0 = iCol4
						num2 = 1
					Loop While arg_6CC_0 <= num2
					iRow4 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
		End Sub

		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.CheckBox7.Checked
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.NpcTableAdapter.Fill(Me.DbDataSet.npc)
				Dim pen_one As Pen = New Pen(Brushes.Black, 1F)
				Dim arg_51_0 As Integer = 0
				Dim num As Integer = Me.NpcDataGridView.Rows.Count - 1
				Dim iRow As Integer = arg_51_0
				While True
					Dim arg_194_0 As Integer = iRow
					Dim num2 As Integer = num
					If arg_194_0 > num2 Then
						Exit While
					End If
					Dim iCol As Integer = 0
					Dim arg_183_0 As Integer
					Do
						flag = (iCol > 0)
						If flag Then
							Dim arg_120_0 As Object = Me.g
							Dim arg_120_1 As Type = Nothing
							Dim arg_120_2 As String = "DrawRectangle"
							Dim array As Object() = New Object(5)
							array(0) = pen_one
							Dim arg_AD_0 As Object() = array
							Dim arg_AD_1 As Integer = 1
							Dim dataGridViewCell As DataGridViewCell = Me.NpcDataGridView.Rows(iRow).Cells(0)
							arg_AD_0(arg_AD_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							Dim arg_DC_0 As Object() = array
							Dim arg_DC_1 As Integer = 2
							Dim dataGridViewCell2 As DataGridViewCell = Me.NpcDataGridView.Rows(iRow).Cells(1)
							arg_DC_0(arg_DC_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							array(3) = 1
							array(4) = 1
							Dim array2 As Object() = array
							Dim arg_120_3 As Object() = array2
							Dim arg_120_4 As String() = Nothing
							Dim arg_120_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_120_0, arg_120_1, arg_120_2, arg_120_3, arg_120_4, arg_120_5, array3, True)
							If array3(0) Then
								pen_one = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array2(1))
							End If
							If array3(2) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array2(2))
							End If
						End If
						iCol += 1
						arg_183_0 = iCol
						num2 = 1
					Loop While arg_183_0 <= num2
					iRow += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox5.Checked
			If flag Then
				Me.FieldTableAdapter.Fill(Me.DbDataSet.field)
				Dim pen_one2 As Pen = New Pen(Brushes.Blue, 1F)
				Dim arg_208_0 As Integer = 0
				Dim num3 As Integer = Me.FieldDataGridView.Rows.Count - 1
				Dim iRow2 As Integer = arg_208_0
				While True
					Dim arg_356_0 As Integer = iRow2
					Dim num2 As Integer = num3
					If arg_356_0 > num2 Then
						Exit While
					End If
					Dim iCol2 As Integer = 0
					Dim arg_342_0 As Integer
					Do
						flag = (iCol2 > 0)
						If flag Then
							Dim arg_2DC_0 As Object = Me.g
							Dim arg_2DC_1 As Type = Nothing
							Dim arg_2DC_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one2
							Dim arg_268_0 As Object() = array2
							Dim arg_268_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.FieldDataGridView.Rows(iRow2).Cells(0)
							arg_268_0(arg_268_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_298_0 As Object() = array2
							Dim arg_298_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.FieldDataGridView.Rows(iRow2).Cells(1)
							arg_298_0(arg_298_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_2DC_3 As Object() = array
							Dim arg_2DC_4 As String() = Nothing
							Dim arg_2DC_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_2DC_0, arg_2DC_1, arg_2DC_2, arg_2DC_3, arg_2DC_4, arg_2DC_5, array3, True)
							If array3(0) Then
								pen_one2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol2 += 1
						arg_342_0 = iCol2
						num2 = 1
					Loop While arg_342_0 <= num2
					iRow2 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox6.Checked
			If flag Then
				Me.FlatsTableAdapter.Fill(Me.DbDataSet.flats)
				Dim pen_one3 As Pen = New Pen(Brushes.Red, 1F)
				Dim arg_3CB_0 As Integer = 0
				Dim num4 As Integer = Me.FlatsDataGridView.Rows.Count - 1
				Dim iRow3 As Integer = arg_3CB_0
				While True
					Dim arg_51B_0 As Integer = iRow3
					Dim num2 As Integer = num4
					If arg_51B_0 > num2 Then
						Exit While
					End If
					Dim iCol3 As Integer = 0
					Dim arg_507_0 As Integer
					Do
						flag = (iCol3 > 0)
						If flag Then
							Dim arg_4A0_0 As Object = Me.g
							Dim arg_4A0_1 As Type = Nothing
							Dim arg_4A0_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one3
							Dim arg_42C_0 As Object() = array2
							Dim arg_42C_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.FlatsDataGridView.Rows(iRow3).Cells(0)
							arg_42C_0(arg_42C_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_45C_0 As Object() = array2
							Dim arg_45C_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.FlatsDataGridView.Rows(iRow3).Cells(1)
							arg_45C_0(arg_45C_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_4A0_3 As Object() = array
							Dim arg_4A0_4 As String() = Nothing
							Dim arg_4A0_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_4A0_0, arg_4A0_1, arg_4A0_2, arg_4A0_3, arg_4A0_4, arg_4A0_5, array3, True)
							If array3(0) Then
								pen_one3 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol3 += 1
						arg_507_0 = iCol3
						num2 = 1
					Loop While arg_507_0 <= num2
					iRow3 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
			flag = Me.CheckBox8.Checked
			If flag Then
				Dim pen_one4 As Pen = New Pen(Brushes.Black, 1F)
				Dim arg_579_0 As Integer = 0
				Dim num5 As Integer = Me.NpcDataGridView.Rows.Count - 1
				Dim iRow4 As Integer = arg_579_0
				While True
					Dim arg_6C9_0 As Integer = iRow4
					Dim num2 As Integer = num5
					If arg_6C9_0 > num2 Then
						Exit While
					End If
					Dim iCol4 As Integer = 0
					Dim arg_6B5_0 As Integer
					Do
						flag = (iCol4 > 0)
						If flag Then
							Dim arg_64E_0 As Object = Me.g
							Dim arg_64E_1 As Type = Nothing
							Dim arg_64E_2 As String = "DrawRectangle"
							Dim array2 As Object() = New Object(5)
							array2(0) = pen_one4
							Dim arg_5DA_0 As Object() = array2
							Dim arg_5DA_1 As Integer = 1
							Dim dataGridViewCell2 As DataGridViewCell = Me.NpcDataGridView.Rows(iRow4).Cells(0)
							arg_5DA_0(arg_5DA_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							Dim arg_60A_0 As Object() = array2
							Dim arg_60A_1 As Integer = 2
							Dim dataGridViewCell As DataGridViewCell = Me.NpcDataGridView.Rows(iRow4).Cells(1)
							arg_60A_0(arg_60A_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							array2(3) = 1
							array2(4) = 1
							Dim array As Object() = array2
							Dim arg_64E_3 As Object() = array
							Dim arg_64E_4 As String() = Nothing
							Dim arg_64E_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_64E_0, arg_64E_1, arg_64E_2, arg_64E_3, arg_64E_4, arg_64E_5, array3, True)
							If array3(0) Then
								pen_one4 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array(1))
							End If
							If array3(2) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array(2))
							End If
						End If
						iCol4 += 1
						arg_6B5_0 = iCol4
						num2 = 1
					Loop While arg_6B5_0 <= num2
					iRow4 += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
		End Sub

		Private Sub CordinBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.CordinBindingSource.EndEdit()
			Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
		End Sub

		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.RadioButton1.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchplayer(Me.DbDataSet.cordin, Me.TextBox1.Text)
				Catch expr_35 As Exception
					ProjectData.SetProjectError(expr_35)
					Dim ex As Exception = expr_35
					MessageBox.Show(ex.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton2.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchalliance(Me.DbDataSet.cordin, Me.TextBox1.Text)
				Catch expr_86 As Exception
					ProjectData.SetProjectError(expr_86)
					Dim ex2 As Exception = expr_86
					MessageBox.Show(ex2.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
		End Sub

		Private Sub CordinDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		End Sub

		Private Sub CordinDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.CordinDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.CordinDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.ColorDialog1.ShowDialog()
			Dim flag As Boolean = Me.ColorDialog1.ShowDialog() = DialogResult.OK
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim pen_one As Pen = New Pen(Me.ColorDialog1.Color, 1F)
				Dim arg_4E_0 As Integer = 0
				Dim num As Integer = Me.CordinDataGridView.Rows.Count - 1
				Dim iRow As Integer = arg_4E_0
				While True
					Dim arg_190_0 As Integer = iRow
					Dim num2 As Integer = num
					If arg_190_0 > num2 Then
						Exit While
					End If
					Dim iCol As Integer = 0
					Dim arg_180_0 As Integer
					Do
						flag = (iCol > 0)
						If flag Then
							Dim arg_11D_0 As Object = Me.g
							Dim arg_11D_1 As Type = Nothing
							Dim arg_11D_2 As String = "DrawRectangle"
							Dim array As Object() = New Object(5)
							array(0) = pen_one
							Dim arg_AA_0 As Object() = array
							Dim arg_AA_1 As Integer = 1
							Dim dataGridViewCell As DataGridViewCell = Me.CordinDataGridView.Rows(iRow).Cells(0)
							arg_AA_0(arg_AA_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
							Dim arg_D9_0 As Object() = array
							Dim arg_D9_1 As Integer = 2
							Dim dataGridViewCell2 As DataGridViewCell = Me.CordinDataGridView.Rows(iRow).Cells(1)
							arg_D9_0(arg_D9_1) = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value)
							array(3) = 1
							array(4) = 1
							Dim array2 As Object() = array
							Dim arg_11D_3 As Object() = array2
							Dim arg_11D_4 As String() = Nothing
							Dim arg_11D_5 As Type() = Nothing
							Dim array3 As Boolean() = New Boolean()() = { True, True, True, False, False }
							NewLateBinding.LateCall(arg_11D_0, arg_11D_1, arg_11D_2, arg_11D_3, arg_11D_4, arg_11D_5, array3, True)
							If array3(0) Then
								pen_one = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Pen)), Pen)
							End If
							If array3(1) Then
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array2(1))
							End If
							If array3(2) Then
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array2(2))
							End If
						End If
						iCol += 1
						arg_180_0 = iCol
						num2 = 1
					Loop While arg_180_0 <= num2
					iRow += 1
				End While
				Me.PictureBox1.Image = Me.i
				Me.PictureBox1.Refresh()
			End If
		End Sub

		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.PictureBox1.Image = Image.FromFile(Application.StartupPath + "\map.jpg")
			Me.i.Dispose()
			Me.g.Dispose()
			Me.i = Image.FromFile(Me.imageName)
			Me.g = Graphics.FromImage(Me.i)
		End Sub

		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.i.Save(Me.thepath + "\" + Me.TextBox1.Text + ".jpg", ImageFormat.Jpeg)
		End Sub

		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = Me.PictureBox1
			' The following expression was wrapped in a checked-statement
			pictureBox.Width += 200
			pictureBox = Me.PictureBox1
			pictureBox.Height += 200
		End Sub

		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = Me.PictureBox1
			' The following expression was wrapped in a checked-statement
			pictureBox.Width -= 200
			pictureBox = Me.PictureBox1
			pictureBox.Height -= 200
		End Sub
	End Class
End Namespace
