Imports System
Imports System.Web.Mvc

'DevExpress.Xpf.Core.vXX.Y.dll
Imports DevExpress.Data.Linq
'DevExpress.Xpf.Core.vXX.Y.dll

Public Class ServerModeEFController
    Inherits Controller
    Public Function IndexEF() As ActionResult
        Return View(GetEntityServerModeSource())
    End Function
    Public Function GridViewPartialEF() As ActionResult
        Return PartialView(GetEntityServerModeSource())
    End Function
    Private Function GetEntityServerModeSource() As EntityServerModeSource
        Dim esms As New EntityServerModeSource()
        esms.KeyExpression = "ProductID"
        esms.QueryableSource = New NorthwindEntities().Products

        Return esms
    End Function
End Class
