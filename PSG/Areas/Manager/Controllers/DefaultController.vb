﻿Imports System.Web.Mvc

Namespace Areas.Manager.Controllers
    Public Class DefaultController
        Inherits Controller

        ' GET: Manager/Default
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace