<%@ Control Language="VB" Inherits="System.Web.Mvc.ViewUserControl" %>
<%:
    Html.DevExpress().GridView( _
        Sub(settings)
            settings.Name = "gridASPX"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialASPX"}

            settings.KeyFieldName = "ProductID"

            settings.Columns.Add("ProductID")
            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("Discontinued")
        End Sub).BindToLINQ(String.Empty, String.Empty,
            New EventHandler(Of DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs)( _
                Sub(s, e)
                    Dim dataContext As New E3252_VB.NorthwindEntities()
                    e.QueryableSource = dataContext.Products
                    e.KeyExpression = "ProductID"
                End Sub)).GetHtml()
%>