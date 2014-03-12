Imports Manco.Licensing
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace vscan
	<DesignerGenerated()>
	Public Class SystemInfoForm
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private components As IContainer

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("txtSystemInfo")>
		Private _txtSystemInfo As TextBox

		<AccessedThroughProperty("label1")>
		Private _label1 As Label

		Private Overridable Property cmdOK() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._cmdOK
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdOK = value
			End Set
		End Property

		Private Overridable Property txtSystemInfo() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtSystemInfo
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSystemInfo = value
			End Set
		End Property

		Private Overridable Property label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._label1 = value
			End Set
		End Property

		Public WriteOnly Property License() As Manco.Licensing.License
			Set(value As Manco.Licensing.License)
				Me.txtSystemInfo.Text = value.SystemInfo
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			MyBase.Load += New EventHandler(Me.SystemInfoForm_Load)
			SystemInfoForm.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = SystemInfoForm.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = SystemInfoForm.__ENCList.Count = SystemInfoForm.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = SystemInfoForm.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = SystemInfoForm.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								SystemInfoForm.__ENCList(num) = SystemInfoForm.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					SystemInfoForm.__ENCList.RemoveRange(num, SystemInfoForm.__ENCList.Count - num)
					SystemInfoForm.__ENCList.Capacity = SystemInfoForm.__ENCList.Count
				End If
				SystemInfoForm.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(SystemInfoForm))
			Me.cmdOK = New Button()
			Me.txtSystemInfo = New TextBox()
			Me.label1 = New Label()
			Me.SuspendLayout()
			Me.cmdOK.DialogResult = DialogResult.OK
			Dim arg_5F_0 As Control = Me.cmdOK
			Dim location As Point = New Point(223, 123)
			arg_5F_0.Location = location
			Me.cmdOK.Name = "cmdOK"
			Dim arg_8A_0 As Control = Me.cmdOK
			Dim size As Size = New Size(75, 23)
			arg_8A_0.Size = size
			Me.cmdOK.TabIndex = 25
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = True
			Me.txtSystemInfo.BackColor = Color.White
			Dim arg_DF_0 As Control = Me.txtSystemInfo
			location = New Point(3, 47)
			arg_DF_0.Location = location
			Me.txtSystemInfo.Multiline = True
			Me.txtSystemInfo.Name = "txtSystemInfo"
			Me.txtSystemInfo.[ReadOnly] = True
			Dim arg_127_0 As Control = Me.txtSystemInfo
			size = New Size(508, 70)
			arg_127_0.Size = size
			Me.txtSystemInfo.TabIndex = 24
			Me.label1.Dock = DockStyle.Top
			Dim arg_159_0 As Control = Me.label1
			location = New Point(0, 0)
			arg_159_0.Location = location
			Me.label1.Name = "label1"
			Dim arg_187_0 As Control = Me.label1
			size = New Size(516, 44)
			arg_187_0.Size = size
			Me.label1.TabIndex = 23
			Me.label1.Text = resources.GetString("label1.Text")
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(516, 150)
			Me.ClientSize = size
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.txtSystemInfo)
			Me.Controls.Add(Me.label1)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
			Me.Name = "SystemInfoForm"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "SystemInfoForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub SystemInfoForm_Load(sender As Object, e As EventArgs)
		End Sub
	End Class
End Namespace
