// Signature file for parser generated by fsyacc
module Parser
type token = 
  | COLON
  | LBRACE
  | RBRACE
  | EOF
  | ID of (string)
type tokenId = 
    | TOKEN_COLON
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_EOF
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startStmt
    | NONTERM_Stmt
    | NONTERM_LabeledStmt
    | NONTERM_CompoundStmt
    | NONTERM_StmtList
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Stmt : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Stmt) 
