module Midgard.Test.Automation.AboutView

open canopy.configuration
open canopy.classic
open canopy.types
open TickSpec


let startBrowser () =
    chromiumDir <- System.AppContext.BaseDirectory
    let options = OpenQA.Selenium.Chrome.ChromeOptions()
    options.AddArgument("--disable-extensions")
    options.AddArgument("disable-infobars")
    options.AddArgument("test-type")
    //options.AddArgument("--headless")
    options.AddArgument("--no-sandbox")
    options.AddArgument("--ignore-certificate-errors")
    options.AddArgument("--disable-gpu")
    options.AddArgument("--disable-setuid-sandbox")
    options.AddArgument("--whitelisted-ips")
    options.AddArgument("--disable-dev-shm-usage")
    options.AddUserProfilePreference("download.default_directory", ".")
    start <| ChromiumWithOptions options
    positionBrowser 0 0 20 200

[<Given>]
let ``the browser window is narrowed down`` () =
    startBrowser ()
    url "https://localhost:3333"

[<Given>]
let ``Fast OP is a DL`` () = ()


[<When>]
let ``I open the card Fast OP`` () =
    waitForElement "div.personControl"

    js "window.scrollBy(0,1300)" |> ignore

    elementWithText "div.personControl" "Fast OP LPC \(DL Members\)"
    |> click

[<When>]
let ``click to About button`` () =
    element "button[title=\"Show more contact information\"]"
    |> click

[<Then>]
let ``I should see the about details`` () =
    1
    === (elements "div[data-log-name=\"GroupDescriptionView\"]").Length
