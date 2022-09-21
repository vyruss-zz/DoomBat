Imports System.IO

Public Class mainForm

    'fields for our config to check against
    Dim firstrun As String = "yes"
    Dim dir As String = ""
    Dim iwad As String = ""
    Dim skill As String = ""
    Dim startmap As String = ""
    Dim mapIndex As Integer = -1
    Dim pwads As String = ""
    Dim config As String = ".\doombat.cfg"
    'write our config to file
    Private Sub writeConfig(filename As String)
        Dim sw As System.IO.StreamWriter
        sw = New StreamWriter(filename)
        sw.WriteLine("no")
        sw.WriteLine(txtWorkingDirectory.Text)
        Select Case iwad
            Case "doom"
                sw.WriteLine("doom")
            Case "doom2"
                sw.WriteLine("doom2")
            Case "udoom"
                sw.WriteLine("udoom")
            Case "heretic"
                sw.WriteLine("heretic")
            Case "hexen"
                sw.WriteLine("hexen")
        End Select

        'game skill level
        Select Case skill
            Case "1"
                sw.WriteLine("1")
            Case "2"
                sw.WriteLine("2")
            Case "3"
                sw.WriteLine("3")
            Case "4"
                sw.WriteLine("4")
            Case "5"
                sw.WriteLine("5")
        End Select

        'level
        If rbTitle.Checked = True Then
            sw.WriteLine("title")
            sw.WriteLine("-1")
        ElseIf rbMap.Checked = True Then
            sw.WriteLine(lbLevels.SelectedItem)
            sw.WriteLine(lbLevels.SelectedIndex)
        End If

        'set pwads if any
        sw.WriteLine(txtPWADs.Text)

        sw.Close()
    End Sub
    'check if we have an existing config file - if not, make one
    Private Sub readConfig(filename As String)
        If (File.Exists(filename)) Then
            Dim sr As System.IO.StreamReader
            sr = New StreamReader(filename)
            firstrun = sr.ReadLine
            dir = sr.ReadLine
            iwad = sr.ReadLine
            skill = sr.ReadLine
            startmap = sr.ReadLine
            mapIndex = sr.ReadLine
            pwads = sr.ReadLine
            sr.Close()
        Else
            Dim sw As System.IO.StreamWriter
            sw = New StreamWriter(filename)
            sw.WriteLine("no")
            sw.WriteLine("e:\doom")
            sw.WriteLine("udoom")
            sw.WriteLine("4")
            sw.WriteLine("title")
            sw.WriteLine(-1)
            sw.WriteLine("")
            sw.Close()
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'run file check twice - want to do the default load at start
        readConfig(config)
        readConfig(config)



        'now that we did that, let's set each control appropriately...
        'directory text box
        txtWorkingDirectory.Text = dir.ToString

        'game IWAD
        Select Case iwad
            Case "doom"
                rbDoom.Checked = True
            Case "doom2"
                rbDoom2.Checked = True
            Case "udoom"
                rbUltimateDoom.Checked = True
            Case "heretic"
                rbHeretic.Checked = True
            Case "hexen"
                rbHeretic.Checked = True
        End Select

        'game skill level
        Select Case skill
            Case "1"
                rbBaby.Checked = True
            Case "2"
                rbEasy.Checked = True
            Case "3"
                rbNormal.Checked = True
            Case "4"
                rbHard.Checked = True
            Case "5"
                rbNightmare.Checked = True
        End Select

        'level
        If startmap = "title" Then
            rbTitle.Checked = True
        Else
            rbMap.Checked = True
            'go through the trouble of yet AGAIN checking through the listbox...
            rbMap_Click(Me, e)
            lbLevels.SelectedItem = startmap
            lbLevels.SelectedIndex = mapIndex
        End If

        'set pwads if any
        txtPWADs.Text = pwads

    End Sub

    Private Sub rbDoom_Click(sender As Object, e As EventArgs) Handles rbDoom.Click
        iwad = "doom"
        If rbMap.Checked Then
            populateMaps(3, 9, False)
        End If
    End Sub

    Private Sub rbDoom2_Click(sender As Object, e As EventArgs) Handles rbDoom2.Click
        iwad = "doom2"
        If rbMap.Checked Then
            populateMaps(0, 32, True)
        End If
    End Sub

    Private Sub rbHeretic_Click(sender As Object, e As EventArgs) Handles rbHeretic.Click
        iwad = "heretic"
        If rbMap.Checked Then
            populateMaps(3, 9, False)
        End If
    End Sub

    Private Sub rbHexen_Click(sender As Object, e As EventArgs) Handles rbHexen.Click
        iwad = "hexen"
        If rbMap.Checked Then
            populateMaps(0, 41, True)
        End If
    End Sub

    Private Sub rbUltimateDoom_Click(sender As Object, e As EventArgs) Handles rbUltimateDoom.Click
        iwad = "udoom"
        If rbMap.Checked Then
            populateMaps(4, 9, False)
        End If
    End Sub

    Private Sub rbEasy_Click(sender As Object, e As EventArgs) Handles rbEasy.Click
        skill = "2"
    End Sub

    Private Sub rbBaby_Click(sender As Object, e As EventArgs) Handles rbBaby.Click
        skill = "1"
    End Sub

    Private Sub rbNormal_Click(sender As Object, e As EventArgs) Handles rbNormal.Click
        skill = "3"
    End Sub

    Private Sub rbHard_Click(sender As Object, e As EventArgs) Handles rbHard.Click
        skill = "4"
    End Sub

    Private Sub rbNightmare_Click(sender As Object, e As EventArgs) Handles rbNightmare.Click
        skill = "5"
    End Sub

    Private Sub txtWorkingDirectory_Leave(sender As Object, e As EventArgs) Handles txtWorkingDirectory.Leave
        dir = txtWorkingDirectory.ToString
    End Sub

    Private Sub txtPWADs_Leave(sender As Object, e As EventArgs) Handles txtPWADs.Leave
        pwads = txtPWADs.ToString
    End Sub

    'reg or com = registered or commercial, false = registered true = commercial
    Private Sub populateMaps(episode As Integer, level As Integer, regOrCom As Boolean)
        Dim map As String
        lbLevels.Items.Clear()
        If regOrCom = False Then
            For epCount As Integer = 1 To episode Step 1
                For levCount As Integer = 1 To level Step 1
                    lbLevels.Items.Add("E" + epCount.ToString + "M" + levCount.ToString)
                Next levCount
            Next epCount
        Else
            For levCount As Integer = 1 To level Step 1
                If levCount < 10 Then
                    map = "MAP0"
                Else
                    map = "MAP"
                End If
                lbLevels.Items.Add(map + levCount.ToString)
            Next levCount
        End If

    End Sub
    Private Sub rbMap_Click(sender As Object, e As EventArgs) Handles rbMap.Click
        lbLevels.Visible = True

        'populate based on IWAD selected
        Select Case iwad
            Case "doom"
                populateMaps(3, 9, False)
            Case "heretic"
                populateMaps(3, 9, False)
            Case "udoom"
                populateMaps(4, 9, False)
            Case "doom2"
                populateMaps(0, 32, True)
            Case "hexen"
                populateMaps(0, 41, True)
        End Select
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        writeConfig(config)
        Me.Close()
    End Sub


    'write batch file with pwads
    Private Sub writePWADBat()
        Dim sw As System.IO.StreamWriter
        sw = New StreamWriter(".\doombat.bat")
        'change drive and directory
        sw.WriteLine(dir.Substring(0, 2))
        sw.WriteLine("cd" + dir.Substring(2, dir.Length - 2))

        'hardcoded call to ZDOOM - oh noooooeeeessss
        sw.Write("gzdoom -iwad ")
        Select Case iwad
            Case "doom"
                sw.Write("doom.wad ")
            Case "doom2"
                sw.Write("doom2.wad ")
            Case "udoom"
                sw.Write("doom.wad ")
            Case "heretic"
                sw.Write("heretic.wad ")
            Case "hexen"
                sw.Write("hexen.wad ")
        End Select

        sw.Write("-skill ")

        'game skill level
        Select Case skill
            Case "1"
                sw.Write("1")
            Case "2"
                sw.Write("2")
            Case "3"
                sw.Write("3")
            Case "4"
                sw.Write("4")
            Case "5"
                sw.Write("5")
        End Select

        'level
        If rbMap.Checked = True Then
            sw.Write(" +MAP " + lbLevels.SelectedItem)
        End If

        sw.Write(" -file " + pwads)
        sw.Close()
    End Sub



    'write our batch file - iwad only
    Private Sub writeIWADBat()
        Dim sw As System.IO.StreamWriter
        sw = New StreamWriter(".\doombat.bat")
        'change drive and directory
        sw.WriteLine(dir.Substring(0, 2))
        sw.WriteLine("cd" + dir.Substring(2, dir.Length - 2))

        'hardcoded call to ZDOOM - oh noooooeeeessss
        sw.Write("zdoom -iwad ")
        Select Case iwad
            Case "doom"
                sw.Write("doom.wad ")
            Case "doom2"
                sw.Write("doom2.wad ")
            Case "udoom"
                sw.Write("doom.wad ")
            Case "heretic"
                sw.Write("heretic.wad ")
            Case "hexen"
                sw.Write("hexen.wad ")
        End Select

        sw.Write("-skill ")

        'game skill level
        Select Case skill
            Case "1"
                sw.Write("1")
            Case "2"
                sw.Write("2")
            Case "3"
                sw.Write("3")
            Case "4"
                sw.Write("4")
            Case "5"
                sw.Write("5")
        End Select

        'level
        If rbMap.Checked = True Then
            sw.Write(" +MAP " + lbLevels.SelectedItem)
        End If
        sw.Close()
    End Sub

    Private Sub btnLaunchGameOnly_Click(sender As Object, e As EventArgs) Handles btnLaunchGameOnly.Click
        writeIWADBat()
        runDoomBat()
    End Sub

    Private Sub rbTitle_Click(sender As Object, e As EventArgs) Handles rbTitle.Click
        lbLevels.SelectedIndex = -1
        startmap = "title"
        lbLevels.Visible = False
        mapIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writePWADBat()
        runDoomBat()
    End Sub

    Private Sub runDoomBat()
        System.Diagnostics.Process.Start(".\doombat.bat")
    End Sub


End Class
