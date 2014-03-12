Imports Microsoft.VisualBasic.ApplicationServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace vscan.My
	<GeneratedCode("MyTemplate", "10.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = MyApplication.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = MyApplication.__ENCList.Count = MyApplication.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = MyApplication.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = MyApplication.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								MyApplication.__ENCList(num) = MyApplication.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					MyApplication.__ENCList.RemoveRange(num, MyApplication.__ENCList.Count - num)
					MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count
				End If
				MyApplication.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<EditorBrowsable(EditorBrowsableState.Advanced), DebuggerHidden(), STAThread()>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Friend Shared Sub Main(Args As String())
			Try
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.[New](AuthenticationMode.Windows)
			MyApplication.__ENCAddToList(Me)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		<DebuggerStepThrough()>
		Protected Override Sub OnCreateMainForm()
			Me.MainForm = MyProject.Forms.Vscaner
		End Sub
	End Class
End Namespace
