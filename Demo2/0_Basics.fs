module Basics



// Binding
let x = 3

// Collections
let arr = [| 1; 2; 3 |]
let lst = [ 'c'; 'j' ]


// Combined types
let tup = (12, "asdfdsf")
type Person = { name: string; age: int }
let person: Person = { name = "2332"; age = 12 }

// Union
type RGB =
    | Red
    | Green
    | Blue


type Wild =
    | Name of string
    | Tup of int * char
    | Color of RGB
    | P of Person
    | W of Wild

let wild = P person

match wild with
| Name name -> name.Length
| Color color -> 0
| _ -> 69
