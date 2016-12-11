Imports System.Web.Mvc

Namespace Areas.Manager.Controllers
    Public Class AdminController
        Inherits Controller

        ' GET: Manager/Admin
        Function Login() As ActionResult
            Return View()
        End Function
    End Class
End Namespace