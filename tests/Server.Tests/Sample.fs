module Tests

open Expecto
open Server

[<Tests>]
let tests =
    testList "samples" [ testCase "square" <| fun _ -> Expect.equal (Server.square 2) 4 "2*2=4" ]
