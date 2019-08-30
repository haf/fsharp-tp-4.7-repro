// Learn more about F# at http://fsharp.org

open Provider.Helpers

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#! %s" (SomeRuntimeHelper.Help())
    0 // return an integer exit code
