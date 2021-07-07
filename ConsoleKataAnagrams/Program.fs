// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Anagrams 


    [<EntryPoint>]
let main argv = 
    let filename = "wordlist.txt"
    let listOfWords = System.IO.File.ReadAllLines(filename)
    let listOfAnagrams = Tools.getAnagrams listOfWords

    // Prints 
    listOfAnagrams |> Array.iter  (fun (_ , anagramList) ->  anagramList |> Array.iter 
(fun str -> printfn "%s" str); printfn "")

0
