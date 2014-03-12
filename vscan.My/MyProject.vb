Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace vscan.My
	<HideModuleName(), GeneratedCode("MyTemplate", "10.0.0.0")>
	Friend Module MyProject
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)>
		Friend Class MyForms
			Public m_map As map

			Public m_player As player

			Public m_SystemInfoForm As SystemInfoForm

			Public m_Vscaner As Vscaner

			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			Public Property map() As map
				<DebuggerNonUserCode()>
				Get
					Me.m_map = MyProject.MyForms.Create__Instance__(Of map)(Me.m_map)
					Return Me.m_map
				End Get
				<DebuggerNonUserCode()>
				Set(value As map)
					Dim flag As Boolean = value Is Me.m_map
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of map)(Me.m_map)
					End If
				End Set
			End Property

			Public Property player() As player
				<DebuggerNonUserCode()>
				Get
					Me.m_player = MyProject.MyForms.Create__Instance__(Of player)(Me.m_player)
					Return Me.m_player
				End Get
				<DebuggerNonUserCode()>
				Set(value As player)
					Dim flag As Boolean = value Is Me.m_player
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of player)(Me.m_player)
					End If
				End Set
			End Property

			Public Property SystemInfoForm() As SystemInfoForm
				<DebuggerNonUserCode()>
				Get
					Me.m_SystemInfoForm = MyProject.MyForms.Create__Instance__(Of SystemInfoForm)(Me.m_SystemInfoForm)
					Return Me.m_SystemInfoForm
				End Get
				<DebuggerNonUserCode()>
				Set(value As SystemInfoForm)
					Dim flag As Boolean = value Is Me.m_SystemInfoForm
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of SystemInfoForm)(Me.m_SystemInfoForm)
					End If
				End Set
			End Property

			Public Property Vscaner() As Vscaner
				<DebuggerNonUserCode()>
				Get
					Me.m_Vscaner = MyProject.MyForms.Create__Instance__(Of Vscaner)(Me.m_Vscaner)
					Return Me.m_Vscaner
				End Get
				<DebuggerNonUserCode()>
				Set(value As Vscaner)
					Dim flag As Boolean = value Is Me.m_Vscaner
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Vscaner)(Me.m_Vscaner)
					End If
				End Set
			End Property

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				Dim Create__Instance__ As T
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(0)))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Try
							Create__Instance__ = Activator.CreateInstance(Of T)()
							Return Create__Instance__
						End Try
						Dim arg_97_0 As Object
						Dim expr_9C As TargetInvocationException = TryCast(arg_97_0, TargetInvocationException)
						Dim arg_B9_0 As Integer
						If expr_9C Is Nothing Then
							arg_B9_0 = 0
						Else
							Dim ex As TargetInvocationException = expr_9C
							ProjectData.SetProjectError(expr_9C)
							arg_B9_0 = (If(((ex.InnerException IsNot Nothing) > False), 1, 0))
						End If
						endfilter(arg_B9_0)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Create__Instance__ = Instance
				Return Create__Instance__
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Sub New()
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Override Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Override Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Override Function ToString() As String
				Return MyBase.ToString()
			End Function
		End Class

		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)>
		Friend Class MyWebServices
			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Override Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Override Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Override Function ToString() As String
				Return MyBase.ToString()
			End Function

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim Create__Instance__ As T
				If flag Then
					Create__Instance__ = Activator.CreateInstance(Of T)()
				Else
					Create__Instance__ = instance
				End If
				Return Create__Instance__
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		<EditorBrowsable(EditorBrowsableState.Never), ComVisible(False)>
		Friend Class ThreadSafeObjectProvider
			<CompilerGenerated(), ThreadStatic()>
			Private Shared m_ThreadStaticValue As T

			Friend ReadOnly Property GetInstance() As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			<EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer() As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application() As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.User")>
		Friend ReadOnly Property User() As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms() As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices() As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property
	End Module
End Namespace
