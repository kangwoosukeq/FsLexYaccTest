module AST

type Stmt =
    | LabeledStmt of string
    | CompoundStmt of Stmt list

let rec printStmt stmt =
    match stmt with
    | LabeledStmt id -> printfn "LabeldStmt(%s)" id
    | CompoundStmt stmts ->
        printfn "CompoundStmt"
        List.iter printStmt stmts
