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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(755, 36)
        Me.btnSpin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(161, 79)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wheel_of_Fortune_2._0.My.Resources.Resources.start_of_spin
        Me.PictureBox1.Location = New System.Drawing.Point(940, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(603, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1543, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
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
        Me.lstTest.ItemHeight = 16
        Me.lstTest.Location = New System.Drawing.Point(0, 31)
        Me.lstTest.Name = "lstTest"
        Me.lstTest.Size = New System.Drawing.Size(44, 20)
        Me.lstTest.TabIndex = 4
        Me.lstTest.Visible = False
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(-3, 54)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(48, 16)
        Me.lblPhrase.TabIndex = 5
        Me.lblPhrase.Text = "Label1"
        Me.lblPhrase.Visible = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(226, 42)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(371, 37)
        Me.lblResult.TabIndex = 6
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(520, 150)
        Me.M.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(37, 23)
        Me.M.TabIndex = 54
        Me.M.Text = "M"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(477, 150)
        Me.N.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(37, 23)
        Me.N.TabIndex = 53
        Me.N.Text = "N"
        Me.N.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(432, 150)
        Me.B.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(37, 23)
        Me.B.TabIndex = 52
        Me.B.Text = "B"
        Me.B.UseVisualStyleBackColor = True
        '
        'V
        '
        Me.V.Location = New System.Drawing.Point(386, 150)
        Me.V.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(37, 23)
        Me.V.TabIndex = 51
        Me.V.Text = "V"
        Me.V.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(342, 150)
        Me.C.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(37, 23)
        Me.C.TabIndex = 50
        Me.C.Text = "C"
        Me.C.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(297, 150)
        Me.X.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(37, 23)
        Me.X.TabIndex = 49
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Z
        '
        Me.Z.Location = New System.Drawing.Point(256, 150)
        Me.Z.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Z.Name = "Z"
        Me.Z.Size = New System.Drawing.Size(37, 23)
        Me.Z.TabIndex = 48
        Me.Z.Text = "Z"
        Me.Z.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Location = New System.Drawing.Point(560, 121)
        Me.L.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(37, 23)
        Me.L.TabIndex = 47
        Me.L.Text = "L"
        Me.L.UseVisualStyleBackColor = True
        '
        'K
        '
        Me.K.Location = New System.Drawing.Point(520, 121)
        Me.K.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(37, 23)
        Me.K.TabIndex = 46
        Me.K.Text = "K"
        Me.K.UseVisualStyleBackColor = True
        '
        'J
        '
        Me.J.Location = New System.Drawing.Point(477, 121)
        Me.J.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.J.Name = "J"
        Me.J.Size = New System.Drawing.Size(37, 23)
        Me.J.TabIndex = 45
        Me.J.Text = "J"
        Me.J.UseVisualStyleBackColor = True
        '
        'H
        '
        Me.H.Location = New System.Drawing.Point(432, 121)
        Me.H.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.H.Name = "H"
        Me.H.Size = New System.Drawing.Size(37, 23)
        Me.H.TabIndex = 44
        Me.H.Text = "H"
        Me.H.UseVisualStyleBackColor = True
        '
        'G
        '
        Me.G.Location = New System.Drawing.Point(386, 121)
        Me.G.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(37, 23)
        Me.G.TabIndex = 43
        Me.G.Text = "G"
        Me.G.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(342, 121)
        Me.F.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(37, 23)
        Me.F.TabIndex = 42
        Me.F.Text = "F"
        Me.F.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.Location = New System.Drawing.Point(297, 121)
        Me.D.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(37, 23)
        Me.D.TabIndex = 41
        Me.D.Text = "D"
        Me.D.UseVisualStyleBackColor = True
        '
        'S
        '
        Me.S.Location = New System.Drawing.Point(256, 121)
        Me.S.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(37, 23)
        Me.S.TabIndex = 40
        Me.S.Text = "S"
        Me.S.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(213, 121)
        Me.A.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(37, 23)
        Me.A.TabIndex = 39
        Me.A.Text = "A"
        Me.A.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.Location = New System.Drawing.Point(588, 91)
        Me.P.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(37, 23)
        Me.P.TabIndex = 38
        Me.P.Text = "P"
        Me.P.UseVisualStyleBackColor = True
        '
        'O
        '
        Me.O.Location = New System.Drawing.Point(544, 92)
        Me.O.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(37, 23)
        Me.O.TabIndex = 37
        Me.O.Text = "O"
        Me.O.UseVisualStyleBackColor = True
        '
        'I
        '
        Me.I.Location = New System.Drawing.Point(504, 92)
        Me.I.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.I.Name = "I"
        Me.I.Size = New System.Drawing.Size(37, 23)
        Me.I.TabIndex = 36
        Me.I.Text = "I"
        Me.I.UseVisualStyleBackColor = True
        '
        'U
        '
        Me.U.Location = New System.Drawing.Point(461, 92)
        Me.U.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(37, 23)
        Me.U.TabIndex = 35
        Me.U.Text = "U"
        Me.U.UseVisualStyleBackColor = True
        '
        'Y
        '
        Me.Y.Location = New System.Drawing.Point(416, 92)
        Me.Y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(37, 23)
        Me.Y.TabIndex = 34
        Me.Y.Text = "Y"
        Me.Y.UseVisualStyleBackColor = True
        '
        'T
        '
        Me.T.Location = New System.Drawing.Point(370, 92)
        Me.T.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(37, 23)
        Me.T.TabIndex = 33
        Me.T.Text = "T"
        Me.T.UseVisualStyleBackColor = True
        '
        'R
        '
        Me.R.Location = New System.Drawing.Point(326, 92)
        Me.R.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(37, 23)
        Me.R.TabIndex = 32
        Me.R.Text = "R"
        Me.R.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(281, 92)
        Me.btnE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(37, 23)
        Me.btnE.TabIndex = 31
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'W
        '
        Me.W.Location = New System.Drawing.Point(240, 92)
        Me.W.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.W.Name = "W"
        Me.W.Size = New System.Drawing.Size(37, 23)
        Me.W.TabIndex = 30
        Me.W.Text = "W"
        Me.W.UseVisualStyleBackColor = True
        '
        'Q
        '
        Me.Q.Location = New System.Drawing.Point(194, 91)
        Me.Q.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(37, 23)
        Me.Q.TabIndex = 29
        Me.Q.Text = "Q"
        Me.Q.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(446, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 41)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(255, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 41)
        Me.Label3.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Player 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Player 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1543, 554)
        Me.Controls.Add(Me.Label4)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Wheel of Fortune"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
