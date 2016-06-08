namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("IntelliFactory.SQLProvider")>]
[<assembly: AssemblyProductAttribute("IntelliFactory.SQLProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type providers for SQL database access (IntelliFactory fork).")>]
[<assembly: AssemblyVersionAttribute("99.0.0")>]
[<assembly: AssemblyFileVersionAttribute("99.0.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "99.0.0"
    let [<Literal>] InformationalVersion = "99.0.0"
