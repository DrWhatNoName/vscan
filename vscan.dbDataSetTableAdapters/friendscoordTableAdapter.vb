Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports vscan.My

Namespace vscan.dbDataSetTableAdapters
	<DataObject(True), HelpKeyword("vs.data.TableAdapter"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code"), ToolboxItem(True)>
	Public Class friendscoordTableAdapter
		Inherits Component

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		<AccessedThroughProperty("_adapter")>
		Private __adapter As OleDbDataAdapter

		Private _connection As OleDbConnection

		Private _transaction As OleDbTransaction

		Private _commandCollection As OleDbCommand()

		Private _clearBeforeFill As Boolean

		Private Overridable Property _adapter() As OleDbDataAdapter
			<DebuggerNonUserCode()>
			Get
				Return Me.__adapter
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbDataAdapter)
				Me.__adapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Friend ReadOnly Property Adapter() As OleDbDataAdapter
			Get
				Dim flag As Boolean = Me._adapter Is Nothing
				If flag Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Property Connection() As OleDbConnection
			Get
				Dim flag As Boolean = Me._connection Is Nothing
				If flag Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(value As OleDbConnection)
				Me._connection = value
				Dim flag As Boolean = Me.Adapter.InsertCommand IsNot Nothing
				If flag Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				flag = (Me.Adapter.DeleteCommand IsNot Nothing)
				If flag Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				flag = (Me.Adapter.UpdateCommand IsNot Nothing)
				If flag Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				' The following expression was wrapped in a checked-statement
				For i As Integer = 0 To Me.CommandCollection.Length - 1
					flag = (Me.CommandCollection(i) IsNot Nothing)
					If flag Then
						Me.CommandCollection(i).Connection = value
					End If
				Next
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Property Transaction() As OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(value As OleDbTransaction)
				Me._transaction = value
				' The following expression was wrapped in a checked-statement
				For i As Integer = 0 To Me.CommandCollection.Length - 1
					Me.CommandCollection(i).Transaction = Me._transaction
				Next
				Dim flag As Boolean = Me.Adapter IsNot Nothing AndAlso Me.Adapter.DeleteCommand IsNot Nothing
				If flag Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				flag = (Me.Adapter IsNot Nothing AndAlso Me.Adapter.InsertCommand IsNot Nothing)
				If flag Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				flag = (Me.Adapter IsNot Nothing AndAlso Me.Adapter.UpdateCommand IsNot Nothing)
				If flag Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected ReadOnly Property CommandCollection() As OleDbCommand()
			Get
				Dim flag As Boolean = Me._commandCollection Is Nothing
				If flag Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = friendscoordTableAdapter.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = friendscoordTableAdapter.__ENCList.Count = friendscoordTableAdapter.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = friendscoordTableAdapter.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = friendscoordTableAdapter.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								friendscoordTableAdapter.__ENCList(num) = friendscoordTableAdapter.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					friendscoordTableAdapter.__ENCList.RemoveRange(num, friendscoordTableAdapter.__ENCList.Count - num)
					friendscoordTableAdapter.__ENCList.Capacity = friendscoordTableAdapter.__ENCList.Count
				End If
				friendscoordTableAdapter.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Sub New()
			friendscoordTableAdapter.__ENCAddToList(Me)
			Me.ClearBeforeFill = True
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitAdapter()
			Me._adapter = New OleDbDataAdapter()
			Dim tableMapping As DataTableMapping = New DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "friendscoord"
			tableMapping.ColumnMappings.Add("id", "id")
			tableMapping.ColumnMappings.Add("alliance", "alliance")
			tableMapping.ColumnMappings.Add("player", "player")
			tableMapping.ColumnMappings.Add("x", "x")
			tableMapping.ColumnMappings.Add("y", "y")
			tableMapping.ColumnMappings.Add("citie", "citie")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitConnection()
			Me._connection = New OleDbConnection()
			Me._connection.ConnectionString = MySettings.[Default].dbConnectionString
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitCommandCollection()
			Me._commandCollection = New OleDbCommand(1)
			Me._commandCollection(0) = New OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT id, alliance, player, x, y, citie FROM friendscoord"
			Me._commandCollection(0).CommandType = CommandType.Text
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Fill(dataTable As dbDataSet.friendscoordDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim clearBeforeFill As Boolean = Me.ClearBeforeFill
			If clearBeforeFill Then
				dataTable.Clear()
			End If
			Return Me.Adapter.Fill(dataTable)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.[Select], True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function GetData() As dbDataSet.friendscoordDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As dbDataSet.friendscoordDataTable = New dbDataSet.friendscoordDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class
End Namespace
