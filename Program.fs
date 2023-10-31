open FSharp.Text.Lexing

let stmts = [ "Label:"; "{}"; "{HAHA:HUHU:}" ]

List.iter
    (fun stmt ->
        let lexbuf =
            LexBuffer<_>.FromBytes(System.Text.Encoding.ASCII.GetBytes(stmt: string))

        let result = Parser.Stmt Lexer.token lexbuf

        AST.printStmt result)
    stmts
