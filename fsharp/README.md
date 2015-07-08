F# Exercism.io
===============

Non IDE use on Linux:

1. To build project:

    Using terminal:

        xbuild Exercism.fsharp.fsproj

        or

        xbuild Exercism.fsharp.sln

    Using vim-fsharp:

        :FSharpBuildProject Exercism.fsharp.fsproj

        or

        :FSharpBuildProject Exercism.fsharp.fsproj

2. To run all tests (from terminal):

    nunit-console bin/Debug/Exercism.fsharp.dll
