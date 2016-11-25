<nav id="mainNav" class="navbar-custom">
    <div class="nav_container">
        @Html.Partial("~/Views/Partials/TopNavigation.vbhtml")
        <div class="navbar-header">
            <a href="/">
                <img src="/Images/logo.png" alt="Logo" title="Playsomegames">
            </a>
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#mainNavbar">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
        </div>
        <div class="collapse navbar-collapse" id="mainNavbar">
            <ul class="nav navbar-nav navbar-right widthanimate">
                <li class="hidden">
                    <a href="#page-top"></a>
                </li>
                @Code
                    Dim Active As String = ""
                    If Request.Url.LocalPath.ToString = "/Game" Then
                        Active = "class=activetopline"
                    End If
                End Code
                <li @Active>
                    <a href="/Game"><i class="fa fa-gamepad fa-2x"></i><p>Spiele</p></a>
                </li>
                @Code
                    Active = ""
                    If Request.Url.LocalPath.ToString = "/Post" Then
                        Active = "class=activetopline"
                    End If
                End Code
                <li @Active>
                    <a href="/Post"><i class="fa fa-rss-square fa-2x"></i><p>Blog</p></a>
                </li>
                @Code
                    Active = ""
                    If Request.Url.LocalPath.ToString = "/Forum" Then
                        Active = "class=activetopline"
                    End If
                End Code
                <li @Active>
                    <a href="/Forum"><i class="fa fa-comments-o fa-2x"></i><p>Forum</p></a>
                </li>
            </ul>
        </div>
    </div>
</nav>
