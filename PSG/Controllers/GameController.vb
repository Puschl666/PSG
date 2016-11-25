Imports System.Web.Mvc

Namespace Controllers
    Public Class GameController
        Inherits Controller

        ' GET: Game
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace