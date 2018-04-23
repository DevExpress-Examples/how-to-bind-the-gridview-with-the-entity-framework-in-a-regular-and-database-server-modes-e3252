Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Mvc

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        Return View()
    End Function

End Class