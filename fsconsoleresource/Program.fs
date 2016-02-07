open System
open System.Reflection

[<EntryPoint>]
let main argv = 
    Assembly.GetExecutingAssembly().GetManifestResourceNames()
    |> Array.iter (Console.WriteLine) 
    0 // return an integer exit code    