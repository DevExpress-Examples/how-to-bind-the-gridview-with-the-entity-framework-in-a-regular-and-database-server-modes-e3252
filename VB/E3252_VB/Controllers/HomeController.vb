Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        Return View("GridView")
    End Function
    Public Function GridViewPartialRazor() As ActionResult
        Return PartialView()
    End Function
    Public Function GridViewPartialASPX() As ActionResult
        Return PartialView()
    End Function

End Class
