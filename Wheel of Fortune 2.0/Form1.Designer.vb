<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lstTest = New System.Windows.Forms.ListBox()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.V = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Z = New System.Windows.Forms.Button()
        Me.L = New System.Windows.Forms.Button()
        Me.K = New System.Windows.Forms.Button()
        Me.J = New System.Windows.Forms.Button()
        Me.H = New System.Windows.Forms.Button()
        Me.G = New System.Windows.Forms.Button()
        Me.F = New System.Windows.Forms.Button()
        Me.D = New System.Windows.Forms.Button()
        Me.S = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.Button()
        Me.P = New System.Windows.Forms.Button()
        Me.O = New System.Windows.Forms.Button()
        Me.I = New System.Windows.Forms.Button()
        Me.U = New System.Windows.Forms.Button()
        Me.Y = New System.Windows.Forms.Button()
        Me.T = New System.Windows.Forms.Button()
        Me.R = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.W = New System.Windows.Forms.Button()
        Me.Q = New System.Windows.Forms.Button()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(566, 29)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(121, 64)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'picWheel
        '
        Me.picWheel.Image = Global.Wheel_of_Fortune_2._0.My.Resources.Resources.start_of_spin
        Me.picWheel.Location = New System.Drawing.Point(705, 25)
        Me.picWheel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(452, 406)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 1
        Me.picWheel.TabStop = False
        '
        'timer
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1157, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lstTest
        '
        Me.lstTest.FormattingEnabled = True
        Me.lstTest.Location = New System.Drawing.Point(0, 25)
        Me.lstTest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstTest.Name = "lstTest"
        Me.lstTest.Size = New System.Drawing.Size(34, 17)
        Me.lstTest.TabIndex = 4
        Me.lstTest.Visible = False
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(-2, 44)
        Me.lblPhrase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(39, 13)
        Me.lblPhrase.TabIndex = 5
        Me.lblPhrase.Text = "Label1"
        Me.lblPhrase.Visible = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(170, 34)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(278, 30)
        Me.lblResult.TabIndex = 6
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(390, 122)
        Me.M.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(28, 19)
        Me.M.TabIndex = 54
        Me.M.Text = "M"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(358, 122)
        Me.N.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(28, 19)
        Me.N.TabIndex = 53
        Me.N.Text = "N"
        Me.N.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(324, 122)
        Me.B.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(28, 19)
        Me.B.TabIndex = 52
        Me.B.Text = "B"
        Me.B.UseVisualStyleBackColor = True
        '
        'V
        '
        Me.V.Location = New System.Drawing.Point(290, 122)
        Me.V.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(28, 19)
        Me.V.TabIndex = 51
        Me.V.Text = "V"
        Me.V.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(256, 122)
        Me.C.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(28, 19)
        Me.C.TabIndex = 50
        Me.C.Text = "C"
        Me.C.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(223, 122)
        Me.X.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(28, 19)
        Me.X.TabIndex = 49
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Z
        '
        Me.Z.Location = New System.Drawing.Point(192, 122)
        Me.Z.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Z.Name = "Z"
        Me.Z.Size = New System.Drawing.Size(28, 19)
        Me.Z.TabIndex = 48
        Me.Z.Text = "Z"
        Me.Z.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Location = New System.Drawing.Point(420, 98)
        Me.L.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(28, 19)
        Me.L.TabIndex = 47
        Me.L.Text = "L"
        Me.L.UseVisualStyleBackColor = True
        '
        'K
        '
        Me.K.Location = New System.Drawing.Point(390, 98)
        Me.K.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(28, 19)
        Me.K.TabIndex = 46
        Me.K.Text = "K"
        Me.K.UseVisualStyleBackColor = True
        '
        'J
        '
        Me.J.Location = New System.Drawing.Point(358, 98)
        Me.J.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.J.Name = "J"
        Me.J.Size = New System.Drawing.Size(28, 19)
        Me.J.TabIndex = 45
        Me.J.Text = "J"
        Me.J.UseVisualStyleBackColor = True
        '
        'H
        '
        Me.H.Location = New System.Drawing.Point(324, 98)
        Me.H.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.H.Name = "H"
        Me.H.Size = New System.Drawing.Size(28, 19)
        Me.H.TabIndex = 44
        Me.H.Text = "H"
        Me.H.UseVisualStyleBackColor = True
        '
        'G
        '
        Me.G.Location = New System.Drawing.Point(290, 98)
        Me.G.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(28, 19)
        Me.G.TabIndex = 43
        Me.G.Text = "G"
        Me.G.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(256, 98)
        Me.F.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(28, 19)
        Me.F.TabIndex = 42
        Me.F.Text = "F"
        Me.F.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.Location = New System.Drawing.Point(223, 98)
        Me.D.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(28, 19)
        Me.D.TabIndex = 41
        Me.D.Text = "D"
        Me.D.UseVisualStyleBackColor = True
        '
        'S
        '
        Me.S.Location = New System.Drawing.Point(192, 98)
        Me.S.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(28, 19)
        Me.S.TabIndex = 40
        Me.S.Text = "S"
        Me.S.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(160, 98)
        Me.A.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(28, 19)
        Me.A.TabIndex = 39
        Me.A.Text = "A"
        Me.A.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.Location = New System.Drawing.Point(441, 74)
        Me.P.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(28, 19)
        Me.P.TabIndex = 38
        Me.P.Text = "P"
        Me.P.UseVisualStyleBackColor = True
        '
        'O
        '
        Me.O.Location = New System.Drawing.Point(408, 75)
        Me.O.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(28, 19)
        Me.O.TabIndex = 37
        Me.O.Text = "O"
        Me.O.UseVisualStyleBackColor = True
        '
        'I
        '
        Me.I.Location = New System.Drawing.Point(378, 75)
        Me.I.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.I.Name = "I"
        Me.I.Size = New System.Drawing.Size(28, 19)
        Me.I.TabIndex = 36
        Me.I.Text = "I"
        Me.I.UseVisualStyleBackColor = True
        '
        'U
        '
        Me.U.Location = New System.Drawing.Point(346, 75)
        Me.U.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(28, 19)
        Me.U.TabIndex = 35
        Me.U.Text = "U"
        Me.U.UseVisualStyleBackColor = True
        '
        'Y
        '
        Me.Y.Location = New System.Drawing.Point(312, 75)
        Me.Y.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(28, 19)
        Me.Y.TabIndex = 34
        Me.Y.Text = "Y"
        Me.Y.UseVisualStyleBackColor = True
        '
        'T
        '
        Me.T.Location = New System.Drawing.Point(278, 75)
        Me.T.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(28, 19)
        Me.T.TabIndex = 33
        Me.T.Text = "T"
        Me.T.UseVisualStyleBackColor = True
        '
        'R
        '
        Me.R.Location = New System.Drawing.Point(244, 75)
        Me.R.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(28, 19)
        Me.R.TabIndex = 32
        Me.R.Text = "R"
        Me.R.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(211, 75)
        Me.btnE.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(28, 19)
        Me.btnE.TabIndex = 31
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'W
        '
        Me.W.Location = New System.Drawing.Point(180, 75)
        Me.W.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.W.Name = "W"
        Me.W.Size = New System.Drawing.Size(28, 19)
        Me.W.TabIndex = 30
        Me.W.Text = "W"
        Me.W.UseVisualStyleBackColor = True
        '
        'Q
        '
        Me.Q.Location = New System.Drawing.Point(146, 74)
        Me.Q.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(28, 19)
        Me.Q.TabIndex = 29
        Me.Q.Text = "Q"
        Me.Q.UseVisualStyleBackColor = True
        '
        'lblPlayer2
        '
        Me.lblPlayer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPlayer2.Location = New System.Drawing.Point(334, 201)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(83, 33)
        Me.lblPlayer2.TabIndex = 58
        Me.lblPlayer2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(191, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 33)
        Me.Label3.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Player 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Player 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1157, 516)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.V)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Z)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.K)
        Me.Controls.Add(Me.J)
        Me.Controls.Add(Me.H)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.O)
        Me.Controls.Add(Me.I)
        Me.Controls.Add(Me.U)
        Me.Controls.Add(Me.Y)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.W)
        Me.Controls.Add(Me.Q)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lstTest)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Wheel of Fortune"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents timer As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lstTest As ListBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents B As Button
    Friend WithEvents V As Button
    Friend WithEvents C As Button
    Friend WithEvents X As Button
    Friend WithEvents Z As Button
    Friend WithEvents L As Button
    Friend WithEvents K As Button
    Friend WithEvents J As Button
    Friend WithEvents H As Button
    Friend WithEvents G As Button
    Friend WithEvents F As Button
    Friend WithEvents D As Button
    Friend WithEvents S As Button
    Friend WithEvents A As Button
    Friend WithEvents P As Button
    Friend WithEvents O As Button
    Friend WithEvents I As Button
    Friend WithEvents U As Button
    Friend WithEvents Y As Button
    Friend WithEvents T As Button
    Friend WithEvents R As Button
    Friend WithEvents btnE As Button
    Friend WithEvents W As Button
    Friend WithEvents Q As Button
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
