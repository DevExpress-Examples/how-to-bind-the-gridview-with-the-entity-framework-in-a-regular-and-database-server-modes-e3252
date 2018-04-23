<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%:
    Html.DevExpress().GridView(settings => {
        settings.Name = "gridASPX";
        settings.CallbackRouteValues = new { Controller = "Home", Action = "GridViewPartialASPX" };

        settings.KeyFieldName = "ProductID";
    
        settings.Columns.Add("ProductID");
        settings.Columns.Add("ProductName");
        settings.Columns.Add("UnitPrice");
        settings.Columns.Add("Discontinued");
    })
    .BindToLINQ(string.Empty, string.Empty, new EventHandler<DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs> ((s, e) =>
    {
        E3252_CS.NorthwindEntities dataContext = new E3252_CS.NorthwindEntities();
        e.QueryableSource = dataContext.Products;
        e.KeyExpression = "ProductID";
    }))
    .GetHtml()
%>