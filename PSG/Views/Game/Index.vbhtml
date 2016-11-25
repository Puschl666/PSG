@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Layout/Default.vbhtml"
End Code

<section class="site_headline">
    <div>
        <div>
            <div>
                <h2 class="text-center"><strong>Spiele</strong></h2>
                <h3>Unsere Spiele im Überblick</h3>
            </div>
        </div>
    </div>
</section>

<section class="game_selection">
    <div>
        <div>
            <div>
                <div class="col-md-4">
                    <div class="game_item">
                        <img src="/Images/Header/login.png" alt="Farmer Joe" title="Farmer Joe" />
                        <div class="game_description">
                            <h4>Farmer Joe</h4>
                            <p class="maxheight" data-maxheight-group="game-text">Ein Farm-Spiel im RPG Style.</p>
                            <a Class="LinkButton" href="http://farmer-joe.de">Mehr sehen</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        PSG.General.BindGameClick('.game_item');
    </script>
</section>

