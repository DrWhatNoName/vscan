Imports Microsoft.VisualBasic.CompilerServices
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

Namespace vscan.dbDataSetTableAdapters
	<HelpKeyword("vs.data.TableAdapterManager"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code"), ToolboxItem(True)>
	Public Class TableAdapterManager
		Inherits Component

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Enum UpdateOrderOption
			InsertUpdateDelete
			UpdateInsertDelete
		End Enum

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Class SelfReferenceComparer
			Implements IComparer(Of DataRow)

			Private _relation As DataRelation

			Private _childFirst As Integer

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(relation As DataRelation, childFirst As Boolean)
				Me._relation = relation
				If childFirst Then
					Me._childFirst = -1
				Else
					Me._childFirst = 1
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Function GetRoot(row As DataRow, ByRef distance As Integer) As DataRow
				Debug.Assert(row IsNot Nothing)
				Dim root As DataRow = row
				distance = 0
				Dim traversedRows As IDictionary(Of DataRow, DataRow) = New Dictionary(Of DataRow, DataRow)()
				traversedRows(row) = row
				Dim parent As DataRow = row.GetParentRow(Me._relation, DataRowVersion.[Default])
				' The following expression was wrapped in a checked-statement
				While parent IsNot Nothing AndAlso Not traversedRows.ContainsKey(parent)
					distance += 1
					root = parent
					traversedRows(parent) = parent
					parent = parent.GetParentRow(Me._relation, DataRowVersion.[Default])
				End While
				Dim flag As Boolean = distance = 0
				If flag Then
					traversedRows.Clear()
					traversedRows(row) = row
					parent = row.GetParentRow(Me._relation, DataRowVersion.Original)
					While parent IsNot Nothing AndAlso Not traversedRows.ContainsKey(parent)
						distance += 1
						root = parent
						traversedRows(parent) = parent
						parent = parent.GetParentRow(Me._relation, DataRowVersion.Original)
					End While
				End If
				Return root
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Compare(row1 As DataRow, row2 As DataRow) As Integer
				Dim flag As Boolean = Object.ReferenceEquals(row1, row2)
				Dim Compare As Integer
				If flag Then
					Compare = 0
				Else
					flag = (row1 Is Nothing)
					If flag Then
						Compare = -1
					Else
						flag = (row2 Is Nothing)
						If flag Then
							Compare = 1
						Else
							Dim distance As Integer = 0
							Dim root As DataRow = Me.GetRoot(row1, distance)
							Dim distance2 As Integer = 0
							Dim root2 As DataRow = Me.GetRoot(row2, distance2)
							flag = Object.ReferenceEquals(root, root2)
							If flag Then
								' The following expression was wrapped in a checked-expression
								Compare = Me._childFirst * distance.CompareTo(distance2)
							Else
								Debug.Assert(root.Table IsNot Nothing AndAlso root2.Table IsNot Nothing)
								flag = (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
								If flag Then
									Compare = -1
								Else
									Compare = 1
								End If
							End If
						End If
					End If
				End If
				Return Compare
			End Function
		End Class

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private _updateOrder As TableAdapterManager.UpdateOrderOption

		Private _altTableAdapter As altTableAdapter

		Private _cordinTableAdapter As cordinTableAdapter

		Private _enemiesTableAdapter As enemiesTableAdapter

		Private _fieldTableAdapter As fieldTableAdapter

		Private _flatsTableAdapter As flatsTableAdapter

		Private _friendsTableAdapter As friendsTableAdapter

		Private _heroTableAdapter As heroTableAdapter

		Private _huntTableAdapter As huntTableAdapter

		Private _neutralTableAdapter As neutralTableAdapter

		Private _npcTableAdapter As npcTableAdapter

		Private _backupDataSetBeforeUpdate As Boolean

		Private _connection As IDbConnection

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Property UpdateOrder() As TableAdapterManager.UpdateOrderOption
			Get
				Return Me._updateOrder
			End Get
			Set(value As TableAdapterManager.UpdateOrderOption)
				Me._updateOrder = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property altTableAdapter() As altTableAdapter
			Get
				Return Me._altTableAdapter
			End Get
			Set(value As altTableAdapter)
				Me._altTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property cordinTableAdapter() As cordinTableAdapter
			Get
				Return Me._cordinTableAdapter
			End Get
			Set(value As cordinTableAdapter)
				Me._cordinTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property enemiesTableAdapter() As enemiesTableAdapter
			Get
				Return Me._enemiesTableAdapter
			End Get
			Set(value As enemiesTableAdapter)
				Me._enemiesTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property fieldTableAdapter() As fieldTableAdapter
			Get
				Return Me._fieldTableAdapter
			End Get
			Set(value As fieldTableAdapter)
				Me._fieldTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property flatsTableAdapter() As flatsTableAdapter
			Get
				Return Me._flatsTableAdapter
			End Get
			Set(value As flatsTableAdapter)
				Me._flatsTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property friendsTableAdapter() As friendsTableAdapter
			Get
				Return Me._friendsTableAdapter
			End Get
			Set(value As friendsTableAdapter)
				Me._friendsTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property heroTableAdapter() As heroTableAdapter
			Get
				Return Me._heroTableAdapter
			End Get
			Set(value As heroTableAdapter)
				Me._heroTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property huntTableAdapter() As huntTableAdapter
			Get
				Return Me._huntTableAdapter
			End Get
			Set(value As huntTableAdapter)
				Me._huntTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property neutralTableAdapter() As neutralTableAdapter
			Get
				Return Me._neutralTableAdapter
			End Get
			Set(value As neutralTableAdapter)
				Me._neutralTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode()>
		Public Property npcTableAdapter() As npcTableAdapter
			Get
				Return Me._npcTableAdapter
			End Get
			Set(value As npcTableAdapter)
				Me._npcTableAdapter = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Property BackupDataSetBeforeUpdate() As Boolean
			Get
				Return Me._backupDataSetBeforeUpdate
			End Get
			Set(value As Boolean)
				Me._backupDataSetBeforeUpdate = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
		Public Property Connection() As IDbConnection
			Get
				Dim flag As Boolean = Me._connection IsNot Nothing
				Dim Connection As IDbConnection
				If flag Then
					Connection = Me._connection
				Else
					flag = (Me._altTableAdapter IsNot Nothing AndAlso Me._altTableAdapter.Connection IsNot Nothing)
					If flag Then
						Connection = Me._altTableAdapter.Connection
					Else
						flag = (Me._cordinTableAdapter IsNot Nothing AndAlso Me._cordinTableAdapter.Connection IsNot Nothing)
						If flag Then
							Connection = Me._cordinTableAdapter.Connection
						Else
							flag = (Me._enemiesTableAdapter IsNot Nothing AndAlso Me._enemiesTableAdapter.Connection IsNot Nothing)
							If flag Then
								Connection = Me._enemiesTableAdapter.Connection
							Else
								flag = (Me._fieldTableAdapter IsNot Nothing AndAlso Me._fieldTableAdapter.Connection IsNot Nothing)
								If flag Then
									Connection = Me._fieldTableAdapter.Connection
								Else
									flag = (Me._flatsTableAdapter IsNot Nothing AndAlso Me._flatsTableAdapter.Connection IsNot Nothing)
									If flag Then
										Connection = Me._flatsTableAdapter.Connection
									Else
										flag = (Me._friendsTableAdapter IsNot Nothing AndAlso Me._friendsTableAdapter.Connection IsNot Nothing)
										If flag Then
											Connection = Me._friendsTableAdapter.Connection
										Else
											flag = (Me._heroTableAdapter IsNot Nothing AndAlso Me._heroTableAdapter.Connection IsNot Nothing)
											If flag Then
												Connection = Me._heroTableAdapter.Connection
											Else
												flag = (Me._huntTableAdapter IsNot Nothing AndAlso Me._huntTableAdapter.Connection IsNot Nothing)
												If flag Then
													Connection = Me._huntTableAdapter.Connection
												Else
													flag = (Me._neutralTableAdapter IsNot Nothing AndAlso Me._neutralTableAdapter.Connection IsNot Nothing)
													If flag Then
														Connection = Me._neutralTableAdapter.Connection
													Else
														flag = (Me._npcTableAdapter IsNot Nothing AndAlso Me._npcTableAdapter.Connection IsNot Nothing)
														If flag Then
															Connection = Me._npcTableAdapter.Connection
														Else
															Connection = Nothing
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				Return Connection
			End Get
			Set(value As IDbConnection)
				Me._connection = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
		Public ReadOnly Property TableAdapterInstanceCount() As Integer
			Get
				Dim count As Integer = 0
				Dim flag As Boolean = Me._altTableAdapter IsNot Nothing
				' The following expression was wrapped in a checked-statement
				If flag Then
					count += 1
				End If
				flag = (Me._cordinTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._enemiesTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._fieldTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._flatsTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._friendsTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._heroTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._huntTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._neutralTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				flag = (Me._npcTableAdapter IsNot Nothing)
				If flag Then
					count += 1
				End If
				Return count
			End Get
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			TableAdapterManager.__ENCAddToList(Me)
		End Sub

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = TableAdapterManager.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = TableAdapterManager.__ENCList.Count = TableAdapterManager.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = TableAdapterManager.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = TableAdapterManager.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								TableAdapterManager.__ENCList(num) = TableAdapterManager.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					TableAdapterManager.__ENCList.RemoveRange(num, TableAdapterManager.__ENCList.Count - num)
					TableAdapterManager.__ENCList.Capacity = TableAdapterManager.__ENCList.Count
				End If
				TableAdapterManager.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function UpdateUpdatedRows(dataSet As dbDataSet, allChangedRows As List(Of DataRow), allAddedRows As List(Of DataRow)) As Integer
			Dim result As Integer = 0
			Dim flag As Boolean = Me._altTableAdapter IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim updatedRows As DataRow() = dataSet.alt.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
				flag = (updatedRows IsNot Nothing AndAlso 0 < updatedRows.Length)
				If flag Then
					result += Me._altTableAdapter.Update(updatedRows)
					allChangedRows.AddRange(updatedRows)
				End If
			End If
			flag = (Me._cordinTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows2 As DataRow() = dataSet.cordin.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows2 = Me.GetRealUpdatedRows(updatedRows2, allAddedRows)
				flag = (updatedRows2 IsNot Nothing AndAlso 0 < updatedRows2.Length)
				If flag Then
					result += Me._cordinTableAdapter.Update(updatedRows2)
					allChangedRows.AddRange(updatedRows2)
				End If
			End If
			flag = (Me._enemiesTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows3 As DataRow() = dataSet.enemies.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows3 = Me.GetRealUpdatedRows(updatedRows3, allAddedRows)
				flag = (updatedRows3 IsNot Nothing AndAlso 0 < updatedRows3.Length)
				If flag Then
					result += Me._enemiesTableAdapter.Update(updatedRows3)
					allChangedRows.AddRange(updatedRows3)
				End If
			End If
			flag = (Me._fieldTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows4 As DataRow() = dataSet.field.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows4 = Me.GetRealUpdatedRows(updatedRows4, allAddedRows)
				flag = (updatedRows4 IsNot Nothing AndAlso 0 < updatedRows4.Length)
				If flag Then
					result += Me._fieldTableAdapter.Update(updatedRows4)
					allChangedRows.AddRange(updatedRows4)
				End If
			End If
			flag = (Me._flatsTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows5 As DataRow() = dataSet.flats.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows5 = Me.GetRealUpdatedRows(updatedRows5, allAddedRows)
				flag = (updatedRows5 IsNot Nothing AndAlso 0 < updatedRows5.Length)
				If flag Then
					result += Me._flatsTableAdapter.Update(updatedRows5)
					allChangedRows.AddRange(updatedRows5)
				End If
			End If
			flag = (Me._friendsTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows6 As DataRow() = dataSet.friends.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows6 = Me.GetRealUpdatedRows(updatedRows6, allAddedRows)
				flag = (updatedRows6 IsNot Nothing AndAlso 0 < updatedRows6.Length)
				If flag Then
					result += Me._friendsTableAdapter.Update(updatedRows6)
					allChangedRows.AddRange(updatedRows6)
				End If
			End If
			flag = (Me._heroTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows7 As DataRow() = dataSet.hero.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows7 = Me.GetRealUpdatedRows(updatedRows7, allAddedRows)
				flag = (updatedRows7 IsNot Nothing AndAlso 0 < updatedRows7.Length)
				If flag Then
					result += Me._heroTableAdapter.Update(updatedRows7)
					allChangedRows.AddRange(updatedRows7)
				End If
			End If
			flag = (Me._huntTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows8 As DataRow() = dataSet.hunt.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows8 = Me.GetRealUpdatedRows(updatedRows8, allAddedRows)
				flag = (updatedRows8 IsNot Nothing AndAlso 0 < updatedRows8.Length)
				If flag Then
					result += Me._huntTableAdapter.Update(updatedRows8)
					allChangedRows.AddRange(updatedRows8)
				End If
			End If
			flag = (Me._neutralTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows9 As DataRow() = dataSet.neutral.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows9 = Me.GetRealUpdatedRows(updatedRows9, allAddedRows)
				flag = (updatedRows9 IsNot Nothing AndAlso 0 < updatedRows9.Length)
				If flag Then
					result += Me._neutralTableAdapter.Update(updatedRows9)
					allChangedRows.AddRange(updatedRows9)
				End If
			End If
			flag = (Me._npcTableAdapter IsNot Nothing)
			If flag Then
				Dim updatedRows10 As DataRow() = dataSet.npc.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				updatedRows10 = Me.GetRealUpdatedRows(updatedRows10, allAddedRows)
				flag = (updatedRows10 IsNot Nothing AndAlso 0 < updatedRows10.Length)
				If flag Then
					result += Me._npcTableAdapter.Update(updatedRows10)
					allChangedRows.AddRange(updatedRows10)
				End If
			End If
			Return result
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function UpdateInsertedRows(dataSet As dbDataSet, allAddedRows As List(Of DataRow)) As Integer
			Dim result As Integer = 0
			Dim flag As Boolean = Me._altTableAdapter IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim addedRows As DataRow() = dataSet.alt.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows IsNot Nothing AndAlso 0 < addedRows.Length)
				If flag Then
					result += Me._altTableAdapter.Update(addedRows)
					allAddedRows.AddRange(addedRows)
				End If
			End If
			flag = (Me._cordinTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows2 As DataRow() = dataSet.cordin.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows2 IsNot Nothing AndAlso 0 < addedRows2.Length)
				If flag Then
					result += Me._cordinTableAdapter.Update(addedRows2)
					allAddedRows.AddRange(addedRows2)
				End If
			End If
			flag = (Me._enemiesTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows3 As DataRow() = dataSet.enemies.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows3 IsNot Nothing AndAlso 0 < addedRows3.Length)
				If flag Then
					result += Me._enemiesTableAdapter.Update(addedRows3)
					allAddedRows.AddRange(addedRows3)
				End If
			End If
			flag = (Me._fieldTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows4 As DataRow() = dataSet.field.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows4 IsNot Nothing AndAlso 0 < addedRows4.Length)
				If flag Then
					result += Me._fieldTableAdapter.Update(addedRows4)
					allAddedRows.AddRange(addedRows4)
				End If
			End If
			flag = (Me._flatsTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows5 As DataRow() = dataSet.flats.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows5 IsNot Nothing AndAlso 0 < addedRows5.Length)
				If flag Then
					result += Me._flatsTableAdapter.Update(addedRows5)
					allAddedRows.AddRange(addedRows5)
				End If
			End If
			flag = (Me._friendsTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows6 As DataRow() = dataSet.friends.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows6 IsNot Nothing AndAlso 0 < addedRows6.Length)
				If flag Then
					result += Me._friendsTableAdapter.Update(addedRows6)
					allAddedRows.AddRange(addedRows6)
				End If
			End If
			flag = (Me._heroTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows7 As DataRow() = dataSet.hero.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows7 IsNot Nothing AndAlso 0 < addedRows7.Length)
				If flag Then
					result += Me._heroTableAdapter.Update(addedRows7)
					allAddedRows.AddRange(addedRows7)
				End If
			End If
			flag = (Me._huntTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows8 As DataRow() = dataSet.hunt.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows8 IsNot Nothing AndAlso 0 < addedRows8.Length)
				If flag Then
					result += Me._huntTableAdapter.Update(addedRows8)
					allAddedRows.AddRange(addedRows8)
				End If
			End If
			flag = (Me._neutralTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows9 As DataRow() = dataSet.neutral.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows9 IsNot Nothing AndAlso 0 < addedRows9.Length)
				If flag Then
					result += Me._neutralTableAdapter.Update(addedRows9)
					allAddedRows.AddRange(addedRows9)
				End If
			End If
			flag = (Me._npcTableAdapter IsNot Nothing)
			If flag Then
				Dim addedRows10 As DataRow() = dataSet.npc.[Select](Nothing, Nothing, DataViewRowState.Added)
				flag = (addedRows10 IsNot Nothing AndAlso 0 < addedRows10.Length)
				If flag Then
					result += Me._npcTableAdapter.Update(addedRows10)
					allAddedRows.AddRange(addedRows10)
				End If
			End If
			Return result
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function UpdateDeletedRows(dataSet As dbDataSet, allChangedRows As List(Of DataRow)) As Integer
			Dim result As Integer = 0
			Dim flag As Boolean = Me._npcTableAdapter IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim deletedRows As DataRow() = dataSet.npc.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows IsNot Nothing AndAlso 0 < deletedRows.Length)
				If flag Then
					result += Me._npcTableAdapter.Update(deletedRows)
					allChangedRows.AddRange(deletedRows)
				End If
			End If
			flag = (Me._neutralTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows2 As DataRow() = dataSet.neutral.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows2 IsNot Nothing AndAlso 0 < deletedRows2.Length)
				If flag Then
					result += Me._neutralTableAdapter.Update(deletedRows2)
					allChangedRows.AddRange(deletedRows2)
				End If
			End If
			flag = (Me._huntTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows3 As DataRow() = dataSet.hunt.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows3 IsNot Nothing AndAlso 0 < deletedRows3.Length)
				If flag Then
					result += Me._huntTableAdapter.Update(deletedRows3)
					allChangedRows.AddRange(deletedRows3)
				End If
			End If
			flag = (Me._heroTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows4 As DataRow() = dataSet.hero.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows4 IsNot Nothing AndAlso 0 < deletedRows4.Length)
				If flag Then
					result += Me._heroTableAdapter.Update(deletedRows4)
					allChangedRows.AddRange(deletedRows4)
				End If
			End If
			flag = (Me._friendsTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows5 As DataRow() = dataSet.friends.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows5 IsNot Nothing AndAlso 0 < deletedRows5.Length)
				If flag Then
					result += Me._friendsTableAdapter.Update(deletedRows5)
					allChangedRows.AddRange(deletedRows5)
				End If
			End If
			flag = (Me._flatsTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows6 As DataRow() = dataSet.flats.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows6 IsNot Nothing AndAlso 0 < deletedRows6.Length)
				If flag Then
					result += Me._flatsTableAdapter.Update(deletedRows6)
					allChangedRows.AddRange(deletedRows6)
				End If
			End If
			flag = (Me._fieldTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows7 As DataRow() = dataSet.field.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows7 IsNot Nothing AndAlso 0 < deletedRows7.Length)
				If flag Then
					result += Me._fieldTableAdapter.Update(deletedRows7)
					allChangedRows.AddRange(deletedRows7)
				End If
			End If
			flag = (Me._enemiesTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows8 As DataRow() = dataSet.enemies.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows8 IsNot Nothing AndAlso 0 < deletedRows8.Length)
				If flag Then
					result += Me._enemiesTableAdapter.Update(deletedRows8)
					allChangedRows.AddRange(deletedRows8)
				End If
			End If
			flag = (Me._cordinTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows9 As DataRow() = dataSet.cordin.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows9 IsNot Nothing AndAlso 0 < deletedRows9.Length)
				If flag Then
					result += Me._cordinTableAdapter.Update(deletedRows9)
					allChangedRows.AddRange(deletedRows9)
				End If
			End If
			flag = (Me._altTableAdapter IsNot Nothing)
			If flag Then
				Dim deletedRows10 As DataRow() = dataSet.alt.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				flag = (deletedRows10 IsNot Nothing AndAlso 0 < deletedRows10.Length)
				If flag Then
					result += Me._altTableAdapter.Update(deletedRows10)
					allChangedRows.AddRange(deletedRows10)
				End If
			End If
			Return result
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function GetRealUpdatedRows(updatedRows As DataRow(), allAddedRows As List(Of DataRow)) As DataRow()
			Dim flag As Boolean = updatedRows Is Nothing OrElse updatedRows.Length < 1
			' The following expression was wrapped in a checked-statement
			Dim GetRealUpdatedRows As DataRow()
			If flag Then
				GetRealUpdatedRows = updatedRows
			Else
				flag = (allAddedRows Is Nothing OrElse allAddedRows.Count < 1)
				If flag Then
					GetRealUpdatedRows = updatedRows
				Else
					Dim realUpdatedRows As List(Of DataRow) = New List(Of DataRow)()
					For i As Integer = 0 To updatedRows.Length - 1
						Dim row As DataRow = updatedRows(i)
						flag = Not allAddedRows.Contains(row)
						If flag Then
							realUpdatedRows.Add(row)
						End If
					Next
					GetRealUpdatedRows = realUpdatedRows.ToArray()
				End If
			End If
			Return GetRealUpdatedRows
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Overridable Function UpdateAll(dataSet As dbDataSet) As Integer
			Dim flag As Boolean = dataSet Is Nothing
			If flag Then
				Throw New ArgumentNullException("dataSet")
			End If
			flag = Not dataSet.HasChanges()
			' The following expression was wrapped in a checked-statement
			Dim UpdateAll As Integer
			If flag Then
				UpdateAll = 0
			Else
				flag = (Me._altTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._altTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._cordinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._cordinTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._enemiesTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._enemiesTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._fieldTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._fieldTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._flatsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._flatsTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._friendsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._friendsTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._heroTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._heroTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._huntTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._huntTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._neutralTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._neutralTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				flag = (Me._npcTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._npcTableAdapter.Connection))
				If flag Then
					Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
				End If
				Dim workConnection As IDbConnection = Me.Connection
				flag = (workConnection Is Nothing)
				If flag Then
					Throw New ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.")
				End If
				Dim workConnOpened As Boolean = False
				flag = ((workConnection.State And ConnectionState.Broken) = ConnectionState.Broken)
				If flag Then
					workConnection.Close()
				End If
				flag = (workConnection.State = ConnectionState.Closed)
				If flag Then
					workConnection.Open()
					workConnOpened = True
				End If
				Dim workTransaction As IDbTransaction = workConnection.BeginTransaction()
				flag = (workTransaction Is Nothing)
				If flag Then
					Throw New ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.")
				End If
				Dim allChangedRows As List(Of DataRow) = New List(Of DataRow)()
				Dim allAddedRows As List(Of DataRow) = New List(Of DataRow)()
				Dim adaptersWithAcceptChangesDuringUpdate As List(Of DataAdapter) = New List(Of DataAdapter)()
				Dim revertConnections As Dictionary(Of Object, IDbConnection) = New Dictionary(Of Object, IDbConnection)()
				Dim result As Integer = 0
				Dim backupDataSet As DataSet = Nothing
				flag = Me.BackupDataSetBeforeUpdate
				If flag Then
					backupDataSet = New DataSet()
					backupDataSet.Merge(dataSet)
				End If
				Try
					flag = (Me._altTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._altTableAdapter, Me._altTableAdapter.Connection)
						Me._altTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._altTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._altTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._altTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._altTableAdapter.Adapter)
						End If
					End If
					flag = (Me._cordinTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._cordinTableAdapter, Me._cordinTableAdapter.Connection)
						Me._cordinTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._cordinTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._cordinTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._cordinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._cordinTableAdapter.Adapter)
						End If
					End If
					flag = (Me._enemiesTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._enemiesTableAdapter, Me._enemiesTableAdapter.Connection)
						Me._enemiesTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._enemiesTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._enemiesTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._enemiesTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._enemiesTableAdapter.Adapter)
						End If
					End If
					flag = (Me._fieldTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._fieldTableAdapter, Me._fieldTableAdapter.Connection)
						Me._fieldTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._fieldTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._fieldTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._fieldTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._fieldTableAdapter.Adapter)
						End If
					End If
					flag = (Me._flatsTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._flatsTableAdapter, Me._flatsTableAdapter.Connection)
						Me._flatsTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._flatsTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._flatsTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._flatsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._flatsTableAdapter.Adapter)
						End If
					End If
					flag = (Me._friendsTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._friendsTableAdapter, Me._friendsTableAdapter.Connection)
						Me._friendsTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._friendsTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._friendsTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._friendsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._friendsTableAdapter.Adapter)
						End If
					End If
					flag = (Me._heroTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._heroTableAdapter, Me._heroTableAdapter.Connection)
						Me._heroTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._heroTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._heroTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._heroTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._heroTableAdapter.Adapter)
						End If
					End If
					flag = (Me._huntTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._huntTableAdapter, Me._huntTableAdapter.Connection)
						Me._huntTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._huntTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._huntTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._huntTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._huntTableAdapter.Adapter)
						End If
					End If
					flag = (Me._neutralTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._neutralTableAdapter, Me._neutralTableAdapter.Connection)
						Me._neutralTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._neutralTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._neutralTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._neutralTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._neutralTableAdapter.Adapter)
						End If
					End If
					flag = (Me._npcTableAdapter IsNot Nothing)
					If flag Then
						revertConnections.Add(Me._npcTableAdapter, Me._npcTableAdapter.Connection)
						Me._npcTableAdapter.Connection = CType(workConnection, OleDbConnection)
						Me._npcTableAdapter.Transaction = CType(workTransaction, OleDbTransaction)
						flag = Me._npcTableAdapter.Adapter.AcceptChangesDuringUpdate
						If flag Then
							Me._npcTableAdapter.Adapter.AcceptChangesDuringUpdate = False
							adaptersWithAcceptChangesDuringUpdate.Add(Me._npcTableAdapter.Adapter)
						End If
					End If
					flag = (Me.UpdateOrder = TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
					If flag Then
						result += Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows)
						result += Me.UpdateInsertedRows(dataSet, allAddedRows)
					Else
						result += Me.UpdateInsertedRows(dataSet, allAddedRows)
						result += Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows)
					End If
					result += Me.UpdateDeletedRows(dataSet, allChangedRows)
					workTransaction.Commit()
					flag = (0 < allAddedRows.Count)
					If flag Then
						Dim rows As DataRow() = New DataRow(allAddedRows.Count - 1 + 1)
						allAddedRows.CopyTo(rows)
						For i As Integer = 0 To rows.Length - 1
							Dim row As DataRow = rows(i)
							row.AcceptChanges()
						Next
					End If
					flag = (0 < allChangedRows.Count)
					If flag Then
						Dim rows2 As DataRow() = New DataRow(allChangedRows.Count - 1 + 1)
						allChangedRows.CopyTo(rows2)
						For j As Integer = 0 To rows2.Length - 1
							Dim row2 As DataRow = rows2(j)
							row2.AcceptChanges()
						Next
					End If
				Catch expr_963 As Exception
					ProjectData.SetProjectError(expr_963)
					Dim ex As Exception = expr_963
					workTransaction.Rollback()
					flag = Me.BackupDataSetBeforeUpdate
					If flag Then
						Debug.Assert(backupDataSet IsNot Nothing)
						dataSet.Clear()
						dataSet.Merge(backupDataSet)
					Else
						flag = (0 < allAddedRows.Count)
						If flag Then
							Dim rows3 As DataRow() = New DataRow(allAddedRows.Count - 1 + 1)
							allAddedRows.CopyTo(rows3)
							For k As Integer = 0 To rows3.Length - 1
								Dim row3 As DataRow = rows3(k)
								row3.AcceptChanges()
								row3.SetAdded()
							Next
						End If
					End If
					Throw ex
				Finally
					flag = workConnOpened
					If flag Then
						workConnection.Close()
					End If
					flag = (Me._altTableAdapter IsNot Nothing)
					If flag Then
						Me._altTableAdapter.Connection = CType(revertConnections(Me._altTableAdapter), OleDbConnection)
						Me._altTableAdapter.Transaction = Nothing
					End If
					flag = (Me._cordinTableAdapter IsNot Nothing)
					If flag Then
						Me._cordinTableAdapter.Connection = CType(revertConnections(Me._cordinTableAdapter), OleDbConnection)
						Me._cordinTableAdapter.Transaction = Nothing
					End If
					flag = (Me._enemiesTableAdapter IsNot Nothing)
					If flag Then
						Me._enemiesTableAdapter.Connection = CType(revertConnections(Me._enemiesTableAdapter), OleDbConnection)
						Me._enemiesTableAdapter.Transaction = Nothing
					End If
					flag = (Me._fieldTableAdapter IsNot Nothing)
					If flag Then
						Me._fieldTableAdapter.Connection = CType(revertConnections(Me._fieldTableAdapter), OleDbConnection)
						Me._fieldTableAdapter.Transaction = Nothing
					End If
					flag = (Me._flatsTableAdapter IsNot Nothing)
					If flag Then
						Me._flatsTableAdapter.Connection = CType(revertConnections(Me._flatsTableAdapter), OleDbConnection)
						Me._flatsTableAdapter.Transaction = Nothing
					End If
					flag = (Me._friendsTableAdapter IsNot Nothing)
					If flag Then
						Me._friendsTableAdapter.Connection = CType(revertConnections(Me._friendsTableAdapter), OleDbConnection)
						Me._friendsTableAdapter.Transaction = Nothing
					End If
					flag = (Me._heroTableAdapter IsNot Nothing)
					If flag Then
						Me._heroTableAdapter.Connection = CType(revertConnections(Me._heroTableAdapter), OleDbConnection)
						Me._heroTableAdapter.Transaction = Nothing
					End If
					flag = (Me._huntTableAdapter IsNot Nothing)
					If flag Then
						Me._huntTableAdapter.Connection = CType(revertConnections(Me._huntTableAdapter), OleDbConnection)
						Me._huntTableAdapter.Transaction = Nothing
					End If
					flag = (Me._neutralTableAdapter IsNot Nothing)
					If flag Then
						Me._neutralTableAdapter.Connection = CType(revertConnections(Me._neutralTableAdapter), OleDbConnection)
						Me._neutralTableAdapter.Transaction = Nothing
					End If
					flag = (Me._npcTableAdapter IsNot Nothing)
					If flag Then
						Me._npcTableAdapter.Connection = CType(revertConnections(Me._npcTableAdapter), OleDbConnection)
						Me._npcTableAdapter.Transaction = Nothing
					End If
					flag = (0 < adaptersWithAcceptChangesDuringUpdate.Count)
					If flag Then
						Dim adapters As DataAdapter() = New DataAdapter(adaptersWithAcceptChangesDuringUpdate.Count - 1 + 1)
						adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters)
						For l As Integer = 0 To adapters.Length - 1
							Dim adapter As DataAdapter = adapters(l)
							adapter.AcceptChangesDuringUpdate = True
						Next
					End If
				End Try
				UpdateAll = result
			End If
			Return UpdateAll
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overridable Sub SortSelfReferenceRows(rows As DataRow(), relation As DataRelation, childFirst As Boolean)
			Array.Sort(Of DataRow)(rows, New TableAdapterManager.SelfReferenceComparer(relation, childFirst))
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overridable Function MatchTableAdapterConnection(inputConnection As IDbConnection) As Boolean
			Dim flag As Boolean = Me._connection IsNot Nothing
			Dim MatchTableAdapterConnection As Boolean
			If flag Then
				MatchTableAdapterConnection = True
			Else
				flag = (Me.Connection Is Nothing OrElse inputConnection Is Nothing)
				If flag Then
					MatchTableAdapterConnection = True
				Else
					flag = String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal)
					MatchTableAdapterConnection = flag
				End If
			End If
			Return MatchTableAdapterConnection
		End Function
	End Class
End Namespace
