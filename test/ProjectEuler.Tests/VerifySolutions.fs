namespace ProjectEuler.Tests

open NUnit.Framework
open Shouldly

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.VerifySolution1() =
        let expected = 233168
        let actual = Challenge01.solution
        expected.ShouldBe(actual);

    [<Test>]
    member this.VerifySolution2() =
        let expected = 4613732
        let actual = Challenge02.solution
        expected.ShouldBe(actual);
        
