Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Threading
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Namespace vscan
	<HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(True), XmlRoot("dbDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")>
	<Serializable()>
	Public Class dbDataSet
		Inherits DataSet

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub altRowChangeEventHandler(sender As Object, e As dbDataSet.altRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub cordinRowChangeEventHandler(sender As Object, e As dbDataSet.cordinRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub enemiesRowChangeEventHandler(sender As Object, e As dbDataSet.enemiesRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub fieldRowChangeEventHandler(sender As Object, e As dbDataSet.fieldRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub flatsRowChangeEventHandler(sender As Object, e As dbDataSet.flatsRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub friendsRowChangeEventHandler(sender As Object, e As dbDataSet.friendsRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub heroRowChangeEventHandler(sender As Object, e As dbDataSet.heroRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub huntRowChangeEventHandler(sender As Object, e As dbDataSet.huntRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub neutralRowChangeEventHandler(sender As Object, e As dbDataSet.neutralRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub npcRowChangeEventHandler(sender As Object, e As dbDataSet.npcRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub altcoordRowChangeEventHandler(sender As Object, e As dbDataSet.altcoordRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub enemiescoordRowChangeEventHandler(sender As Object, e As dbDataSet.enemiescoordRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub friendscoordRowChangeEventHandler(sender As Object, e As dbDataSet.friendscoordRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub hero_allianceRowChangeEventHandler(sender As Object, e As dbDataSet.hero_allianceRowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub neutralcoordRowChangeEventHandler(sender As Object, e As dbDataSet.neutralcoordRowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class altDataTable
			Inherits TypedTableBase(Of dbDataSet.altRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private altRowChangingEvent As dbDataSet.altRowChangeEventHandler

			Private altRowChangedEvent As dbDataSet.altRowChangeEventHandler

			Private altRowDeletingEvent As dbDataSet.altRowChangeEventHandler

			Private altRowDeletedEvent As dbDataSet.altRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altRowChanging As dbDataSet.altRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altRowChangingEvent = CType([Delegate].Combine(Me.altRowChangingEvent, value), dbDataSet.altRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altRowChangingEvent = CType([Delegate].Remove(Me.altRowChangingEvent, value), dbDataSet.altRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altRowChanged As dbDataSet.altRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altRowChangedEvent = CType([Delegate].Combine(Me.altRowChangedEvent, value), dbDataSet.altRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altRowChangedEvent = CType([Delegate].Remove(Me.altRowChangedEvent, value), dbDataSet.altRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altRowDeleting As dbDataSet.altRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altRowDeletingEvent = CType([Delegate].Combine(Me.altRowDeletingEvent, value), dbDataSet.altRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altRowDeletingEvent = CType([Delegate].Remove(Me.altRowDeletingEvent, value), dbDataSet.altRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altRowDeleted As dbDataSet.altRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altRowDeletedEvent = CType([Delegate].Combine(Me.altRowDeletedEvent, value), dbDataSet.altRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altRowDeletedEvent = CType([Delegate].Remove(Me.altRowDeletedEvent, value), dbDataSet.altRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.altRow
				Get
					Return CType(Me.Rows(index), dbDataSet.altRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.altDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.altDataTable.__ENCList.Count = dbDataSet.altDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.altDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.altDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.altDataTable.__ENCList(num) = dbDataSet.altDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.altDataTable.__ENCList.RemoveRange(num, dbDataSet.altDataTable.__ENCList.Count - num)
						dbDataSet.altDataTable.__ENCList.Capacity = dbDataSet.altDataTable.__ENCList.Count
					End If
					dbDataSet.altDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.altDataTable.__ENCAddToList(Me)
				Me.TableName = "alt"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.altDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.altDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddaltRow(row As dbDataSet.altRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddaltRow(alliance As String, player As String, x As Integer, y As Integer) As dbDataSet.altRow
				Dim rowaltRow As dbDataSet.altRow = CType(Me.NewRow(), dbDataSet.altRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y }
				rowaltRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowaltRow)
				Return rowaltRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByid(id As Integer) As dbDataSet.altRow
				Return CType(Me.Rows.Find(New Object()() = { id }), dbDataSet.altRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.altDataTable = CType(MyBase.Clone(), dbDataSet.altDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.altDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnid }, True))
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnid.AllowDBNull = False
				Me.columnid.Unique = True
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewaltRow() As dbDataSet.altRow
				Return CType(Me.NewRow(), dbDataSet.altRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.altRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.altRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.altRowChangedEvent IsNot Nothing
				If flag Then
					Dim altRowChangeEventHandler As dbDataSet.altRowChangeEventHandler = Me.altRowChangedEvent
					flag = (altRowChangeEventHandler IsNot Nothing)
					If flag Then
						altRowChangeEventHandler(Me, New dbDataSet.altRowChangeEvent(CType(e.Row, dbDataSet.altRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.altRowChangingEvent IsNot Nothing
				If flag Then
					Dim altRowChangeEventHandler As dbDataSet.altRowChangeEventHandler = Me.altRowChangingEvent
					flag = (altRowChangeEventHandler IsNot Nothing)
					If flag Then
						altRowChangeEventHandler(Me, New dbDataSet.altRowChangeEvent(CType(e.Row, dbDataSet.altRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.altRowDeletedEvent IsNot Nothing
				If flag Then
					Dim altRowChangeEventHandler As dbDataSet.altRowChangeEventHandler = Me.altRowDeletedEvent
					flag = (altRowChangeEventHandler IsNot Nothing)
					If flag Then
						altRowChangeEventHandler(Me, New dbDataSet.altRowChangeEvent(CType(e.Row, dbDataSet.altRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.altRowDeletingEvent IsNot Nothing
				If flag Then
					Dim altRowChangeEventHandler As dbDataSet.altRowChangeEventHandler = Me.altRowDeletingEvent
					flag = (altRowChangeEventHandler IsNot Nothing)
					If flag Then
						altRowChangeEventHandler(Me, New dbDataSet.altRowChangeEvent(CType(e.Row, dbDataSet.altRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovealtRow(row As dbDataSet.altRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "altDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class cordinDataTable
			Inherits TypedTableBase(Of dbDataSet.cordinRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columncitie As DataColumn

			Private columnID As DataColumn

			Private cordinRowChangingEvent As dbDataSet.cordinRowChangeEventHandler

			Private cordinRowChangedEvent As dbDataSet.cordinRowChangeEventHandler

			Private cordinRowDeletingEvent As dbDataSet.cordinRowChangeEventHandler

			Private cordinRowDeletedEvent As dbDataSet.cordinRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event cordinRowChanging As dbDataSet.cordinRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.cordinRowChangingEvent = CType([Delegate].Combine(Me.cordinRowChangingEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.cordinRowChangingEvent = CType([Delegate].Remove(Me.cordinRowChangingEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event cordinRowChanged As dbDataSet.cordinRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.cordinRowChangedEvent = CType([Delegate].Combine(Me.cordinRowChangedEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.cordinRowChangedEvent = CType([Delegate].Remove(Me.cordinRowChangedEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event cordinRowDeleting As dbDataSet.cordinRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.cordinRowDeletingEvent = CType([Delegate].Combine(Me.cordinRowDeletingEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.cordinRowDeletingEvent = CType([Delegate].Remove(Me.cordinRowDeletingEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event cordinRowDeleted As dbDataSet.cordinRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.cordinRowDeletedEvent = CType([Delegate].Combine(Me.cordinRowDeletedEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.cordinRowDeletedEvent = CType([Delegate].Remove(Me.cordinRowDeletedEvent, value), dbDataSet.cordinRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property citieColumn() As DataColumn
				Get
					Return Me.columncitie
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn() As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.cordinRow
				Get
					Return CType(Me.Rows(index), dbDataSet.cordinRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.cordinDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.cordinDataTable.__ENCList.Count = dbDataSet.cordinDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.cordinDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.cordinDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.cordinDataTable.__ENCList(num) = dbDataSet.cordinDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.cordinDataTable.__ENCList.RemoveRange(num, dbDataSet.cordinDataTable.__ENCList.Count - num)
						dbDataSet.cordinDataTable.__ENCList.Capacity = dbDataSet.cordinDataTable.__ENCList.Count
					End If
					dbDataSet.cordinDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.cordinDataTable.__ENCAddToList(Me)
				Me.TableName = "cordin"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.cordinDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.cordinDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddcordinRow(row As dbDataSet.cordinRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddcordinRow(alliance As String, player As String, x As Integer, y As Integer, citie As String, ID As Integer) As dbDataSet.cordinRow
				Dim rowcordinRow As dbDataSet.cordinRow = CType(Me.NewRow(), dbDataSet.cordinRow)
				Dim columnValuesArray As Object() = New Object()() = { alliance, player, x, y, citie, ID }
				rowcordinRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowcordinRow)
				Return rowcordinRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As dbDataSet.cordinRow
				Return CType(Me.Rows.Find(New Object()() = { ID }), dbDataSet.cordinRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.cordinDataTable = CType(MyBase.Clone(), dbDataSet.cordinDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.cordinDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columncitie = MyBase.Columns("citie")
				Me.columnID = MyBase.Columns("ID")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columncitie = New DataColumn("citie", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncitie)
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnID }, True))
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
				Me.columncitie.MaxLength = 255
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewcordinRow() As dbDataSet.cordinRow
				Return CType(Me.NewRow(), dbDataSet.cordinRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.cordinRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.cordinRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.cordinRowChangedEvent IsNot Nothing
				If flag Then
					Dim cordinRowChangeEventHandler As dbDataSet.cordinRowChangeEventHandler = Me.cordinRowChangedEvent
					flag = (cordinRowChangeEventHandler IsNot Nothing)
					If flag Then
						cordinRowChangeEventHandler(Me, New dbDataSet.cordinRowChangeEvent(CType(e.Row, dbDataSet.cordinRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.cordinRowChangingEvent IsNot Nothing
				If flag Then
					Dim cordinRowChangeEventHandler As dbDataSet.cordinRowChangeEventHandler = Me.cordinRowChangingEvent
					flag = (cordinRowChangeEventHandler IsNot Nothing)
					If flag Then
						cordinRowChangeEventHandler(Me, New dbDataSet.cordinRowChangeEvent(CType(e.Row, dbDataSet.cordinRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.cordinRowDeletedEvent IsNot Nothing
				If flag Then
					Dim cordinRowChangeEventHandler As dbDataSet.cordinRowChangeEventHandler = Me.cordinRowDeletedEvent
					flag = (cordinRowChangeEventHandler IsNot Nothing)
					If flag Then
						cordinRowChangeEventHandler(Me, New dbDataSet.cordinRowChangeEvent(CType(e.Row, dbDataSet.cordinRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.cordinRowDeletingEvent IsNot Nothing
				If flag Then
					Dim cordinRowChangeEventHandler As dbDataSet.cordinRowChangeEventHandler = Me.cordinRowDeletingEvent
					flag = (cordinRowChangeEventHandler IsNot Nothing)
					If flag Then
						cordinRowChangeEventHandler(Me, New dbDataSet.cordinRowChangeEvent(CType(e.Row, dbDataSet.cordinRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovecordinRow(row As dbDataSet.cordinRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "cordinDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class enemiesDataTable
			Inherits TypedTableBase(Of dbDataSet.enemiesRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private enemiesRowChangingEvent As dbDataSet.enemiesRowChangeEventHandler

			Private enemiesRowChangedEvent As dbDataSet.enemiesRowChangeEventHandler

			Private enemiesRowDeletingEvent As dbDataSet.enemiesRowChangeEventHandler

			Private enemiesRowDeletedEvent As dbDataSet.enemiesRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiesRowChanging As dbDataSet.enemiesRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiesRowChangingEvent = CType([Delegate].Combine(Me.enemiesRowChangingEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiesRowChangingEvent = CType([Delegate].Remove(Me.enemiesRowChangingEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiesRowChanged As dbDataSet.enemiesRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiesRowChangedEvent = CType([Delegate].Combine(Me.enemiesRowChangedEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiesRowChangedEvent = CType([Delegate].Remove(Me.enemiesRowChangedEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiesRowDeleting As dbDataSet.enemiesRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiesRowDeletingEvent = CType([Delegate].Combine(Me.enemiesRowDeletingEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiesRowDeletingEvent = CType([Delegate].Remove(Me.enemiesRowDeletingEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiesRowDeleted As dbDataSet.enemiesRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiesRowDeletedEvent = CType([Delegate].Combine(Me.enemiesRowDeletedEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiesRowDeletedEvent = CType([Delegate].Remove(Me.enemiesRowDeletedEvent, value), dbDataSet.enemiesRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.enemiesRow
				Get
					Return CType(Me.Rows(index), dbDataSet.enemiesRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.enemiesDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.enemiesDataTable.__ENCList.Count = dbDataSet.enemiesDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.enemiesDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.enemiesDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.enemiesDataTable.__ENCList(num) = dbDataSet.enemiesDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.enemiesDataTable.__ENCList.RemoveRange(num, dbDataSet.enemiesDataTable.__ENCList.Count - num)
						dbDataSet.enemiesDataTable.__ENCList.Capacity = dbDataSet.enemiesDataTable.__ENCList.Count
					End If
					dbDataSet.enemiesDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.enemiesDataTable.__ENCAddToList(Me)
				Me.TableName = "enemies"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.enemiesDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.enemiesDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddenemiesRow(row As dbDataSet.enemiesRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddenemiesRow(alliance As String, player As String, x As Integer, y As Integer) As dbDataSet.enemiesRow
				Dim rowenemiesRow As dbDataSet.enemiesRow = CType(Me.NewRow(), dbDataSet.enemiesRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y }
				rowenemiesRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowenemiesRow)
				Return rowenemiesRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByid(id As Integer) As dbDataSet.enemiesRow
				Return CType(Me.Rows.Find(New Object()() = { id }), dbDataSet.enemiesRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.enemiesDataTable = CType(MyBase.Clone(), dbDataSet.enemiesDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.enemiesDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnid }, True))
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnid.AllowDBNull = False
				Me.columnid.Unique = True
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewenemiesRow() As dbDataSet.enemiesRow
				Return CType(Me.NewRow(), dbDataSet.enemiesRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.enemiesRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.enemiesRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.enemiesRowChangedEvent IsNot Nothing
				If flag Then
					Dim enemiesRowChangeEventHandler As dbDataSet.enemiesRowChangeEventHandler = Me.enemiesRowChangedEvent
					flag = (enemiesRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiesRowChangeEventHandler(Me, New dbDataSet.enemiesRowChangeEvent(CType(e.Row, dbDataSet.enemiesRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.enemiesRowChangingEvent IsNot Nothing
				If flag Then
					Dim enemiesRowChangeEventHandler As dbDataSet.enemiesRowChangeEventHandler = Me.enemiesRowChangingEvent
					flag = (enemiesRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiesRowChangeEventHandler(Me, New dbDataSet.enemiesRowChangeEvent(CType(e.Row, dbDataSet.enemiesRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.enemiesRowDeletedEvent IsNot Nothing
				If flag Then
					Dim enemiesRowChangeEventHandler As dbDataSet.enemiesRowChangeEventHandler = Me.enemiesRowDeletedEvent
					flag = (enemiesRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiesRowChangeEventHandler(Me, New dbDataSet.enemiesRowChangeEvent(CType(e.Row, dbDataSet.enemiesRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.enemiesRowDeletingEvent IsNot Nothing
				If flag Then
					Dim enemiesRowChangeEventHandler As dbDataSet.enemiesRowChangeEventHandler = Me.enemiesRowDeletingEvent
					flag = (enemiesRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiesRowChangeEventHandler(Me, New dbDataSet.enemiesRowChangeEvent(CType(e.Row, dbDataSet.enemiesRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveenemiesRow(row As dbDataSet.enemiesRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "enemiesDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class fieldDataTable
			Inherits TypedTableBase(Of dbDataSet.fieldRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columnlevel As DataColumn

			Private columnfield As DataColumn

			Private columnID As DataColumn

			Private fieldRowChangingEvent As dbDataSet.fieldRowChangeEventHandler

			Private fieldRowChangedEvent As dbDataSet.fieldRowChangeEventHandler

			Private fieldRowDeletingEvent As dbDataSet.fieldRowChangeEventHandler

			Private fieldRowDeletedEvent As dbDataSet.fieldRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event fieldRowChanging As dbDataSet.fieldRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.fieldRowChangingEvent = CType([Delegate].Combine(Me.fieldRowChangingEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.fieldRowChangingEvent = CType([Delegate].Remove(Me.fieldRowChangingEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event fieldRowChanged As dbDataSet.fieldRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.fieldRowChangedEvent = CType([Delegate].Combine(Me.fieldRowChangedEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.fieldRowChangedEvent = CType([Delegate].Remove(Me.fieldRowChangedEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event fieldRowDeleting As dbDataSet.fieldRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.fieldRowDeletingEvent = CType([Delegate].Combine(Me.fieldRowDeletingEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.fieldRowDeletingEvent = CType([Delegate].Remove(Me.fieldRowDeletingEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event fieldRowDeleted As dbDataSet.fieldRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.fieldRowDeletedEvent = CType([Delegate].Combine(Me.fieldRowDeletedEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.fieldRowDeletedEvent = CType([Delegate].Remove(Me.fieldRowDeletedEvent, value), dbDataSet.fieldRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property levelColumn() As DataColumn
				Get
					Return Me.columnlevel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property fieldColumn() As DataColumn
				Get
					Return Me.columnfield
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn() As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.fieldRow
				Get
					Return CType(Me.Rows(index), dbDataSet.fieldRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.fieldDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.fieldDataTable.__ENCList.Count = dbDataSet.fieldDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.fieldDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.fieldDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.fieldDataTable.__ENCList(num) = dbDataSet.fieldDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.fieldDataTable.__ENCList.RemoveRange(num, dbDataSet.fieldDataTable.__ENCList.Count - num)
						dbDataSet.fieldDataTable.__ENCList.Capacity = dbDataSet.fieldDataTable.__ENCList.Count
					End If
					dbDataSet.fieldDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.fieldDataTable.__ENCAddToList(Me)
				Me.TableName = "field"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.fieldDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.fieldDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddfieldRow(row As dbDataSet.fieldRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddfieldRow(x As Integer, y As Integer, level As Integer, field As String) As dbDataSet.fieldRow
				Dim rowfieldRow As dbDataSet.fieldRow = CType(Me.NewRow(), dbDataSet.fieldRow)
				Dim columnValuesArray As Object() = New Object()() = { x, y, level, field, Nothing }
				rowfieldRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowfieldRow)
				Return rowfieldRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As dbDataSet.fieldRow
				Return CType(Me.Rows.Find(New Object()() = { ID }), dbDataSet.fieldRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.fieldDataTable = CType(MyBase.Clone(), dbDataSet.fieldDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.fieldDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columnlevel = MyBase.Columns("level")
				Me.columnfield = MyBase.Columns("field")
				Me.columnID = MyBase.Columns("ID")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columnlevel = New DataColumn("level", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlevel)
				Me.columnfield = New DataColumn("field", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnfield)
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnID }, True))
				Me.columnfield.MaxLength = 255
				Me.columnID.AutoIncrement = True
				Me.columnID.AutoIncrementSeed = -1L
				Me.columnID.AutoIncrementStep = -1L
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewfieldRow() As dbDataSet.fieldRow
				Return CType(Me.NewRow(), dbDataSet.fieldRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.fieldRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.fieldRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.fieldRowChangedEvent IsNot Nothing
				If flag Then
					Dim fieldRowChangeEventHandler As dbDataSet.fieldRowChangeEventHandler = Me.fieldRowChangedEvent
					flag = (fieldRowChangeEventHandler IsNot Nothing)
					If flag Then
						fieldRowChangeEventHandler(Me, New dbDataSet.fieldRowChangeEvent(CType(e.Row, dbDataSet.fieldRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.fieldRowChangingEvent IsNot Nothing
				If flag Then
					Dim fieldRowChangeEventHandler As dbDataSet.fieldRowChangeEventHandler = Me.fieldRowChangingEvent
					flag = (fieldRowChangeEventHandler IsNot Nothing)
					If flag Then
						fieldRowChangeEventHandler(Me, New dbDataSet.fieldRowChangeEvent(CType(e.Row, dbDataSet.fieldRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.fieldRowDeletedEvent IsNot Nothing
				If flag Then
					Dim fieldRowChangeEventHandler As dbDataSet.fieldRowChangeEventHandler = Me.fieldRowDeletedEvent
					flag = (fieldRowChangeEventHandler IsNot Nothing)
					If flag Then
						fieldRowChangeEventHandler(Me, New dbDataSet.fieldRowChangeEvent(CType(e.Row, dbDataSet.fieldRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.fieldRowDeletingEvent IsNot Nothing
				If flag Then
					Dim fieldRowChangeEventHandler As dbDataSet.fieldRowChangeEventHandler = Me.fieldRowDeletingEvent
					flag = (fieldRowChangeEventHandler IsNot Nothing)
					If flag Then
						fieldRowChangeEventHandler(Me, New dbDataSet.fieldRowChangeEvent(CType(e.Row, dbDataSet.fieldRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovefieldRow(row As dbDataSet.fieldRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "fieldDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class flatsDataTable
			Inherits TypedTableBase(Of dbDataSet.flatsRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columnlevel As DataColumn

			Private columnID As DataColumn

			Private flatsRowChangingEvent As dbDataSet.flatsRowChangeEventHandler

			Private flatsRowChangedEvent As dbDataSet.flatsRowChangeEventHandler

			Private flatsRowDeletingEvent As dbDataSet.flatsRowChangeEventHandler

			Private flatsRowDeletedEvent As dbDataSet.flatsRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event flatsRowChanging As dbDataSet.flatsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.flatsRowChangingEvent = CType([Delegate].Combine(Me.flatsRowChangingEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.flatsRowChangingEvent = CType([Delegate].Remove(Me.flatsRowChangingEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event flatsRowChanged As dbDataSet.flatsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.flatsRowChangedEvent = CType([Delegate].Combine(Me.flatsRowChangedEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.flatsRowChangedEvent = CType([Delegate].Remove(Me.flatsRowChangedEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event flatsRowDeleting As dbDataSet.flatsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.flatsRowDeletingEvent = CType([Delegate].Combine(Me.flatsRowDeletingEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.flatsRowDeletingEvent = CType([Delegate].Remove(Me.flatsRowDeletingEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event flatsRowDeleted As dbDataSet.flatsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.flatsRowDeletedEvent = CType([Delegate].Combine(Me.flatsRowDeletedEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.flatsRowDeletedEvent = CType([Delegate].Remove(Me.flatsRowDeletedEvent, value), dbDataSet.flatsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property levelColumn() As DataColumn
				Get
					Return Me.columnlevel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn() As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.flatsRow
				Get
					Return CType(Me.Rows(index), dbDataSet.flatsRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.flatsDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.flatsDataTable.__ENCList.Count = dbDataSet.flatsDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.flatsDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.flatsDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.flatsDataTable.__ENCList(num) = dbDataSet.flatsDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.flatsDataTable.__ENCList.RemoveRange(num, dbDataSet.flatsDataTable.__ENCList.Count - num)
						dbDataSet.flatsDataTable.__ENCList.Capacity = dbDataSet.flatsDataTable.__ENCList.Count
					End If
					dbDataSet.flatsDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.flatsDataTable.__ENCAddToList(Me)
				Me.TableName = "flats"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.flatsDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.flatsDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddflatsRow(row As dbDataSet.flatsRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddflatsRow(x As Integer, y As Integer, level As Integer) As dbDataSet.flatsRow
				Dim rowflatsRow As dbDataSet.flatsRow = CType(Me.NewRow(), dbDataSet.flatsRow)
				Dim columnValuesArray As Object() = New Object()() = { x, y, level, Nothing }
				rowflatsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowflatsRow)
				Return rowflatsRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As dbDataSet.flatsRow
				Return CType(Me.Rows.Find(New Object()() = { ID }), dbDataSet.flatsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.flatsDataTable = CType(MyBase.Clone(), dbDataSet.flatsDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.flatsDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columnlevel = MyBase.Columns("level")
				Me.columnID = MyBase.Columns("ID")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columnlevel = New DataColumn("level", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlevel)
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnID }, True))
				Me.columnID.AutoIncrement = True
				Me.columnID.AutoIncrementSeed = -1L
				Me.columnID.AutoIncrementStep = -1L
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewflatsRow() As dbDataSet.flatsRow
				Return CType(Me.NewRow(), dbDataSet.flatsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.flatsRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.flatsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.flatsRowChangedEvent IsNot Nothing
				If flag Then
					Dim flatsRowChangeEventHandler As dbDataSet.flatsRowChangeEventHandler = Me.flatsRowChangedEvent
					flag = (flatsRowChangeEventHandler IsNot Nothing)
					If flag Then
						flatsRowChangeEventHandler(Me, New dbDataSet.flatsRowChangeEvent(CType(e.Row, dbDataSet.flatsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.flatsRowChangingEvent IsNot Nothing
				If flag Then
					Dim flatsRowChangeEventHandler As dbDataSet.flatsRowChangeEventHandler = Me.flatsRowChangingEvent
					flag = (flatsRowChangeEventHandler IsNot Nothing)
					If flag Then
						flatsRowChangeEventHandler(Me, New dbDataSet.flatsRowChangeEvent(CType(e.Row, dbDataSet.flatsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.flatsRowDeletedEvent IsNot Nothing
				If flag Then
					Dim flatsRowChangeEventHandler As dbDataSet.flatsRowChangeEventHandler = Me.flatsRowDeletedEvent
					flag = (flatsRowChangeEventHandler IsNot Nothing)
					If flag Then
						flatsRowChangeEventHandler(Me, New dbDataSet.flatsRowChangeEvent(CType(e.Row, dbDataSet.flatsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.flatsRowDeletingEvent IsNot Nothing
				If flag Then
					Dim flatsRowChangeEventHandler As dbDataSet.flatsRowChangeEventHandler = Me.flatsRowDeletingEvent
					flag = (flatsRowChangeEventHandler IsNot Nothing)
					If flag Then
						flatsRowChangeEventHandler(Me, New dbDataSet.flatsRowChangeEvent(CType(e.Row, dbDataSet.flatsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveflatsRow(row As dbDataSet.flatsRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "flatsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class friendsDataTable
			Inherits TypedTableBase(Of dbDataSet.friendsRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private friendsRowChangingEvent As dbDataSet.friendsRowChangeEventHandler

			Private friendsRowChangedEvent As dbDataSet.friendsRowChangeEventHandler

			Private friendsRowDeletingEvent As dbDataSet.friendsRowChangeEventHandler

			Private friendsRowDeletedEvent As dbDataSet.friendsRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendsRowChanging As dbDataSet.friendsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendsRowChangingEvent = CType([Delegate].Combine(Me.friendsRowChangingEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendsRowChangingEvent = CType([Delegate].Remove(Me.friendsRowChangingEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendsRowChanged As dbDataSet.friendsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendsRowChangedEvent = CType([Delegate].Combine(Me.friendsRowChangedEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendsRowChangedEvent = CType([Delegate].Remove(Me.friendsRowChangedEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendsRowDeleting As dbDataSet.friendsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendsRowDeletingEvent = CType([Delegate].Combine(Me.friendsRowDeletingEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendsRowDeletingEvent = CType([Delegate].Remove(Me.friendsRowDeletingEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendsRowDeleted As dbDataSet.friendsRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendsRowDeletedEvent = CType([Delegate].Combine(Me.friendsRowDeletedEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendsRowDeletedEvent = CType([Delegate].Remove(Me.friendsRowDeletedEvent, value), dbDataSet.friendsRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.friendsRow
				Get
					Return CType(Me.Rows(index), dbDataSet.friendsRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.friendsDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.friendsDataTable.__ENCList.Count = dbDataSet.friendsDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.friendsDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.friendsDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.friendsDataTable.__ENCList(num) = dbDataSet.friendsDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.friendsDataTable.__ENCList.RemoveRange(num, dbDataSet.friendsDataTable.__ENCList.Count - num)
						dbDataSet.friendsDataTable.__ENCList.Capacity = dbDataSet.friendsDataTable.__ENCList.Count
					End If
					dbDataSet.friendsDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.friendsDataTable.__ENCAddToList(Me)
				Me.TableName = "friends"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.friendsDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.friendsDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddfriendsRow(row As dbDataSet.friendsRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddfriendsRow(alliance As String, player As String, x As Integer, y As Integer) As dbDataSet.friendsRow
				Dim rowfriendsRow As dbDataSet.friendsRow = CType(Me.NewRow(), dbDataSet.friendsRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y }
				rowfriendsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowfriendsRow)
				Return rowfriendsRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByid(id As Integer) As dbDataSet.friendsRow
				Return CType(Me.Rows.Find(New Object()() = { id }), dbDataSet.friendsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.friendsDataTable = CType(MyBase.Clone(), dbDataSet.friendsDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.friendsDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnid }, True))
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnid.AllowDBNull = False
				Me.columnid.Unique = True
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewfriendsRow() As dbDataSet.friendsRow
				Return CType(Me.NewRow(), dbDataSet.friendsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.friendsRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.friendsRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.friendsRowChangedEvent IsNot Nothing
				If flag Then
					Dim friendsRowChangeEventHandler As dbDataSet.friendsRowChangeEventHandler = Me.friendsRowChangedEvent
					flag = (friendsRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendsRowChangeEventHandler(Me, New dbDataSet.friendsRowChangeEvent(CType(e.Row, dbDataSet.friendsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.friendsRowChangingEvent IsNot Nothing
				If flag Then
					Dim friendsRowChangeEventHandler As dbDataSet.friendsRowChangeEventHandler = Me.friendsRowChangingEvent
					flag = (friendsRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendsRowChangeEventHandler(Me, New dbDataSet.friendsRowChangeEvent(CType(e.Row, dbDataSet.friendsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.friendsRowDeletedEvent IsNot Nothing
				If flag Then
					Dim friendsRowChangeEventHandler As dbDataSet.friendsRowChangeEventHandler = Me.friendsRowDeletedEvent
					flag = (friendsRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendsRowChangeEventHandler(Me, New dbDataSet.friendsRowChangeEvent(CType(e.Row, dbDataSet.friendsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.friendsRowDeletingEvent IsNot Nothing
				If flag Then
					Dim friendsRowChangeEventHandler As dbDataSet.friendsRowChangeEventHandler = Me.friendsRowDeletingEvent
					flag = (friendsRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendsRowChangeEventHandler(Me, New dbDataSet.friendsRowChangeEvent(CType(e.Row, dbDataSet.friendsRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovefriendsRow(row As dbDataSet.friendsRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "friendsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class heroDataTable
			Inherits TypedTableBase(Of dbDataSet.heroRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnhero_nr As DataColumn

			Private columnhero_name As DataColumn

			Private columnplayer_name As DataColumn

			Private columnlevel As DataColumn

			Private columnpolit As DataColumn

			Private columnatt As DataColumn

			Private columnintel As DataColumn

			Private columnid As DataColumn

			Private heroRowChangingEvent As dbDataSet.heroRowChangeEventHandler

			Private heroRowChangedEvent As dbDataSet.heroRowChangeEventHandler

			Private heroRowDeletingEvent As dbDataSet.heroRowChangeEventHandler

			Private heroRowDeletedEvent As dbDataSet.heroRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event heroRowChanging As dbDataSet.heroRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.heroRowChangingEvent = CType([Delegate].Combine(Me.heroRowChangingEvent, value), dbDataSet.heroRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.heroRowChangingEvent = CType([Delegate].Remove(Me.heroRowChangingEvent, value), dbDataSet.heroRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event heroRowChanged As dbDataSet.heroRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.heroRowChangedEvent = CType([Delegate].Combine(Me.heroRowChangedEvent, value), dbDataSet.heroRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.heroRowChangedEvent = CType([Delegate].Remove(Me.heroRowChangedEvent, value), dbDataSet.heroRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event heroRowDeleting As dbDataSet.heroRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.heroRowDeletingEvent = CType([Delegate].Combine(Me.heroRowDeletingEvent, value), dbDataSet.heroRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.heroRowDeletingEvent = CType([Delegate].Remove(Me.heroRowDeletingEvent, value), dbDataSet.heroRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event heroRowDeleted As dbDataSet.heroRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.heroRowDeletedEvent = CType([Delegate].Combine(Me.heroRowDeletedEvent, value), dbDataSet.heroRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.heroRowDeletedEvent = CType([Delegate].Remove(Me.heroRowDeletedEvent, value), dbDataSet.heroRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property hero_nrColumn() As DataColumn
				Get
					Return Me.columnhero_nr
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property hero_nameColumn() As DataColumn
				Get
					Return Me.columnhero_name
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property player_nameColumn() As DataColumn
				Get
					Return Me.columnplayer_name
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property levelColumn() As DataColumn
				Get
					Return Me.columnlevel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property politColumn() As DataColumn
				Get
					Return Me.columnpolit
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property attColumn() As DataColumn
				Get
					Return Me.columnatt
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property intelColumn() As DataColumn
				Get
					Return Me.columnintel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.heroRow
				Get
					Return CType(Me.Rows(index), dbDataSet.heroRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.heroDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.heroDataTable.__ENCList.Count = dbDataSet.heroDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.heroDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.heroDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.heroDataTable.__ENCList(num) = dbDataSet.heroDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.heroDataTable.__ENCList.RemoveRange(num, dbDataSet.heroDataTable.__ENCList.Count - num)
						dbDataSet.heroDataTable.__ENCList.Capacity = dbDataSet.heroDataTable.__ENCList.Count
					End If
					dbDataSet.heroDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.heroDataTable.__ENCAddToList(Me)
				Me.TableName = "hero"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.heroDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.heroDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddheroRow(row As dbDataSet.heroRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddheroRow(hero_nr As Integer, hero_name As String, player_name As String, level As Integer, polit As Integer, att As Integer, intel As Integer) As dbDataSet.heroRow
				Dim rowheroRow As dbDataSet.heroRow = CType(Me.NewRow(), dbDataSet.heroRow)
				Dim columnValuesArray As Object() = New Object()() = { hero_nr, hero_name, player_name, level, polit, att, intel, Nothing }
				rowheroRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowheroRow)
				Return rowheroRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByid(id As Integer) As dbDataSet.heroRow
				Return CType(Me.Rows.Find(New Object()() = { id }), dbDataSet.heroRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.heroDataTable = CType(MyBase.Clone(), dbDataSet.heroDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.heroDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnhero_nr = MyBase.Columns("hero nr")
				Me.columnhero_name = MyBase.Columns("hero name")
				Me.columnplayer_name = MyBase.Columns("player name")
				Me.columnlevel = MyBase.Columns("level")
				Me.columnpolit = MyBase.Columns("polit")
				Me.columnatt = MyBase.Columns("att")
				Me.columnintel = MyBase.Columns("intel")
				Me.columnid = MyBase.Columns("id")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnhero_nr = New DataColumn("hero nr", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnhero_nr)
				Me.columnhero_name = New DataColumn("hero name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnhero_name)
				Me.columnplayer_name = New DataColumn("player name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer_name)
				Me.columnlevel = New DataColumn("level", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlevel)
				Me.columnpolit = New DataColumn("polit", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnpolit)
				Me.columnatt = New DataColumn("att", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnatt)
				Me.columnintel = New DataColumn("intel", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnintel)
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnid }, True))
				Me.columnhero_name.MaxLength = 255
				Me.columnplayer_name.MaxLength = 255
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnid.AllowDBNull = False
				Me.columnid.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewheroRow() As dbDataSet.heroRow
				Return CType(Me.NewRow(), dbDataSet.heroRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.heroRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.heroRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.heroRowChangedEvent IsNot Nothing
				If flag Then
					Dim heroRowChangeEventHandler As dbDataSet.heroRowChangeEventHandler = Me.heroRowChangedEvent
					flag = (heroRowChangeEventHandler IsNot Nothing)
					If flag Then
						heroRowChangeEventHandler(Me, New dbDataSet.heroRowChangeEvent(CType(e.Row, dbDataSet.heroRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.heroRowChangingEvent IsNot Nothing
				If flag Then
					Dim heroRowChangeEventHandler As dbDataSet.heroRowChangeEventHandler = Me.heroRowChangingEvent
					flag = (heroRowChangeEventHandler IsNot Nothing)
					If flag Then
						heroRowChangeEventHandler(Me, New dbDataSet.heroRowChangeEvent(CType(e.Row, dbDataSet.heroRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.heroRowDeletedEvent IsNot Nothing
				If flag Then
					Dim heroRowChangeEventHandler As dbDataSet.heroRowChangeEventHandler = Me.heroRowDeletedEvent
					flag = (heroRowChangeEventHandler IsNot Nothing)
					If flag Then
						heroRowChangeEventHandler(Me, New dbDataSet.heroRowChangeEvent(CType(e.Row, dbDataSet.heroRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.heroRowDeletingEvent IsNot Nothing
				If flag Then
					Dim heroRowChangeEventHandler As dbDataSet.heroRowChangeEventHandler = Me.heroRowDeletingEvent
					flag = (heroRowChangeEventHandler IsNot Nothing)
					If flag Then
						heroRowChangeEventHandler(Me, New dbDataSet.heroRowChangeEvent(CType(e.Row, dbDataSet.heroRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveheroRow(row As dbDataSet.heroRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "heroDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class huntDataTable
			Inherits TypedTableBase(Of dbDataSet.huntRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columnplayer As DataColumn

			Private columnID As DataColumn

			Private huntRowChangingEvent As dbDataSet.huntRowChangeEventHandler

			Private huntRowChangedEvent As dbDataSet.huntRowChangeEventHandler

			Private huntRowDeletingEvent As dbDataSet.huntRowChangeEventHandler

			Private huntRowDeletedEvent As dbDataSet.huntRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event huntRowChanging As dbDataSet.huntRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.huntRowChangingEvent = CType([Delegate].Combine(Me.huntRowChangingEvent, value), dbDataSet.huntRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.huntRowChangingEvent = CType([Delegate].Remove(Me.huntRowChangingEvent, value), dbDataSet.huntRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event huntRowChanged As dbDataSet.huntRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.huntRowChangedEvent = CType([Delegate].Combine(Me.huntRowChangedEvent, value), dbDataSet.huntRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.huntRowChangedEvent = CType([Delegate].Remove(Me.huntRowChangedEvent, value), dbDataSet.huntRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event huntRowDeleting As dbDataSet.huntRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.huntRowDeletingEvent = CType([Delegate].Combine(Me.huntRowDeletingEvent, value), dbDataSet.huntRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.huntRowDeletingEvent = CType([Delegate].Remove(Me.huntRowDeletingEvent, value), dbDataSet.huntRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event huntRowDeleted As dbDataSet.huntRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.huntRowDeletedEvent = CType([Delegate].Combine(Me.huntRowDeletedEvent, value), dbDataSet.huntRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.huntRowDeletedEvent = CType([Delegate].Remove(Me.huntRowDeletedEvent, value), dbDataSet.huntRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn() As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.huntRow
				Get
					Return CType(Me.Rows(index), dbDataSet.huntRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.huntDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.huntDataTable.__ENCList.Count = dbDataSet.huntDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.huntDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.huntDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.huntDataTable.__ENCList(num) = dbDataSet.huntDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.huntDataTable.__ENCList.RemoveRange(num, dbDataSet.huntDataTable.__ENCList.Count - num)
						dbDataSet.huntDataTable.__ENCList.Capacity = dbDataSet.huntDataTable.__ENCList.Count
					End If
					dbDataSet.huntDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.huntDataTable.__ENCAddToList(Me)
				Me.TableName = "hunt"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.huntDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.huntDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddhuntRow(row As dbDataSet.huntRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddhuntRow(x As Integer, y As Integer, player As String) As dbDataSet.huntRow
				Dim rowhuntRow As dbDataSet.huntRow = CType(Me.NewRow(), dbDataSet.huntRow)
				Dim columnValuesArray As Object() = New Object()() = { x, y, player, Nothing }
				rowhuntRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowhuntRow)
				Return rowhuntRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As dbDataSet.huntRow
				Return CType(Me.Rows.Find(New Object()() = { ID }), dbDataSet.huntRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.huntDataTable = CType(MyBase.Clone(), dbDataSet.huntDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.huntDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnID = MyBase.Columns("ID")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnID }, True))
				Me.columnplayer.MaxLength = 255
				Me.columnID.AutoIncrement = True
				Me.columnID.AutoIncrementSeed = -1L
				Me.columnID.AutoIncrementStep = -1L
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewhuntRow() As dbDataSet.huntRow
				Return CType(Me.NewRow(), dbDataSet.huntRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.huntRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.huntRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.huntRowChangedEvent IsNot Nothing
				If flag Then
					Dim huntRowChangeEventHandler As dbDataSet.huntRowChangeEventHandler = Me.huntRowChangedEvent
					flag = (huntRowChangeEventHandler IsNot Nothing)
					If flag Then
						huntRowChangeEventHandler(Me, New dbDataSet.huntRowChangeEvent(CType(e.Row, dbDataSet.huntRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.huntRowChangingEvent IsNot Nothing
				If flag Then
					Dim huntRowChangeEventHandler As dbDataSet.huntRowChangeEventHandler = Me.huntRowChangingEvent
					flag = (huntRowChangeEventHandler IsNot Nothing)
					If flag Then
						huntRowChangeEventHandler(Me, New dbDataSet.huntRowChangeEvent(CType(e.Row, dbDataSet.huntRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.huntRowDeletedEvent IsNot Nothing
				If flag Then
					Dim huntRowChangeEventHandler As dbDataSet.huntRowChangeEventHandler = Me.huntRowDeletedEvent
					flag = (huntRowChangeEventHandler IsNot Nothing)
					If flag Then
						huntRowChangeEventHandler(Me, New dbDataSet.huntRowChangeEvent(CType(e.Row, dbDataSet.huntRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.huntRowDeletingEvent IsNot Nothing
				If flag Then
					Dim huntRowChangeEventHandler As dbDataSet.huntRowChangeEventHandler = Me.huntRowDeletingEvent
					flag = (huntRowChangeEventHandler IsNot Nothing)
					If flag Then
						huntRowChangeEventHandler(Me, New dbDataSet.huntRowChangeEvent(CType(e.Row, dbDataSet.huntRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovehuntRow(row As dbDataSet.huntRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "huntDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class neutralDataTable
			Inherits TypedTableBase(Of dbDataSet.neutralRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private neutralRowChangingEvent As dbDataSet.neutralRowChangeEventHandler

			Private neutralRowChangedEvent As dbDataSet.neutralRowChangeEventHandler

			Private neutralRowDeletingEvent As dbDataSet.neutralRowChangeEventHandler

			Private neutralRowDeletedEvent As dbDataSet.neutralRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralRowChanging As dbDataSet.neutralRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralRowChangingEvent = CType([Delegate].Combine(Me.neutralRowChangingEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralRowChangingEvent = CType([Delegate].Remove(Me.neutralRowChangingEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralRowChanged As dbDataSet.neutralRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralRowChangedEvent = CType([Delegate].Combine(Me.neutralRowChangedEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralRowChangedEvent = CType([Delegate].Remove(Me.neutralRowChangedEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralRowDeleting As dbDataSet.neutralRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralRowDeletingEvent = CType([Delegate].Combine(Me.neutralRowDeletingEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralRowDeletingEvent = CType([Delegate].Remove(Me.neutralRowDeletingEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralRowDeleted As dbDataSet.neutralRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralRowDeletedEvent = CType([Delegate].Combine(Me.neutralRowDeletedEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralRowDeletedEvent = CType([Delegate].Remove(Me.neutralRowDeletedEvent, value), dbDataSet.neutralRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.neutralRow
				Get
					Return CType(Me.Rows(index), dbDataSet.neutralRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.neutralDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.neutralDataTable.__ENCList.Count = dbDataSet.neutralDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.neutralDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.neutralDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.neutralDataTable.__ENCList(num) = dbDataSet.neutralDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.neutralDataTable.__ENCList.RemoveRange(num, dbDataSet.neutralDataTable.__ENCList.Count - num)
						dbDataSet.neutralDataTable.__ENCList.Capacity = dbDataSet.neutralDataTable.__ENCList.Count
					End If
					dbDataSet.neutralDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.neutralDataTable.__ENCAddToList(Me)
				Me.TableName = "neutral"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.neutralDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.neutralDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddneutralRow(row As dbDataSet.neutralRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddneutralRow(alliance As String, player As String, x As Integer, y As Integer) As dbDataSet.neutralRow
				Dim rowneutralRow As dbDataSet.neutralRow = CType(Me.NewRow(), dbDataSet.neutralRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y }
				rowneutralRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowneutralRow)
				Return rowneutralRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByid(id As Integer) As dbDataSet.neutralRow
				Return CType(Me.Rows.Find(New Object()() = { id }), dbDataSet.neutralRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.neutralDataTable = CType(MyBase.Clone(), dbDataSet.neutralDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.neutralDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnid }, True))
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnid.AllowDBNull = False
				Me.columnid.Unique = True
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewneutralRow() As dbDataSet.neutralRow
				Return CType(Me.NewRow(), dbDataSet.neutralRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.neutralRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.neutralRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.neutralRowChangedEvent IsNot Nothing
				If flag Then
					Dim neutralRowChangeEventHandler As dbDataSet.neutralRowChangeEventHandler = Me.neutralRowChangedEvent
					flag = (neutralRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralRowChangeEventHandler(Me, New dbDataSet.neutralRowChangeEvent(CType(e.Row, dbDataSet.neutralRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.neutralRowChangingEvent IsNot Nothing
				If flag Then
					Dim neutralRowChangeEventHandler As dbDataSet.neutralRowChangeEventHandler = Me.neutralRowChangingEvent
					flag = (neutralRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralRowChangeEventHandler(Me, New dbDataSet.neutralRowChangeEvent(CType(e.Row, dbDataSet.neutralRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.neutralRowDeletedEvent IsNot Nothing
				If flag Then
					Dim neutralRowChangeEventHandler As dbDataSet.neutralRowChangeEventHandler = Me.neutralRowDeletedEvent
					flag = (neutralRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralRowChangeEventHandler(Me, New dbDataSet.neutralRowChangeEvent(CType(e.Row, dbDataSet.neutralRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.neutralRowDeletingEvent IsNot Nothing
				If flag Then
					Dim neutralRowChangeEventHandler As dbDataSet.neutralRowChangeEventHandler = Me.neutralRowDeletingEvent
					flag = (neutralRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralRowChangeEventHandler(Me, New dbDataSet.neutralRowChangeEvent(CType(e.Row, dbDataSet.neutralRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveneutralRow(row As dbDataSet.neutralRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "neutralDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class npcDataTable
			Inherits TypedTableBase(Of dbDataSet.npcRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columnlevel As DataColumn

			Private columnID As DataColumn

			Private npcRowChangingEvent As dbDataSet.npcRowChangeEventHandler

			Private npcRowChangedEvent As dbDataSet.npcRowChangeEventHandler

			Private npcRowDeletingEvent As dbDataSet.npcRowChangeEventHandler

			Private npcRowDeletedEvent As dbDataSet.npcRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event npcRowChanging As dbDataSet.npcRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.npcRowChangingEvent = CType([Delegate].Combine(Me.npcRowChangingEvent, value), dbDataSet.npcRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.npcRowChangingEvent = CType([Delegate].Remove(Me.npcRowChangingEvent, value), dbDataSet.npcRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event npcRowChanged As dbDataSet.npcRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.npcRowChangedEvent = CType([Delegate].Combine(Me.npcRowChangedEvent, value), dbDataSet.npcRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.npcRowChangedEvent = CType([Delegate].Remove(Me.npcRowChangedEvent, value), dbDataSet.npcRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event npcRowDeleting As dbDataSet.npcRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.npcRowDeletingEvent = CType([Delegate].Combine(Me.npcRowDeletingEvent, value), dbDataSet.npcRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.npcRowDeletingEvent = CType([Delegate].Remove(Me.npcRowDeletingEvent, value), dbDataSet.npcRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event npcRowDeleted As dbDataSet.npcRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.npcRowDeletedEvent = CType([Delegate].Combine(Me.npcRowDeletedEvent, value), dbDataSet.npcRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.npcRowDeletedEvent = CType([Delegate].Remove(Me.npcRowDeletedEvent, value), dbDataSet.npcRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property levelColumn() As DataColumn
				Get
					Return Me.columnlevel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn() As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.npcRow
				Get
					Return CType(Me.Rows(index), dbDataSet.npcRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.npcDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.npcDataTable.__ENCList.Count = dbDataSet.npcDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.npcDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.npcDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.npcDataTable.__ENCList(num) = dbDataSet.npcDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.npcDataTable.__ENCList.RemoveRange(num, dbDataSet.npcDataTable.__ENCList.Count - num)
						dbDataSet.npcDataTable.__ENCList.Capacity = dbDataSet.npcDataTable.__ENCList.Count
					End If
					dbDataSet.npcDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.npcDataTable.__ENCAddToList(Me)
				Me.TableName = "npc"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.npcDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.npcDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddnpcRow(row As dbDataSet.npcRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddnpcRow(x As Integer, y As Integer, level As Integer) As dbDataSet.npcRow
				Dim rownpcRow As dbDataSet.npcRow = CType(Me.NewRow(), dbDataSet.npcRow)
				Dim columnValuesArray As Object() = New Object()() = { x, y, level, Nothing }
				rownpcRow.ItemArray = columnValuesArray
				Me.Rows.Add(rownpcRow)
				Return rownpcRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function FindByID(ID As Integer) As dbDataSet.npcRow
				Return CType(Me.Rows.Find(New Object()() = { ID }), dbDataSet.npcRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.npcDataTable = CType(MyBase.Clone(), dbDataSet.npcDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.npcDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columnlevel = MyBase.Columns("level")
				Me.columnID = MyBase.Columns("ID")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columnlevel = New DataColumn("level", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlevel)
				Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn()() = { Me.columnID }, True))
				Me.columnID.AutoIncrement = True
				Me.columnID.AutoIncrementSeed = -1L
				Me.columnID.AutoIncrementStep = -1L
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewnpcRow() As dbDataSet.npcRow
				Return CType(Me.NewRow(), dbDataSet.npcRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.npcRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.npcRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.npcRowChangedEvent IsNot Nothing
				If flag Then
					Dim npcRowChangeEventHandler As dbDataSet.npcRowChangeEventHandler = Me.npcRowChangedEvent
					flag = (npcRowChangeEventHandler IsNot Nothing)
					If flag Then
						npcRowChangeEventHandler(Me, New dbDataSet.npcRowChangeEvent(CType(e.Row, dbDataSet.npcRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.npcRowChangingEvent IsNot Nothing
				If flag Then
					Dim npcRowChangeEventHandler As dbDataSet.npcRowChangeEventHandler = Me.npcRowChangingEvent
					flag = (npcRowChangeEventHandler IsNot Nothing)
					If flag Then
						npcRowChangeEventHandler(Me, New dbDataSet.npcRowChangeEvent(CType(e.Row, dbDataSet.npcRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.npcRowDeletedEvent IsNot Nothing
				If flag Then
					Dim npcRowChangeEventHandler As dbDataSet.npcRowChangeEventHandler = Me.npcRowDeletedEvent
					flag = (npcRowChangeEventHandler IsNot Nothing)
					If flag Then
						npcRowChangeEventHandler(Me, New dbDataSet.npcRowChangeEvent(CType(e.Row, dbDataSet.npcRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.npcRowDeletingEvent IsNot Nothing
				If flag Then
					Dim npcRowChangeEventHandler As dbDataSet.npcRowChangeEventHandler = Me.npcRowDeletingEvent
					flag = (npcRowChangeEventHandler IsNot Nothing)
					If flag Then
						npcRowChangeEventHandler(Me, New dbDataSet.npcRowChangeEvent(CType(e.Row, dbDataSet.npcRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovenpcRow(row As dbDataSet.npcRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "npcDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class altcoordDataTable
			Inherits TypedTableBase(Of dbDataSet.altcoordRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnplayer As DataColumn

			Private columnalliance As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columncitie As DataColumn

			Private altcoordRowChangingEvent As dbDataSet.altcoordRowChangeEventHandler

			Private altcoordRowChangedEvent As dbDataSet.altcoordRowChangeEventHandler

			Private altcoordRowDeletingEvent As dbDataSet.altcoordRowChangeEventHandler

			Private altcoordRowDeletedEvent As dbDataSet.altcoordRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altcoordRowChanging As dbDataSet.altcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altcoordRowChangingEvent = CType([Delegate].Combine(Me.altcoordRowChangingEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altcoordRowChangingEvent = CType([Delegate].Remove(Me.altcoordRowChangingEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altcoordRowChanged As dbDataSet.altcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altcoordRowChangedEvent = CType([Delegate].Combine(Me.altcoordRowChangedEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altcoordRowChangedEvent = CType([Delegate].Remove(Me.altcoordRowChangedEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altcoordRowDeleting As dbDataSet.altcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altcoordRowDeletingEvent = CType([Delegate].Combine(Me.altcoordRowDeletingEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altcoordRowDeletingEvent = CType([Delegate].Remove(Me.altcoordRowDeletingEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event altcoordRowDeleted As dbDataSet.altcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.altcoordRowDeletedEvent = CType([Delegate].Combine(Me.altcoordRowDeletedEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.altcoordRowDeletedEvent = CType([Delegate].Remove(Me.altcoordRowDeletedEvent, value), dbDataSet.altcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property citieColumn() As DataColumn
				Get
					Return Me.columncitie
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.altcoordRow
				Get
					Return CType(Me.Rows(index), dbDataSet.altcoordRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.altcoordDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.altcoordDataTable.__ENCList.Count = dbDataSet.altcoordDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.altcoordDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.altcoordDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.altcoordDataTable.__ENCList(num) = dbDataSet.altcoordDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.altcoordDataTable.__ENCList.RemoveRange(num, dbDataSet.altcoordDataTable.__ENCList.Count - num)
						dbDataSet.altcoordDataTable.__ENCList.Capacity = dbDataSet.altcoordDataTable.__ENCList.Count
					End If
					dbDataSet.altcoordDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.altcoordDataTable.__ENCAddToList(Me)
				Me.TableName = "altcoord"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.altcoordDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.altcoordDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddaltcoordRow(row As dbDataSet.altcoordRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddaltcoordRow(player As String, alliance As String, x As Integer, y As Integer, citie As String) As dbDataSet.altcoordRow
				Dim rowaltcoordRow As dbDataSet.altcoordRow = CType(Me.NewRow(), dbDataSet.altcoordRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, player, alliance, x, y, citie }
				rowaltcoordRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowaltcoordRow)
				Return rowaltcoordRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.altcoordDataTable = CType(MyBase.Clone(), dbDataSet.altcoordDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.altcoordDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columncitie = MyBase.Columns("citie")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columncitie = New DataColumn("citie", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncitie)
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnplayer.MaxLength = 255
				Me.columnalliance.MaxLength = 255
				Me.columncitie.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewaltcoordRow() As dbDataSet.altcoordRow
				Return CType(Me.NewRow(), dbDataSet.altcoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.altcoordRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.altcoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.altcoordRowChangedEvent IsNot Nothing
				If flag Then
					Dim altcoordRowChangeEventHandler As dbDataSet.altcoordRowChangeEventHandler = Me.altcoordRowChangedEvent
					flag = (altcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						altcoordRowChangeEventHandler(Me, New dbDataSet.altcoordRowChangeEvent(CType(e.Row, dbDataSet.altcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.altcoordRowChangingEvent IsNot Nothing
				If flag Then
					Dim altcoordRowChangeEventHandler As dbDataSet.altcoordRowChangeEventHandler = Me.altcoordRowChangingEvent
					flag = (altcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						altcoordRowChangeEventHandler(Me, New dbDataSet.altcoordRowChangeEvent(CType(e.Row, dbDataSet.altcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.altcoordRowDeletedEvent IsNot Nothing
				If flag Then
					Dim altcoordRowChangeEventHandler As dbDataSet.altcoordRowChangeEventHandler = Me.altcoordRowDeletedEvent
					flag = (altcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						altcoordRowChangeEventHandler(Me, New dbDataSet.altcoordRowChangeEvent(CType(e.Row, dbDataSet.altcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.altcoordRowDeletingEvent IsNot Nothing
				If flag Then
					Dim altcoordRowChangeEventHandler As dbDataSet.altcoordRowChangeEventHandler = Me.altcoordRowDeletingEvent
					flag = (altcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						altcoordRowChangeEventHandler(Me, New dbDataSet.altcoordRowChangeEvent(CType(e.Row, dbDataSet.altcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovealtcoordRow(row As dbDataSet.altcoordRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "altcoordDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class enemiescoordDataTable
			Inherits TypedTableBase(Of dbDataSet.enemiescoordRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columncitie As DataColumn

			Private enemiescoordRowChangingEvent As dbDataSet.enemiescoordRowChangeEventHandler

			Private enemiescoordRowChangedEvent As dbDataSet.enemiescoordRowChangeEventHandler

			Private enemiescoordRowDeletingEvent As dbDataSet.enemiescoordRowChangeEventHandler

			Private enemiescoordRowDeletedEvent As dbDataSet.enemiescoordRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiescoordRowChanging As dbDataSet.enemiescoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiescoordRowChangingEvent = CType([Delegate].Combine(Me.enemiescoordRowChangingEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiescoordRowChangingEvent = CType([Delegate].Remove(Me.enemiescoordRowChangingEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiescoordRowChanged As dbDataSet.enemiescoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiescoordRowChangedEvent = CType([Delegate].Combine(Me.enemiescoordRowChangedEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiescoordRowChangedEvent = CType([Delegate].Remove(Me.enemiescoordRowChangedEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiescoordRowDeleting As dbDataSet.enemiescoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiescoordRowDeletingEvent = CType([Delegate].Combine(Me.enemiescoordRowDeletingEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiescoordRowDeletingEvent = CType([Delegate].Remove(Me.enemiescoordRowDeletingEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event enemiescoordRowDeleted As dbDataSet.enemiescoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.enemiescoordRowDeletedEvent = CType([Delegate].Combine(Me.enemiescoordRowDeletedEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.enemiescoordRowDeletedEvent = CType([Delegate].Remove(Me.enemiescoordRowDeletedEvent, value), dbDataSet.enemiescoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property citieColumn() As DataColumn
				Get
					Return Me.columncitie
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.enemiescoordRow
				Get
					Return CType(Me.Rows(index), dbDataSet.enemiescoordRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.enemiescoordDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.enemiescoordDataTable.__ENCList.Count = dbDataSet.enemiescoordDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.enemiescoordDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.enemiescoordDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.enemiescoordDataTable.__ENCList(num) = dbDataSet.enemiescoordDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.enemiescoordDataTable.__ENCList.RemoveRange(num, dbDataSet.enemiescoordDataTable.__ENCList.Count - num)
						dbDataSet.enemiescoordDataTable.__ENCList.Capacity = dbDataSet.enemiescoordDataTable.__ENCList.Count
					End If
					dbDataSet.enemiescoordDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.enemiescoordDataTable.__ENCAddToList(Me)
				Me.TableName = "enemiescoord"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.enemiescoordDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.enemiescoordDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddenemiescoordRow(row As dbDataSet.enemiescoordRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddenemiescoordRow(alliance As String, player As String, x As Integer, y As Integer, citie As String) As dbDataSet.enemiescoordRow
				Dim rowenemiescoordRow As dbDataSet.enemiescoordRow = CType(Me.NewRow(), dbDataSet.enemiescoordRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y, citie }
				rowenemiescoordRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowenemiescoordRow)
				Return rowenemiescoordRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.enemiescoordDataTable = CType(MyBase.Clone(), dbDataSet.enemiescoordDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.enemiescoordDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columncitie = MyBase.Columns("citie")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columncitie = New DataColumn("citie", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncitie)
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
				Me.columncitie.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewenemiescoordRow() As dbDataSet.enemiescoordRow
				Return CType(Me.NewRow(), dbDataSet.enemiescoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.enemiescoordRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.enemiescoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.enemiescoordRowChangedEvent IsNot Nothing
				If flag Then
					Dim enemiescoordRowChangeEventHandler As dbDataSet.enemiescoordRowChangeEventHandler = Me.enemiescoordRowChangedEvent
					flag = (enemiescoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiescoordRowChangeEventHandler(Me, New dbDataSet.enemiescoordRowChangeEvent(CType(e.Row, dbDataSet.enemiescoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.enemiescoordRowChangingEvent IsNot Nothing
				If flag Then
					Dim enemiescoordRowChangeEventHandler As dbDataSet.enemiescoordRowChangeEventHandler = Me.enemiescoordRowChangingEvent
					flag = (enemiescoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiescoordRowChangeEventHandler(Me, New dbDataSet.enemiescoordRowChangeEvent(CType(e.Row, dbDataSet.enemiescoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.enemiescoordRowDeletedEvent IsNot Nothing
				If flag Then
					Dim enemiescoordRowChangeEventHandler As dbDataSet.enemiescoordRowChangeEventHandler = Me.enemiescoordRowDeletedEvent
					flag = (enemiescoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiescoordRowChangeEventHandler(Me, New dbDataSet.enemiescoordRowChangeEvent(CType(e.Row, dbDataSet.enemiescoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.enemiescoordRowDeletingEvent IsNot Nothing
				If flag Then
					Dim enemiescoordRowChangeEventHandler As dbDataSet.enemiescoordRowChangeEventHandler = Me.enemiescoordRowDeletingEvent
					flag = (enemiescoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						enemiescoordRowChangeEventHandler(Me, New dbDataSet.enemiescoordRowChangeEvent(CType(e.Row, dbDataSet.enemiescoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveenemiescoordRow(row As dbDataSet.enemiescoordRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "enemiescoordDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class friendscoordDataTable
			Inherits TypedTableBase(Of dbDataSet.friendscoordRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private columncitie As DataColumn

			Private friendscoordRowChangingEvent As dbDataSet.friendscoordRowChangeEventHandler

			Private friendscoordRowChangedEvent As dbDataSet.friendscoordRowChangeEventHandler

			Private friendscoordRowDeletingEvent As dbDataSet.friendscoordRowChangeEventHandler

			Private friendscoordRowDeletedEvent As dbDataSet.friendscoordRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendscoordRowChanging As dbDataSet.friendscoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendscoordRowChangingEvent = CType([Delegate].Combine(Me.friendscoordRowChangingEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendscoordRowChangingEvent = CType([Delegate].Remove(Me.friendscoordRowChangingEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendscoordRowChanged As dbDataSet.friendscoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendscoordRowChangedEvent = CType([Delegate].Combine(Me.friendscoordRowChangedEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendscoordRowChangedEvent = CType([Delegate].Remove(Me.friendscoordRowChangedEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendscoordRowDeleting As dbDataSet.friendscoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendscoordRowDeletingEvent = CType([Delegate].Combine(Me.friendscoordRowDeletingEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendscoordRowDeletingEvent = CType([Delegate].Remove(Me.friendscoordRowDeletingEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event friendscoordRowDeleted As dbDataSet.friendscoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.friendscoordRowDeletedEvent = CType([Delegate].Combine(Me.friendscoordRowDeletedEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.friendscoordRowDeletedEvent = CType([Delegate].Remove(Me.friendscoordRowDeletedEvent, value), dbDataSet.friendscoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property citieColumn() As DataColumn
				Get
					Return Me.columncitie
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.friendscoordRow
				Get
					Return CType(Me.Rows(index), dbDataSet.friendscoordRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.friendscoordDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.friendscoordDataTable.__ENCList.Count = dbDataSet.friendscoordDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.friendscoordDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.friendscoordDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.friendscoordDataTable.__ENCList(num) = dbDataSet.friendscoordDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.friendscoordDataTable.__ENCList.RemoveRange(num, dbDataSet.friendscoordDataTable.__ENCList.Count - num)
						dbDataSet.friendscoordDataTable.__ENCList.Capacity = dbDataSet.friendscoordDataTable.__ENCList.Count
					End If
					dbDataSet.friendscoordDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.friendscoordDataTable.__ENCAddToList(Me)
				Me.TableName = "friendscoord"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.friendscoordDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.friendscoordDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddfriendscoordRow(row As dbDataSet.friendscoordRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddfriendscoordRow(alliance As String, player As String, x As Integer, y As Integer, citie As String) As dbDataSet.friendscoordRow
				Dim rowfriendscoordRow As dbDataSet.friendscoordRow = CType(Me.NewRow(), dbDataSet.friendscoordRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y, citie }
				rowfriendscoordRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowfriendscoordRow)
				Return rowfriendscoordRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.friendscoordDataTable = CType(MyBase.Clone(), dbDataSet.friendscoordDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.friendscoordDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
				Me.columncitie = MyBase.Columns("citie")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columncitie = New DataColumn("citie", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncitie)
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
				Me.columncitie.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewfriendscoordRow() As dbDataSet.friendscoordRow
				Return CType(Me.NewRow(), dbDataSet.friendscoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.friendscoordRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.friendscoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.friendscoordRowChangedEvent IsNot Nothing
				If flag Then
					Dim friendscoordRowChangeEventHandler As dbDataSet.friendscoordRowChangeEventHandler = Me.friendscoordRowChangedEvent
					flag = (friendscoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendscoordRowChangeEventHandler(Me, New dbDataSet.friendscoordRowChangeEvent(CType(e.Row, dbDataSet.friendscoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.friendscoordRowChangingEvent IsNot Nothing
				If flag Then
					Dim friendscoordRowChangeEventHandler As dbDataSet.friendscoordRowChangeEventHandler = Me.friendscoordRowChangingEvent
					flag = (friendscoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendscoordRowChangeEventHandler(Me, New dbDataSet.friendscoordRowChangeEvent(CType(e.Row, dbDataSet.friendscoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.friendscoordRowDeletedEvent IsNot Nothing
				If flag Then
					Dim friendscoordRowChangeEventHandler As dbDataSet.friendscoordRowChangeEventHandler = Me.friendscoordRowDeletedEvent
					flag = (friendscoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendscoordRowChangeEventHandler(Me, New dbDataSet.friendscoordRowChangeEvent(CType(e.Row, dbDataSet.friendscoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.friendscoordRowDeletingEvent IsNot Nothing
				If flag Then
					Dim friendscoordRowChangeEventHandler As dbDataSet.friendscoordRowChangeEventHandler = Me.friendscoordRowDeletingEvent
					flag = (friendscoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						friendscoordRowChangeEventHandler(Me, New dbDataSet.friendscoordRowChangeEvent(CType(e.Row, dbDataSet.friendscoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemovefriendscoordRow(row As dbDataSet.friendscoordRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "friendscoordDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class hero_allianceDataTable
			Inherits TypedTableBase(Of dbDataSet.hero_allianceRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnhero_nr As DataColumn

			Private columnhero_name As DataColumn

			Private columnplayer_name As DataColumn

			Private columnalliance As DataColumn

			Private columnlevel As DataColumn

			Private columnpolit As DataColumn

			Private columnatt As DataColumn

			Private columnintel As DataColumn

			Private hero_allianceRowChangingEvent As dbDataSet.hero_allianceRowChangeEventHandler

			Private hero_allianceRowChangedEvent As dbDataSet.hero_allianceRowChangeEventHandler

			Private hero_allianceRowDeletingEvent As dbDataSet.hero_allianceRowChangeEventHandler

			Private hero_allianceRowDeletedEvent As dbDataSet.hero_allianceRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event hero_allianceRowChanging As dbDataSet.hero_allianceRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.hero_allianceRowChangingEvent = CType([Delegate].Combine(Me.hero_allianceRowChangingEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.hero_allianceRowChangingEvent = CType([Delegate].Remove(Me.hero_allianceRowChangingEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event hero_allianceRowChanged As dbDataSet.hero_allianceRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.hero_allianceRowChangedEvent = CType([Delegate].Combine(Me.hero_allianceRowChangedEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.hero_allianceRowChangedEvent = CType([Delegate].Remove(Me.hero_allianceRowChangedEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event hero_allianceRowDeleting As dbDataSet.hero_allianceRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.hero_allianceRowDeletingEvent = CType([Delegate].Combine(Me.hero_allianceRowDeletingEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.hero_allianceRowDeletingEvent = CType([Delegate].Remove(Me.hero_allianceRowDeletingEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event hero_allianceRowDeleted As dbDataSet.hero_allianceRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.hero_allianceRowDeletedEvent = CType([Delegate].Combine(Me.hero_allianceRowDeletedEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.hero_allianceRowDeletedEvent = CType([Delegate].Remove(Me.hero_allianceRowDeletedEvent, value), dbDataSet.hero_allianceRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property hero_nrColumn() As DataColumn
				Get
					Return Me.columnhero_nr
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property hero_nameColumn() As DataColumn
				Get
					Return Me.columnhero_name
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property player_nameColumn() As DataColumn
				Get
					Return Me.columnplayer_name
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property levelColumn() As DataColumn
				Get
					Return Me.columnlevel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property politColumn() As DataColumn
				Get
					Return Me.columnpolit
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property attColumn() As DataColumn
				Get
					Return Me.columnatt
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property intelColumn() As DataColumn
				Get
					Return Me.columnintel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.hero_allianceRow
				Get
					Return CType(Me.Rows(index), dbDataSet.hero_allianceRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.hero_allianceDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.hero_allianceDataTable.__ENCList.Count = dbDataSet.hero_allianceDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.hero_allianceDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.hero_allianceDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.hero_allianceDataTable.__ENCList(num) = dbDataSet.hero_allianceDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.hero_allianceDataTable.__ENCList.RemoveRange(num, dbDataSet.hero_allianceDataTable.__ENCList.Count - num)
						dbDataSet.hero_allianceDataTable.__ENCList.Capacity = dbDataSet.hero_allianceDataTable.__ENCList.Count
					End If
					dbDataSet.hero_allianceDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.hero_allianceDataTable.__ENCAddToList(Me)
				Me.TableName = "hero_alliance"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.hero_allianceDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.hero_allianceDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Addhero_allianceRow(row As dbDataSet.hero_allianceRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Addhero_allianceRow(hero_nr As Integer, hero_name As String, player_name As String, alliance As String, level As Integer, polit As Integer, att As Integer, intel As Integer) As dbDataSet.hero_allianceRow
				Dim rowhero_allianceRow As dbDataSet.hero_allianceRow = CType(Me.NewRow(), dbDataSet.hero_allianceRow)
				Dim columnValuesArray As Object() = New Object()() = { hero_nr, hero_name, player_name, alliance, level, polit, att, intel }
				rowhero_allianceRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowhero_allianceRow)
				Return rowhero_allianceRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.hero_allianceDataTable = CType(MyBase.Clone(), dbDataSet.hero_allianceDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.hero_allianceDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnhero_nr = MyBase.Columns("hero nr")
				Me.columnhero_name = MyBase.Columns("hero name")
				Me.columnplayer_name = MyBase.Columns("player name")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnlevel = MyBase.Columns("level")
				Me.columnpolit = MyBase.Columns("polit")
				Me.columnatt = MyBase.Columns("att")
				Me.columnintel = MyBase.Columns("intel")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnhero_nr = New DataColumn("hero nr", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnhero_nr)
				Me.columnhero_name = New DataColumn("hero name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnhero_name)
				Me.columnplayer_name = New DataColumn("player name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer_name)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnlevel = New DataColumn("level", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlevel)
				Me.columnpolit = New DataColumn("polit", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnpolit)
				Me.columnatt = New DataColumn("att", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnatt)
				Me.columnintel = New DataColumn("intel", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnintel)
				Me.columnhero_name.MaxLength = 255
				Me.columnplayer_name.MaxLength = 255
				Me.columnalliance.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Newhero_allianceRow() As dbDataSet.hero_allianceRow
				Return CType(Me.NewRow(), dbDataSet.hero_allianceRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.hero_allianceRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.hero_allianceRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.hero_allianceRowChangedEvent IsNot Nothing
				If flag Then
					Dim hero_allianceRowChangeEventHandler As dbDataSet.hero_allianceRowChangeEventHandler = Me.hero_allianceRowChangedEvent
					flag = (hero_allianceRowChangeEventHandler IsNot Nothing)
					If flag Then
						hero_allianceRowChangeEventHandler(Me, New dbDataSet.hero_allianceRowChangeEvent(CType(e.Row, dbDataSet.hero_allianceRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.hero_allianceRowChangingEvent IsNot Nothing
				If flag Then
					Dim hero_allianceRowChangeEventHandler As dbDataSet.hero_allianceRowChangeEventHandler = Me.hero_allianceRowChangingEvent
					flag = (hero_allianceRowChangeEventHandler IsNot Nothing)
					If flag Then
						hero_allianceRowChangeEventHandler(Me, New dbDataSet.hero_allianceRowChangeEvent(CType(e.Row, dbDataSet.hero_allianceRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.hero_allianceRowDeletedEvent IsNot Nothing
				If flag Then
					Dim hero_allianceRowChangeEventHandler As dbDataSet.hero_allianceRowChangeEventHandler = Me.hero_allianceRowDeletedEvent
					flag = (hero_allianceRowChangeEventHandler IsNot Nothing)
					If flag Then
						hero_allianceRowChangeEventHandler(Me, New dbDataSet.hero_allianceRowChangeEvent(CType(e.Row, dbDataSet.hero_allianceRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.hero_allianceRowDeletingEvent IsNot Nothing
				If flag Then
					Dim hero_allianceRowChangeEventHandler As dbDataSet.hero_allianceRowChangeEventHandler = Me.hero_allianceRowDeletingEvent
					flag = (hero_allianceRowChangeEventHandler IsNot Nothing)
					If flag Then
						hero_allianceRowChangeEventHandler(Me, New dbDataSet.hero_allianceRowChangeEvent(CType(e.Row, dbDataSet.hero_allianceRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Removehero_allianceRow(row As dbDataSet.hero_allianceRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "hero_allianceDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class neutralcoordDataTable
			Inherits TypedTableBase(Of dbDataSet.neutralcoordRow)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnid As DataColumn

			Private columnalliance As DataColumn

			Private columnplayer As DataColumn

			Private columnx As DataColumn

			Private columny As DataColumn

			Private neutralcoordRowChangingEvent As dbDataSet.neutralcoordRowChangeEventHandler

			Private neutralcoordRowChangedEvent As dbDataSet.neutralcoordRowChangeEventHandler

			Private neutralcoordRowDeletingEvent As dbDataSet.neutralcoordRowChangeEventHandler

			Private neutralcoordRowDeletedEvent As dbDataSet.neutralcoordRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralcoordRowChanging As dbDataSet.neutralcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralcoordRowChangingEvent = CType([Delegate].Combine(Me.neutralcoordRowChangingEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralcoordRowChangingEvent = CType([Delegate].Remove(Me.neutralcoordRowChangingEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralcoordRowChanged As dbDataSet.neutralcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralcoordRowChangedEvent = CType([Delegate].Combine(Me.neutralcoordRowChangedEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralcoordRowChangedEvent = CType([Delegate].Remove(Me.neutralcoordRowChangedEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralcoordRowDeleting As dbDataSet.neutralcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralcoordRowDeletingEvent = CType([Delegate].Combine(Me.neutralcoordRowDeletingEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralcoordRowDeletingEvent = CType([Delegate].Remove(Me.neutralcoordRowDeletingEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Custom Event neutralcoordRowDeleted As dbDataSet.neutralcoordRowChangeEventHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				AddHandler
					Me.neutralcoordRowDeletedEvent = CType([Delegate].Combine(Me.neutralcoordRowDeletedEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End AddHandler
				<DebuggerNonUserCode()>
				<MethodImpl(MethodImplOptions.Synchronized)>
				RemoveHandler
					Me.neutralcoordRowDeletedEvent = CType([Delegate].Remove(Me.neutralcoordRowDeletedEvent, value), dbDataSet.neutralcoordRowChangeEventHandler)
				End RemoveHandler
			End Event

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property idColumn() As DataColumn
				Get
					Return Me.columnid
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property allianceColumn() As DataColumn
				Get
					Return Me.columnalliance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property playerColumn() As DataColumn
				Get
					Return Me.columnplayer
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property xColumn() As DataColumn
				Get
					Return Me.columnx
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property yColumn() As DataColumn
				Get
					Return Me.columny
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property (index As Integer) As dbDataSet.neutralcoordRow
				Get
					Return CType(Me.Rows(index), dbDataSet.neutralcoordRow)
				End Get
			End Property

			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dbDataSet.neutralcoordDataTable.__ENCList
				Dim flag As Boolean = False
				' The following expression was wrapped in a checked-statement
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dbDataSet.neutralcoordDataTable.__ENCList.Count = dbDataSet.neutralcoordDataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim arg_44_0 As Integer = 0
						Dim num2 As Integer = dbDataSet.neutralcoordDataTable.__ENCList.Count - 1
						Dim num3 As Integer = arg_44_0
						While True
							Dim arg_95_0 As Integer = num3
							Dim num4 As Integer = num2
							If arg_95_0 > num4 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dbDataSet.neutralcoordDataTable.__ENCList(num3)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num3 <> num
								If flag3 Then
									dbDataSet.neutralcoordDataTable.__ENCList(num) = dbDataSet.neutralcoordDataTable.__ENCList(num3)
								End If
								num += 1
							End If
							num3 += 1
						End While
						dbDataSet.neutralcoordDataTable.__ENCList.RemoveRange(num, dbDataSet.neutralcoordDataTable.__ENCList.Count - num)
						dbDataSet.neutralcoordDataTable.__ENCList.Capacity = dbDataSet.neutralcoordDataTable.__ENCList.Count
					End If
					dbDataSet.neutralcoordDataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dbDataSet.neutralcoordDataTable.__ENCAddToList(Me)
				Me.TableName = "neutralcoord"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dbDataSet.neutralcoordDataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.[New](info, context)
				dbDataSet.neutralcoordDataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddneutralcoordRow(row As dbDataSet.neutralcoordRow)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddneutralcoordRow(alliance As String, player As String, x As Integer, y As Integer) As dbDataSet.neutralcoordRow
				Dim rowneutralcoordRow As dbDataSet.neutralcoordRow = CType(Me.NewRow(), dbDataSet.neutralcoordRow)
				Dim columnValuesArray As Object() = New Object()() = { Nothing, alliance, player, x, y }
				rowneutralcoordRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowneutralcoordRow)
				Return rowneutralcoordRow
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Override Function Clone() As DataTable
				Dim cln As dbDataSet.neutralcoordDataTable = CType(MyBase.Clone(), dbDataSet.neutralcoordDataTable)
				cln.InitVars()
				Return cln
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function CreateInstance() As DataTable
				Return New dbDataSet.neutralcoordDataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnid = MyBase.Columns("id")
				Me.columnalliance = MyBase.Columns("alliance")
				Me.columnplayer = MyBase.Columns("player")
				Me.columnx = MyBase.Columns("x")
				Me.columny = MyBase.Columns("y")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnid = New DataColumn("id", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid)
				Me.columnalliance = New DataColumn("alliance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnalliance)
				Me.columnplayer = New DataColumn("player", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnplayer)
				Me.columnx = New DataColumn("x", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnx)
				Me.columny = New DataColumn("y", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columny)
				Me.columnid.AutoIncrement = True
				Me.columnid.AutoIncrementSeed = -1L
				Me.columnid.AutoIncrementStep = -1L
				Me.columnalliance.MaxLength = 255
				Me.columnplayer.MaxLength = 255
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewneutralcoordRow() As dbDataSet.neutralcoordRow
				Return CType(Me.NewRow(), dbDataSet.neutralcoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dbDataSet.neutralcoordRow(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Function GetRowType() As Type
				Return GetType(dbDataSet.neutralcoordRow)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.neutralcoordRowChangedEvent IsNot Nothing
				If flag Then
					Dim neutralcoordRowChangeEventHandler As dbDataSet.neutralcoordRowChangeEventHandler = Me.neutralcoordRowChangedEvent
					flag = (neutralcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralcoordRowChangeEventHandler(Me, New dbDataSet.neutralcoordRowChangeEvent(CType(e.Row, dbDataSet.neutralcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.neutralcoordRowChangingEvent IsNot Nothing
				If flag Then
					Dim neutralcoordRowChangeEventHandler As dbDataSet.neutralcoordRowChangeEventHandler = Me.neutralcoordRowChangingEvent
					flag = (neutralcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralcoordRowChangeEventHandler(Me, New dbDataSet.neutralcoordRowChangeEvent(CType(e.Row, dbDataSet.neutralcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.neutralcoordRowDeletedEvent IsNot Nothing
				If flag Then
					Dim neutralcoordRowChangeEventHandler As dbDataSet.neutralcoordRowChangeEventHandler = Me.neutralcoordRowDeletedEvent
					flag = (neutralcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralcoordRowChangeEventHandler(Me, New dbDataSet.neutralcoordRowChangeEvent(CType(e.Row, dbDataSet.neutralcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Override Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.neutralcoordRowDeletingEvent IsNot Nothing
				If flag Then
					Dim neutralcoordRowChangeEventHandler As dbDataSet.neutralcoordRowChangeEventHandler = Me.neutralcoordRowDeletingEvent
					flag = (neutralcoordRowChangeEventHandler IsNot Nothing)
					If flag Then
						neutralcoordRowChangeEventHandler(Me, New dbDataSet.neutralcoordRowChangeEvent(CType(e.Row, dbDataSet.neutralcoordRow), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveneutralcoordRow(row As dbDataSet.neutralcoordRow)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim ds As dbDataSet = New dbDataSet()
				Dim any As XmlSchemaAny = New XmlSchemaAny()
				any.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim arg_34_0 As XmlSchemaParticle = any
				Dim minOccurs As Decimal = New Decimal(0)
				arg_34_0.MinOccurs = minOccurs
				any.MaxOccurs = 79228162514264337593543950335D
				any.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any)
				Dim any2 As XmlSchemaAny = New XmlSchemaAny()
				any2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim arg_94_0 As XmlSchemaParticle = any2
				minOccurs = New Decimal(1)
				arg_94_0.MinOccurs = minOccurs
				any2.ProcessContents = XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute.Name = "namespace"
				attribute.FixedValue = ds.[Namespace]
				type.Attributes.Add(attribute)
				Dim attribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "neutralcoordDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
				Dim GetTypedTableSchema As XmlSchemaComplexType
				If flag Then
					Dim s As MemoryStream = New MemoryStream()
					Dim s2 As MemoryStream = New MemoryStream()
					Try
						dsSchema.Write(s)
						Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						While schemas.MoveNext()
							Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
							s2.SetLength(0L)
							schema.Write(s2)
							flag = (s.Length = s2.Length)
							If flag Then
								s.Position = 0L
								s2.Position = 0L
								While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
								End While
								flag = (s.Position = s.Length)
								If flag Then
									GetTypedTableSchema = type
									Return GetTypedTableSchema
								End If
							End If
						End While
					Finally
						flag = (s IsNot Nothing)
						If flag Then
							s.Close()
						End If
						flag = (s2 IsNot Nothing)
						If flag Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				GetTypedTableSchema = type
				Return GetTypedTableSchema
			End Function
		End Class

		Public Class altRow
			Inherits DataRow

			Private tablealt As dbDataSet.altDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablealt.idColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablealt.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablealt.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'alt' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablealt.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablealt.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'alt' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablealt.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablealt.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'alt' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablealt.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablealt.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'alt' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablealt.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablealt = CType(Me.Table, dbDataSet.altDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablealt.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablealt.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablealt.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablealt.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablealt.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablealt.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablealt.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablealt.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class cordinRow
			Inherits DataRow

			Private tablecordin As dbDataSet.cordinDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablecordin.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'cordin' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablecordin.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablecordin.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'cordin' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablecordin.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablecordin.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'cordin' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablecordin.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablecordin.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'cordin' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablecordin.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property citie() As String
				Get
					Dim citie As String
					Try
						citie = Conversions.ToString(Me(Me.tablecordin.citieColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'citie' in table 'cordin' is DBNull.", e)
					End Try
					Return citie
				End Get
				Set(value As String)
					Me(Me.tablecordin.citieColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablecordin.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablecordin.IDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablecordin = CType(Me.Table, dbDataSet.cordinDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablecordin.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablecordin.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablecordin.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablecordin.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablecordin.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablecordin.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablecordin.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablecordin.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IscitieNull() As Boolean
				Return Me.IsNull(Me.tablecordin.citieColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetcitieNull()
				Me(Me.tablecordin.citieColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class enemiesRow
			Inherits DataRow

			Private tableenemies As dbDataSet.enemiesDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tableenemies.idColumn))
				End Get
				Set(value As Integer)
					Me(Me.tableenemies.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tableenemies.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'enemies' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tableenemies.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tableenemies.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'enemies' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tableenemies.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tableenemies.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'enemies' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tableenemies.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tableenemies.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'enemies' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tableenemies.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tableenemies = CType(Me.Table, dbDataSet.enemiesDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tableenemies.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tableenemies.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tableenemies.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tableenemies.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tableenemies.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tableenemies.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tableenemies.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tableenemies.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class fieldRow
			Inherits DataRow

			Private tablefield As dbDataSet.fieldDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablefield.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'field' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablefield.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablefield.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'field' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablefield.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property level() As Integer
				Get
					Dim level As Integer
					Try
						level = Conversions.ToInteger(Me(Me.tablefield.levelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'level' in table 'field' is DBNull.", e)
					End Try
					Return level
				End Get
				Set(value As Integer)
					Me(Me.tablefield.levelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property field() As String
				Get
					Dim field As String
					Try
						field = Conversions.ToString(Me(Me.tablefield.fieldColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'field' in table 'field' is DBNull.", e)
					End Try
					Return field
				End Get
				Set(value As String)
					Me(Me.tablefield.fieldColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablefield.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablefield.IDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablefield = CType(Me.Table, dbDataSet.fieldDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablefield.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablefield.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablefield.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablefield.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IslevelNull() As Boolean
				Return Me.IsNull(Me.tablefield.levelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetlevelNull()
				Me(Me.tablefield.levelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsfieldNull() As Boolean
				Return Me.IsNull(Me.tablefield.fieldColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetfieldNull()
				Me(Me.tablefield.fieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class flatsRow
			Inherits DataRow

			Private tableflats As dbDataSet.flatsDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tableflats.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'flats' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tableflats.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tableflats.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'flats' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tableflats.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property level() As Integer
				Get
					Dim level As Integer
					Try
						level = Conversions.ToInteger(Me(Me.tableflats.levelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'level' in table 'flats' is DBNull.", e)
					End Try
					Return level
				End Get
				Set(value As Integer)
					Me(Me.tableflats.levelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tableflats.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tableflats.IDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tableflats = CType(Me.Table, dbDataSet.flatsDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tableflats.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tableflats.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tableflats.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tableflats.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IslevelNull() As Boolean
				Return Me.IsNull(Me.tableflats.levelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetlevelNull()
				Me(Me.tableflats.levelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class friendsRow
			Inherits DataRow

			Private tablefriends As dbDataSet.friendsDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablefriends.idColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablefriends.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablefriends.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'friends' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablefriends.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablefriends.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'friends' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablefriends.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablefriends.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'friends' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablefriends.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablefriends.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'friends' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablefriends.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablefriends = CType(Me.Table, dbDataSet.friendsDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablefriends.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablefriends.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablefriends.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablefriends.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablefriends.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablefriends.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablefriends.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablefriends.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class heroRow
			Inherits DataRow

			Private tablehero As dbDataSet.heroDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property hero_nr() As Integer
				Get
					Dim hero_nr As Integer
					Try
						hero_nr = Conversions.ToInteger(Me(Me.tablehero.hero_nrColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'hero nr' in table 'hero' is DBNull.", e)
					End Try
					Return hero_nr
				End Get
				Set(value As Integer)
					Me(Me.tablehero.hero_nrColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property hero_name() As String
				Get
					Dim hero_name As String
					Try
						hero_name = Conversions.ToString(Me(Me.tablehero.hero_nameColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'hero name' in table 'hero' is DBNull.", e)
					End Try
					Return hero_name
				End Get
				Set(value As String)
					Me(Me.tablehero.hero_nameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player_name() As String
				Get
					Dim player_name As String
					Try
						player_name = Conversions.ToString(Me(Me.tablehero.player_nameColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player name' in table 'hero' is DBNull.", e)
					End Try
					Return player_name
				End Get
				Set(value As String)
					Me(Me.tablehero.player_nameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property level() As Integer
				Get
					Dim level As Integer
					Try
						level = Conversions.ToInteger(Me(Me.tablehero.levelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'level' in table 'hero' is DBNull.", e)
					End Try
					Return level
				End Get
				Set(value As Integer)
					Me(Me.tablehero.levelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property polit() As Integer
				Get
					Dim polit As Integer
					Try
						polit = Conversions.ToInteger(Me(Me.tablehero.politColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'polit' in table 'hero' is DBNull.", e)
					End Try
					Return polit
				End Get
				Set(value As Integer)
					Me(Me.tablehero.politColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property att() As Integer
				Get
					Dim att As Integer
					Try
						att = Conversions.ToInteger(Me(Me.tablehero.attColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'att' in table 'hero' is DBNull.", e)
					End Try
					Return att
				End Get
				Set(value As Integer)
					Me(Me.tablehero.attColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property intel() As Integer
				Get
					Dim intel As Integer
					Try
						intel = Conversions.ToInteger(Me(Me.tablehero.intelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'intel' in table 'hero' is DBNull.", e)
					End Try
					Return intel
				End Get
				Set(value As Integer)
					Me(Me.tablehero.intelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablehero.idColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablehero.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablehero = CType(Me.Table, dbDataSet.heroDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Ishero_nrNull() As Boolean
				Return Me.IsNull(Me.tablehero.hero_nrColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Sethero_nrNull()
				Me(Me.tablehero.hero_nrColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Ishero_nameNull() As Boolean
				Return Me.IsNull(Me.tablehero.hero_nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Sethero_nameNull()
				Me(Me.tablehero.hero_nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Isplayer_nameNull() As Boolean
				Return Me.IsNull(Me.tablehero.player_nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Setplayer_nameNull()
				Me(Me.tablehero.player_nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IslevelNull() As Boolean
				Return Me.IsNull(Me.tablehero.levelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetlevelNull()
				Me(Me.tablehero.levelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IspolitNull() As Boolean
				Return Me.IsNull(Me.tablehero.politColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetpolitNull()
				Me(Me.tablehero.politColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsattNull() As Boolean
				Return Me.IsNull(Me.tablehero.attColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetattNull()
				Me(Me.tablehero.attColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsintelNull() As Boolean
				Return Me.IsNull(Me.tablehero.intelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetintelNull()
				Me(Me.tablehero.intelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class huntRow
			Inherits DataRow

			Private tablehunt As dbDataSet.huntDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablehunt.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'hunt' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablehunt.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablehunt.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'hunt' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablehunt.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablehunt.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'hunt' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablehunt.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablehunt.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablehunt.IDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablehunt = CType(Me.Table, dbDataSet.huntDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablehunt.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablehunt.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablehunt.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablehunt.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablehunt.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablehunt.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class neutralRow
			Inherits DataRow

			Private tableneutral As dbDataSet.neutralDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tableneutral.idColumn))
				End Get
				Set(value As Integer)
					Me(Me.tableneutral.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tableneutral.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'neutral' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tableneutral.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tableneutral.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'neutral' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tableneutral.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tableneutral.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'neutral' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tableneutral.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tableneutral.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'neutral' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tableneutral.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tableneutral = CType(Me.Table, dbDataSet.neutralDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tableneutral.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tableneutral.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tableneutral.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tableneutral.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tableneutral.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tableneutral.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tableneutral.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tableneutral.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class npcRow
			Inherits DataRow

			Private tablenpc As dbDataSet.npcDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablenpc.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'npc' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablenpc.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablenpc.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'npc' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablenpc.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property level() As Integer
				Get
					Dim level As Integer
					Try
						level = Conversions.ToInteger(Me(Me.tablenpc.levelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'level' in table 'npc' is DBNull.", e)
					End Try
					Return level
				End Get
				Set(value As Integer)
					Me(Me.tablenpc.levelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID() As Integer
				Get
					Return Conversions.ToInteger(Me(Me.tablenpc.IDColumn))
				End Get
				Set(value As Integer)
					Me(Me.tablenpc.IDColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablenpc = CType(Me.Table, dbDataSet.npcDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablenpc.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablenpc.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablenpc.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablenpc.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IslevelNull() As Boolean
				Return Me.IsNull(Me.tablenpc.levelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetlevelNull()
				Me(Me.tablenpc.levelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class altcoordRow
			Inherits DataRow

			Private tablealtcoord As dbDataSet.altcoordDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Dim id As Integer
					Try
						id = Conversions.ToInteger(Me(Me.tablealtcoord.idColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'id' in table 'altcoord' is DBNull.", e)
					End Try
					Return id
				End Get
				Set(value As Integer)
					Me(Me.tablealtcoord.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablealtcoord.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'altcoord' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablealtcoord.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablealtcoord.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'altcoord' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablealtcoord.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablealtcoord.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'altcoord' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablealtcoord.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablealtcoord.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'altcoord' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablealtcoord.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property citie() As String
				Get
					Dim citie As String
					Try
						citie = Conversions.ToString(Me(Me.tablealtcoord.citieColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'citie' in table 'altcoord' is DBNull.", e)
					End Try
					Return citie
				End Get
				Set(value As String)
					Me(Me.tablealtcoord.citieColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablealtcoord = CType(Me.Table, dbDataSet.altcoordDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsidNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.idColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetidNull()
				Me(Me.tablealtcoord.idColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablealtcoord.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablealtcoord.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablealtcoord.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablealtcoord.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IscitieNull() As Boolean
				Return Me.IsNull(Me.tablealtcoord.citieColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetcitieNull()
				Me(Me.tablealtcoord.citieColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class enemiescoordRow
			Inherits DataRow

			Private tableenemiescoord As dbDataSet.enemiescoordDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Dim id As Integer
					Try
						id = Conversions.ToInteger(Me(Me.tableenemiescoord.idColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'id' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return id
				End Get
				Set(value As Integer)
					Me(Me.tableenemiescoord.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tableenemiescoord.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tableenemiescoord.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tableenemiescoord.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tableenemiescoord.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tableenemiescoord.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tableenemiescoord.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tableenemiescoord.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tableenemiescoord.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property citie() As String
				Get
					Dim citie As String
					Try
						citie = Conversions.ToString(Me(Me.tableenemiescoord.citieColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'citie' in table 'enemiescoord' is DBNull.", e)
					End Try
					Return citie
				End Get
				Set(value As String)
					Me(Me.tableenemiescoord.citieColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tableenemiescoord = CType(Me.Table, dbDataSet.enemiescoordDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsidNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.idColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetidNull()
				Me(Me.tableenemiescoord.idColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tableenemiescoord.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tableenemiescoord.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tableenemiescoord.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tableenemiescoord.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IscitieNull() As Boolean
				Return Me.IsNull(Me.tableenemiescoord.citieColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetcitieNull()
				Me(Me.tableenemiescoord.citieColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class friendscoordRow
			Inherits DataRow

			Private tablefriendscoord As dbDataSet.friendscoordDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Dim id As Integer
					Try
						id = Conversions.ToInteger(Me(Me.tablefriendscoord.idColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'id' in table 'friendscoord' is DBNull.", e)
					End Try
					Return id
				End Get
				Set(value As Integer)
					Me(Me.tablefriendscoord.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablefriendscoord.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'friendscoord' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablefriendscoord.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tablefriendscoord.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'friendscoord' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tablefriendscoord.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tablefriendscoord.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'friendscoord' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tablefriendscoord.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tablefriendscoord.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'friendscoord' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tablefriendscoord.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property citie() As String
				Get
					Dim citie As String
					Try
						citie = Conversions.ToString(Me(Me.tablefriendscoord.citieColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'citie' in table 'friendscoord' is DBNull.", e)
					End Try
					Return citie
				End Get
				Set(value As String)
					Me(Me.tablefriendscoord.citieColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablefriendscoord = CType(Me.Table, dbDataSet.friendscoordDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsidNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.idColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetidNull()
				Me(Me.tablefriendscoord.idColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablefriendscoord.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tablefriendscoord.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tablefriendscoord.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tablefriendscoord.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IscitieNull() As Boolean
				Return Me.IsNull(Me.tablefriendscoord.citieColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetcitieNull()
				Me(Me.tablefriendscoord.citieColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class hero_allianceRow
			Inherits DataRow

			Private tablehero_alliance As dbDataSet.hero_allianceDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property hero_nr() As Integer
				Get
					Dim hero_nr As Integer
					Try
						hero_nr = Conversions.ToInteger(Me(Me.tablehero_alliance.hero_nrColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'hero nr' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return hero_nr
				End Get
				Set(value As Integer)
					Me(Me.tablehero_alliance.hero_nrColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property hero_name() As String
				Get
					Dim hero_name As String
					Try
						hero_name = Conversions.ToString(Me(Me.tablehero_alliance.hero_nameColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'hero name' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return hero_name
				End Get
				Set(value As String)
					Me(Me.tablehero_alliance.hero_nameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player_name() As String
				Get
					Dim player_name As String
					Try
						player_name = Conversions.ToString(Me(Me.tablehero_alliance.player_nameColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player name' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return player_name
				End Get
				Set(value As String)
					Me(Me.tablehero_alliance.player_nameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tablehero_alliance.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tablehero_alliance.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property level() As Integer
				Get
					Dim level As Integer
					Try
						level = Conversions.ToInteger(Me(Me.tablehero_alliance.levelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'level' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return level
				End Get
				Set(value As Integer)
					Me(Me.tablehero_alliance.levelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property polit() As Integer
				Get
					Dim polit As Integer
					Try
						polit = Conversions.ToInteger(Me(Me.tablehero_alliance.politColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'polit' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return polit
				End Get
				Set(value As Integer)
					Me(Me.tablehero_alliance.politColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property att() As Integer
				Get
					Dim att As Integer
					Try
						att = Conversions.ToInteger(Me(Me.tablehero_alliance.attColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'att' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return att
				End Get
				Set(value As Integer)
					Me(Me.tablehero_alliance.attColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property intel() As Integer
				Get
					Dim intel As Integer
					Try
						intel = Conversions.ToInteger(Me(Me.tablehero_alliance.intelColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'intel' in table 'hero_alliance' is DBNull.", e)
					End Try
					Return intel
				End Get
				Set(value As Integer)
					Me(Me.tablehero_alliance.intelColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tablehero_alliance = CType(Me.Table, dbDataSet.hero_allianceDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Ishero_nrNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.hero_nrColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Sethero_nrNull()
				Me(Me.tablehero_alliance.hero_nrColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Ishero_nameNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.hero_nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Sethero_nameNull()
				Me(Me.tablehero_alliance.hero_nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Isplayer_nameNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.player_nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Setplayer_nameNull()
				Me(Me.tablehero_alliance.player_nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tablehero_alliance.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IslevelNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.levelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetlevelNull()
				Me(Me.tablehero_alliance.levelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IspolitNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.politColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetpolitNull()
				Me(Me.tablehero_alliance.politColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsattNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.attColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetattNull()
				Me(Me.tablehero_alliance.attColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsintelNull() As Boolean
				Return Me.IsNull(Me.tablehero_alliance.intelColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetintelNull()
				Me(Me.tablehero_alliance.intelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class neutralcoordRow
			Inherits DataRow

			Private tableneutralcoord As dbDataSet.neutralcoordDataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property id() As Integer
				Get
					Dim id As Integer
					Try
						id = Conversions.ToInteger(Me(Me.tableneutralcoord.idColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'id' in table 'neutralcoord' is DBNull.", e)
					End Try
					Return id
				End Get
				Set(value As Integer)
					Me(Me.tableneutralcoord.idColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property alliance() As String
				Get
					Dim alliance As String
					Try
						alliance = Conversions.ToString(Me(Me.tableneutralcoord.allianceColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'alliance' in table 'neutralcoord' is DBNull.", e)
					End Try
					Return alliance
				End Get
				Set(value As String)
					Me(Me.tableneutralcoord.allianceColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property player() As String
				Get
					Dim player As String
					Try
						player = Conversions.ToString(Me(Me.tableneutralcoord.playerColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'player' in table 'neutralcoord' is DBNull.", e)
					End Try
					Return player
				End Get
				Set(value As String)
					Me(Me.tableneutralcoord.playerColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property x() As Integer
				Get
					Dim x As Integer
					Try
						x = Conversions.ToInteger(Me(Me.tableneutralcoord.xColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'x' in table 'neutralcoord' is DBNull.", e)
					End Try
					Return x
				End Get
				Set(value As Integer)
					Me(Me.tableneutralcoord.xColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property y() As Integer
				Get
					Dim y As Integer
					Try
						y = Conversions.ToInteger(Me(Me.tableneutralcoord.yColumn))
					Catch expr_1D As InvalidCastException
						ProjectData.SetProjectError(expr_1D)
						Dim e As InvalidCastException = expr_1D
						Throw New StrongTypingException("The value for column 'y' in table 'neutralcoord' is DBNull.", e)
					End Try
					Return y
				End Get
				Set(value As Integer)
					Me(Me.tableneutralcoord.yColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.[New](rb)
				Me.tableneutralcoord = CType(Me.Table, dbDataSet.neutralcoordDataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsidNull() As Boolean
				Return Me.IsNull(Me.tableneutralcoord.idColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetidNull()
				Me(Me.tableneutralcoord.idColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsallianceNull() As Boolean
				Return Me.IsNull(Me.tableneutralcoord.allianceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetallianceNull()
				Me(Me.tableneutralcoord.allianceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsplayerNull() As Boolean
				Return Me.IsNull(Me.tableneutralcoord.playerColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetplayerNull()
				Me(Me.tableneutralcoord.playerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsxNull() As Boolean
				Return Me.IsNull(Me.tableneutralcoord.xColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetxNull()
				Me(Me.tableneutralcoord.xColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsyNull() As Boolean
				Return Me.IsNull(Me.tableneutralcoord.yColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetyNull()
				Me(Me.tableneutralcoord.yColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class altRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.altRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.altRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.altRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class cordinRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.cordinRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.cordinRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.cordinRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class enemiesRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.enemiesRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.enemiesRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.enemiesRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class fieldRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.fieldRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.fieldRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.fieldRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class flatsRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.flatsRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.flatsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.flatsRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class friendsRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.friendsRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.friendsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.friendsRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class heroRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.heroRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.heroRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.heroRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class huntRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.huntRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.huntRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.huntRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class neutralRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.neutralRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.neutralRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.neutralRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class npcRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.npcRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.npcRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.npcRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class altcoordRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.altcoordRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.altcoordRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.altcoordRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class enemiescoordRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.enemiescoordRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.enemiescoordRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.enemiescoordRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class friendscoordRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.friendscoordRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.friendscoordRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.friendscoordRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class hero_allianceRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.hero_allianceRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.hero_allianceRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.hero_allianceRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class neutralcoordRowChangeEvent
			Inherits EventArgs

			Private eventRow As dbDataSet.neutralcoordRow

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row() As dbDataSet.neutralcoordRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dbDataSet.neutralcoordRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tablealt As dbDataSet.altDataTable

		Private tablecordin As dbDataSet.cordinDataTable

		Private tableenemies As dbDataSet.enemiesDataTable

		Private tablefield As dbDataSet.fieldDataTable

		Private tableflats As dbDataSet.flatsDataTable

		Private tablefriends As dbDataSet.friendsDataTable

		Private tablehero As dbDataSet.heroDataTable

		Private tablehunt As dbDataSet.huntDataTable

		Private tableneutral As dbDataSet.neutralDataTable

		Private tablenpc As dbDataSet.npcDataTable

		Private tablealtcoord As dbDataSet.altcoordDataTable

		Private tableenemiescoord As dbDataSet.enemiescoordDataTable

		Private tablefriendscoord As dbDataSet.friendscoordDataTable

		Private tablehero_alliance As dbDataSet.hero_allianceDataTable

		Private tableneutralcoord As dbDataSet.neutralcoordDataTable

		Private _schemaSerializationMode As SchemaSerializationMode

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property alt() As dbDataSet.altDataTable
			Get
				Return Me.tablealt
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property cordin() As dbDataSet.cordinDataTable
			Get
				Return Me.tablecordin
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property enemies() As dbDataSet.enemiesDataTable
			Get
				Return Me.tableenemies
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property field() As dbDataSet.fieldDataTable
			Get
				Return Me.tablefield
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property flats() As dbDataSet.flatsDataTable
			Get
				Return Me.tableflats
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property friends() As dbDataSet.friendsDataTable
			Get
				Return Me.tablefriends
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property hero() As dbDataSet.heroDataTable
			Get
				Return Me.tablehero
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property hunt() As dbDataSet.huntDataTable
			Get
				Return Me.tablehunt
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property neutral() As dbDataSet.neutralDataTable
			Get
				Return Me.tableneutral
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property npc() As dbDataSet.npcDataTable
			Get
				Return Me.tablenpc
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property altcoord() As dbDataSet.altcoordDataTable
			Get
				Return Me.tablealtcoord
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property enemiescoord() As dbDataSet.enemiescoordDataTable
			Get
				Return Me.tableenemiescoord
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property friendscoord() As dbDataSet.friendscoordDataTable
			Get
				Return Me.tablefriendscoord
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property hero_alliance() As dbDataSet.hero_allianceDataTable
			Get
				Return Me.tablehero_alliance
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode()>
		Public ReadOnly Property neutralcoord() As dbDataSet.neutralcoordDataTable
			Get
				Return Me.tableneutralcoord
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode()>
		Public Override Property SchemaSerializationMode() As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode()>
		Public ReadOnly Property Tables() As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode()>
		Public ReadOnly Property Relations() As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dbDataSet.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dbDataSet.__ENCList.Count = dbDataSet.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = dbDataSet.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dbDataSet.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								dbDataSet.__ENCList(num) = dbDataSet.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					dbDataSet.__ENCList.RemoveRange(num, dbDataSet.__ENCList.Count - num)
					dbDataSet.__ENCList.Capacity = dbDataSet.__ENCList.Count
				End If
				dbDataSet.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Sub New()
			dbDataSet.__ENCAddToList(Me)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As CollectionChangeEventHandler = New CollectionChangeEventHandler(Me.SchemaChanged)
			MyBase.Tables.CollectionChanged += schemaChangedHandler
			MyBase.Relations.CollectionChanged += schemaChangedHandler
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.[New](info, context, False)
			dbDataSet.__ENCAddToList(Me)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Dim flag As Boolean = Me.IsBinarySerialized(info, context)
			If flag Then
				Me.InitVars(False)
				Dim schemaChangedHandler As CollectionChangeEventHandler = New CollectionChangeEventHandler(Me.SchemaChanged)
				Me.Tables.CollectionChanged += schemaChangedHandler
				Me.Relations.CollectionChanged += schemaChangedHandler
			Else
				Dim strSchema As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
				flag = (Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema)
				If flag Then
					Dim ds As DataSet = New DataSet()
					ds.ReadXmlSchema(New XmlTextReader(New StringReader(strSchema)))
					flag = (ds.Tables("alt") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.altDataTable(ds.Tables("alt")))
					End If
					flag = (ds.Tables("cordin") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.cordinDataTable(ds.Tables("cordin")))
					End If
					flag = (ds.Tables("enemies") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.enemiesDataTable(ds.Tables("enemies")))
					End If
					flag = (ds.Tables("field") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.fieldDataTable(ds.Tables("field")))
					End If
					flag = (ds.Tables("flats") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.flatsDataTable(ds.Tables("flats")))
					End If
					flag = (ds.Tables("friends") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.friendsDataTable(ds.Tables("friends")))
					End If
					flag = (ds.Tables("hero") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.heroDataTable(ds.Tables("hero")))
					End If
					flag = (ds.Tables("hunt") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.huntDataTable(ds.Tables("hunt")))
					End If
					flag = (ds.Tables("neutral") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.neutralDataTable(ds.Tables("neutral")))
					End If
					flag = (ds.Tables("npc") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.npcDataTable(ds.Tables("npc")))
					End If
					flag = (ds.Tables("altcoord") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.altcoordDataTable(ds.Tables("altcoord")))
					End If
					flag = (ds.Tables("enemiescoord") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.enemiescoordDataTable(ds.Tables("enemiescoord")))
					End If
					flag = (ds.Tables("friendscoord") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.friendscoordDataTable(ds.Tables("friendscoord")))
					End If
					flag = (ds.Tables("hero_alliance") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.hero_allianceDataTable(ds.Tables("hero_alliance")))
					End If
					flag = (ds.Tables("neutralcoord") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dbDataSet.neutralcoordDataTable(ds.Tables("neutralcoord")))
					End If
					Me.DataSetName = ds.DataSetName
					Me.Prefix = ds.Prefix
					Me.[Namespace] = ds.[Namespace]
					Me.Locale = ds.Locale
					Me.CaseSensitive = ds.CaseSensitive
					Me.EnforceConstraints = ds.EnforceConstraints
					Me.Merge(ds, False, MissingSchemaAction.Add)
					Me.InitVars()
				Else
					Me.ReadXmlSchema(New XmlTextReader(New StringReader(strSchema)))
				End If
				Me.GetSerializationData(info, context)
				Dim schemaChangedHandler2 As CollectionChangeEventHandler = New CollectionChangeEventHandler(Me.SchemaChanged)
				MyBase.Tables.CollectionChanged += schemaChangedHandler2
				Me.Relations.CollectionChanged += schemaChangedHandler2
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Override Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Override Function Clone() As DataSet
			Dim cln As dbDataSet = CType(MyBase.Clone(), dbDataSet)
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Override Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Override Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Override Sub ReadXmlSerializable(reader As XmlReader)
			Dim flag As Boolean = Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema
			If flag Then
				Me.Reset()
				Dim ds As DataSet = New DataSet()
				ds.ReadXml(reader)
				flag = (ds.Tables("alt") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.altDataTable(ds.Tables("alt")))
				End If
				flag = (ds.Tables("cordin") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.cordinDataTable(ds.Tables("cordin")))
				End If
				flag = (ds.Tables("enemies") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.enemiesDataTable(ds.Tables("enemies")))
				End If
				flag = (ds.Tables("field") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.fieldDataTable(ds.Tables("field")))
				End If
				flag = (ds.Tables("flats") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.flatsDataTable(ds.Tables("flats")))
				End If
				flag = (ds.Tables("friends") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.friendsDataTable(ds.Tables("friends")))
				End If
				flag = (ds.Tables("hero") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.heroDataTable(ds.Tables("hero")))
				End If
				flag = (ds.Tables("hunt") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.huntDataTable(ds.Tables("hunt")))
				End If
				flag = (ds.Tables("neutral") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.neutralDataTable(ds.Tables("neutral")))
				End If
				flag = (ds.Tables("npc") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.npcDataTable(ds.Tables("npc")))
				End If
				flag = (ds.Tables("altcoord") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.altcoordDataTable(ds.Tables("altcoord")))
				End If
				flag = (ds.Tables("enemiescoord") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.enemiescoordDataTable(ds.Tables("enemiescoord")))
				End If
				flag = (ds.Tables("friendscoord") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.friendscoordDataTable(ds.Tables("friendscoord")))
				End If
				flag = (ds.Tables("hero_alliance") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.hero_allianceDataTable(ds.Tables("hero_alliance")))
				End If
				flag = (ds.Tables("neutralcoord") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dbDataSet.neutralcoordDataTable(ds.Tables("neutralcoord")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.[Namespace] = ds.[Namespace]
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Override Function GetSchemaSerializable() As XmlSchema
			Dim stream As MemoryStream = New MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
			stream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(stream), Nothing)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Sub InitVars(initTable As Boolean)
			Me.tablealt = CType(MyBase.Tables("alt"), dbDataSet.altDataTable)
			If initTable Then
				Dim flag As Boolean = Me.tablealt IsNot Nothing
				If flag Then
					Me.tablealt.InitVars()
				End If
			End If
			Me.tablecordin = CType(MyBase.Tables("cordin"), dbDataSet.cordinDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablecordin IsNot Nothing
				If flag2 Then
					Me.tablecordin.InitVars()
				End If
			End If
			Me.tableenemies = CType(MyBase.Tables("enemies"), dbDataSet.enemiesDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableenemies IsNot Nothing
				If flag2 Then
					Me.tableenemies.InitVars()
				End If
			End If
			Me.tablefield = CType(MyBase.Tables("field"), dbDataSet.fieldDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablefield IsNot Nothing
				If flag2 Then
					Me.tablefield.InitVars()
				End If
			End If
			Me.tableflats = CType(MyBase.Tables("flats"), dbDataSet.flatsDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableflats IsNot Nothing
				If flag2 Then
					Me.tableflats.InitVars()
				End If
			End If
			Me.tablefriends = CType(MyBase.Tables("friends"), dbDataSet.friendsDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablefriends IsNot Nothing
				If flag2 Then
					Me.tablefriends.InitVars()
				End If
			End If
			Me.tablehero = CType(MyBase.Tables("hero"), dbDataSet.heroDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablehero IsNot Nothing
				If flag2 Then
					Me.tablehero.InitVars()
				End If
			End If
			Me.tablehunt = CType(MyBase.Tables("hunt"), dbDataSet.huntDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablehunt IsNot Nothing
				If flag2 Then
					Me.tablehunt.InitVars()
				End If
			End If
			Me.tableneutral = CType(MyBase.Tables("neutral"), dbDataSet.neutralDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableneutral IsNot Nothing
				If flag2 Then
					Me.tableneutral.InitVars()
				End If
			End If
			Me.tablenpc = CType(MyBase.Tables("npc"), dbDataSet.npcDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablenpc IsNot Nothing
				If flag2 Then
					Me.tablenpc.InitVars()
				End If
			End If
			Me.tablealtcoord = CType(MyBase.Tables("altcoord"), dbDataSet.altcoordDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablealtcoord IsNot Nothing
				If flag2 Then
					Me.tablealtcoord.InitVars()
				End If
			End If
			Me.tableenemiescoord = CType(MyBase.Tables("enemiescoord"), dbDataSet.enemiescoordDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableenemiescoord IsNot Nothing
				If flag2 Then
					Me.tableenemiescoord.InitVars()
				End If
			End If
			Me.tablefriendscoord = CType(MyBase.Tables("friendscoord"), dbDataSet.friendscoordDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablefriendscoord IsNot Nothing
				If flag2 Then
					Me.tablefriendscoord.InitVars()
				End If
			End If
			Me.tablehero_alliance = CType(MyBase.Tables("hero_alliance"), dbDataSet.hero_allianceDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tablehero_alliance IsNot Nothing
				If flag2 Then
					Me.tablehero_alliance.InitVars()
				End If
			End If
			Me.tableneutralcoord = CType(MyBase.Tables("neutralcoord"), dbDataSet.neutralcoordDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableneutralcoord IsNot Nothing
				If flag2 Then
					Me.tableneutralcoord.InitVars()
				End If
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "dbDataSet"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dbDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tablealt = New dbDataSet.altDataTable()
			MyBase.Tables.Add(Me.tablealt)
			Me.tablecordin = New dbDataSet.cordinDataTable()
			MyBase.Tables.Add(Me.tablecordin)
			Me.tableenemies = New dbDataSet.enemiesDataTable()
			MyBase.Tables.Add(Me.tableenemies)
			Me.tablefield = New dbDataSet.fieldDataTable()
			MyBase.Tables.Add(Me.tablefield)
			Me.tableflats = New dbDataSet.flatsDataTable()
			MyBase.Tables.Add(Me.tableflats)
			Me.tablefriends = New dbDataSet.friendsDataTable()
			MyBase.Tables.Add(Me.tablefriends)
			Me.tablehero = New dbDataSet.heroDataTable()
			MyBase.Tables.Add(Me.tablehero)
			Me.tablehunt = New dbDataSet.huntDataTable()
			MyBase.Tables.Add(Me.tablehunt)
			Me.tableneutral = New dbDataSet.neutralDataTable()
			MyBase.Tables.Add(Me.tableneutral)
			Me.tablenpc = New dbDataSet.npcDataTable()
			MyBase.Tables.Add(Me.tablenpc)
			Me.tablealtcoord = New dbDataSet.altcoordDataTable()
			MyBase.Tables.Add(Me.tablealtcoord)
			Me.tableenemiescoord = New dbDataSet.enemiescoordDataTable()
			MyBase.Tables.Add(Me.tableenemiescoord)
			Me.tablefriendscoord = New dbDataSet.friendscoordDataTable()
			MyBase.Tables.Add(Me.tablefriendscoord)
			Me.tablehero_alliance = New dbDataSet.hero_allianceDataTable()
			MyBase.Tables.Add(Me.tablehero_alliance)
			Me.tableneutralcoord = New dbDataSet.neutralcoordDataTable()
			MyBase.Tables.Add(Me.tableneutralcoord)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializealt() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializecordin() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeenemies() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializefield() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeflats() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializefriends() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializehero() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializehunt() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeneutral() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializenpc() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializealtcoord() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeenemiescoord() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializefriendscoord() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializehero_alliance() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeneutralcoord() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim ds As dbDataSet = New dbDataSet()
			Dim type As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim sequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim any As XmlSchemaAny = New XmlSchemaAny()
			any.[Namespace] = ds.[Namespace]
			sequence.Items.Add(any)
			type.Particle = sequence
			Dim dsSchema As XmlSchema = ds.GetSchemaSerializable()
			Dim flag As Boolean = xs.Contains(dsSchema.TargetNamespace)
			Dim GetTypedDataSetSchema As XmlSchemaComplexType
			If flag Then
				Dim s As MemoryStream = New MemoryStream()
				Dim s2 As MemoryStream = New MemoryStream()
				Try
					dsSchema.Write(s)
					Dim schemas As IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
					While schemas.MoveNext()
						Dim schema As XmlSchema = CType(schemas.Current, XmlSchema)
						s2.SetLength(0L)
						schema.Write(s2)
						flag = (s.Length = s2.Length)
						If flag Then
							s.Position = 0L
							s2.Position = 0L
							While s.Position <> s.Length AndAlso s.ReadByte() = s2.ReadByte()
							End While
							flag = (s.Position = s.Length)
							If flag Then
								GetTypedDataSetSchema = type
								Return GetTypedDataSetSchema
							End If
						End If
					End While
				Finally
					flag = (s IsNot Nothing)
					If flag Then
						s.Close()
					End If
					flag = (s2 IsNot Nothing)
					If flag Then
						s2.Close()
					End If
				End Try
			End If
			xs.Add(dsSchema)
			GetTypedDataSetSchema = type
			Return GetTypedDataSetSchema
		End Function
	End Class
End Namespace
