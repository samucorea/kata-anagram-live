module Anagrams.Tests

open NUnit.Framework
open Anagrams

[<SetUp>]
let Setup () = ()

[<Test>]
let getAnagramInputEmptyStringArrayShouldReturnEmptyList () =
    let expected = []
    let actual = Tools.getAnagrams [||]

    Assert.AreEqual(expected, actual)
