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
	Public Class huntTableAdapter
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
			Dim _ENCList As List(Of WeakReference) = huntTableAdapter.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = huntTableAdapter.__ENCList.Count = huntTableAdapter.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = huntTableAdapter.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = huntTableAdapter.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								huntTableAdapter.__ENCList(num) = huntTableAdapter.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					huntTableAdapter.__ENCList.RemoveRange(num, huntTableAdapter.__ENCList.Count - num)
					huntTableAdapter.__ENCList.Capacity = huntTableAdapter.__ENCList.Count
				End If
				huntTableAdapter.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Sub New()
			huntTableAdapter.__ENCAddToList(Me)
			Me.ClearBeforeFill = True
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitAdapter()
			Me._adapter = New OleDbDataAdapter()
			Dim tableMapping As DataTableMapping = New DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "hunt"
			tableMapping.ColumnMappings.Add("x", "x")
			tableMapping.ColumnMappings.Add("y", "y")
			tableMapping.ColumnMappings.Add("player", "player")
			tableMapping.ColumnMappings.Add("ID", "ID")
			Me._adapter.TableMappings.Add(tableMapping)
			Me._adapter.DeleteCommand = New OleDbCommand()
			Me._adapter.DeleteCommand.Connection = Me.Connection
			Me._adapter.DeleteCommand.CommandText = "DELETE FROM `hunt` WHERE (((? = 1 AND `x` IS NULL) OR (`x` = ?)) AND ((? = 1 AND `y` IS NULL) OR (`y` = ?)) AND ((? = 1 AND `player` IS NULL) OR (`player` = ?)) AND (`ID` = ?))"
			Me._adapter.DeleteCommand.CommandType = CommandType.Text
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("IsNull_player", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_player", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New OleDbParameter("Original_ID", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, False, Nothing))
			Me._adapter.InsertCommand = New OleDbCommand()
			Me._adapter.InsertCommand.Connection = Me.Connection
			Me._adapter.InsertCommand.CommandText = "INSERT INTO `hunt` (`x`, `y`, `player`) VALUES (?, ?, ?)"
			Me._adapter.InsertCommand.CommandType = CommandType.Text
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New OleDbParameter("player", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand = New OleDbCommand()
			Me._adapter.UpdateCommand.Connection = Me.Connection
			Me._adapter.UpdateCommand.CommandText = "UPDATE `hunt` SET `x` = ?, `y` = ?, `player` = ? WHERE (((? = 1 AND `x` IS NULL) OR (`x` = ?)) AND ((? = 1 AND `y` IS NULL) OR (`y` = ?)) AND ((? = 1 AND `player` IS NULL) OR (`player` = ?)) AND (`ID` = ?))"
			Me._adapter.UpdateCommand.CommandType = CommandType.Text
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("player", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_x", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "x", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_y", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "y", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("IsNull_player", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_player", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "player", DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New OleDbParameter("Original_ID", OleDbType.[Integer], 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, False, Nothing))
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
			Me._commandCollection(0).CommandText = "SELECT x, y, player, ID FROM hunt"
			Me._commandCollection(0).CommandType = CommandType.Text
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Fill(dataTable As dbDataSet.huntDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim clearBeforeFill As Boolean = Me.ClearBeforeFill
			If clearBeforeFill Then
				dataTable.Clear()
			End If
			Return Me.Adapter.Fill(dataTable)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.[Select], True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function GetData() As dbDataSet.huntDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As dbDataSet.huntDataTable = New dbDataSet.huntDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Update(dataTable As dbDataSet.huntDataTable) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Update(dataSet As dbDataSet) As Integer
			Return Me.Adapter.Update(dataSet, "hunt")
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Update(dataRow As DataRow) As Integer
			Return Me.Adapter.Update(New DataRow()() = { dataRow })
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Update(dataRows As DataRow()) As Integer
			Return Me.Adapter.Update(dataRows)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Delete, True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Delete(Original_x As Integer?, Original_y As Integer?, Original_player As String, Original_ID As Integer) As Integer
			Dim flag As Boolean = Original_x.HasValue
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(0).Value = 0
				Me.Adapter.DeleteCommand.Parameters(1).Value = Original_x.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(0).Value = 1
				Me.Adapter.DeleteCommand.Parameters(1).Value = DBNull.Value
			End If
			flag = Original_y.HasValue
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(2).Value = 0
				Me.Adapter.DeleteCommand.Parameters(3).Value = Original_y.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(2).Value = 1
				Me.Adapter.DeleteCommand.Parameters(3).Value = DBNull.Value
			End If
			flag = (Original_player = Nothing)
			If flag Then
				Me.Adapter.DeleteCommand.Parameters(4).Value = 1
				Me.Adapter.DeleteCommand.Parameters(5).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(4).Value = 0
				Me.Adapter.DeleteCommand.Parameters(5).Value = Original_player
			End If
			Me.Adapter.DeleteCommand.Parameters(6).Value = Original_ID
			Dim previousConnectionState As ConnectionState = Me.Adapter.DeleteCommand.Connection.State
			flag = ((Me.Adapter.DeleteCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open)
			If flag Then
				Me.Adapter.DeleteCommand.Connection.Open()
			End If
			Dim Delete As Integer
			Try
				Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
				Delete = returnValue
			Finally
				flag = (previousConnectionState = ConnectionState.Closed)
				If flag Then
					Me.Adapter.DeleteCommand.Connection.Close()
				End If
			End Try
			Return Delete
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Insert, True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Insert(x As Integer?, y As Integer?, player As String) As Integer
			Dim flag As Boolean = x.HasValue
			If flag Then
				Me.Adapter.InsertCommand.Parameters(0).Value = x.Value
			Else
				Me.Adapter.InsertCommand.Parameters(0).Value = DBNull.Value
			End If
			flag = y.HasValue
			If flag Then
				Me.Adapter.InsertCommand.Parameters(1).Value = y.Value
			Else
				Me.Adapter.InsertCommand.Parameters(1).Value = DBNull.Value
			End If
			flag = (player = Nothing)
			If flag Then
				Me.Adapter.InsertCommand.Parameters(2).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(2).Value = player
			End If
			Dim previousConnectionState As ConnectionState = Me.Adapter.InsertCommand.Connection.State
			flag = ((Me.Adapter.InsertCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open)
			If flag Then
				Me.Adapter.InsertCommand.Connection.Open()
			End If
			Dim Insert As Integer
			Try
				Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
				Insert = returnValue
			Finally
				flag = (previousConnectionState = ConnectionState.Closed)
				If flag Then
					Me.Adapter.InsertCommand.Connection.Close()
				End If
			End Try
			Return Insert
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Update, True), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode()>
		Public Overridable Function Update(x As Integer?, y As Integer?, player As String, Original_x As Integer?, Original_y As Integer?, Original_player As String, Original_ID As Integer) As Integer
			Dim flag As Boolean = x.HasValue
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(0).Value = x.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(0).Value = DBNull.Value
			End If
			flag = y.HasValue
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(1).Value = y.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(1).Value = DBNull.Value
			End If
			flag = (player = Nothing)
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(2).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(2).Value = player
			End If
			flag = Original_x.HasValue
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(3).Value = 0
				Me.Adapter.UpdateCommand.Parameters(4).Value = Original_x.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(3).Value = 1
				Me.Adapter.UpdateCommand.Parameters(4).Value = DBNull.Value
			End If
			flag = Original_y.HasValue
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(5).Value = 0
				Me.Adapter.UpdateCommand.Parameters(6).Value = Original_y.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(5).Value = 1
				Me.Adapter.UpdateCommand.Parameters(6).Value = DBNull.Value
			End If
			flag = (Original_player = Nothing)
			If flag Then
				Me.Adapter.UpdateCommand.Parameters(7).Value = 1
				Me.Adapter.UpdateCommand.Parameters(8).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(7).Value = 0
				Me.Adapter.UpdateCommand.Parameters(8).Value = Original_player
			End If
			Me.Adapter.UpdateCommand.Parameters(9).Value = Original_ID
			Dim previousConnectionState As ConnectionState = Me.Adapter.UpdateCommand.Connection.State
			flag = ((Me.Adapter.UpdateCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open)
			If flag Then
				Me.Adapter.UpdateCommand.Connection.Open()
			End If
			Dim Update As Integer
			Try
				Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
				Update = returnValue
			Finally
				flag = (previousConnectionState = ConnectionState.Closed)
				If flag Then
					Me.Adapter.UpdateCommand.Connection.Close()
				End If
			End Try
			Return Update
		End Function
	End Class
End Namespace
