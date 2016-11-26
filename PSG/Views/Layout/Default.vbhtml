<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData("Title") - Playsomegames</title>
    <link rel="icon" type="image/png" href="/Images/favicon.png" />
    @Styles.Render("~/css")
    @Scripts.Render("~/javascript")
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
