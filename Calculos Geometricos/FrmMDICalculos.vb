Imports System.Windows.Forms

Public Class FrmMDICalculos

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ÁreaParalelogramoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaParalelogramoToolStripMenuItem.Click
        Dim Objhijo1 As New FrmAreaParalelogramo
        Objhijo1.MdiParent = Me
        Objhijo1.Show()
    End Sub

    Private Sub ÁreaTrapecioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaTrapecioToolStripMenuItem.Click
        Dim Objhijo2 As New FrmAreaTrapecio
        Objhijo2.MdiParent = Me
        Objhijo2.Show()
    End Sub

    Private Sub ÁreaOctágonoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ÁreaOctágonoToolStripMenuItem.Click
        Dim Objhijo3 As New FrmAreaOctagono
        Objhijo3.MdiParent = Me
        Objhijo3.Show()
    End Sub

    Private Sub ÁreaPirámideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaPirámideToolStripMenuItem.Click
        Dim Objhijo4 As New FrmPiramide
        Objhijo4.MdiParent = Me
        Objhijo4.Show()
    End Sub
End Class
