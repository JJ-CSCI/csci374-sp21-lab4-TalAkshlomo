module Assignment

// Problem 1
let rec prod (lst:int list) =
    if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)
    // write your solution here
    0

// Problem 2
let rec map f (lst:int list) =
    if x = 0
    then []
    else x :: map (x-1)
    // write your solution here
    []

// Problem 3
let rec Odd x (lst:int list) =
    if x = 0 then true 
    else Even (x-1) 
and Even x = 
    if x = 0 then false 
    else Odd (x-1)
    // write your solution here
    lst

// Problem 4
let rec filter f lst =
    if lst.IsEmpty 
    then f
    else lst.Head :: append lst.Tail f
    // write your solution here
    lst
