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

[<Test>]
let getAnagramInputWordArrayShouldReturnArrayOfAnagrams () =
    let expected = [("moor", ["romo"; "moro"])]
    let actual = Tools.getAnagrams [| "romo"; "moro"; "hola"|]

    Assert.That(expected, Is.EqualTo(actual))
