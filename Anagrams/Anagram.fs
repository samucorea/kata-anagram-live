namespace Anagrams
open System
module Tools =
    let getAnagrams (words: string array) =
        let getKey (str : string) =
            str.ToCharArray()
            |> Array.sort
            |> String
        words
        |> Array.groupBy getKey
        |> Array.filter( fun (_, originalWord ) -> originalWord.Length > 1)
            

