Public Class Navegar
    Private navegacion As New List(Of Form)
    Public Sub New(ventanaActual As Form)
        navegacion.Add(ventanaActual)
    End Sub
    ' Navega a la nueva ventana ocultando la anterior en el procesos
    Public Sub NavegarA(ventanaANavegar As Form)
        navegacion.Last.Hide()
        navegacion.Add(ventanaANavegar)
        navegacion.Last.Show()
    End Sub
    ' regresa a la ventana anterior
    Public Sub Regresar(ventanaActual As Form)
        navegacion.Last().Hide()
        navegacion.Remove(ventanaActual)
        navegacion.Last.Show()
    End Sub
    ' Solo muestra la nueva con un modal o algo asi
    Public Sub Mostrar(ventana As Form)
        navegacion.Add(ventana)
        navegacion.Last.Show()
    End Sub
End Class
