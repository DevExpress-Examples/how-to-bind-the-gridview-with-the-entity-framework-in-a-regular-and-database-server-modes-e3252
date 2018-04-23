<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>@ViewBag.Title</title>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-1.4.4.min.js")" type="text/javascript"></script>
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.GridView}, New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, New Script With {.ExtensionSuite = ExtensionSuite.Editors}, New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout})
</head>
<body>
    @RenderBody()
</body>
</html>