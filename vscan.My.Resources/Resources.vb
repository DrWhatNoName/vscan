Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace vscan.My.Resources
	<HideModuleName(), GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode(), CompilerGenerated()>
	Friend Module Resources
		Private resourceMan As ResourceManager

		Private resourceCulture As CultureInfo

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager() As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim temp As ResourceManager = New ResourceManager("vscan.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = temp
				End If
				Return Resources.resourceMan
			End Get
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture() As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		Friend ReadOnly Property ebaybot() As Byte()
			Get
				Dim obj As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("ebaybot", Resources.resourceCulture))
				Return CType(obj, Byte())
			End Get
		End Property

		Friend ReadOnly Property map() As Bitmap
			Get
				Dim obj As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("map", Resources.resourceCulture))
				Return CType(obj, Bitmap)
			End Get
		End Property
	End Module
End Namespace
