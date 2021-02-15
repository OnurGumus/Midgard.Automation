
open System.Reflection
open TickSpec
open canopy.classic

[<AfterScenarioAttribute>]
let quitBrowser () =  ()


[<EntryPointAttribute>]
let main _ = 
    try
        do
            let ass = Assembly.GetExecutingAssembly()
            let definitions = StepDefinitions(ass)
            [ "about-view" ]
            |> Seq.iter
                (fun source ->
                    let s =
                        ass.GetManifestResourceStream("Midgard.Test.Automation." + source + ".feature")
                    definitions.Execute(source, s))

        0
    with e ->
        printf "%A" e
        -1
