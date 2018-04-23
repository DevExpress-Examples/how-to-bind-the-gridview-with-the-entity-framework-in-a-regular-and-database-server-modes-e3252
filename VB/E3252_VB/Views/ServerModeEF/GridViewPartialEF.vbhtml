@Imports Microsoft.VisualBasic
@Imports DevExpress.Web.Mvc
@Imports DevExpress.Web.Mvc.UI

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
            settings.CallbackRouteValues = New With {.Controller = "ServerModeEF", .Action = "GridViewPartialEF"}

            settings.KeyFieldName = "ProductID"

            settings.Columns.Add("ProductID")
            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("Discontinued")
    End Sub).Bind(Model).GetHtml()