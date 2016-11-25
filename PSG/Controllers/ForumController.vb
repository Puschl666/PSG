Imports System.Web.Mvc

Namespace Controllers
    Public Class ForumController
        Inherits Controller

        ' GET: Forum
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace