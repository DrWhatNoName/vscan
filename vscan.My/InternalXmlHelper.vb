Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Linq

Namespace vscan.My
	<EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode(), CompilerGenerated()>
	Friend Class InternalXmlHelper
		<EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode(), CompilerGenerated()>
		Private Class RemoveNamespaceAttributesClosure
			Private m_inScopePrefixes As String()

			Private m_inScopeNs As XNamespace()

			Private m_attributes As List(Of XAttribute)

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Sub New(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute))
				Me.m_inScopePrefixes = inScopePrefixes
				Me.m_inScopeNs = inScopeNs
				Me.m_attributes = attributes
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessXElement(elem As XElement) As XElement
				Return InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, elem)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessObject(obj As Object) As Object
				Dim elem As XElement = TryCast(obj, XElement)
				Dim flag As Boolean = elem IsNot Nothing
				Dim ProcessObject As Object
				If flag Then
					ProcessObject = InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, elem)
				Else
					ProcessObject = obj
				End If
				Return ProcessObject
			End Function
		End Class

		Public Shared Property Value() As String
			Get
				Dim Value As String
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim item As XElement = enumerator.Current
						Value = item.Value
						Return Value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				Value = Nothing
				Return Value
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim item As XElement = enumerator.Current
						item.Value = value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		Public Shared Property AttributeValue() As String
			Get
				Dim AttributeValue As String
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim item As XElement = enumerator.Current
						AttributeValue = CStr(item.Attribute(name))
						Return AttributeValue
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				AttributeValue = Nothing
				Return AttributeValue
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim item As XElement = enumerator.Current
						item.SetAttributeValue(name, value)
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		Public Shared Property AttributeValue() As String
			Get
				Return CStr(source.Attribute(name))
			End Get
			Set(value As String)
				source.SetAttributeValue(name, value)
			End Set
		End Property

		<EditorBrowsable(EditorBrowsableState.Never)>
		Private Sub New()
		End Sub

		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateAttribute(name As XName, value As Object) As XAttribute
			Dim flag As Boolean = value Is Nothing
			Dim CreateAttribute As XAttribute
			If flag Then
				CreateAttribute = Nothing
			Else
				CreateAttribute = New XAttribute(name, RuntimeHelpers.GetObjectValue(value))
			End If
			Return CreateAttribute
		End Function

		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateNamespaceAttribute(name As XName, ns As XNamespace) As XAttribute
			Dim a As XAttribute = New XAttribute(name, ns.NamespaceName)
			a.AddAnnotation(ns)
			Return a
		End Function

		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As Object) As Object
			Dim flag As Boolean = obj IsNot Nothing
			Dim RemoveNamespaceAttributes As Object
			If flag Then
				Dim elem As XElement = TryCast(obj, XElement)
				flag = (elem IsNot Nothing)
				If flag Then
					RemoveNamespaceAttributes = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elem)
					Return RemoveNamespaceAttributes
				End If
				Dim elems As IEnumerable = TryCast(obj, IEnumerable)
				flag = (elems IsNot Nothing)
				If flag Then
					RemoveNamespaceAttributes = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elems)
					Return RemoveNamespaceAttributes
				End If
			End If
			RemoveNamespaceAttributes = obj
			Return RemoveNamespaceAttributes
		End Function

		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As IEnumerable) As IEnumerable
			Dim flag As Boolean = obj IsNot Nothing
			Dim RemoveNamespaceAttributes As IEnumerable
			If flag Then
				Dim elems As IEnumerable(Of XElement) = TryCast(obj, IEnumerable(Of XElement))
				flag = (elems IsNot Nothing)
				If flag Then
					RemoveNamespaceAttributes = elems.[Select](New Func(Of XElement, XElement)(New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement))
				Else
					RemoveNamespaceAttributes = obj.Cast(Of Object)().[Select](New Func(Of Object, Object)(New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject))
				End If
			Else
				RemoveNamespaceAttributes = obj
			End If
			Return RemoveNamespaceAttributes
		End Function

		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), e As XElement) As XElement
			Dim flag As Boolean = e IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim nextA As XAttribute
				Dim a As XAttribute = e.FirstAttribute
				While a IsNot Nothing
					nextA = a.NextAttribute
					flag = a.IsNamespaceDeclaration
					If flag Then
						Dim ns As XNamespace = a.Annotation(Of XNamespace)()
						Dim prefix As String = a.Name.LocalName
						flag = (ns IsNot Nothing)
						If flag Then
							Dim flag2 As Boolean = inScopePrefixes IsNot Nothing AndAlso inScopeNs IsNot Nothing
							If flag2 Then
								Dim lastIndex As Integer = inScopePrefixes.Length - 1
								Dim arg_74_0 As Integer = 0
								Dim num As Integer = lastIndex
								Dim i As Integer = arg_74_0
								Dim currentInScopeNs As XNamespace
								While True
									Dim arg_BE_0 As Integer = i
									Dim num2 As Integer = num
									If arg_BE_0 > num2 Then
										GoTo IL_C0
									End If
									Dim currentInScopePrefix As String = inScopePrefixes(i)
									currentInScopeNs = inScopeNs(i)
									flag2 = prefix.Equals(currentInScopePrefix)
									If flag2 Then
										Exit While
									End If
									i += 1
								End While
								flag = (ns Is currentInScopeNs)
								If flag Then
									a.Remove()
								End If
								a = Nothing
							End If
							IL_C0:
							flag2 = (a IsNot Nothing)
							If flag2 Then
								flag = (attributes IsNot Nothing)
								Dim flag3 As Boolean
								If flag Then
									Dim lastIndex2 As Integer = attributes.Count - 1
									Dim arg_ED_0 As Integer = 0
									Dim num3 As Integer = lastIndex2
									Dim j As Integer = arg_ED_0
									Dim currentInScopeNs2 As XNamespace
									While True
										Dim arg_15B_0 As Integer = j
										Dim num2 As Integer = num3
										If arg_15B_0 > num2 Then
											GoTo IL_15D
										End If
										Dim currentA As XAttribute = attributes(j)
										Dim currentInScopePrefix2 As String = currentA.Name.LocalName
										currentInScopeNs2 = currentA.Annotation(Of XNamespace)()
										flag2 = (currentInScopeNs2 IsNot Nothing)
										If flag2 Then
											flag = prefix.Equals(currentInScopePrefix2)
											If flag Then
												Exit While
											End If
										End If
										j += 1
									End While
									flag3 = (ns Is currentInScopeNs2)
									If flag3 Then
										a.Remove()
									End If
									a = Nothing
								End If
								IL_15D:
								flag3 = (a IsNot Nothing)
								If flag3 Then
									a.Remove()
									attributes.Add(a)
								End If
							End If
						End If
					End If
					a = nextA
				End While
			End If
			Return e
		End Function
	End Class
End Namespace
