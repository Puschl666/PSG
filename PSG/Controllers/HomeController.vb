Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function
        Function Imprint() As ActionResult
            Return View()
        End Function
        Function Help() As ActionResult
            Return View()
        End Function
        Function TaC() As ActionResult
            Return View()
        End Function
        Function DataPrivacy() As ActionResult
            Return View()
        End Function
        Function Contact() As ActionResult
            Return View()
        End Function
    End Class
End Namespace