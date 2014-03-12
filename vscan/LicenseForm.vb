Imports Manco.Licensing
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace vscan
	<DesignerGenerated()>
	Public Class LicenseForm
		Inherits Form

		<CompilerGenerated()>
		Friend Class _Closure$__2
			<CompilerGenerated()>
			Friend Class _Closure$__3
				Public $VB$Local_activationTask As Task(Of String)

				Public $VB$NonLocal__Closure$__2 As LicenseForm._Closure$__2

				<DebuggerNonUserCode()>
				Public Sub New()
				End Sub

				<DebuggerNonUserCode()>
				Public Sub New(other As LicenseForm._Closure$__2._Closure$__3)
					Dim flag As Boolean = other IsNot Nothing
					If flag Then
						Me.$VB$NonLocal__Closure$__2 = other.$VB$NonLocal__Closure$__2
						Me.$VB$Local_activationTask = other.$VB$Local_activationTask
					End If
				End Sub

				<CompilerGenerated()>
				Public Sub _Lambda$__5()
					Me.$VB$NonLocal__Closure$__2.$VB$Me.EnableButtons(True)
					Me.$VB$NonLocal__Closure$__2.$VB$Me.Cursor = Me.$VB$NonLocal__Closure$__2.$VB$Me.cur
					Dim flag As Boolean = Me.$VB$Local_activationTask.IsCompleted
					If flag Then
						Dim activationKey As String = Me.$VB$Local_activationTask.Result
						flag = Not String.IsNullOrEmpty(activationKey)
						If flag Then
							Me.$VB$NonLocal__Closure$__2.$VB$Me.m_isAwsCalled = True
							Me.$VB$NonLocal__Closure$__2.$VB$Me.txtActivationKey.Text = activationKey
							MessageBox.Show("Activation Key has been succesfully generated and passed to the text box. Click OK to continue.")
						End If
					Else
						flag = (Me.$VB$Local_activationTask.Exception IsNot Nothing)
						If flag Then
							MessageBox.Show("nepavyko")
							Vscaner.ProcessException(Me.$VB$Local_activationTask.Exception)
						End If
					End If
				End Sub
			End Class

			Public $VB$Me As LicenseForm

			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			<DebuggerNonUserCode()>
			Public Sub New(other As LicenseForm._Closure$__2)
				Dim flag As Boolean = other IsNot Nothing
				If flag Then
					Me.$VB$Me = other.$VB$Me
				End If
			End Sub

			<CompilerGenerated()>
			Public Sub _Lambda$__4(activationTask As Task(Of String))
				Me.$VB$Me.BeginInvoke(Sub()
					Me.$VB$Me.EnableButtons(True)
					Me.$VB$Me.Cursor = Me.$VB$Me.cur
					Dim flag As Boolean = activationTask.IsCompleted
					If flag Then
						Dim activationKey As String = activationTask.Result
						flag = Not String.IsNullOrEmpty(activationKey)
						If flag Then
							Me.$VB$Me.m_isAwsCalled = True
							Me.$VB$Me.txtActivationKey.Text = activationKey
							MessageBox.Show("Activation Key has been succesfully generated and passed to the text box. Click OK to continue.")
						End If
					Else
						flag = (activationTask.Exception IsNot Nothing)
						If flag Then
							MessageBox.Show("nepavyko")
							Vscaner.ProcessException(activationTask.Exception)
						End If
					End If
				End Sub)
			End Sub
		End Class

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private components As IContainer

		<AccessedThroughProperty("cmdSysInfo")>
		Private _cmdSysInfo As Button

		<AccessedThroughProperty("label3")>
		Private _label3 As Label

		<AccessedThroughProperty("label2")>
		Private _label2 As Label

		<AccessedThroughProperty("lblExpiration")>
		Private _lblExpiration As Label

		<AccessedThroughProperty("cmdActivate")>
		Private _cmdActivate As Button

		<AccessedThroughProperty("txtActivationKey")>
		Private _txtActivationKey As TextBox

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("txtUnlockKey")>
		Private _txtUnlockKey As TextBox

		<AccessedThroughProperty("label1")>
		Private _label1 As Label

		Private license As Manco.Licensing.License

		Private m_isAwsCalled As Boolean

		Private cur As Cursor

		Private Overridable Property cmdSysInfo() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._cmdSysInfo
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.cmdSysInfo_Click)
				Dim flag As Boolean = Me._cmdSysInfo IsNot Nothing
				If flag Then
					Me._cmdSysInfo.Click -= value2
				End If
				Me._cmdSysInfo = value
				flag = (Me._cmdSysInfo IsNot Nothing)
				If flag Then
					Me._cmdSysInfo.Click += value2
				End If
			End Set
		End Property

		Private Overridable Property label3() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._label3 = value
			End Set
		End Property

		Private Overridable Property label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._label2 = value
			End Set
		End Property

		Private Overridable Property lblExpiration() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._lblExpiration
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblExpiration = value
			End Set
		End Property

		Private Overridable Property cmdActivate() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._cmdActivate
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = New EventHandler(Me.cmdActivateAndFill_Click)
				Dim flag As Boolean = Me._cmdActivate IsNot Nothing
				If flag Then
					Me._cmdActivate.Click -= value2
				End If
				Me._cmdActivate = value
				flag = (Me._cmdActivate IsNot Nothing)
				If flag Then
					Me._cmdActivate.Click += value2
				End If
			End Set
		End Property

		Private Overridable Property txtActivationKey() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtActivationKey
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActivationKey = value
			End Set
		End Property

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

		Private Overridable Property txtUnlockKey() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtUnlockKey
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtUnlockKey = value
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

		Public ReadOnly Property IsAwsCalled() As Boolean
			Get
				Return Me.m_isAwsCalled
			End Get
		End Property

		Public ReadOnly Property UnlockKey() As String
			Get
				Return Me.txtUnlockKey.Text.Replace("\n", "").Replace("\r", "").Replace(" ", "")
			End Get
		End Property

		Public ReadOnly Property ActivationKey() As String
			Get
				Return Me.txtActivationKey.Text.Replace("\n", "").Replace("\r", "").Replace(" ", "")
			End Get
		End Property

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = LicenseForm.__ENCList
			Dim flag As Boolean = False
			' The following expression was wrapped in a checked-statement
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = LicenseForm.__ENCList.Count = LicenseForm.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim arg_44_0 As Integer = 0
					Dim num2 As Integer = LicenseForm.__ENCList.Count - 1
					Dim num3 As Integer = arg_44_0
					While True
						Dim arg_95_0 As Integer = num3
						Dim num4 As Integer = num2
						If arg_95_0 > num4 Then
							Exit While
						End If
						Dim weakReference As WeakReference = LicenseForm.__ENCList(num3)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num3 <> num
							If flag3 Then
								LicenseForm.__ENCList(num) = LicenseForm.__ENCList(num3)
							End If
							num += 1
						End If
						num3 += 1
					End While
					LicenseForm.__ENCList.RemoveRange(num, LicenseForm.__ENCList.Count - num)
					LicenseForm.__ENCList.Capacity = LicenseForm.__ENCList.Count
				End If
				LicenseForm.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(LicenseForm))
			Me.cmdSysInfo = New Button()
			Me.label3 = New Label()
			Me.label2 = New Label()
			Me.lblExpiration = New Label()
			Me.cmdActivate = New Button()
			Me.txtActivationKey = New TextBox()
			Me.cmdOK = New Button()
			Me.txtUnlockKey = New TextBox()
			Me.label1 = New Label()
			Me.SuspendLayout()
			Dim arg_9D_0 As Control = Me.cmdSysInfo
			Dim location As Point = New Point(565, 161)
			arg_9D_0.Location = location
			Me.cmdSysInfo.Name = "cmdSysInfo"
			Dim arg_C8_0 As Control = Me.cmdSysInfo
			Dim size As Size = New Size(80, 23)
			arg_C8_0.Size = size
			Me.cmdSysInfo.TabIndex = 35
			Me.cmdSysInfo.Text = "Sys Info"
			Me.cmdSysInfo.UseVisualStyleBackColor = True
			Me.label3.AutoSize = True
			Dim arg_11D_0 As Control = Me.label3
			location = New Point(12, 161)
			arg_11D_0.Location = location
			Me.label3.Name = "label3"
			Dim arg_148_0 As Control = Me.label3
			size = New Size(78, 13)
			arg_148_0.Size = size
			Me.label3.TabIndex = 34
			Me.label3.Text = "Activation Key:"
			Me.label2.AutoSize = True
			Dim arg_18D_0 As Control = Me.label2
			location = New Point(12, 104)
			arg_18D_0.Location = location
			Me.label2.Name = "label2"
			Dim arg_1B8_0 As Control = Me.label2
			size = New Size(65, 13)
			arg_1B8_0.Size = size
			Me.label2.TabIndex = 33
			Me.label2.Text = "Unlock Key:"
			Me.lblExpiration.AutoSize = True
			Dim arg_1FD_0 As Control = Me.lblExpiration
			location = New Point(12, 69)
			arg_1FD_0.Location = location
			Me.lblExpiration.Name = "lblExpiration"
			Dim arg_22B_0 As Control = Me.lblExpiration
			size = New Size(213, 13)
			arg_22B_0.Size = size
			Me.lblExpiration.TabIndex = 32
			Me.lblExpiration.Text = "Your evaluation license will expire in 0 days."
			Dim arg_266_0 As Control = Me.cmdActivate
			location = New Point(565, 104)
			arg_266_0.Location = location
			Me.cmdActivate.Name = "cmdActivate"
			Dim arg_291_0 As Control = Me.cmdActivate
			size = New Size(80, 23)
			arg_291_0.Size = size
			Me.cmdActivate.TabIndex = 31
			Me.cmdActivate.Text = "Activate"
			Dim arg_2CC_0 As Control = Me.txtActivationKey
			location = New Point(93, 158)
			arg_2CC_0.Location = location
			Me.txtActivationKey.Multiline = True
			Me.txtActivationKey.Name = "txtActivationKey"
			Me.txtActivationKey.ScrollBars = ScrollBars.Vertical
			Dim arg_314_0 As Control = Me.txtActivationKey
			size = New Size(466, 80)
			arg_314_0.Size = size
			Me.txtActivationKey.TabIndex = 30
			Me.cmdOK.DialogResult = DialogResult.OK
			Dim arg_34E_0 As Control = Me.cmdOK
			location = New Point(295, 249)
			arg_34E_0.Location = location
			Me.cmdOK.Name = "cmdOK"
			Dim arg_379_0 As Control = Me.cmdOK
			size = New Size(75, 23)
			arg_379_0.Size = size
			Me.cmdOK.TabIndex = 29
			Me.cmdOK.Text = "OK"
			Dim arg_3B1_0 As Control = Me.txtUnlockKey
			location = New Point(93, 101)
			arg_3B1_0.Location = location
			Me.txtUnlockKey.Multiline = True
			Me.txtUnlockKey.Name = "txtUnlockKey"
			Dim arg_3EC_0 As Control = Me.txtUnlockKey
			size = New Size(466, 51)
			arg_3EC_0.Size = size
			Me.txtUnlockKey.TabIndex = 28
			Dim arg_413_0 As Control = Me.label1
			location = New Point(12, 15)
			arg_413_0.Location = location
			Me.label1.Name = "label1"
			Dim arg_441_0 As Control = Me.label1
			size = New Size(644, 50)
			arg_441_0.Size = size
			Me.label1.TabIndex = 27
			Me.label1.Text = resources.GetString("label1.Text")
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(668, 290)
			Me.ClientSize = size
			Me.Controls.Add(Me.cmdSysInfo)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.lblExpiration)
			Me.Controls.Add(Me.cmdActivate)
			Me.Controls.Add(Me.txtActivationKey)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.txtUnlockKey)
			Me.Controls.Add(Me.label1)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
			Me.Name = "LicenseForm"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "LicenseForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Public Sub New(aoLicense As Manco.Licensing.License)
			MyBase.Load += New EventHandler(Me.LicenseForm_Load)
			LicenseForm.__ENCAddToList(Me)
			Me.m_isAwsCalled = False
			Me.InitializeComponent()
			Me.license = aoLicense
			Dim licenseProperties As ILicenseProperties = Me.license.GetLicenseProperties()
			Me.lblExpiration.Text = String.Format("Your evaluation license will expire in {0:F2} days.", licenseProperties.EvaluationTimeLeft.TotalDays)
			Me.lblExpiration.Text = String.Format("Your evaluation license will expire in {0} days {1} hours {2} minutes {3} secs.", New Object()() = { licenseProperties.EvaluationTimeLeft.Days, licenseProperties.EvaluationTimeLeft.Hours, licenseProperties.EvaluationTimeLeft.Minutes, licenseProperties.EvaluationTimeLeft.Seconds })
			Me.lblExpiration.Text = String.Format("Your evaluation license will expire at {0:f}", licenseProperties.ExpiryDate)
		End Sub

		Private Sub cmdSysInfo_Click(sender As Object, e As EventArgs)
			New SystemInfoForm() With { .License = Me.license }.ShowDialog()
		End Sub

		Private Sub cmdActivateAndFill_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.UnlockKey.Trim(), String.Empty, False) <> 0
			If flag Then
				Me.license.UnlockKey = Me.UnlockKey.Trim()
				Dim helper As AwsHelper = New AwsHelper(Me.license, Vscaner.AwsUri)
				Try
					Me.EnableButtons(False)
					Me.cur = Me.Cursor
					Me.Cursor = Cursors.WaitCursor
					helper.ActivateProductGetKeyAsync(False).ContinueWith(Sub(activationTask As Task(Of String))
						Me.BeginInvoke(Sub()
							Me.EnableButtons(True)
							Me.Cursor = Me.cur
							Dim flag2 As Boolean = activationTask.IsCompleted
							If flag2 Then
								Dim activationKey As String = activationTask.Result
								flag2 = Not String.IsNullOrEmpty(activationKey)
								If flag2 Then
									Me.m_isAwsCalled = True
									Me.txtActivationKey.Text = activationKey
									MessageBox.Show("Activation Key has been succesfully generated and passed to the text box. Click OK to continue.")
								End If
							Else
								flag2 = (activationTask.Exception IsNot Nothing)
								If flag2 Then
									MessageBox.Show("nepavyko")
									Vscaner.ProcessException(activationTask.Exception)
								End If
							End If
						End Sub)
					End Sub)
				Catch expr_96 As Exception
					ProjectData.SetProjectError(expr_96)
					Dim exc As Exception = expr_96
					Me.EnableButtons(True)
					Me.Cursor = Me.cur
					Vscaner.ProcessException(exc)
					ProjectData.ClearProjectError()
				End Try
			Else
				MessageBox.Show("Enter Unlock Key to be able activate product")
			End If
		End Sub

		Private Sub EnableButtons(enabled As Boolean)
			Me.cmdActivate.Enabled = enabled
			Me.cmdSysInfo.Enabled = enabled
			Me.cmdOK.Enabled = enabled
		End Sub

		Private Sub LicenseForm_Load(sender As Object, e As EventArgs)
		End Sub
	End Class
End Namespace
