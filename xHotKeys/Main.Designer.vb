﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tbMaster = New System.Windows.Forms.TrackBar
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.cbTuner = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TimerGetRemote = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMaster
        '
        Me.tbMaster.LargeChange = 20
        Me.tbMaster.Location = New System.Drawing.Point(433, 12)
        Me.tbMaster.Maximum = 100
        Me.tbMaster.Name = "tbMaster"
        Me.tbMaster.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbMaster.Size = New System.Drawing.Size(45, 225)
        Me.tbMaster.SmallChange = 5
        Me.tbMaster.TabIndex = 2
        Me.tbMaster.TickFrequency = 10
        Me.tbMaster.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.MainMenu
        Me.TrayIcon.Text = "NotifyIcon1"
        Me.TrayIcon.Visible = True
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptions, Me.mnuExit})
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(153, 70)
        '
        'mnuOptions
        '
        Me.mnuOptions.DoubleClickEnabled = True
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptions.Text = "Параметры"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Выход"
        '
        'cbTuner
        '
        Me.cbTuner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTuner.FormattingEnabled = True
        Me.cbTuner.Location = New System.Drawing.Point(12, 46)
        Me.cbTuner.Name = "cbTuner"
        Me.cbTuner.Size = New System.Drawing.Size(237, 21)
        Me.cbTuner.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'TimerGetRemote
        '
        Me.TimerGetRemote.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTuner)
        Me.Controls.Add(Me.tbMaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "xHotKeys"
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tbMaster As System.Windows.Forms.TrackBar
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents cbTuner As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerGetRemote As System.Windows.Forms.Timer
    Friend WithEvents MainMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem

End Class
