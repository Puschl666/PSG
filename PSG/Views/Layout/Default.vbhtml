<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <link rel="icon" type="image/png" href="/Images/favicon.png" />

    <link href="/css/bootstrap.css" rel="stylesheet" />
    <link href="/css/font-awesome.css" rel="stylesheet" />
    <link href="/css/Common.css" rel="stylesheet" />
    <link href="/css/Footer.css" rel="stylesheet" />
    <link href="/css/Header.css" rel="stylesheet" />
    <link href="/css/Navigation.css" rel="stylesheet" />
    <link href="/css/Site.css" rel="stylesheet" />
    <link href="/css/SubMenu.css" rel="stylesheet" />
    <link href="/css/content/GameSelection.css" rel="stylesheet" />
    <link href="/css/content/SiteHeadline.css" rel="stylesheet" />

    <script src="/javascript/jquery/jquery.js"></script>
    <script src="/javascript/namespaces.js"></script>
    <script src="/javascript/bootstrap.js"></script>
    <script src="/javascript/plugins/parallax.js"></script>
    <script src="/javascript/plugins/equalheight.js"></script>
    <script src="/javascript/general.js"></script>
    <script src="/javascript/javascript.js"></script>
</head>
<body>
    <div>
        @Html.Partial("~/Views/Partials/Navigation.vbhtml")
        @Html.Partial("~/Views/Partials/Header.vbhtml")
        @RenderBody()

        @Html.Partial("~/Views/Partials/Footer.vbhtml")

        <div class="modal fade" id="modal" tabindex="-1" role="dialog" aria-labelledby="basicModal" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"><i class="fa fa-close"></i></button>
                        <h4 class="modal-title" id="myModalLabel"></h4>
                    </div>
                    <div class="modal-body">
                    </div>
                    <div class="modal-footer">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
