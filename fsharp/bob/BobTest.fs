module BobTests

open NUnit.Framework
open Bob

[<TestFixture>]
type BobTest() =
    
    [<Test>]
    member tests.StatingSomething() =
        Assert.That(Bob("Tom-ay-to, tom-aaaah-to.").Hey(), Is.EqualTo("Whatever."))

    [<Test>]
    member tests.Shouting() =
        Assert.That(Bob("WATCH OUT!").Hey(), Is.EqualTo("Whoa, chill out!"))

    [<Test>]
    member tests.AskingAquestion() =
        Assert.That(Bob("Does this cryogenic chamber make me look fat?").Hey(), Is.EqualTo("Sure."))

    [<Test>]
    member tests.AskingAnumericQuestion() =
        Assert.That(Bob("You are, what, like 15?").Hey(), Is.EqualTo("Sure."))

    [<Test>]
    member tests.ForcefulQuestions() =
        Assert.That(Bob("WHAT THE HELL WERE YOU THINKING?").Hey(), Is.EqualTo("Whoa, chill out!"))

    [<Test>]
    member tests.ShoutingNumbers() =
        Assert.That(Bob("1, 2, 3 GO!").Hey(), Is.EqualTo("Whoa, chill out!"))

    [<Test>]
    member tests.OnlyNumbers() =
        Assert.That(Bob("1, 2, 3").Hey(), Is.EqualTo("Whatever."))

    [<Test>]
    member tests.QuestionOnlyWithNumbers() =
        Assert.That(Bob("4?").Hey(), Is.EqualTo("Sure."))

    [<Test>]
    member tests.ShoutingWithSpecialCharacters() =
        Assert.That(Bob("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!").Hey(), Is.EqualTo("Whoa, chill out!"))

    [<Test>]
    member tests.ShoutingWithNoWxlamationMark() =
        Assert.That(Bob("I HATE YOU").Hey(), Is.EqualTo("Whoa, chill out!"))

    [<Test>]
    member tests.StatementContainingQuestionMark() =
        Assert.That(Bob("Ending with ? means a question.").Hey(), Is.EqualTo("Whatever."))

    [<Test>]
    member tests.PrattlingOn() =
        Assert.That(Bob("Wait! Hang on. Are you going to be OK?").Hey(), Is.EqualTo("Sure."))

    [<Test>]
    member tests.Silence() =
        Assert.That(Bob("").Hey(), Is.EqualTo("Fine. Be that way!"))

    [<Test>]
    member tests.ProlongedSilence() =
        Assert.That(Bob("    ").Hey(), Is.EqualTo("Fine. Be that way!"))

    [<Test>]
    member tests.MultipleLineQuestion() =
        Assert.That(Bob("Does this cryogenic chamber make me look fat?\nno").Hey(), Is.EqualTo("Whatever."))
