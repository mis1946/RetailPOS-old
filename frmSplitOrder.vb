﻿Public Class frmSplitOrder
    Private pnLoadx As Integer
    Private poControl As Control

    Private Sub frmPayGC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
        End Select
    End Sub

    Private Sub frmPay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setVisible()

        If pnLoadx = 0 Then
            showDetail(False)
            clearFields()
            Call grpEventHandler(Me, GetType(Button), "cmdButton", "Click", AddressOf cmdButton_Click)
            pnLoadx = 1
        End If
    End Sub

    Private Sub cmdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim loChk As Button
        loChk = CType(sender, System.Windows.Forms.Button)

        Dim lnIndex As Integer
        lnIndex = Val(Mid(loChk.Name, 10))

        Select Case lnIndex
            Case 0
            Case 1, 2, 4
        End Select
endProc:
        Exit Sub
    End Sub

    Private Sub showDetail(ByVal lbShow As Boolean)
        Dim lvDetailLoc As New Point(1, 199)
        Dim lvButtonLoc As New Point(1, 333)
        Dim lvMPnelOrgx As New Size(344, 377)
        Dim lvMPnelNewx As New Size(344, 243)
        Dim lvFormOrgxx As New Size(628, 645)
        Dim lvFormNewxx As New Size(628, 645)

        'If lbShow Then
        '    Me.Size = lvFormOrgxx
        '    pnlDetail.Visible = True
        '    pnlMain.Size = lvMPnelOrgx
        '    pnlButtons.Location = lvButtonLoc
        'Else
        '    Me.Size = lvFormNewxx
        '    pnlDetail.Visible = False
        '    pnlMain.Size = lvMPnelNewx
        '    pnlButtons.Location = lvDetailLoc
        'End If
    End Sub

    Private Sub setVisible()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.Visible = False
        Me.BackColor = Color.Transparent
        Me.Location = New Point(3, 3)
        txtField00.Focus()
        Me.Visible = True
    End Sub

    Private Sub clearFields()
        lblBill.Text = Format(0.0#, "#,##0.00")
        txtField02.Text = Format(0.0#, "#,##0.00")
        txtField00.Text = ""
        txtField01.Text = ""
    End Sub
End Class