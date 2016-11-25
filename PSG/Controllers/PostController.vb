Imports System.Web.Mvc

Namespace Controllers
    Public Class PostController
        Inherits Controller

        ' GET: Post
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace