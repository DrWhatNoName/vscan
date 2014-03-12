Imports AxShockwaveFlashObjects
Imports Manco.Licensing
Imports Manco.Licensing.Validation
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.PowerPacks
Imports SkinSoft.VisualStyler
Imports SkinSoft.VisualStyler.Licensing
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Xml
Imports vscan.dbDataSetTableAdapters

Namespace vscan
	<DesignerGenerated()>
	Public Class Vscaner
		Inherits Form
		Implements ILicenseKeyProvider

		<CompilerGenerated()>
		Friend Class _Closure$__1
			Public $VB$Local_customerInfo As String

			Public $VB$Me As Vscaner

			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			<DebuggerNonUserCode()>
			Public Sub New(other As Vscaner._Closure$__1)
				Dim flag As Boolean = other IsNot Nothing
				If flag Then
					Me.$VB$Local_customerInfo = other.$VB$Local_customerInfo
					Me.$VB$Me = other.$VB$Me
				End If
			End Sub

			<CompilerGenerated()>
			Public Sub _Lambda$__2(customerTask As Task(Of String))
				Me.$VB$Local_customerInfo = customerTask.Result
				Dim flag As Boolean = Not String.IsNullOrEmpty(Me.$VB$Local_customerInfo)
				If flag Then
					Me.$VB$Me.license.SetCustomValue("CustomerInfo", Me.$VB$Local_customerInfo)
				End If
				Me.$VB$Me.InitializeUi()
			End Sub
		End Class

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private components As IContainer

		<AccessedThroughProperty("VisualStyler1")>
		Private _VisualStyler1 As VisualStyler

		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		<AccessedThroughProperty("TextBox7")>
		Private _TextBox7 As TextBox

		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("AxShockwaveFlash1")>
		Private _AxShockwaveFlash1 As AxShockwaveFlash

		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("TextBox9")>
		Private _TextBox9 As TextBox

		<AccessedThroughProperty("RadioButton4")>
		Private _RadioButton4 As RadioButton

		<AccessedThroughProperty("RadioButton3")>
		Private _RadioButton3 As RadioButton

		<AccessedThroughProperty("RadioButton2")>
		Private _RadioButton2 As RadioButton

		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		<AccessedThroughProperty("TextBox8")>
		Private _TextBox8 As TextBox

		<AccessedThroughProperty("RadioButton7")>
		Private _RadioButton7 As RadioButton

		<AccessedThroughProperty("RadioButton6")>
		Private _RadioButton6 As RadioButton

		<AccessedThroughProperty("RadioButton5")>
		Private _RadioButton5 As RadioButton

		<AccessedThroughProperty("TabPage4")>
		Private _TabPage4 As TabPage

		<AccessedThroughProperty("TabControl2")>
		Private _TabControl2 As TabControl

		<AccessedThroughProperty("TabPage5")>
		Private _TabPage5 As TabPage

		<AccessedThroughProperty("TabPage6")>
		Private _TabPage6 As TabPage

		<AccessedThroughProperty("TabPage7")>
		Private _TabPage7 As TabPage

		<AccessedThroughProperty("TabPage8")>
		Private _TabPage8 As TabPage

		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		<AccessedThroughProperty("Label20")>
		Private _Label20 As Label

		<AccessedThroughProperty("Label19")>
		Private _Label19 As Label

		<AccessedThroughProperty("Label18")>
		Private _Label18 As Label

		<AccessedThroughProperty("Label17")>
		Private _Label17 As Label

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		<AccessedThroughProperty("CordinBindingSource")>
		Private _CordinBindingSource As BindingSource

		<AccessedThroughProperty("DbDataSet")>
		Private _DbDataSet As dbDataSet

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

		<AccessedThroughProperty("DataGridViewTextBoxColumn9")>
		Private _DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn10")>
		Private _DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn11")>
		Private _DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn12")>
		Private _DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn13")>
		Private _DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn14")>
		Private _DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		<AccessedThroughProperty("AltBindingSource")>
		Private _AltBindingSource As BindingSource

		<AccessedThroughProperty("AltTableAdapter")>
		Private _AltTableAdapter As altTableAdapter

		<AccessedThroughProperty("AltDataGridView")>
		Private _AltDataGridView As DataGridView

		<AccessedThroughProperty("AltcoordBindingSource")>
		Private _AltcoordBindingSource As BindingSource

		<AccessedThroughProperty("AltcoordTableAdapter")>
		Private _AltcoordTableAdapter As altcoordTableAdapter

		<AccessedThroughProperty("AltcoordDataGridView")>
		Private _AltcoordDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn23")>
		Private _DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn24")>
		Private _DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn25")>
		Private _DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn21")>
		Private _DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn22")>
		Private _DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn20")>
		Private _DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn17")>
		Private _DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn16")>
		Private _DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn18")>
		Private _DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn19")>
		Private _DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn15")>
		Private _DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("Button11")>
		Private _Button11 As Button

		<AccessedThroughProperty("Button10")>
		Private _Button10 As Button

		<AccessedThroughProperty("FriendsBindingSource")>
		Private _FriendsBindingSource As BindingSource

		<AccessedThroughProperty("FriendsTableAdapter")>
		Private _FriendsTableAdapter As friendsTableAdapter

		<AccessedThroughProperty("FriendsDataGridView")>
		Private _FriendsDataGridView As DataGridView

		<AccessedThroughProperty("FriendscoordBindingSource")>
		Private _FriendscoordBindingSource As BindingSource

		<AccessedThroughProperty("FriendscoordTableAdapter")>
		Private _FriendscoordTableAdapter As friendscoordTableAdapter

		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		<AccessedThroughProperty("FriendscoordDataGridView")>
		Private _FriendscoordDataGridView As DataGridView

		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		<AccessedThroughProperty("DataGridViewTextBoxColumn32")>
		Private _DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn33")>
		Private _DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn36")>
		Private _DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn34")>
		Private _DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn35")>
		Private _DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn31")>
		Private _DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn27")>
		Private _DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn28")>
		Private _DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn29")>
		Private _DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn30")>
		Private _DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn26")>
		Private _DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("EnemiesBindingSource")>
		Private _EnemiesBindingSource As BindingSource

		<AccessedThroughProperty("EnemiesTableAdapter")>
		Private _EnemiesTableAdapter As enemiesTableAdapter

		<AccessedThroughProperty("EnemiesDataGridView")>
		Private _EnemiesDataGridView As DataGridView

		<AccessedThroughProperty("EnemiescoordBindingSource")>
		Private _EnemiescoordBindingSource As BindingSource

		<AccessedThroughProperty("EnemiescoordTableAdapter")>
		Private _EnemiescoordTableAdapter As enemiescoordTableAdapter

		<AccessedThroughProperty("EnemiescoordDataGridView")>
		Private _EnemiescoordDataGridView As DataGridView

		<AccessedThroughProperty("NeutralcoordBindingSource")>
		Private _NeutralcoordBindingSource As BindingSource

		<AccessedThroughProperty("NeutralcoordTableAdapter")>
		Private _NeutralcoordTableAdapter As neutralcoordTableAdapter

		<AccessedThroughProperty("NeutralcoordDataGridView")>
		Private _NeutralcoordDataGridView As DataGridView

		<AccessedThroughProperty("NeutralBindingSource")>
		Private _NeutralBindingSource As BindingSource

		<AccessedThroughProperty("NeutralTableAdapter")>
		Private _NeutralTableAdapter As neutralTableAdapter

		<AccessedThroughProperty("NeutralDataGridView")>
		Private _NeutralDataGridView As DataGridView

		<AccessedThroughProperty("DataGridViewTextBoxColumn43")>
		Private _DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn44")>
		Private _DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn47")>
		Private _DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn45")>
		Private _DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn46")>
		Private _DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn42")>
		Private _DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn38")>
		Private _DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn39")>
		Private _DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn40")>
		Private _DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn41")>
		Private _DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn37")>
		Private _DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn54")>
		Private _DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn55")>
		Private _DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn56")>
		Private _DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn57")>
		Private _DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn53")>
		Private _DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn49")>
		Private _DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn50")>
		Private _DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn51")>
		Private _DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn52")>
		Private _DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn48")>
		Private _DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("ShapeContainer1")>
		Private _ShapeContainer1 As ShapeContainer

		<AccessedThroughProperty("RectangleShape1")>
		Private _RectangleShape1 As RectangleShape

		<AccessedThroughProperty("BuyLicenseToolStripMenuItem")>
		Private _BuyLicenseToolStripMenuItem As ToolStripMenuItem

		Friend Shared AwsUri As String = "http://www.mygameaid.com/activationservice/activationservice.asmx"

		Private license As Manco.Licensing.License

		Private licenseState As ILicenseState

		Private licenseProperties As ILicenseProperties

		Private helper As AwsHelper

		Friend Overridable Property VisualStyler1() As VisualStyler
			<DebuggerNonUserCode()>
			Get
				Return Me._VisualStyler1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As VisualStyler)
				Me._VisualStyler1 = value
			End Set
		End Property

		Friend Overridable Property TabControl1() As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		Friend Overridable Property TabPage1() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		Friend Overridable Property Label8() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = New EventHandler(Me.Label8_TextChanged)
				Dim flag As Boolean = Me._Label8 IsNot Nothing
				If flag Then
					Me._Label8.TextChanged -= value2
				End If
				Me._Label8 = value
				flag = (Me._Label8 IsNot Nothing)
				If flag Then
					Me._Label8.TextChanged += value2
				End If
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = New EventHandler(Me.Label7_TextChanged)
				Dim flag As Boolean = Me._Label7 IsNot Nothing
				If flag Then
					Me._Label7.TextChanged -= value2
				End If
				Me._Label7 = value
				flag = (Me._Label7 IsNot Nothing)
				If flag Then
					Me._Label7.TextChanged += value2
				End If
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

		Friend Overridable Property TextBox5() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		Friend Overridable Property TextBox6() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox6 = value
			End Set
		End Property

		Friend Overridable Property TextBox7() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox7 = value
			End Set
		End Property

		Friend Overridable Property TextBox4() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = New EventHandler(Me.TextBox4_TextChanged)
				Dim flag As Boolean = Me._TextBox4 IsNot Nothing
				If flag Then
					Me._TextBox4.TextChanged -= value2
				End If
				Me._TextBox4 = value
				flag = (Me._TextBox4 IsNot Nothing)
				If flag Then
					Me._TextBox4.TextChanged += value2
				End If
			End Set
		End Property

		Friend Overridable Property TextBox3() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = New EventHandler(Me.TextBox3_TextChanged)
				Dim flag As Boolean = Me._TextBox3 IsNot Nothing
				If flag Then
					Me._TextBox3.TextChanged -= value2
				End If
				Me._TextBox3 = value
				flag = (Me._TextBox3 IsNot Nothing)
				If flag Then
					Me._TextBox3.TextChanged += value2
				End If
			End Set
		End Property

		Friend Overridable Property TextBox2() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = New EventHandler(Me.TextBox2_TextChanged)
				Dim flag As Boolean = Me._TextBox2 IsNot Nothing
				If flag Then
					Me._TextBox2.TextChanged -= value2
				End If
				Me._TextBox2 = value
				flag = (Me._TextBox2 IsNot Nothing)
				If flag Then
					Me._TextBox2.TextChanged += value2
				End If
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
				Dim value2 As EventHandler = New EventHandler(Me.TextBox1_DoubleClick)
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					Me._TextBox1.DoubleClick -= value2
				End If
				Me._TextBox1 = value
				flag = (Me._TextBox1 IsNot Nothing)
				If flag Then
					Me._TextBox1.DoubleClick += value2
				End If
			End Set
		End Property

		Friend Overridable Property AxShockwaveFlash1() As AxShockwaveFlash
			<DebuggerNonUserCode()>
			Get
				Return Me._AxShockwaveFlash1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxShockwaveFlash)
				Dim value2 As _IShockwaveFlashEvents_FSCommandEventHandler = New _IShockwaveFlashEvents_FSCommandEventHandler(Me.AxShockwaveFlash1_FSCommand)
				Dim flag As Boolean = Me._AxShockwaveFlash1 IsNot Nothing
				If flag Then
					Me._AxShockwaveFlash1.FSCommand -= value2
				End If
				Me._AxShockwaveFlash1 = value
				flag = (Me._AxShockwaveFlash1 IsNot Nothing)
				If flag Then
					Me._AxShockwaveFlash1.FSCommand += value2
				End If
			End Set
		End Property

		Friend Overridable Property TabPage2() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		Friend Overridable Property TabPage3() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		Friend Overridable Property MenuStrip1() As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		Friend Overridable Property HelpToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._HelpToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._HelpToolStripMenuItem = value
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

		Friend Overridable Property TextBox9() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = New EventHandler(Me.TextBox9_TextChanged)
				Dim flag As Boolean = Me._TextBox9 IsNot Nothing
				If flag Then
					Me._TextBox9.TextChanged -= value2
				End If
				Me._TextBox9 = value
				flag = (Me._TextBox9 IsNot Nothing)
				If flag Then
					Me._TextBox9.TextChanged += value2
				End If
			End Set
		End Property

		Friend Overridable Property RadioButton4() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton4 = value
			End Set
		End Property

		Friend Overridable Property RadioButton3() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton3 = value
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

		Friend Overridable Property TextBox8() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox8 = value
			End Set
		End Property

		Friend Overridable Property RadioButton7() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton7 = value
			End Set
		End Property

		Friend Overridable Property RadioButton6() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton6 = value
			End Set
		End Property

		Friend Overridable Property RadioButton5() As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton5 = value
			End Set
		End Property

		Friend Overridable Property TabPage4() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage4 = value
			End Set
		End Property

		Friend Overridable Property TabControl2() As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl2 = value
			End Set
		End Property

		Friend Overridable Property TabPage5() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage5 = value
			End Set
		End Property

		Friend Overridable Property TabPage6() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage6 = value
			End Set
		End Property

		Friend Overridable Property TabPage7() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage7 = value
			End Set
		End Property

		Friend Overridable Property TabPage8() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage8 = value
			End Set
		End Property

		Friend Overridable Property Label14() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label14 = value
			End Set
		End Property

		Friend Overridable Property Label13() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label13 = value
			End Set
		End Property

		Friend Overridable Property Label12() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label12 = value
			End Set
		End Property

		Friend Overridable Property Label11() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		Friend Overridable Property Label9() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		Friend Overridable Property Label10() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		Friend Overridable Property Label16() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label16 = value
			End Set
		End Property

		Friend Overridable Property Label15() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label15 = value
			End Set
		End Property

		Friend Overridable Property ProgressBar1() As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		Friend Overridable Property Label20() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label20 = value
			End Set
		End Property

		Friend Overridable Property Label19() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label19 = value
			End Set
		End Property

		Friend Overridable Property Label18() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label18 = value
			End Set
		End Property

		Friend Overridable Property Label17() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label17 = value
			End Set
		End Property

		Friend Overridable Property Timer1() As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Me._Timer1 = value
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
				Dim flag As Boolean = Me._Hero_allianceDataGridView IsNot Nothing
				If flag Then
					Me._Hero_allianceDataGridView.CellFormatting -= value2
				End If
				Me._Hero_allianceDataGridView = value
				flag = (Me._Hero_allianceDataGridView IsNot Nothing)
				If flag Then
					Me._Hero_allianceDataGridView.CellFormatting += value2
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

		Friend Overridable Property Button8() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button8_Click)
				Dim flag As Boolean = Me._Button8 IsNot Nothing
				If flag Then
					Me._Button8.Click -= value2
				End If
				Me._Button8 = value
				flag = (Me._Button8 IsNot Nothing)
				If flag Then
					Me._Button8.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button9() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button9_Click)
				Dim flag As Boolean = Me._Button9 IsNot Nothing
				If flag Then
					Me._Button9.Click -= value2
				End If
				Me._Button9 = value
				flag = (Me._Button9 IsNot Nothing)
				If flag Then
					Me._Button9.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property AltBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._AltBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._AltBindingSource = value
			End Set
		End Property

		Friend Overridable Property AltTableAdapter() As altTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._AltTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As altTableAdapter)
				Me._AltTableAdapter = value
			End Set
		End Property

		Friend Overridable Property AltDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._AltDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.AltDataGridView_CellFormatting)
				Dim flag As Boolean = Me._AltDataGridView IsNot Nothing
				If flag Then
					Me._AltDataGridView.CellFormatting -= value2
				End If
				Me._AltDataGridView = value
				flag = (Me._AltDataGridView IsNot Nothing)
				If flag Then
					Me._AltDataGridView.CellFormatting += value2
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
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.AltcoordDataGridView_CellFormatting)
				Dim flag As Boolean = Me._AltcoordDataGridView IsNot Nothing
				If flag Then
					Me._AltcoordDataGridView.CellFormatting -= value2
				End If
				Me._AltcoordDataGridView = value
				flag = (Me._AltcoordDataGridView IsNot Nothing)
				If flag Then
					Me._AltcoordDataGridView.CellFormatting += value2
				End If
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

		Friend Overridable Property Button11() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button11_Click)
				Dim flag As Boolean = Me._Button11 IsNot Nothing
				If flag Then
					Me._Button11.Click -= value2
				End If
				Me._Button11 = value
				flag = (Me._Button11 IsNot Nothing)
				If flag Then
					Me._Button11.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button10() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button10_Click)
				Dim flag As Boolean = Me._Button10 IsNot Nothing
				If flag Then
					Me._Button10.Click -= value2
				End If
				Me._Button10 = value
				flag = (Me._Button10 IsNot Nothing)
				If flag Then
					Me._Button10.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property FriendsBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendsBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._FriendsBindingSource = value
			End Set
		End Property

		Friend Overridable Property FriendsTableAdapter() As friendsTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendsTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As friendsTableAdapter)
				Me._FriendsTableAdapter = value
			End Set
		End Property

		Friend Overridable Property FriendsDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._FriendsDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.FriendsDataGridView_CellFormatting)
				Dim flag As Boolean = Me._FriendsDataGridView IsNot Nothing
				If flag Then
					Me._FriendsDataGridView.CellFormatting -= value2
				End If
				Me._FriendsDataGridView = value
				flag = (Me._FriendsDataGridView IsNot Nothing)
				If flag Then
					Me._FriendsDataGridView.CellFormatting += value2
				End If
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

		Friend Overridable Property Button12() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button12_Click)
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					Me._Button12.Click -= value2
				End If
				Me._Button12 = value
				flag = (Me._Button12 IsNot Nothing)
				If flag Then
					Me._Button12.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button13() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button13_Click)
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					Me._Button13.Click -= value2
				End If
				Me._Button13 = value
				flag = (Me._Button13 IsNot Nothing)
				If flag Then
					Me._Button13.Click += value2
				End If
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
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.FriendscoordDataGridView_CellFormatting)
				Dim flag As Boolean = Me._FriendscoordDataGridView IsNot Nothing
				If flag Then
					Me._FriendscoordDataGridView.CellFormatting -= value2
				End If
				Me._FriendscoordDataGridView = value
				flag = (Me._FriendscoordDataGridView IsNot Nothing)
				If flag Then
					Me._FriendscoordDataGridView.CellFormatting += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button14() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button14_Click)
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					Me._Button14.Click -= value2
				End If
				Me._Button14 = value
				flag = (Me._Button14 IsNot Nothing)
				If flag Then
					Me._Button14.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button15() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button15_Click)
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					Me._Button15.Click -= value2
				End If
				Me._Button15 = value
				flag = (Me._Button15 IsNot Nothing)
				If flag Then
					Me._Button15.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button16() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button16_Click)
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					Me._Button16.Click -= value2
				End If
				Me._Button16 = value
				flag = (Me._Button16 IsNot Nothing)
				If flag Then
					Me._Button16.Click += value2
				End If
			End Set
		End Property

		Friend Overridable Property Button17() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.Button17_Click)
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					Me._Button17.Click -= value2
				End If
				Me._Button17 = value
				flag = (Me._Button17 IsNot Nothing)
				If flag Then
					Me._Button17.Click += value2
				End If
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

		Friend Overridable Property EnemiesBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiesBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._EnemiesBindingSource = value
			End Set
		End Property

		Friend Overridable Property EnemiesTableAdapter() As enemiesTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiesTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As enemiesTableAdapter)
				Me._EnemiesTableAdapter = value
			End Set
		End Property

		Friend Overridable Property EnemiesDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._EnemiesDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.EnemiesDataGridView_CellFormatting)
				Dim flag As Boolean = Me._EnemiesDataGridView IsNot Nothing
				If flag Then
					Me._EnemiesDataGridView.CellFormatting -= value2
				End If
				Me._EnemiesDataGridView = value
				flag = (Me._EnemiesDataGridView IsNot Nothing)
				If flag Then
					Me._EnemiesDataGridView.CellFormatting += value2
				End If
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
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.EnemiescoordDataGridView_CellFormatting)
				Dim flag As Boolean = Me._EnemiescoordDataGridView IsNot Nothing
				If flag Then
					Me._EnemiescoordDataGridView.CellFormatting -= value2
				End If
				Me._EnemiescoordDataGridView = value
				flag = (Me._EnemiescoordDataGridView IsNot Nothing)
				If flag Then
					Me._EnemiescoordDataGridView.CellFormatting += value2
				End If
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
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.NeutralcoordDataGridView_CellFormatting)
				Dim flag As Boolean = Me._NeutralcoordDataGridView IsNot Nothing
				If flag Then
					Me._NeutralcoordDataGridView.CellFormatting -= value2
				End If
				Me._NeutralcoordDataGridView = value
				flag = (Me._NeutralcoordDataGridView IsNot Nothing)
				If flag Then
					Me._NeutralcoordDataGridView.CellFormatting += value2
				End If
			End Set
		End Property

		Friend Overridable Property NeutralBindingSource() As BindingSource
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralBindingSource
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Me._NeutralBindingSource = value
			End Set
		End Property

		Friend Overridable Property NeutralTableAdapter() As neutralTableAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralTableAdapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As neutralTableAdapter)
				Me._NeutralTableAdapter = value
			End Set
		End Property

		Friend Overridable Property NeutralDataGridView() As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._NeutralDataGridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellFormattingEventHandler = New DataGridViewCellFormattingEventHandler(Me.NeutralDataGridView_CellFormatting)
				Dim flag As Boolean = Me._NeutralDataGridView IsNot Nothing
				If flag Then
					Me._NeutralDataGridView.CellFormatting -= value2
				End If
				Me._NeutralDataGridView = value
				flag = (Me._NeutralDataGridView IsNot Nothing)
				If flag Then
					Me._NeutralDataGridView.CellFormatting += value2
				End If
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn43() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn43
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn43 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn44() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn44
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn44 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn47() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn47
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn47 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn45() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn45
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn45 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn46() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn46
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn46 = value
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

		Friend Overridable Property DataGridViewTextBoxColumn54() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn54
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn54 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn55() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn55
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn55 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn56() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn56
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn56 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn57() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn57
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn57 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn53() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn53
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn53 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn49() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn49
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn49 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn50() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn50
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn50 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn51() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn51
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn51 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn52() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn52
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn52 = value
			End Set
		End Property

		Friend Overridable Property DataGridViewTextBoxColumn48() As DataGridViewTextBoxColumn
			<DebuggerNonUserCode()>
			Get
				Return Me._DataGridViewTextBoxColumn48
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridViewTextBoxColumn)
				Me._DataGridViewTextBoxColumn48 = value
			End Set
		End Property

		Friend Overridable Property ShapeContainer1() As ShapeContainer
			<DebuggerNonUserCode()>
			Get
				Return Me._ShapeContainer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ShapeContainer)
				Me._ShapeContainer1 = value
			End Set
		End Property

		Friend Overridable Property RectangleShape1() As RectangleShape
			<DebuggerNonUserCode()>
			Get
				Return Me._RectangleShape1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RectangleShape)
				Me._RectangleShape1 = value
			End Set
		End Property

		Friend Overridable Property BuyLicenseToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._BuyLicenseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = New EventHandler(Me.BuyLicenseToolStripMenuItem_Click)
				Dim flag As Boolean = Me._BuyLicenseToolStripMenuItem IsNot Nothing
				If flag Then
					Me._BuyLicenseToolStripMenuItem.Click -= value2
				End If
				Me._BuyLicenseToolStripMenuItem = value
				flag = (Me._BuyLicenseToolStripMenuItem IsNot Nothing)
				If flag Then
					Me._BuyLicenseToolStripMenuItem.Click += value2
				End If
			End Set
		End Property

		Public ReadOnly Property BaseContainerName() As String
			Get
				Return""
			End Get
		End Property

		Public ReadOnly Property BypassExpirationCheck() As Boolean
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property BypassSignatureForEmbedded() As Boolean
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property DoLoadLicense() As Boolean
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property EmbeddedLicenseAssembly() As Assembly
			Get
				Return Nothing
			End Get
		End Property

		Public ReadOnly Property EmbeddedOnly() As Boolean
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property LicenseFileName() As String
			Get
				Return"License.lic"
			End Get
		End Property

		Public ReadOnly Property LicenseKey() As String
			Get
				Return"PAAvAGUAIgAgAD0AZQA1AD0AKwArAGgASABLADYAZAB6AEEAUABEADcAQgBVAFoAKwBIAFgAQwBGAD0AawBJAFUAIgA5AE0AWABIAHUASAB2AHYATQBqAEsAPgB5ACAASwA9AHkAdwAiAG8AaQBJAE8AeQAwAC8AZQBnAGEATwBXAFYAcwBlAFUASgBOAEoANAAiAE0AVgArACAAbAA9AEIAZwBjAGMASwA0AEIAUgA="
			End Get
		End Property

		Public ReadOnly Property LicenseParameters() As String
			Get
				Return"<AaRcg.iinecsLno.nSM><Cemuoa>gRSA<eoVClXeRBDItAbCAAGBGUeEiAQQ5AsEKAxBtvQFz0/3GjFovNUAMKZ6LSdTfX2/16IkIWx0/0dyHKY91TH+0GB3OQ7TrMhlS57hi2BhmVJBmo/B2CiW2Gno5fCnFAWCi+X3GbsSOocWEAToG5bYPJNXiU8u8pYnMmspFOJXsTumJXeWu2aQgYSD>JM8/P>8uOaByZKzSA/y=rAHC8WgCppk14KywdtY2KPkuiHch8RaCUypDmmtvhHl86OhyMUTrIjlAvAELeSkm5H5q5ZyI9tohu8WVQJX5ET/zLJPag/XFS8lm++B0HmUL2KoZS9EuLictVk9XhTfUk6k6T1S2lYvyh1tFiaTAeICyI1gtnuakcslcyoeRF3OVoQPAjAxAeAVxg0CSDA8kdA7AZgE>fuLaQyXKqS0<mLHXx>Jo9mCCt<4ewliV8egAKRK<d0O+DxiLyR6j/vGzcnHQd+sWEZMcJNubFM9Qen8ti9uEASrLU+rgpR4+OHgQDZlTRQ+Uxbk8LLfjA6wZ1hPGQ2KxCovyfKOA8Eq9koT1T4YaUlcRuvYSjzf6uiHWg6VDmwK8eISkr1/aVGzhPxdFtI3nWY4dtbiHSuMIod4me0cg6RdSPX1yM>nSo.Lncsneiig.RcAa</o>mrnt<nSiK/y=auuv>1wQAnAfkBA+Sh0sy9AzAPANAXQR5nuPf8hk/CRl53/4+UcAGW0rgiU4tYTVlCND3fMn+YXy0VaZy+k3NjKeEJEFRqFFNapce//miFHd80sT0r/S63AjT7XKaT1g2SeQ0IioOe2wnRGoG7YHdDrOpUaqFpGl7p9lpKrYtUC>UrrtjnMiO<cLPXT<oeslTV8eaAORm<R=5uywq5oL3j8/V2pVZDD7QP2fL2/SUdRKyNaV/p2SQXyrBFi89/OsOdrQLGQ8QegpUibOjyRZTrLFVH9FfHePpUusZ5m561gI00q6XLZc1RNBNL8E9eTuH3Q6nT3jO8K2FHpxw2xf/QcqhNO4/Fv/GfKtPQJM3Aa6xddQl5Pe54WCbA9ESAyQ0AIEjU9BnA5CbAfIyBSe/lRV7e+AuRR>3MJ<CnCmKoB/T>fuWaIyJK5SE/E=0So+04ThhWdYONZiNQiRYj8Aw7mdQa6LWIJ/BE5AMdeq1cV47tDTWXdvCRRj8q4FJRIjqw/LcX7C0YTx1fWuqG0MKNE6IXeA0RilmHCQnqcqclMghEMcIk4FT3rr0QWmh5WL4LomLhHT79Jf1IWwdj+h3Yv//RQoE9tHq0tdGXtAUZYIkN"
			End Get
		End Property

		Public ReadOnly Property MaxContainersNumber() As Integer
			Get
				Return20
			End Get
		End Property

		Public ReadOnly Property ServiceIndex() As Integer
			Get
				Return2
			End Get
		End Property

		Public ReadOnly Property UseMachineKeyStore() As Boolean
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property ProtectedStorage() As Integer
			Get
				Return2
			End Get
		End Property

		Public ReadOnly Property UseMachineProtectedStorage() As Boolean
			Get
				Return False
			End Get
		End Property

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Vscaner.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = Vscaner.__ENCList.Count = Vscaner.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = Vscaner.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = Vscaner.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								Vscaner.__ENCList(num) = Vscaner.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					Vscaner.__ENCList.RemoveRange(num, Vscaner.__ENCList.Count - num)
					Vscaner.__ENCList.Capacity = Vscaner.__ENCList.Count
				End If
				Vscaner.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Vscaner))
			Dim DataGridViewCellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
			Me.VisualStyler1 = New VisualStyler(Me.components)
			Me.MenuStrip1 = New MenuStrip()
			Me.HelpToolStripMenuItem = New ToolStripMenuItem()
			Me.BuyLicenseToolStripMenuItem = New ToolStripMenuItem()
			Me.TabControl1 = New TabControl()
			Me.TabPage1 = New TabPage()
			Me.Label20 = New Label()
			Me.Label19 = New Label()
			Me.Label18 = New Label()
			Me.Label17 = New Label()
			Me.ProgressBar1 = New ProgressBar()
			Me.Label16 = New Label()
			Me.Label15 = New Label()
			Me.Label14 = New Label()
			Me.Label13 = New Label()
			Me.Label12 = New Label()
			Me.Label11 = New Label()
			Me.Label9 = New Label()
			Me.Label10 = New Label()
			Me.Label8 = New Label()
			Me.Label7 = New Label()
			Me.Button1 = New Button()
			Me.Label6 = New Label()
			Me.Label5 = New Label()
			Me.Label4 = New Label()
			Me.Label3 = New Label()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.TextBox5 = New TextBox()
			Me.TextBox6 = New TextBox()
			Me.TextBox7 = New TextBox()
			Me.TextBox4 = New TextBox()
			Me.TextBox3 = New TextBox()
			Me.TextBox2 = New TextBox()
			Me.TextBox1 = New TextBox()
			Me.AxShockwaveFlash1 = New AxShockwaveFlash()
			Me.ShapeContainer1 = New ShapeContainer()
			Me.RectangleShape1 = New RectangleShape()
			Me.TabPage2 = New TabPage()
			Me.Button2 = New Button()
			Me.CordinDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
			Me.CordinBindingSource = New BindingSource(Me.components)
			Me.DbDataSet = New dbDataSet()
			Me.Button5 = New Button()
			Me.Button3 = New Button()
			Me.GroupBox1 = New GroupBox()
			Me.TextBox9 = New TextBox()
			Me.RadioButton4 = New RadioButton()
			Me.RadioButton3 = New RadioButton()
			Me.RadioButton2 = New RadioButton()
			Me.RadioButton1 = New RadioButton()
			Me.TabPage3 = New TabPage()
			Me.Button9 = New Button()
			Me.Button8 = New Button()
			Me.Hero_allianceDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn10 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn11 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn12 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn13 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn14 = New DataGridViewTextBoxColumn()
			Me.Hero_allianceBindingSource = New BindingSource(Me.components)
			Me.Button6 = New Button()
			Me.Button7 = New Button()
			Me.GroupBox2 = New GroupBox()
			Me.Button4 = New Button()
			Me.TextBox8 = New TextBox()
			Me.RadioButton7 = New RadioButton()
			Me.RadioButton6 = New RadioButton()
			Me.RadioButton5 = New RadioButton()
			Me.TabPage4 = New TabPage()
			Me.TabControl2 = New TabControl()
			Me.TabPage5 = New TabPage()
			Me.Button11 = New Button()
			Me.Button10 = New Button()
			Me.AltcoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn23 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn24 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn25 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn21 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn22 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn20 = New DataGridViewTextBoxColumn()
			Me.AltcoordBindingSource = New BindingSource(Me.components)
			Me.AltDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn17 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn16 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn18 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn19 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn15 = New DataGridViewTextBoxColumn()
			Me.AltBindingSource = New BindingSource(Me.components)
			Me.TabPage6 = New TabPage()
			Me.Button12 = New Button()
			Me.Button13 = New Button()
			Me.FriendscoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn32 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn33 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn36 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn34 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn35 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn31 = New DataGridViewTextBoxColumn()
			Me.FriendscoordBindingSource = New BindingSource(Me.components)
			Me.FriendsDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn27 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn28 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn29 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn30 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn26 = New DataGridViewTextBoxColumn()
			Me.FriendsBindingSource = New BindingSource(Me.components)
			Me.TabPage7 = New TabPage()
			Me.EnemiescoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn43 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn44 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn47 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn45 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn46 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn42 = New DataGridViewTextBoxColumn()
			Me.EnemiescoordBindingSource = New BindingSource(Me.components)
			Me.EnemiesDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn38 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn39 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn40 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn41 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn37 = New DataGridViewTextBoxColumn()
			Me.EnemiesBindingSource = New BindingSource(Me.components)
			Me.Button14 = New Button()
			Me.Button15 = New Button()
			Me.TabPage8 = New TabPage()
			Me.NeutralDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn54 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn55 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn56 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn57 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn53 = New DataGridViewTextBoxColumn()
			Me.NeutralBindingSource = New BindingSource(Me.components)
			Me.NeutralcoordDataGridView = New DataGridView()
			Me.DataGridViewTextBoxColumn49 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn50 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn51 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn52 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn48 = New DataGridViewTextBoxColumn()
			Me.NeutralcoordBindingSource = New BindingSource(Me.components)
			Me.Button16 = New Button()
			Me.Button17 = New Button()
			Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.CordinTableAdapter = New cordinTableAdapter()
			Me.TableAdapterManager = New TableAdapterManager()
			Me.Hero_allianceTableAdapter = New hero_allianceTableAdapter()
			Me.AltTableAdapter = New altTableAdapter()
			Me.AltcoordTableAdapter = New altcoordTableAdapter()
			Me.FriendsTableAdapter = New friendsTableAdapter()
			Me.FriendscoordTableAdapter = New friendscoordTableAdapter()
			Me.EnemiesTableAdapter = New enemiesTableAdapter()
			Me.EnemiescoordTableAdapter = New enemiescoordTableAdapter()
			Me.NeutralcoordTableAdapter = New neutralcoordTableAdapter()
			Me.NeutralTableAdapter = New neutralTableAdapter()
			(CType(Me.VisualStyler1, ISupportInitialize)).BeginInit()
			Me.MenuStrip1.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			(CType(Me.AxShockwaveFlash1, ISupportInitialize)).BeginInit()
			Me.TabPage2.SuspendLayout()
			(CType(Me.CordinDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.DbDataSet, ISupportInitialize)).BeginInit()
			Me.GroupBox1.SuspendLayout()
			Me.TabPage3.SuspendLayout()
			(CType(Me.Hero_allianceDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.Hero_allianceBindingSource, ISupportInitialize)).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.TabPage4.SuspendLayout()
			Me.TabControl2.SuspendLayout()
			Me.TabPage5.SuspendLayout()
			(CType(Me.AltcoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.AltcoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.AltDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.AltBindingSource, ISupportInitialize)).BeginInit()
			Me.TabPage6.SuspendLayout()
			(CType(Me.FriendscoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.FriendscoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.FriendsDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.FriendsBindingSource, ISupportInitialize)).BeginInit()
			Me.TabPage7.SuspendLayout()
			(CType(Me.EnemiescoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.EnemiescoordBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.EnemiesDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.EnemiesBindingSource, ISupportInitialize)).BeginInit()
			Me.TabPage8.SuspendLayout()
			(CType(Me.NeutralDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.NeutralBindingSource, ISupportInitialize)).BeginInit()
			(CType(Me.NeutralcoordDataGridView, ISupportInitialize)).BeginInit()
			(CType(Me.NeutralcoordBindingSource, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.VisualStyler1.HostForm = Me
			Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), VisualStylerLicense)
			Me.VisualStyler1.LoadVisualStyle(Nothing, "Fresco (FrescoB).vssf")
			Me.MenuStrip1.Items.AddRange(New ToolStripItem()() = { Me.HelpToolStripMenuItem })
			Dim arg_AC3_0 As Control = Me.MenuStrip1
			Dim location As Point = New Point(0, 0)
			arg_AC3_0.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim arg_AF1_0 As Control = Me.MenuStrip1
			Dim size As Size = New Size(1030, 24)
			arg_AF1_0.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem()() = { Me.BuyLicenseToolStripMenuItem })
			Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
			Dim arg_B60_0 As ToolStripItem = Me.HelpToolStripMenuItem
			size = New Size(44, 20)
			arg_B60_0.Size = size
			Me.HelpToolStripMenuItem.Text = "Help"
			Me.BuyLicenseToolStripMenuItem.Name = "BuyLicenseToolStripMenuItem"
			Dim arg_B9F_0 As ToolStripItem = Me.BuyLicenseToolStripMenuItem
			size = New Size(152, 22)
			arg_B9F_0.Size = size
			Me.BuyLicenseToolStripMenuItem.Text = "Buy License"
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Controls.Add(Me.TabPage3)
			Me.TabControl1.Controls.Add(Me.TabPage4)
			Me.TabControl1.Dock = DockStyle.Fill
			Me.TabControl1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_C50_0 As Control = Me.TabControl1
			location = New Point(0, 24)
			arg_C50_0.Location = location
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim arg_C8E_0 As Control = Me.TabControl1
			size = New Size(1030, 655)
			arg_C8E_0.Size = size
			Me.TabControl1.TabIndex = 1
			Me.TabPage1.Controls.Add(Me.Label20)
			Me.TabPage1.Controls.Add(Me.Label19)
			Me.TabPage1.Controls.Add(Me.Label18)
			Me.TabPage1.Controls.Add(Me.Label17)
			Me.TabPage1.Controls.Add(Me.ProgressBar1)
			Me.TabPage1.Controls.Add(Me.Label16)
			Me.TabPage1.Controls.Add(Me.Label15)
			Me.TabPage1.Controls.Add(Me.Label14)
			Me.TabPage1.Controls.Add(Me.Label13)
			Me.TabPage1.Controls.Add(Me.Label12)
			Me.TabPage1.Controls.Add(Me.Label11)
			Me.TabPage1.Controls.Add(Me.Label9)
			Me.TabPage1.Controls.Add(Me.Label10)
			Me.TabPage1.Controls.Add(Me.Label8)
			Me.TabPage1.Controls.Add(Me.Label7)
			Me.TabPage1.Controls.Add(Me.Button1)
			Me.TabPage1.Controls.Add(Me.Label6)
			Me.TabPage1.Controls.Add(Me.Label5)
			Me.TabPage1.Controls.Add(Me.Label4)
			Me.TabPage1.Controls.Add(Me.Label3)
			Me.TabPage1.Controls.Add(Me.Label2)
			Me.TabPage1.Controls.Add(Me.Label1)
			Me.TabPage1.Controls.Add(Me.TextBox5)
			Me.TabPage1.Controls.Add(Me.TextBox6)
			Me.TabPage1.Controls.Add(Me.TextBox7)
			Me.TabPage1.Controls.Add(Me.TextBox4)
			Me.TabPage1.Controls.Add(Me.TextBox3)
			Me.TabPage1.Controls.Add(Me.TextBox2)
			Me.TabPage1.Controls.Add(Me.TextBox1)
			Me.TabPage1.Controls.Add(Me.AxShockwaveFlash1)
			Me.TabPage1.Controls.Add(Me.ShapeContainer1)
			Dim arg_F7D_0 As TabPage = Me.TabPage1
			location = New Point(4, 22)
			arg_F7D_0.Location = location
			Me.TabPage1.Name = "TabPage1"
			Dim arg_FA5_0 As Control = Me.TabPage1
			Dim padding As Padding = New Padding(3)
			arg_FA5_0.Padding = padding
			Dim arg_FC5_0 As Control = Me.TabPage1
			size = New Size(1022, 629)
			arg_FC5_0.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "Scaner"
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.Label20.AutoSize = True
			Dim arg_101D_0 As Control = Me.Label20
			location = New Point(947, 214)
			arg_101D_0.Location = location
			Me.Label20.Name = "Label20"
			Dim arg_1048_0 As Control = Me.Label20
			size = New Size(49, 13)
			arg_1048_0.Size = size
			Me.Label20.TabIndex = 49
			Me.Label20.Text = "00:00:00"
			Me.Label19.AutoSize = True
			Dim arg_1094_0 As Control = Me.Label19
			location = New Point(947, 178)
			arg_1094_0.Location = location
			Me.Label19.Name = "Label19"
			Dim arg_10BF_0 As Control = Me.Label19
			size = New Size(49, 13)
			arg_10BF_0.Size = size
			Me.Label19.TabIndex = 48
			Me.Label19.Text = "00:00:00"
			Me.Label18.AutoSize = True
			Dim arg_110B_0 As Control = Me.Label18
			location = New Point(947, 145)
			arg_110B_0.Location = location
			Me.Label18.Name = "Label18"
			Dim arg_1136_0 As Control = Me.Label18
			size = New Size(49, 13)
			arg_1136_0.Size = size
			Me.Label18.TabIndex = 47
			Me.Label18.Text = "00:00:00"
			Me.Label17.AutoSize = True
			Dim arg_117F_0 As Control = Me.Label17
			location = New Point(943, 120)
			arg_117F_0.Location = location
			Me.Label17.Name = "Label17"
			Dim arg_11AA_0 As Control = Me.Label17
			size = New Size(53, 13)
			arg_11AA_0.Size = size
			Me.Label17.TabIndex = 46
			Me.Label17.Text = "Last scan"
			Dim arg_11E5_0 As Control = Me.ProgressBar1
			location = New Point(3, 592)
			arg_11E5_0.Location = location
			Me.ProgressBar1.Maximum = 30000
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim arg_1224_0 As Control = Me.ProgressBar1
			size = New Size(776, 33)
			arg_1224_0.Size = size
			Me.ProgressBar1.[Step] = 1
			Me.ProgressBar1.TabIndex = 45
			Me.ProgressBar1.Visible = False
			Me.Label16.AutoSize = True
			Dim arg_1279_0 As Control = Me.Label16
			location = New Point(888, 423)
			arg_1279_0.Location = location
			Me.Label16.Name = "Label16"
			Dim arg_12A4_0 As Control = Me.Label16
			size = New Size(37, 13)
			arg_12A4_0.Size = size
			Me.Label16.TabIndex = 44
			Me.Label16.Text = "heronr"
			Me.Label16.Visible = False
			Me.Label15.AutoSize = True
			Dim arg_12FD_0 As Control = Me.Label15
			location = New Point(801, 423)
			arg_12FD_0.Location = location
			Me.Label15.Name = "Label15"
			Dim arg_1328_0 As Control = Me.Label15
			size = New Size(39, 13)
			arg_1328_0.Size = size
			Me.Label15.TabIndex = 43
			Me.Label15.Text = "scannr"
			Me.Label15.Visible = False
			Me.Label14.AutoSize = True
			Dim arg_1381_0 As Control = Me.Label14
			location = New Point(907, 214)
			arg_1381_0.Location = location
			Me.Label14.Name = "Label14"
			Dim arg_13AC_0 As Control = Me.Label14
			size = New Size(13, 13)
			arg_13AC_0.Size = size
			Me.Label14.TabIndex = 42
			Me.Label14.Text = "0"
			Me.Label13.AutoSize = True
			Dim arg_13F8_0 As Control = Me.Label13
			location = New Point(820, 214)
			arg_13F8_0.Location = location
			Me.Label13.Name = "Label13"
			Dim arg_1423_0 As Control = Me.Label13
			size = New Size(67, 13)
			arg_1423_0.Size = size
			Me.Label13.TabIndex = 41
			Me.Label13.Text = "Flats records"
			Me.Label12.AutoSize = True
			Dim arg_146F_0 As Control = Me.Label12
			location = New Point(907, 179)
			arg_146F_0.Location = location
			Me.Label12.Name = "Label12"
			Dim arg_149A_0 As Control = Me.Label12
			size = New Size(13, 13)
			arg_149A_0.Size = size
			Me.Label12.TabIndex = 40
			Me.Label12.Text = "0"
			Me.Label11.AutoSize = True
			Dim arg_14E6_0 As Control = Me.Label11
			location = New Point(819, 178)
			arg_14E6_0.Location = location
			Me.Label11.Name = "Label11"
			Dim arg_1511_0 As Control = Me.Label11
			size = New Size(68, 13)
			arg_1511_0.Size = size
			Me.Label11.TabIndex = 39
			Me.Label11.Text = "Hero records"
			Me.Label9.AutoSize = True
			Dim arg_155D_0 As Control = Me.Label9
			location = New Point(795, 144)
			arg_155D_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_1588_0 As Control = Me.Label9
			size = New Size(92, 13)
			arg_1588_0.Size = size
			Me.Label9.TabIndex = 38
			Me.Label9.Text = "Map scan records"
			Me.Label10.AutoSize = True
			Dim arg_15D4_0 As Control = Me.Label10
			location = New Point(907, 145)
			arg_15D4_0.Location = location
			Me.Label10.Name = "Label10"
			Dim arg_15FF_0 As Control = Me.Label10
			size = New Size(13, 13)
			arg_15FF_0.Size = size
			Me.Label10.TabIndex = 37
			Me.Label10.Text = "0"
			Me.Label8.AutoSize = True
			Dim arg_164B_0 As Control = Me.Label8
			location = New Point(936, 423)
			arg_164B_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_1676_0 As Control = Me.Label8
			size = New Size(13, 13)
			arg_1676_0.Size = size
			Me.Label8.TabIndex = 17
			Me.Label8.Text = "0"
			Me.Label8.Visible = False
			Me.Label7.AutoSize = True
			Dim arg_16CF_0 As Control = Me.Label7
			location = New Point(852, 423)
			arg_16CF_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_16FA_0 As Control = Me.Label7
			size = New Size(13, 13)
			arg_16FA_0.Size = size
			Me.Label7.TabIndex = 16
			Me.Label7.Text = "0"
			Me.Label7.Visible = False
			Dim arg_1743_0 As Control = Me.Button1
			location = New Point(851, 33)
			arg_1743_0.Location = location
			Me.Button1.Name = "Button1"
			Dim arg_176E_0 As Control = Me.Button1
			size = New Size(109, 35)
			arg_176E_0.Size = size
			Me.Button1.TabIndex = 14
			Me.Button1.Text = "Load scaner"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label6.AutoSize = True
			Dim arg_17C7_0 As Control = Me.Label6
			location = New Point(968, 524)
			arg_17C7_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_17F2_0 As Control = Me.Label6
			size = New Size(42, 13)
			arg_17F2_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "hunting"
			Me.Label6.Visible = False
			Me.Label5.AutoSize = True
			Dim arg_184B_0 As Control = Me.Label5
			location = New Point(885, 525)
			arg_184B_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_1876_0 As Control = Me.Label5
			size = New Size(31, 13)
			arg_1876_0.Size = size
			Me.Label5.TabIndex = 12
			Me.Label5.Text = "fields"
			Me.Label5.Visible = False
			Me.Label4.AutoSize = True
			Dim arg_18CF_0 As Control = Me.Label4
			location = New Point(811, 525)
			arg_18CF_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_18FA_0 As Control = Me.Label4
			size = New Size(25, 13)
			arg_18FA_0.Size = size
			Me.Label4.TabIndex = 11
			Me.Label4.Text = "npc"
			Me.Label4.Visible = False
			Me.Label3.AutoSize = True
			Dim arg_1953_0 As Control = Me.Label3
			location = New Point(968, 454)
			arg_1953_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_197E_0 As Control = Me.Label3
			size = New Size(26, 13)
			arg_197E_0.Size = size
			Me.Label3.TabIndex = 10
			Me.Label3.Text = "flats"
			Me.Label3.Visible = False
			Me.Label2.AutoSize = True
			Dim arg_19D7_0 As Control = Me.Label2
			location = New Point(888, 455)
			arg_19D7_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_1A02_0 As Control = Me.Label2
			size = New Size(28, 13)
			arg_1A02_0.Size = size
			Me.Label2.TabIndex = 9
			Me.Label2.Text = "hero"
			Me.Label2.Visible = False
			Me.Label1.AutoSize = True
			Dim arg_1A5B_0 As Control = Me.Label1
			location = New Point(811, 455)
			arg_1A5B_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_1A86_0 As Control = Me.Label1
			size = New Size(26, 13)
			arg_1A86_0.Size = size
			Me.Label1.TabIndex = 8
			Me.Label1.Text = "citie"
			Me.Label1.Visible = False
			Dim arg_1AD1_0 As Control = Me.TextBox5
			location = New Point(950, 540)
			arg_1AD1_0.Location = location
			Me.TextBox5.Multiline = True
			Me.TextBox5.Name = "TextBox5"
			Dim arg_1B09_0 As Control = Me.TextBox5
			size = New Size(72, 52)
			arg_1B09_0.Size = size
			Me.TextBox5.TabIndex = 7
			Me.TextBox5.Visible = False
			Dim arg_1B43_0 As Control = Me.TextBox6
			location = New Point(872, 541)
			arg_1B43_0.Location = location
			Me.TextBox6.Multiline = True
			Me.TextBox6.Name = "TextBox6"
			Dim arg_1B7B_0 As Control = Me.TextBox6
			size = New Size(72, 52)
			arg_1B7B_0.Size = size
			Me.TextBox6.TabIndex = 6
			Me.TextBox6.Visible = False
			Dim arg_1BB5_0 As Control = Me.TextBox7
			location = New Point(794, 541)
			arg_1BB5_0.Location = location
			Me.TextBox7.Multiline = True
			Me.TextBox7.Name = "TextBox7"
			Dim arg_1BED_0 As Control = Me.TextBox7
			size = New Size(72, 52)
			arg_1BED_0.Size = size
			Me.TextBox7.TabIndex = 5
			Me.TextBox7.Visible = False
			Dim arg_1C27_0 As Control = Me.TextBox4
			location = New Point(950, 470)
			arg_1C27_0.Location = location
			Me.TextBox4.Multiline = True
			Me.TextBox4.Name = "TextBox4"
			Dim arg_1C5F_0 As Control = Me.TextBox4
			size = New Size(72, 52)
			arg_1C5F_0.Size = size
			Me.TextBox4.TabIndex = 4
			Me.TextBox4.Visible = False
			Dim arg_1C99_0 As Control = Me.TextBox3
			location = New Point(872, 470)
			arg_1C99_0.Location = location
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Dim arg_1CD1_0 As Control = Me.TextBox3
			size = New Size(72, 52)
			arg_1CD1_0.Size = size
			Me.TextBox3.TabIndex = 3
			Me.TextBox3.Visible = False
			Dim arg_1D0B_0 As Control = Me.TextBox2
			location = New Point(794, 471)
			arg_1D0B_0.Location = location
			Me.TextBox2.Multiline = True
			Me.TextBox2.Name = "TextBox2"
			Dim arg_1D43_0 As Control = Me.TextBox2
			size = New Size(72, 52)
			arg_1D43_0.Size = size
			Me.TextBox2.TabIndex = 2
			Me.TextBox2.Visible = False
			Dim arg_1D79_0 As Control = Me.TextBox1
			location = New Point(8, 470)
			arg_1D79_0.Location = location
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.ScrollBars = ScrollBars.Vertical
			Dim arg_1DC1_0 As Control = Me.TextBox1
			size = New Size(774, 106)
			arg_1DC1_0.Size = size
			Me.TextBox1.TabIndex = 1
			Me.AxShockwaveFlash1.Enabled = True
			Dim arg_1DF4_0 As Control = Me.AxShockwaveFlash1
			location = New Point(8, 15)
			arg_1DF4_0.Location = location
			Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
			Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), AxHost.State)
			Dim arg_1E42_0 As Control = Me.AxShockwaveFlash1
			size = New Size(771, 438)
			arg_1E42_0.Size = size
			Me.AxShockwaveFlash1.TabIndex = 0
			Me.AxShockwaveFlash1.Tag = "XC"
			Dim arg_1E78_0 As Control = Me.ShapeContainer1
			location = New Point(3, 3)
			arg_1E78_0.Location = location
			Dim arg_1E8F_0 As Control = Me.ShapeContainer1
			padding = New Padding(0)
			arg_1E8F_0.Margin = padding
			Me.ShapeContainer1.Name = "ShapeContainer1"
			Me.ShapeContainer1.Shapes.AddRange(New Shape()() = { Me.RectangleShape1 })
			Dim arg_1EE6_0 As Control = Me.ShapeContainer1
			size = New Size(1016, 623)
			arg_1EE6_0.Size = size
			Me.ShapeContainer1.TabIndex = 50
			Me.ShapeContainer1.TabStop = False
			Me.RectangleShape1.BorderColor = Color.Gray
			Me.RectangleShape1.FillGradientColor = Color.Gray
			Dim arg_1F40_0 As SimpleShape = Me.RectangleShape1
			location = New Point(785, 107)
			arg_1F40_0.Location = location
			Me.RectangleShape1.Name = "RectangleShape1"
			Dim arg_1F71_0 As SimpleShape = Me.RectangleShape1
			size = New Size(223, 135)
			arg_1F71_0.Size = size
			Me.TabPage2.Controls.Add(Me.Button2)
			Me.TabPage2.Controls.Add(Me.CordinDataGridView)
			Me.TabPage2.Controls.Add(Me.Button5)
			Me.TabPage2.Controls.Add(Me.Button3)
			Me.TabPage2.Controls.Add(Me.GroupBox1)
			Dim arg_1FFD_0 As TabPage = Me.TabPage2
			location = New Point(4, 22)
			arg_1FFD_0.Location = location
			Me.TabPage2.Name = "TabPage2"
			Dim arg_2025_0 As Control = Me.TabPage2
			padding = New Padding(3)
			arg_2025_0.Padding = padding
			Dim arg_2045_0 As Control = Me.TabPage2
			size = New Size(1022, 629)
			arg_2045_0.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "Cities"
			Me.TabPage2.UseVisualStyleBackColor = True
			Dim arg_2090_0 As Control = Me.Button2
			location = New Point(843, 525)
			arg_2090_0.Location = location
			Me.Button2.Name = "Button2"
			Dim arg_20BB_0 As Control = Me.Button2
			size = New Size(100, 23)
			arg_20BB_0.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.Text = "Save (.txt)"
			Me.Button2.UseVisualStyleBackColor = True
			Me.CordinDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle.BackColor = SystemColors.Control
			DataGridViewCellStyle.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
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
			Dim arg_225D_0 As Control = Me.CordinDataGridView
			location = New Point(3, 6)
			arg_225D_0.Location = location
			Me.CordinDataGridView.Name = "CordinDataGridView"
			Dim arg_228E_0 As Control = Me.CordinDataGridView
			size = New Size(758, 586)
			arg_228E_0.Size = size
			Me.CordinDataGridView.TabIndex = 4
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
			Me.CordinBindingSource.DataMember = "cordin"
			Me.CordinBindingSource.DataSource = Me.DbDataSet
			Me.DbDataSet.DataSetName = "dbDataSet"
			Me.DbDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Dim arg_2481_0 As Control = Me.Button5
			location = New Point(901, 162)
			arg_2481_0.Location = location
			Me.Button5.Name = "Button5"
			Dim arg_24AC_0 As Control = Me.Button5
			size = New Size(75, 23)
			arg_24AC_0.Size = size
			Me.Button5.TabIndex = 4
			Me.Button5.Text = "Map"
			Me.Button5.UseVisualStyleBackColor = True
			Dim arg_24F7_0 As Control = Me.Button3
			location = New Point(795, 162)
			arg_24F7_0.Location = location
			Me.Button3.Name = "Button3"
			Dim arg_2522_0 As Control = Me.Button3
			size = New Size(75, 23)
			arg_2522_0.Size = size
			Me.Button3.TabIndex = 2
			Me.Button3.Text = "Player info"
			Me.Button3.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.TextBox9)
			Me.GroupBox1.Controls.Add(Me.RadioButton4)
			Me.GroupBox1.Controls.Add(Me.RadioButton3)
			Me.GroupBox1.Controls.Add(Me.RadioButton2)
			Me.GroupBox1.Controls.Add(Me.RadioButton1)
			Dim arg_25DD_0 As Control = Me.GroupBox1
			location = New Point(767, 20)
			arg_25DD_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_260E_0 As Control = Me.GroupBox1
			size = New Size(245, 136)
			arg_260E_0.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Search by"
			Dim arg_2653_0 As Control = Me.TextBox9
			location = New Point(76, 100)
			arg_2653_0.Location = location
			Me.TextBox9.Name = "TextBox9"
			Dim arg_267E_0 As Control = Me.TextBox9
			size = New Size(100, 20)
			arg_267E_0.Size = size
			Me.TextBox9.TabIndex = 4
			Me.RadioButton4.AutoSize = True
			Dim arg_26B2_0 As Control = Me.RadioButton4
			location = New Point(114, 63)
			arg_26B2_0.Location = location
			Me.RadioButton4.Name = "RadioButton4"
			Dim arg_26DD_0 As Control = Me.RadioButton4
			size = New Size(121, 17)
			arg_26DD_0.Size = size
			Me.RadioButton4.TabIndex = 3
			Me.RadioButton4.Text = "Citie/Player/Alliance"
			Me.RadioButton4.UseVisualStyleBackColor = True
			Me.RadioButton3.AutoSize = True
			Dim arg_272F_0 As Control = Me.RadioButton3
			location = New Point(114, 30)
			arg_272F_0.Location = location
			Me.RadioButton3.Name = "RadioButton3"
			Dim arg_275A_0 As Control = Me.RadioButton3
			size = New Size(62, 17)
			arg_275A_0.Size = size
			Me.RadioButton3.TabIndex = 2
			Me.RadioButton3.Text = "Alliance"
			Me.RadioButton3.UseVisualStyleBackColor = True
			Me.RadioButton2.AutoSize = True
			Me.RadioButton2.Checked = True
			Dim arg_27B9_0 As Control = Me.RadioButton2
			location = New Point(16, 63)
			arg_27B9_0.Location = location
			Me.RadioButton2.Name = "RadioButton2"
			Dim arg_27E4_0 As Control = Me.RadioButton2
			size = New Size(54, 17)
			arg_27E4_0.Size = size
			Me.RadioButton2.TabIndex = 1
			Me.RadioButton2.TabStop = True
			Me.RadioButton2.Text = "Player"
			Me.RadioButton2.UseVisualStyleBackColor = True
			Me.RadioButton1.AutoSize = True
			Dim arg_2843_0 As Control = Me.RadioButton1
			location = New Point(16, 30)
			arg_2843_0.Location = location
			Me.RadioButton1.Name = "RadioButton1"
			Dim arg_286E_0 As Control = Me.RadioButton1
			size = New Size(45, 17)
			arg_286E_0.Size = size
			Me.RadioButton1.TabIndex = 0
			Me.RadioButton1.Text = "Citie"
			Me.RadioButton1.UseVisualStyleBackColor = True
			Me.TabPage3.Controls.Add(Me.Button9)
			Me.TabPage3.Controls.Add(Me.Button8)
			Me.TabPage3.Controls.Add(Me.Hero_allianceDataGridView)
			Me.TabPage3.Controls.Add(Me.Button6)
			Me.TabPage3.Controls.Add(Me.Button7)
			Me.TabPage3.Controls.Add(Me.GroupBox2)
			Dim arg_293C_0 As TabPage = Me.TabPage3
			location = New Point(4, 22)
			arg_293C_0.Location = location
			Me.TabPage3.Name = "TabPage3"
			Dim arg_2964_0 As Control = Me.TabPage3
			padding = New Padding(3)
			arg_2964_0.Padding = padding
			Dim arg_2984_0 As Control = Me.TabPage3
			size = New Size(1022, 629)
			arg_2984_0.Size = size
			Me.TabPage3.TabIndex = 2
			Me.TabPage3.Text = "Heroes"
			Me.TabPage3.UseVisualStyleBackColor = True
			Dim arg_29CF_0 As Control = Me.Button9
			location = New Point(852, 128)
			arg_29CF_0.Location = location
			Me.Button9.Name = "Button9"
			Dim arg_29FA_0 As Control = Me.Button9
			size = New Size(75, 23)
			arg_29FA_0.Size = size
			Me.Button9.TabIndex = 8
			Me.Button9.Text = "Top 10000"
			Me.Button9.UseVisualStyleBackColor = True
			Dim arg_2A45_0 As Control = Me.Button8
			location = New Point(852, 555)
			arg_2A45_0.Location = location
			Me.Button8.Name = "Button8"
			Dim arg_2A70_0 As Control = Me.Button8
			size = New Size(89, 23)
			arg_2A70_0.Size = size
			Me.Button8.TabIndex = 7
			Me.Button8.Text = "Save (.txt)"
			Me.Button8.UseVisualStyleBackColor = True
			Me.Hero_allianceDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle3.BackColor = SystemColors.Control
			DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle3.WrapMode = DataGridViewTriState.[True]
			Me.Hero_allianceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
			Me.Hero_allianceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.Hero_allianceDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14 })
			Me.Hero_allianceDataGridView.DataSource = Me.Hero_allianceBindingSource
			DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle4.BackColor = SystemColors.Window
			DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle4.WrapMode = DataGridViewTriState.[False]
			Me.Hero_allianceDataGridView.DefaultCellStyle = DataGridViewCellStyle4
			Dim arg_2C30_0 As Control = Me.Hero_allianceDataGridView
			location = New Point(0, 6)
			arg_2C30_0.Location = location
			Me.Hero_allianceDataGridView.Name = "Hero_allianceDataGridView"
			Dim arg_2C61_0 As Control = Me.Hero_allianceDataGridView
			size = New Size(758, 586)
			arg_2C61_0.Size = size
			Me.Hero_allianceDataGridView.TabIndex = 6
			Me.DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn7.DataPropertyName = "hero nr"
			Me.DataGridViewTextBoxColumn7.HeaderText = "Hero Nr"
			Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
			Me.DataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn8.DataPropertyName = "hero name"
			Me.DataGridViewTextBoxColumn8.HeaderText = "Hero"
			Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
			Me.DataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn9.DataPropertyName = "player name"
			Me.DataGridViewTextBoxColumn9.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
			Me.DataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn10.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn10.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
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
			Me.Hero_allianceBindingSource.DataMember = "hero_alliance"
			Me.Hero_allianceBindingSource.DataSource = Me.DbDataSet
			Dim arg_2EB9_0 As Control = Me.Button6
			location = New Point(912, 169)
			arg_2EB9_0.Location = location
			Me.Button6.Name = "Button6"
			Dim arg_2EE4_0 As Control = Me.Button6
			size = New Size(75, 23)
			arg_2EE4_0.Size = size
			Me.Button6.TabIndex = 6
			Me.Button6.Text = "Map"
			Me.Button6.UseVisualStyleBackColor = True
			Dim arg_2F2F_0 As Control = Me.Button7
			location = New Point(805, 169)
			arg_2F2F_0.Location = location
			Me.Button7.Name = "Button7"
			Dim arg_2F5A_0 As Control = Me.Button7
			size = New Size(75, 23)
			arg_2F5A_0.Size = size
			Me.Button7.TabIndex = 5
			Me.Button7.Text = "Player info"
			Me.Button7.UseVisualStyleBackColor = True
			Me.GroupBox2.Controls.Add(Me.Button4)
			Me.GroupBox2.Controls.Add(Me.TextBox8)
			Me.GroupBox2.Controls.Add(Me.RadioButton7)
			Me.GroupBox2.Controls.Add(Me.RadioButton6)
			Me.GroupBox2.Controls.Add(Me.RadioButton5)
			Dim arg_3015_0 As Control = Me.GroupBox2
			location = New Point(774, 22)
			arg_3015_0.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim arg_3043_0 As Control = Me.GroupBox2
			size = New Size(238, 100)
			arg_3043_0.Size = size
			Me.GroupBox2.TabIndex = 0
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Search by"
			Dim arg_308B_0 As Control = Me.Button4
			location = New Point(138, 56)
			arg_308B_0.Location = location
			Me.Button4.Name = "Button4"
			Dim arg_30B6_0 As Control = Me.Button4
			size = New Size(75, 23)
			arg_30B6_0.Size = size
			Me.Button4.TabIndex = 4
			Me.Button4.Text = "Search"
			Me.Button4.UseVisualStyleBackColor = True
			Dim arg_30FB_0 As Control = Me.TextBox8
			location = New Point(18, 59)
			arg_30FB_0.Location = location
			Me.TextBox8.Name = "TextBox8"
			Dim arg_3126_0 As Control = Me.TextBox8
			size = New Size(100, 20)
			arg_3126_0.Size = size
			Me.TextBox8.TabIndex = 3
			Me.RadioButton7.AutoSize = True
			Dim arg_315D_0 As Control = Me.RadioButton7
			location = New Point(151, 19)
			arg_315D_0.Location = location
			Me.RadioButton7.Name = "RadioButton7"
			Dim arg_3188_0 As Control = Me.RadioButton7
			size = New Size(62, 17)
			arg_3188_0.Size = size
			Me.RadioButton7.TabIndex = 2
			Me.RadioButton7.Text = "Alliance"
			Me.RadioButton7.UseVisualStyleBackColor = True
			Me.RadioButton6.AutoSize = True
			Me.RadioButton6.Checked = True
			Dim arg_31E7_0 As Control = Me.RadioButton6
			location = New Point(78, 20)
			arg_31E7_0.Location = location
			Me.RadioButton6.Name = "RadioButton6"
			Dim arg_3212_0 As Control = Me.RadioButton6
			size = New Size(54, 17)
			arg_3212_0.Size = size
			Me.RadioButton6.TabIndex = 1
			Me.RadioButton6.TabStop = True
			Me.RadioButton6.Text = "Player"
			Me.RadioButton6.UseVisualStyleBackColor = True
			Me.RadioButton5.AutoSize = True
			Dim arg_3271_0 As Control = Me.RadioButton5
			location = New Point(18, 20)
			arg_3271_0.Location = location
			Me.RadioButton5.Name = "RadioButton5"
			Dim arg_329C_0 As Control = Me.RadioButton5
			size = New Size(54, 17)
			arg_329C_0.Size = size
			Me.RadioButton5.TabIndex = 0
			Me.RadioButton5.Text = "Heroe"
			Me.RadioButton5.UseVisualStyleBackColor = True
			Me.TabPage4.Controls.Add(Me.TabControl2)
			Dim arg_32F7_0 As TabPage = Me.TabPage4
			location = New Point(4, 22)
			arg_32F7_0.Location = location
			Me.TabPage4.Name = "TabPage4"
			Dim arg_331F_0 As Control = Me.TabPage4
			padding = New Padding(3)
			arg_331F_0.Padding = padding
			Dim arg_333F_0 As Control = Me.TabPage4
			size = New Size(1022, 629)
			arg_333F_0.Size = size
			Me.TabPage4.TabIndex = 3
			Me.TabPage4.Text = "Diplomacy"
			Me.TabPage4.UseVisualStyleBackColor = True
			Me.TabControl2.Controls.Add(Me.TabPage5)
			Me.TabControl2.Controls.Add(Me.TabPage6)
			Me.TabControl2.Controls.Add(Me.TabPage7)
			Me.TabControl2.Controls.Add(Me.TabPage8)
			Me.TabControl2.Dock = DockStyle.Fill
			Dim arg_33EB_0 As Control = Me.TabControl2
			location = New Point(3, 3)
			arg_33EB_0.Location = location
			Me.TabControl2.Name = "TabControl2"
			Me.TabControl2.SelectedIndex = 0
			Dim arg_3429_0 As Control = Me.TabControl2
			size = New Size(1016, 623)
			arg_3429_0.Size = size
			Me.TabControl2.TabIndex = 0
			Me.TabPage5.Controls.Add(Me.Button11)
			Me.TabPage5.Controls.Add(Me.Button10)
			Me.TabPage5.Controls.Add(Me.AltcoordDataGridView)
			Me.TabPage5.Controls.Add(Me.AltDataGridView)
			Dim arg_34AB_0 As TabPage = Me.TabPage5
			location = New Point(4, 22)
			arg_34AB_0.Location = location
			Me.TabPage5.Name = "TabPage5"
			Dim arg_34D3_0 As Control = Me.TabPage5
			padding = New Padding(3)
			arg_34D3_0.Padding = padding
			Dim arg_34F3_0 As Control = Me.TabPage5
			size = New Size(1008, 597)
			arg_34F3_0.Size = size
			Me.TabPage5.TabIndex = 0
			Me.TabPage5.Text = "Alt."
			Me.TabPage5.UseVisualStyleBackColor = True
			Dim arg_353B_0 As Control = Me.Button11
			location = New Point(76, 254)
			arg_353B_0.Location = location
			Me.Button11.Name = "Button11"
			Dim arg_3566_0 As Control = Me.Button11
			size = New Size(55, 23)
			arg_3566_0.Size = size
			Me.Button11.TabIndex = 3
			Me.Button11.Text = "Delete"
			Me.Button11.UseVisualStyleBackColor = True
			Dim arg_35AE_0 As Control = Me.Button10
			location = New Point(15, 254)
			arg_35AE_0.Location = location
			Me.Button10.Name = "Button10"
			Dim arg_35D9_0 As Control = Me.Button10
			size = New Size(55, 23)
			arg_35D9_0.Size = size
			Me.Button10.TabIndex = 2
			Me.Button10.Text = "Update"
			Me.Button10.UseVisualStyleBackColor = True
			Me.AltcoordDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle5.BackColor = SystemColors.Control
			DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle5.WrapMode = DataGridViewTriState.[True]
			Me.AltcoordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
			Me.AltcoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.AltcoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn20 })
			Me.AltcoordDataGridView.DataSource = Me.AltcoordBindingSource
			DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle6.BackColor = SystemColors.Window
			DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle6.WrapMode = DataGridViewTriState.[False]
			Me.AltcoordDataGridView.DefaultCellStyle = DataGridViewCellStyle6
			Dim arg_3788_0 As Control = Me.AltcoordDataGridView
			location = New Point(165, 18)
			arg_3788_0.Location = location
			Me.AltcoordDataGridView.Name = "AltcoordDataGridView"
			Dim arg_37B9_0 As Control = Me.AltcoordDataGridView
			size = New Size(835, 544)
			arg_37B9_0.Size = size
			Me.AltcoordDataGridView.TabIndex = 1
			Me.DataGridViewTextBoxColumn23.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn23.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn23.HeaderText = "X"
			Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
			Me.DataGridViewTextBoxColumn24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn24.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn24.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
			Me.DataGridViewTextBoxColumn25.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn25.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn25.HeaderText = "Citie"
			Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
			Me.DataGridViewTextBoxColumn21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn21.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn21.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
			Me.DataGridViewTextBoxColumn22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn22.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn22.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
			Me.DataGridViewTextBoxColumn20.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn20.HeaderText = "id"
			Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
			Me.DataGridViewTextBoxColumn20.Visible = False
			Me.AltcoordBindingSource.DataMember = "altcoord"
			Me.AltcoordBindingSource.DataSource = Me.DbDataSet
			Me.AltDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle7.BackColor = SystemColors.Control
			DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle7.WrapMode = DataGridViewTriState.[True]
			Me.AltDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
			Me.AltDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.AltDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn15 })
			Me.AltDataGridView.DataSource = Me.AltBindingSource
			DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle8.BackColor = SystemColors.Window
			DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle8.WrapMode = DataGridViewTriState.[False]
			Me.AltDataGridView.DefaultCellStyle = DataGridViewCellStyle8
			Dim arg_3AE3_0 As Control = Me.AltDataGridView
			location = New Point(6, 18)
			arg_3AE3_0.Location = location
			Me.AltDataGridView.Name = "AltDataGridView"
			Dim arg_3B14_0 As Control = Me.AltDataGridView
			size = New Size(144, 220)
			arg_3B14_0.Size = size
			Me.AltDataGridView.TabIndex = 0
			Me.DataGridViewTextBoxColumn17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn17.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn17.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
			Me.DataGridViewTextBoxColumn16.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn16.HeaderText = "alliance"
			Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
			Me.DataGridViewTextBoxColumn16.Visible = False
			Me.DataGridViewTextBoxColumn18.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn18.HeaderText = "x"
			Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
			Me.DataGridViewTextBoxColumn18.Visible = False
			Me.DataGridViewTextBoxColumn19.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn19.HeaderText = "y"
			Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
			Me.DataGridViewTextBoxColumn19.Visible = False
			Me.DataGridViewTextBoxColumn15.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn15.HeaderText = "id"
			Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
			Me.DataGridViewTextBoxColumn15.Visible = False
			Me.AltBindingSource.DataMember = "alt"
			Me.AltBindingSource.DataSource = Me.DbDataSet
			Me.TabPage6.Controls.Add(Me.Button12)
			Me.TabPage6.Controls.Add(Me.Button13)
			Me.TabPage6.Controls.Add(Me.FriendscoordDataGridView)
			Me.TabPage6.Controls.Add(Me.FriendsDataGridView)
			Dim arg_3CFA_0 As TabPage = Me.TabPage6
			location = New Point(4, 22)
			arg_3CFA_0.Location = location
			Me.TabPage6.Name = "TabPage6"
			Dim arg_3D22_0 As Control = Me.TabPage6
			padding = New Padding(3)
			arg_3D22_0.Padding = padding
			Dim arg_3D42_0 As Control = Me.TabPage6
			size = New Size(1008, 597)
			arg_3D42_0.Size = size
			Me.TabPage6.TabIndex = 1
			Me.TabPage6.Text = "Friendly"
			Me.TabPage6.UseVisualStyleBackColor = True
			Dim arg_3D8A_0 As Control = Me.Button12
			location = New Point(76, 254)
			arg_3D8A_0.Location = location
			Me.Button12.Name = "Button12"
			Dim arg_3DB5_0 As Control = Me.Button12
			size = New Size(55, 23)
			arg_3DB5_0.Size = size
			Me.Button12.TabIndex = 5
			Me.Button12.Text = "Delete"
			Me.Button12.UseVisualStyleBackColor = True
			Dim arg_3DFD_0 As Control = Me.Button13
			location = New Point(15, 254)
			arg_3DFD_0.Location = location
			Me.Button13.Name = "Button13"
			Dim arg_3E28_0 As Control = Me.Button13
			size = New Size(55, 23)
			arg_3E28_0.Size = size
			Me.Button13.TabIndex = 4
			Me.Button13.Text = "Update"
			Me.Button13.UseVisualStyleBackColor = True
			Me.FriendscoordDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle9.BackColor = SystemColors.Control
			DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle9.WrapMode = DataGridViewTriState.[True]
			Me.FriendscoordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
			Me.FriendscoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.FriendscoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn31 })
			Me.FriendscoordDataGridView.DataSource = Me.FriendscoordBindingSource
			DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle10.BackColor = SystemColors.Window
			DataGridViewCellStyle10.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle10.WrapMode = DataGridViewTriState.[False]
			Me.FriendscoordDataGridView.DefaultCellStyle = DataGridViewCellStyle10
			Dim arg_3FCF_0 As Control = Me.FriendscoordDataGridView
			location = New Point(165, 18)
			arg_3FCF_0.Location = location
			Me.FriendscoordDataGridView.Name = "FriendscoordDataGridView"
			Dim arg_4000_0 As Control = Me.FriendscoordDataGridView
			size = New Size(835, 544)
			arg_4000_0.Size = size
			Me.FriendscoordDataGridView.TabIndex = 1
			Me.DataGridViewTextBoxColumn32.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn32.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
			Me.DataGridViewTextBoxColumn33.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn33.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
			Me.DataGridViewTextBoxColumn36.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn36.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn36.HeaderText = "Citie"
			Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
			Me.DataGridViewTextBoxColumn34.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn34.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn34.HeaderText = "X"
			Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
			Me.DataGridViewTextBoxColumn35.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn35.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn35.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
			Me.DataGridViewTextBoxColumn31.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn31.HeaderText = "id"
			Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
			Me.DataGridViewTextBoxColumn31.Visible = False
			Me.FriendscoordBindingSource.DataMember = "friendscoord"
			Me.FriendscoordBindingSource.DataSource = Me.DbDataSet
			Me.FriendsDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle11.BackColor = SystemColors.Control
			DataGridViewCellStyle11.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle11.WrapMode = DataGridViewTriState.[True]
			Me.FriendsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
			Me.FriendsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.FriendsDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn26 })
			Me.FriendsDataGridView.DataSource = Me.FriendsBindingSource
			DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle12.BackColor = SystemColors.Window
			DataGridViewCellStyle12.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle12.WrapMode = DataGridViewTriState.[False]
			Me.FriendsDataGridView.DefaultCellStyle = DataGridViewCellStyle12
			Dim arg_42FE_0 As Control = Me.FriendsDataGridView
			location = New Point(6, 18)
			arg_42FE_0.Location = location
			Me.FriendsDataGridView.Name = "FriendsDataGridView"
			Dim arg_432F_0 As Control = Me.FriendsDataGridView
			size = New Size(144, 220)
			arg_432F_0.Size = size
			Me.FriendsDataGridView.TabIndex = 0
			Me.DataGridViewTextBoxColumn27.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn27.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn27.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
			Me.DataGridViewTextBoxColumn28.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn28.HeaderText = "player"
			Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
			Me.DataGridViewTextBoxColumn28.Visible = False
			Me.DataGridViewTextBoxColumn29.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn29.HeaderText = "x"
			Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
			Me.DataGridViewTextBoxColumn29.Visible = False
			Me.DataGridViewTextBoxColumn30.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn30.HeaderText = "y"
			Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
			Me.DataGridViewTextBoxColumn30.Visible = False
			Me.DataGridViewTextBoxColumn26.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn26.HeaderText = "id"
			Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
			Me.DataGridViewTextBoxColumn26.Visible = False
			Me.FriendsBindingSource.DataMember = "friends"
			Me.FriendsBindingSource.DataSource = Me.DbDataSet
			Me.TabPage7.Controls.Add(Me.EnemiescoordDataGridView)
			Me.TabPage7.Controls.Add(Me.EnemiesDataGridView)
			Me.TabPage7.Controls.Add(Me.Button14)
			Me.TabPage7.Controls.Add(Me.Button15)
			Dim arg_4515_0 As TabPage = Me.TabPage7
			location = New Point(4, 22)
			arg_4515_0.Location = location
			Me.TabPage7.Name = "TabPage7"
			Dim arg_453D_0 As Control = Me.TabPage7
			padding = New Padding(3)
			arg_453D_0.Padding = padding
			Dim arg_455D_0 As Control = Me.TabPage7
			size = New Size(1008, 597)
			arg_455D_0.Size = size
			Me.TabPage7.TabIndex = 2
			Me.TabPage7.Text = "Enemies"
			Me.TabPage7.UseVisualStyleBackColor = True
			Me.EnemiescoordDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle13.BackColor = SystemColors.Control
			DataGridViewCellStyle13.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle13.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle13.WrapMode = DataGridViewTriState.[True]
			Me.EnemiescoordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
			Me.EnemiescoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.EnemiescoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn42 })
			Me.EnemiescoordDataGridView.DataSource = Me.EnemiescoordBindingSource
			DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle14.BackColor = SystemColors.Window
			DataGridViewCellStyle14.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle14.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle14.WrapMode = DataGridViewTriState.[False]
			Me.EnemiescoordDataGridView.DefaultCellStyle = DataGridViewCellStyle14
			Dim arg_470C_0 As Control = Me.EnemiescoordDataGridView
			location = New Point(165, 18)
			arg_470C_0.Location = location
			Me.EnemiescoordDataGridView.Name = "EnemiescoordDataGridView"
			Dim arg_473D_0 As Control = Me.EnemiescoordDataGridView
			size = New Size(835, 544)
			arg_473D_0.Size = size
			Me.EnemiescoordDataGridView.TabIndex = 5
			Me.DataGridViewTextBoxColumn43.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn43.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn43.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
			Me.DataGridViewTextBoxColumn44.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn44.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn44.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
			Me.DataGridViewTextBoxColumn47.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn47.DataPropertyName = "citie"
			Me.DataGridViewTextBoxColumn47.HeaderText = "Citie"
			Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
			Me.DataGridViewTextBoxColumn45.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn45.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn45.HeaderText = "X"
			Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
			Me.DataGridViewTextBoxColumn46.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn46.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn46.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
			Me.DataGridViewTextBoxColumn42.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn42.HeaderText = "id"
			Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
			Me.DataGridViewTextBoxColumn42.Visible = False
			Me.EnemiescoordBindingSource.DataMember = "enemiescoord"
			Me.EnemiescoordBindingSource.DataSource = Me.DbDataSet
			Me.EnemiesDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle15.BackColor = SystemColors.Control
			DataGridViewCellStyle15.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle15.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle15.WrapMode = DataGridViewTriState.[True]
			Me.EnemiesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
			Me.EnemiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.EnemiesDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn37 })
			Me.EnemiesDataGridView.DataSource = Me.EnemiesBindingSource
			DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle16.BackColor = SystemColors.Window
			DataGridViewCellStyle16.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle16.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle16.WrapMode = DataGridViewTriState.[False]
			Me.EnemiesDataGridView.DefaultCellStyle = DataGridViewCellStyle16
			Dim arg_4A67_0 As Control = Me.EnemiesDataGridView
			location = New Point(6, 18)
			arg_4A67_0.Location = location
			Me.EnemiesDataGridView.Name = "EnemiesDataGridView"
			Dim arg_4A98_0 As Control = Me.EnemiesDataGridView
			size = New Size(144, 220)
			arg_4A98_0.Size = size
			Me.EnemiesDataGridView.TabIndex = 5
			Me.DataGridViewTextBoxColumn38.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn38.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn38.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
			Me.DataGridViewTextBoxColumn39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn39.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn39.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
			Me.DataGridViewTextBoxColumn39.Visible = False
			Me.DataGridViewTextBoxColumn40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn40.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn40.HeaderText = "X"
			Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
			Me.DataGridViewTextBoxColumn40.Visible = False
			Me.DataGridViewTextBoxColumn41.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn41.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn41.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
			Me.DataGridViewTextBoxColumn41.Visible = False
			Me.DataGridViewTextBoxColumn37.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn37.HeaderText = "id"
			Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
			Me.DataGridViewTextBoxColumn37.Visible = False
			Me.EnemiesBindingSource.DataMember = "enemies"
			Me.EnemiesBindingSource.DataSource = Me.DbDataSet
			Dim arg_4C50_0 As Control = Me.Button14
			location = New Point(76, 254)
			arg_4C50_0.Location = location
			Me.Button14.Name = "Button14"
			Dim arg_4C7B_0 As Control = Me.Button14
			size = New Size(55, 23)
			arg_4C7B_0.Size = size
			Me.Button14.TabIndex = 5
			Me.Button14.Text = "Delete"
			Me.Button14.UseVisualStyleBackColor = True
			Dim arg_4CC3_0 As Control = Me.Button15
			location = New Point(15, 254)
			arg_4CC3_0.Location = location
			Me.Button15.Name = "Button15"
			Dim arg_4CEE_0 As Control = Me.Button15
			size = New Size(55, 23)
			arg_4CEE_0.Size = size
			Me.Button15.TabIndex = 4
			Me.Button15.Text = "Update"
			Me.Button15.UseVisualStyleBackColor = True
			Me.TabPage8.Controls.Add(Me.NeutralDataGridView)
			Me.TabPage8.Controls.Add(Me.NeutralcoordDataGridView)
			Me.TabPage8.Controls.Add(Me.Button16)
			Me.TabPage8.Controls.Add(Me.Button17)
			Dim arg_4D8E_0 As TabPage = Me.TabPage8
			location = New Point(4, 22)
			arg_4D8E_0.Location = location
			Me.TabPage8.Name = "TabPage8"
			Dim arg_4DB6_0 As Control = Me.TabPage8
			padding = New Padding(3)
			arg_4DB6_0.Padding = padding
			Dim arg_4DD6_0 As Control = Me.TabPage8
			size = New Size(1008, 597)
			arg_4DD6_0.Size = size
			Me.TabPage8.TabIndex = 3
			Me.TabPage8.Text = "Neutral"
			Me.TabPage8.UseVisualStyleBackColor = True
			Me.NeutralDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle17.BackColor = SystemColors.Control
			DataGridViewCellStyle17.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle17.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle17.WrapMode = DataGridViewTriState.[True]
			Me.NeutralDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
			Me.NeutralDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.NeutralDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn53 })
			Me.NeutralDataGridView.DataSource = Me.NeutralBindingSource
			DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle18.BackColor = SystemColors.Window
			DataGridViewCellStyle18.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle18.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle18.WrapMode = DataGridViewTriState.[False]
			Me.NeutralDataGridView.DefaultCellStyle = DataGridViewCellStyle18
			Dim arg_4F76_0 As Control = Me.NeutralDataGridView
			location = New Point(6, 18)
			arg_4F76_0.Location = location
			Me.NeutralDataGridView.Name = "NeutralDataGridView"
			Dim arg_4FA7_0 As Control = Me.NeutralDataGridView
			size = New Size(144, 220)
			arg_4FA7_0.Size = size
			Me.NeutralDataGridView.TabIndex = 5
			Me.DataGridViewTextBoxColumn54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn54.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn54.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
			Me.DataGridViewTextBoxColumn55.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn55.HeaderText = "player"
			Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
			Me.DataGridViewTextBoxColumn55.Visible = False
			Me.DataGridViewTextBoxColumn56.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn56.HeaderText = "x"
			Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
			Me.DataGridViewTextBoxColumn56.Visible = False
			Me.DataGridViewTextBoxColumn57.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn57.HeaderText = "y"
			Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
			Me.DataGridViewTextBoxColumn57.Visible = False
			Me.DataGridViewTextBoxColumn53.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn53.HeaderText = "id"
			Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
			Me.DataGridViewTextBoxColumn53.Visible = False
			Me.NeutralBindingSource.DataMember = "neutral"
			Me.NeutralBindingSource.DataSource = Me.DbDataSet
			Me.NeutralcoordDataGridView.AutoGenerateColumns = False
			DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle19.BackColor = SystemColors.Control
			DataGridViewCellStyle19.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle19.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle19.WrapMode = DataGridViewTriState.[True]
			Me.NeutralcoordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
			Me.NeutralcoordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.NeutralcoordDataGridView.Columns.AddRange(New DataGridViewColumn()() = { Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn48 })
			Me.NeutralcoordDataGridView.DataSource = Me.NeutralcoordBindingSource
			DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle20.BackColor = SystemColors.Window
			DataGridViewCellStyle20.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle20.ForeColor = SystemColors.ControlText
			DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle20.WrapMode = DataGridViewTriState.[False]
			Me.NeutralcoordDataGridView.DefaultCellStyle = DataGridViewCellStyle20
			Dim arg_5291_0 As Control = Me.NeutralcoordDataGridView
			location = New Point(165, 18)
			arg_5291_0.Location = location
			Me.NeutralcoordDataGridView.Name = "NeutralcoordDataGridView"
			DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridViewCellStyle21.BackColor = SystemColors.Control
			DataGridViewCellStyle21.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			DataGridViewCellStyle21.ForeColor = SystemColors.WindowText
			DataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight
			DataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText
			DataGridViewCellStyle21.WrapMode = DataGridViewTriState.[True]
			Me.NeutralcoordDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
			Dim arg_5331_0 As Control = Me.NeutralcoordDataGridView
			size = New Size(835, 544)
			arg_5331_0.Size = size
			Me.NeutralcoordDataGridView.TabIndex = 5
			Me.DataGridViewTextBoxColumn49.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn49.DataPropertyName = "alliance"
			Me.DataGridViewTextBoxColumn49.HeaderText = "Alliance"
			Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
			Me.DataGridViewTextBoxColumn50.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn50.DataPropertyName = "player"
			Me.DataGridViewTextBoxColumn50.HeaderText = "Player"
			Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
			Me.DataGridViewTextBoxColumn51.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn51.DataPropertyName = "x"
			Me.DataGridViewTextBoxColumn51.HeaderText = "X"
			Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
			Me.DataGridViewTextBoxColumn52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			Me.DataGridViewTextBoxColumn52.DataPropertyName = "y"
			Me.DataGridViewTextBoxColumn52.HeaderText = "Y"
			Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
			Me.DataGridViewTextBoxColumn48.DataPropertyName = "id"
			Me.DataGridViewTextBoxColumn48.HeaderText = "id"
			Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
			Me.DataGridViewTextBoxColumn48.Visible = False
			Me.NeutralcoordBindingSource.DataMember = "neutralcoord"
			Me.NeutralcoordBindingSource.DataSource = Me.DbDataSet
			Dim arg_54C2_0 As Control = Me.Button16
			location = New Point(76, 254)
			arg_54C2_0.Location = location
			Me.Button16.Name = "Button16"
			Dim arg_54ED_0 As Control = Me.Button16
			size = New Size(55, 23)
			arg_54ED_0.Size = size
			Me.Button16.TabIndex = 5
			Me.Button16.Text = "Delete"
			Me.Button16.UseVisualStyleBackColor = True
			Dim arg_5535_0 As Control = Me.Button17
			location = New Point(15, 254)
			arg_5535_0.Location = location
			Me.Button17.Name = "Button17"
			Dim arg_5560_0 As Control = Me.Button17
			size = New Size(55, 23)
			arg_5560_0.Size = size
			Me.Button17.TabIndex = 4
			Me.Button17.Text = "Update"
			Me.Button17.UseVisualStyleBackColor = True
			Me.Timer1.Interval = 1000
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
			Me.Hero_allianceTableAdapter.ClearBeforeFill = True
			Me.AltTableAdapter.ClearBeforeFill = True
			Me.AltcoordTableAdapter.ClearBeforeFill = True
			Me.FriendsTableAdapter.ClearBeforeFill = True
			Me.FriendscoordTableAdapter.ClearBeforeFill = True
			Me.EnemiesTableAdapter.ClearBeforeFill = True
			Me.EnemiescoordTableAdapter.ClearBeforeFill = True
			Me.NeutralcoordTableAdapter.ClearBeforeFill = True
			Me.NeutralTableAdapter.ClearBeforeFill = True
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(1030, 679)
			Me.ClientSize = size
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Vscaner"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Vscaner"
			(CType(Me.VisualStyler1, ISupportInitialize)).EndInit()
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.TabPage1.PerformLayout()
			(CType(Me.AxShockwaveFlash1, ISupportInitialize)).EndInit()
			Me.TabPage2.ResumeLayout(False)
			(CType(Me.CordinDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.CordinBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.DbDataSet, ISupportInitialize)).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.TabPage3.ResumeLayout(False)
			(CType(Me.Hero_allianceDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.Hero_allianceBindingSource, ISupportInitialize)).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.TabPage4.ResumeLayout(False)
			Me.TabControl2.ResumeLayout(False)
			Me.TabPage5.ResumeLayout(False)
			(CType(Me.AltcoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.AltcoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.AltDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.AltBindingSource, ISupportInitialize)).EndInit()
			Me.TabPage6.ResumeLayout(False)
			(CType(Me.FriendscoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.FriendscoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.FriendsDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.FriendsBindingSource, ISupportInitialize)).EndInit()
			Me.TabPage7.ResumeLayout(False)
			(CType(Me.EnemiescoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.EnemiescoordBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.EnemiesDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.EnemiesBindingSource, ISupportInitialize)).EndInit()
			Me.TabPage8.ResumeLayout(False)
			(CType(Me.NeutralDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.NeutralBindingSource, ISupportInitialize)).EndInit()
			(CType(Me.NeutralcoordDataGridView, ISupportInitialize)).EndInit()
			(CType(Me.NeutralcoordBindingSource, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Public Sub New()
			MyBase.Load += New EventHandler(Me.Vscaner_Load)
			Vscaner.__ENCAddToList(Me)
			Me.InitializeComponent()
			Me.license = New Manco.Licensing.License(Me)
			Me.license.LicensedAssembly = GetType(Vscaner).Assembly
			Me.licenseProperties = Me.license.GetLicenseProperties()
			Me.license.CustomProfileMode = CustomProfileMode.Combine
			Me.license.CustomProfile = Environment.MachineName
			Me.licenseState = Me.license.GetLicenseState(True)
			Me.helper = New AwsHelper(Me.license, Vscaner.AwsUri)
		End Sub

		Friend Shared Sub ProcessException(exc As Exception)
			Dim flag As Boolean = exc.Message.Contains("Manco.Licensing.ActivationWebService.Exceptions.AllowedActivationsExceededException")
			If flag Then
				MessageBox.Show("Number of the allowed activations exceeded.")
			Else
				MessageBox.Show("Exception during activation:" & vbLf + exc.ToString())
			End If
		End Sub

		Private Function ConfirmValidation() As Boolean
			Dim lsMessage As String = "Application will attempt to verify your license online now. Active Internet connection will be necessary in order to connect the AWS. You can allow doing it right now, or when application will be run next time. You can bypass verification 4 times only. After that your license will be switched to evaluation version.\nDo you want allow online verification now?"
			Dim result As DialogResult = MessageBox.Show(lsMessage, "Sample Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			Return result = DialogResult.Yes
		End Function

		Private Sub Vscaner_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.licenseState.IsEvaluation Or Not Me.licenseState.IsValid
			Dim flag2 As Boolean
			If flag Then
				Me.license.ClearUnlockKeys()
				Dim loForm As LicenseForm = New LicenseForm(Me.license)
				flag = (loForm.ShowDialog() = DialogResult.OK And Operators.CompareString(loForm.UnlockKey.Trim(), String.Empty, False) <> 0 And Operators.CompareString(loForm.ActivationKey.Trim(), String.Empty, False) <> 0)
				If flag Then
					flag2 = (loForm.IsAwsCalled Or Not Me.licenseProperties.DoForceValidation)
					If flag2 Then
						Me.license.UnlockKey = loForm.UnlockKey
						Me.license.ActivationKey = loForm.ActivationKey
					Else
						MessageBox.Show("You must click 'Activate' button on the evaluation formto activate your copy of the product on this PC.")
					End If
				Else
					flag2 = Me.licenseState.IsEvaluationExpired
					If flag2 Then
						Application.[Exit]()
					End If
				End If
			End If
			flag2 = Me.licenseState.IsValid
			If flag2 Then
				flag = Not String.IsNullOrEmpty(Me.license.ActivationKey)
				If flag Then
					Dim validationParameters As ValidationParameters = New ValidationParameters()
					validationParameters.ValidationIntervalType = ValidationIntervalType.Weekly
					validationParameters.RepeatCount = 2
					validationParameters.NumberOfFailureAllowed = 4
					validationParameters.FailureAction = FailureAction.SwitchToEvaluation
					validationParameters.ExpirationRule = "ExpirationDates"
					validationParameters.ExpirationValue = "3"
					Try
						Me.helper.ValidateProductAsync(New Func(Of Boolean)(Me.ConfirmValidation), validationParameters).ContinueWith(Sub(validationTask As Task(Of AwsValidateProductEventArgs))
							Dim flag3 As Boolean = validationTask.IsCompleted
							If flag3 Then
								Dim args As AwsValidateProductEventArgs = validationTask.Result
								flag3 = (args.Exception IsNot Nothing)
								If flag3 Then
									Vscaner.ProcessException(args.Exception)
								End If
								flag3 = args.IsValid
								If flag3 Then
									Me.GetCustomerInfo()
								Else
									Application.[Exit]()
								End If
							Else
								flag3 = (validationTask.Exception IsNot Nothing)
								If flag3 Then
									Vscaner.ProcessException(validationTask.Exception)
									Application.[Exit]()
								End If
							End If
						End Sub)
					Catch expr_185 As Exception
						ProjectData.SetProjectError(expr_185)
						Dim exc As Exception = expr_185
						Vscaner.ProcessException(exc)
						Application.[Exit]()
						ProjectData.ClearProjectError()
						Return
					End Try
				Else
					Me.InitializeUi()
				End If
			Else
				MessageBox.Show("License Not Valid" & vbCrLf & "Invalid Validator: " + Me.licenseState.InvalidValidator.ToString(), "Sample Application", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Application.[Exit]()
			End If
			Me.NeutralTableAdapter.Fill(Me.DbDataSet.neutral)
			Me.NeutralcoordTableAdapter.Fill(Me.DbDataSet.neutralcoord)
			Me.EnemiescoordTableAdapter.Fill(Me.DbDataSet.enemiescoord)
			Me.EnemiesTableAdapter.Fill(Me.DbDataSet.enemies)
			Me.FriendscoordTableAdapter.Fill(Me.DbDataSet.friendscoord)
			Me.FriendsTableAdapter.Fill(Me.DbDataSet.friends)
			Me.AltcoordTableAdapter.Fill(Me.DbDataSet.altcoord)
			Me.AltTableAdapter.Fill(Me.DbDataSet.alt)
			Me.Hero_allianceTableAdapter.Fill(Me.DbDataSet.hero_alliance)
			Me.CordinTableAdapter.Fill(Me.DbDataSet.cordin)
		End Sub

		Private Sub GetCustomerInfo()
			Dim customerInfo As String = Me.license.GetCustomValue("CustomerInfo")
			Dim flag As Boolean = String.IsNullOrEmpty(customerInfo)
			If flag Then
				Me.helper.GetCustomerInfoAsync().ContinueWith(Sub(customerTask As Task(Of String))
					customerInfo = customerTask.Result
					Dim flag2 As Boolean = Not String.IsNullOrEmpty(customerInfo)
					If flag2 Then
						Me.license.SetCustomValue("CustomerInfo", customerInfo)
					End If
					Me.InitializeUi()
				End Sub)
			Else
				Me.InitializeUi()
			End If
		End Sub

		Private Sub InitializeUi()
			Me.BeginInvoke(Sub()
				Dim customerInfo As String = Me.license.GetCustomValue("CustomerInfo")
				Dim flag As Boolean = Not String.IsNullOrEmpty(customerInfo)
				If flag Then
					Dim lxmlCustomerDoc As XmlDocument = Me.license.DecryptCustomerInfo(customerInfo)
				End If
			End Sub)
		End Sub

		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.AxShockwaveFlash1.Movie = Application.StartupPath + "\ebaybot.swf"
		End Sub

		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim player As player = New player()
			Dim message As String = Conversions.ToString(Me.CordinDataGridView.CurrentRow.Cells(3).Value)
			Dim message2 As String = Conversions.ToString(Me.CordinDataGridView.CurrentRow.Cells(4).Value)
			player.Label5.Text = message
			player.Label6.Text = message2
			player.Label7.Text = message
			Me.DialogResult = DialogResult.OK
			player.Show()
		End Sub

		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Dim map As map = New map()
			map.Show()
		End Sub

		Private Sub AxShockwaveFlash1_FSCommand(sender As Object, e As _IShockwaveFlashEvents_FSCommandEvent)
			Dim flag As Boolean = Operators.CompareString(e.command, "scan", False) = 0
			If flag Then
				Me.TextBox2.AppendText(e.args.ToString() + Environment.NewLine)
			End If
			flag = (Operators.CompareString(e.command, "hero", False) = 0)
			If flag Then
				Me.TextBox3.AppendText(e.args.ToString() + Environment.NewLine)
			End If
			flag = (Operators.CompareString(e.command, "flats", False) = 0)
			If flag Then
				Me.TextBox4.AppendText(e.args.ToString() + Environment.NewLine)
			End If
			flag = (Operators.CompareString(e.command, "scannr", False) = 0)
			If flag Then
				Me.Label7.Text = e.args.ToString()
			End If
			flag = (Operators.CompareString(e.command, "heronr", False) = 0)
			If flag Then
				Me.Label8.Text = e.args.ToString()
			End If
			flag = (Operators.CompareString(e.command, "hunt", False) = 0)
			If flag Then
				Me.TextBox5.AppendText(e.args.ToString() + Environment.NewLine)
			End If
			flag = (Operators.CompareString(e.command, "herotrack", False) = 0)
			If flag Then
				Me.TextBox1.AppendText(e.args.ToString() + Environment.NewLine)
			End If
			flag = (Operators.CompareString(e.command, "scantrack", False) = 0)
			If flag Then
				Me.TextBox1.AppendText(e.args.ToString() + Environment.NewLine)
			End If
		End Sub

		Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
			Me.Label10.Text = Conversions.ToString(Me.TextBox2.Lines.Count(Of String)())
		End Sub

		Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
			Me.Label12.Text = Conversions.ToString(Me.TextBox3.Lines.Count(Of String)())
		End Sub

		Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
			Me.Label14.Text = Conversions.ToString(Me.TextBox4.Lines.Count(Of String)())
		End Sub

		Private Sub Label7_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox2.Text, "", False) <> 0
			If flag Then
				Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Dim com As OleDbCommand = New OleDbCommand("DELETE FROM cordin", Con)
				Con.Open()
				com.ExecuteNonQuery()
				Con.Close()
			End If
			flag = (Operators.CompareString(Me.TextBox4.Text, "", False) <> 0)
			If flag Then
				Dim Con2 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Dim com2 As OleDbCommand = New OleDbCommand("DELETE FROM flats", Con2)
				Con2.Open()
				com2.ExecuteNonQuery()
				Con2.Close()
			End If
			flag = (Operators.CompareString(Me.TextBox5.Text, "", False) <> 0)
			If flag Then
				Dim Con3 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Dim com3 As OleDbCommand = New OleDbCommand("DELETE FROM hunt", Con3)
				Con3.Open()
				com3.ExecuteNonQuery()
				Con3.Close()
			End If
			flag = (Operators.CompareString(Me.TextBox2.Text, "", False) <> 0)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.ProgressBar1.Visible = True
				Me.ProgressBar1.Minimum = 0
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = Conversions.ToInteger(Me.Label10.Text)
				Me.TextBox1.AppendText("Start saving Map scan data to db." + Environment.NewLine)
				Dim objCmd As OleDbCommand = New OleDbCommand()
				Dim Con4 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Con4.Open()
				Dim id As Integer = 1
				Dim arr As String() = Strings.Split(Me.TextBox2.Text, vbCrLf, -1, CompareMethod.Binary)
				Dim arg_1B9_0 As Integer = 0
				Dim num As Integer = Information.UBound(arr, 1)
				Dim d As Integer = arg_1B9_0
				While True
					Dim arg_2D6_0 As Integer = d
					Dim num2 As Integer = num
					If arg_2D6_0 > num2 Then
						Exit While
					End If
					Try
						Dim parts As String() = arr(d).ToString().Split(New Char()() = { "," })
						Dim SQL As String = String.Concat(New String()() = { "INSERT INTO cordin (x, y, citie, player, alliance, ID) VALUES ('", parts(0), "', '", parts(1), "','", parts(2), "','", parts(3), "', '", parts(4), "',", id.ToString(), ")" })
						Dim Cmd As OleDbCommand = New OleDbCommand(SQL, Con4)
						id += 1
						objCmd = New OleDbCommand(SQL, Con4)
						objCmd.ExecuteNonQuery()
						Dim progressBar As ProgressBar = Me.ProgressBar1
						progressBar.Value += 1
					Catch expr_2B6 As Exception
						ProjectData.SetProjectError(expr_2B6)
						ProjectData.ClearProjectError()
					End Try
					d += 1
				End While
				Con4.Close()
				Me.ProgressBar1.Visible = False
				Me.TextBox2.Text = ""
				Me.Label7.Text = "0"
				Me.TextBox1.AppendText("Cities data saving is finish." + Environment.NewLine)
				Me.Label18.Text = Conversions.ToString(DateAndTime.TimeOfDay)
			End If
			flag = (Operators.CompareString(Me.TextBox4.Text, "", False) <> 0)
			If flag Then
				Me.ProgressBar1.Visible = True
				Me.ProgressBar1.Minimum = 0
				Me.ProgressBar1.Value = 0
				Me.TextBox1.AppendText("Start saving Flats data to db." + Environment.NewLine)
				Me.ProgressBar1.Maximum = Conversions.ToInteger(Me.Label14.Text)
				Dim objCmd2 As OleDbCommand = New OleDbCommand()
				Dim Con5 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Con5.Open()
				Dim id2 As Integer = 1
				Dim arr2 As String() = Strings.Split(Me.TextBox4.Text, vbCrLf, -1, CompareMethod.Binary)
				Dim arg_409_0 As Integer = 0
				Dim num3 As Integer = Information.UBound(arr2, 1)
				Dim d2 As Integer = arg_409_0
				While True
					Dim arg_4FC_0 As Integer = d2
					Dim num2 As Integer = num3
					If arg_4FC_0 > num2 Then
						Exit While
					End If
					Try
						Dim parts2 As String() = arr2(d2).ToString().Split(New Char()() = { "," })
						Dim SQL2 As String = String.Concat(New String()() = { "INSERT INTO flats (x, y, [level], ID) VALUES (", parts2(0), ", ", parts2(1), ",", parts2(2), ",", id2.ToString(), ")" })
						Dim Cmd2 As OleDbCommand = New OleDbCommand(SQL2, Con5)
						id2 += 1
						objCmd2 = New OleDbCommand(SQL2, Con5)
						objCmd2.ExecuteNonQuery()
						Dim progressBar As ProgressBar = Me.ProgressBar1
						progressBar.Value += 1
					Catch expr_4DC As Exception
						ProjectData.SetProjectError(expr_4DC)
						ProjectData.ClearProjectError()
					End Try
					d2 += 1
				End While
				Con5.Close()
				Me.ProgressBar1.Visible = False
				Me.TextBox4.Text = ""
				Me.Label7.Text = "0"
				Me.TextBox1.AppendText("Flats data saving is finish." + Environment.NewLine)
				Me.Label20.Text = Conversions.ToString(DateAndTime.TimeOfDay)
			End If
			flag = (Operators.CompareString(Me.TextBox5.Text, "", False) <> 0)
			If flag Then
				Me.TextBox1.AppendText("Start saving Hunt data to db." + Environment.NewLine)
				Dim objCmd3 As OleDbCommand = New OleDbCommand()
				Dim Con6 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Con6.Open()
				Dim id3 As Integer = 1
				Dim arr3 As String() = Strings.Split(Me.TextBox5.Text, vbCrLf, -1, CompareMethod.Binary)
				Dim arg_5EC_0 As Integer = 0
				Dim num4 As Integer = Information.UBound(arr3, 1)
				Dim d3 As Integer = arg_5EC_0
				While True
					Dim arg_6C6_0 As Integer = d3
					Dim num2 As Integer = num4
					If arg_6C6_0 > num2 Then
						Exit While
					End If
					Try
						Dim parts3 As String() = arr3(d3).ToString().Split(New Char()() = { "," })
						Dim SQL3 As String = String.Concat(New String()() = { "INSERT INTO hunt (x, y, player, ID) VALUES (", parts3(0), ", ", parts3(1), ",'", parts3(2), "',", id3.ToString(), ")" })
						Dim Cmd3 As OleDbCommand = New OleDbCommand(SQL3, Con6)
						id3 += 1
						objCmd3 = New OleDbCommand(SQL3, Con6)
						objCmd3.ExecuteNonQuery()
					Catch expr_6A6 As Exception
						ProjectData.SetProjectError(expr_6A6)
						ProjectData.ClearProjectError()
					End Try
					d3 += 1
				End While
				Con6.Close()
				Me.TextBox5.Text = ""
				Me.TextBox1.AppendText("Finished saving data to db." + Environment.NewLine)
			End If
		End Sub

		Private Sub Label8_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox3.Text, "", False) <> 0
			If flag Then
				Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Dim com As OleDbCommand = New OleDbCommand("DELETE FROM hero", Con)
				Con.Open()
				com.ExecuteNonQuery()
				Con.Close()
			End If
			flag = (Operators.CompareString(Me.TextBox3.Text, "", False) <> 0)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.ProgressBar1.Visible = True
				Me.ProgressBar1.Minimum = 0
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = Conversions.ToInteger(Me.Label12.Text)
				Me.TextBox1.AppendText("Start saving Hero data to db." + Environment.NewLine)
				Dim objCmd As OleDbCommand = New OleDbCommand()
				Dim Con2 As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb")
				Con2.Open()
				Dim id As Integer = 1
				Dim arr As String() = Strings.Split(Me.TextBox3.Text, vbCrLf, -1, CompareMethod.Binary)
				Dim arg_113_0 As Integer = 0
				Dim num As Integer = Information.UBound(arr, 1)
				Dim d As Integer = arg_113_0
				While True
					Dim arg_258_0 As Integer = d
					Dim num2 As Integer = num
					If arg_258_0 > num2 Then
						Exit While
					End If
					Try
						Dim parts As String() = arr(d).ToString().Split(New Char()() = { "," })
						Dim SQL As String = String.Concat(New String()() = { "INSERT INTO hero ( [hero nr], [hero name], [player name], [level], polit, att, intel,id) VALUES (", parts(0), ", '", parts(1), "','", parts(2), "','", parts(3), "', '", parts(4), "','", parts(5), "',' ", parts(6), "',", id.ToString(), ")" })
						Dim Cmd As OleDbCommand = New OleDbCommand(SQL, Con2)
						id += 1
						objCmd = New OleDbCommand(SQL, Con2)
						objCmd.ExecuteNonQuery()
						Dim progressBar As ProgressBar = Me.ProgressBar1
						progressBar.Value += 1
					Catch expr_238 As Exception
						ProjectData.SetProjectError(expr_238)
						ProjectData.ClearProjectError()
					End Try
					d += 1
				End While
				Con2.Close()
				Me.ProgressBar1.Visible = False
				Me.TextBox3.Text = ""
				Me.Label8.Text = "0"
				Me.TextBox1.AppendText("Hero data saving is finish." + Environment.NewLine)
				Me.Label19.Text = Conversions.ToString(DateAndTime.TimeOfDay)
			End If
		End Sub

		Private Sub CordinBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.CordinBindingSource.EndEdit()
			Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
		End Sub

		Private Sub CordinDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.CordinDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.CordinDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs)
			Me.TextBox1.Text = ""
		End Sub

		Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.RadioButton1.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchcitie(Me.DbDataSet.cordin, Me.TextBox9.Text)
				Catch expr_37 As Exception
					ProjectData.SetProjectError(expr_37)
					Dim ex As Exception = expr_37
					MessageBox.Show(ex.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton2.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchplayer(Me.DbDataSet.cordin, Me.TextBox9.Text)
				Catch expr_8A As Exception
					ProjectData.SetProjectError(expr_8A)
					Dim ex2 As Exception = expr_8A
					MessageBox.Show(ex2.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton3.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchalliance(Me.DbDataSet.cordin, Me.TextBox9.Text)
				Catch expr_DD As Exception
					ProjectData.SetProjectError(expr_DD)
					Dim ex3 As Exception = expr_DD
					MessageBox.Show(ex3.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton4.Checked
			If checked Then
				Try
					Me.CordinTableAdapter.searchmix(Me.DbDataSet.cordin, Me.TextBox9.Text, Me.TextBox9.Text, Me.TextBox9.Text)
				Catch expr_146 As Exception
					ProjectData.SetProjectError(expr_146)
					Dim ex4 As Exception = expr_146
					MessageBox.Show(ex4.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
		End Sub

		Private Sub Hero_allianceDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.Hero_allianceDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.Hero_allianceDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim map As map = New map()
			map.Show()
		End Sub

		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Dim player As player = New player()
			Dim message As String = Conversions.ToString(Me.Hero_allianceDataGridView.CurrentRow.Cells(2).Value)
			Dim message2 As String = Conversions.ToString(Me.Hero_allianceDataGridView.CurrentRow.Cells(3).Value)
			player.Label5.Text = message
			player.Label6.Text = message2
			player.Label7.Text = message
			Me.DialogResult = DialogResult.OK
			player.Show()
		End Sub

		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.RadioButton5.Checked
			If checked Then
				Try
					Me.Hero_allianceTableAdapter.searchhero(Me.DbDataSet.hero_alliance, Me.TextBox8.Text)
				Catch expr_35 As Exception
					ProjectData.SetProjectError(expr_35)
					Dim ex As Exception = expr_35
					MessageBox.Show(ex.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton6.Checked
			If checked Then
				Try
					Me.Hero_allianceTableAdapter.searchplayer1(Me.DbDataSet.hero_alliance, Me.TextBox8.Text)
				Catch expr_86 As Exception
					ProjectData.SetProjectError(expr_86)
					Dim ex2 As Exception = expr_86
					MessageBox.Show(ex2.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
			checked = Me.RadioButton7.Checked
			If checked Then
				Try
					Me.Hero_allianceTableAdapter.searchalliance1(Me.DbDataSet.hero_alliance, Me.TextBox8.Text)
				Catch expr_D7 As Exception
					ProjectData.SetProjectError(expr_D7)
					Dim ex3 As Exception = expr_D7
					MessageBox.Show(ex3.Message)
					ProjectData.ClearProjectError()
				End Try
			End If
		End Sub

		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			Dim FileToSaveAs As String = thepath + "\" + Me.TextBox9.Text + ".txt"
			Dim objwriter As StreamWriter = New StreamWriter(FileToSaveAs, False)
			objwriter.WriteLine("    ")
			objwriter.WriteLine("Search")
			objwriter.WriteLine(" X , Y ,Citie,Player,Alliance")
			objwriter.WriteLine("-------------------------------")
			Dim arg_71_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.CordinDataGridView.Rows.Count - 1
			Dim iRow As Integer = arg_71_0
			While True
				Dim arg_F0_0 As Integer = iRow
				Dim num2 As Integer = num
				If arg_F0_0 > num2 Then
					Exit While
				End If
				Dim iCol As Integer = 0
				Dim arg_CF_0 As Integer
				Do
					Dim flag As Boolean = iCol > 0
					If flag Then
						objwriter.Write(",")
					End If
					objwriter.Write("{0}", RuntimeHelpers.GetObjectValue(Me.CordinDataGridView.Rows(iRow).Cells(iCol).Value))
					iCol += 1
					arg_CF_0 = iCol
					num2 = 4
				Loop While arg_CF_0 <= num2
				objwriter.WriteLine()
				objwriter.WriteLine("---------------------------")
				iRow += 1
			End While
			objwriter.Close()
			Interaction.MsgBox("Saved", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			Dim FileToSaveAs As String = thepath + "\" + Me.TextBox8.Text + "heroes.txt"
			Dim objwriter As StreamWriter = New StreamWriter(FileToSaveAs, False)
			objwriter.WriteLine("Search:  " + Me.TextBox8.Text)
			objwriter.WriteLine("    ")
			objwriter.WriteLine(" Hero nr,Hero n,Player n,Alliance,Lvl,Pol,Att,Int.")
			objwriter.WriteLine("-----------------------------------------------")
			Dim arg_81_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.Hero_allianceDataGridView.Rows.Count - 1
			Dim iRow As Integer = arg_81_0
			While True
				Dim arg_100_0 As Integer = iRow
				Dim num2 As Integer = num
				If arg_100_0 > num2 Then
					Exit While
				End If
				Dim iCol As Integer = 0
				Dim arg_DF_0 As Integer
				Do
					Dim flag As Boolean = iCol > 0
					If flag Then
						objwriter.Write(",")
					End If
					objwriter.Write("{0}", RuntimeHelpers.GetObjectValue(Me.Hero_allianceDataGridView.Rows(iRow).Cells(iCol).Value))
					iCol += 1
					arg_DF_0 = iCol
					num2 = 7
				Loop While arg_DF_0 <= num2
				objwriter.WriteLine()
				objwriter.WriteLine("-------------------------------------------")
				iRow += 1
			End While
			objwriter.Close()
			Interaction.MsgBox("Saved", MsgBoxStyle.OkOnly, Nothing)
		End Sub

		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Me.Hero_allianceTableAdapter.Fill(Me.DbDataSet.hero_alliance)
		End Sub

		Private Sub AltcoordDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.AltcoordDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.AltcoordDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub AltDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.AltDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.AltDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Button10_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.AltBindingSource.EndEdit()
			Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
			Me.AltcoordTableAdapter.Fill(Me.DbDataSet.altcoord)
		End Sub

		Private Sub Button11_Click(sender As Object, e As EventArgs)
			Me.AltDataGridView.Rows.RemoveAt(Me.AltDataGridView.CurrentRow.Index)
		End Sub

		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.FriendsBindingSource.EndEdit()
			Me.FriendsTableAdapter.Update(Me.DbDataSet)
			Me.FriendscoordTableAdapter.Fill(Me.DbDataSet.friendscoord)
		End Sub

		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.FriendsDataGridView.Rows.RemoveAt(Me.FriendsDataGridView.CurrentRow.Index)
		End Sub

		Private Sub FriendsDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.FriendsDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.FriendsDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub FriendscoordDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.FriendscoordDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.FriendscoordDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.EnemiesBindingSource.EndEdit()
			Me.EnemiesTableAdapter.Update(Me.DbDataSet)
			Me.EnemiescoordTableAdapter.Fill(Me.DbDataSet.enemiescoord)
		End Sub

		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.EnemiesDataGridView.Rows.RemoveAt(Me.EnemiesDataGridView.CurrentRow.Index)
		End Sub

		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.NeutralDataGridView.Rows.RemoveAt(Me.NeutralDataGridView.CurrentRow.Index)
		End Sub

		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.Validate()
			Me.NeutralBindingSource.EndEdit()
			Me.NeutralTableAdapter.Update(Me.DbDataSet)
			Me.NeutralcoordTableAdapter.Fill(Me.DbDataSet.neutralcoord)
		End Sub

		Private Sub NeutralcoordDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.NeutralcoordDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.NeutralcoordDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub NeutralDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.NeutralDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.NeutralDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub EnemiesDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.EnemiesDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.EnemiesDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub EnemiescoordDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Me.EnemiescoordDataGridView.DefaultCellStyle.ForeColor = Color.Black
			Me.EnemiescoordDataGridView.DefaultCellStyle.BackColor = Color.Gainsboro
		End Sub

		Private Sub BuyLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Interaction.Shell("C:\Program Files\Internet Explorer\IEXPLORE.EXE http://www.mygameaid.com", AppWinStyle.MinimizedFocus, False, -1)
		End Sub

		<CompilerGenerated()>
		Private Sub _Lambda$__1(validationTask As Task(Of AwsValidateProductEventArgs))
			Dim flag As Boolean = validationTask.IsCompleted
			If flag Then
				Dim args As AwsValidateProductEventArgs = validationTask.Result
				flag = (args.Exception IsNot Nothing)
				If flag Then
					Vscaner.ProcessException(args.Exception)
				End If
				flag = args.IsValid
				If flag Then
					Me.GetCustomerInfo()
				Else
					Application.[Exit]()
				End If
			Else
				flag = (validationTask.Exception IsNot Nothing)
				If flag Then
					Vscaner.ProcessException(validationTask.Exception)
					Application.[Exit]()
				End If
			End If
		End Sub

		<CompilerGenerated()>
		Private Sub _Lambda$__3()
			Dim customerInfo As String = Me.license.GetCustomValue("CustomerInfo")
			Dim flag As Boolean = Not String.IsNullOrEmpty(customerInfo)
			If flag Then
				Dim lxmlCustomerDoc As XmlDocument = Me.license.DecryptCustomerInfo(customerInfo)
			End If
		End Sub
	End Class
End Namespace
