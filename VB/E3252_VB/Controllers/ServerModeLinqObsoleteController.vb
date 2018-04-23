Imports System
Imports System.Web.Mvc

Public Class ServerModeLinqObsoleteController
    Inherits Controller
    Public Function IndexLinqObsolete() As ActionResult
        Return View()
    End Function
    Public Function GridViewPartialLinqObsolete() As ActionResult
        Return PartialView()
    End Function
End Class