
//Define Square function
let square x = x * x

//define the sumOfSquare function
let sumOfSquares n = 
    [1..n] |> List.map square |> List.sum

let answer = sumOfSquares 100
