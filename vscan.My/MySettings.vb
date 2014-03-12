Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace vscan.My
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated()>
	Friend Class MySettings
		Inherits ApplicationSettingsBase

		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		Private Shared addedHandler As Boolean

		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())

		Public Shared ReadOnly Property [Default]() As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					Dim flag2 As Boolean = False
					Try
						Monitor.Enter(obj, flag2)
						flag = Not MySettings.addedHandler
						If flag Then
							MyProject.Application.Shutdown += New ShutdownEventHandler(MySettings.AutoSaveSettings)
							MySettings.addedHandler = True
						End If
					Finally
						flag = flag2
						If flag Then
							Monitor.[Exit](obj)
						End If
					End Try
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		<ApplicationScopedSetting(), DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode()>
		Public ReadOnly Property dbConnectionString() As String
			Get
				Return Conversions.ToString(Me("dbConnectionString"))
			End Get
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		<EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode()>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub
	End Class
End Namespace
