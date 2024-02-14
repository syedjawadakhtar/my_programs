fn main() {
    let mut x = 5;
    println!("{}", x);
    x = 6;
    println!("{}", x);

    const AGE: u32 = 24_00;
    // Can't mutate a constants; must be type annotated; can be only set to constant expressions, can't be set to a function. 
    // Shadowing create a variable with an existing name. 
    let x = 5;  // This is shadowed 
    let x = "charater"; //  by this value of x. 1. Letting us keep the immutability of the variable. 2. Can change the type.

    // Data types
    // Scalar datatypes: 
    // Integers (i8, i128, u8, u138, arch)
    let a = 98_22; // Decimal
    let a = 0xff; // Hex
    let a = 0o77; // Octal
    let a = 0b1111_000; // binary
    let a = b'A'; // Byte (u8 only)

    let f: u8 = 255;  // 256 will become 0 , 257 ~ 1; error reminding of overflow.

    // Float
    let f = 2.0;
    let g: f32 = 3.0;

    //addtions
    let sum = 95.5 + 10.5;
    // subtraction
    let difference = 3 - 2;
    // multiplication
    let multiply = 4 * 3;
    //division
    let divide = 56.7/32.2;
    //remainder
    let remainder = 43% 3;

    // Booleans
    let t = true;
    let f = false;

    // Character
    let c = 'z';
    let z: char = 'ℤ';
    let heart_eyed_cat = '😻';

    // Compound types
    let tup = ("lets get pizza", 15_00); // using ()
    let (food, price) = tup; // Will assign 'lets get pizza' with food and 15_00 with price
    let price = tup.1; // starting index is 0

    // Arrays
    let error_codes = [200, 400, 500];
    let not_found = error_codes[1];
    // let x = error_codes[3]; // will give an error on run as it's out of bound and memory unsafe

    let byte = [0; 8]; // Array with 8 values with all set 0
    let sum = my_function(11, 22);
    println!("The sum is {}", sum);

    /** Control flow
     similar if else statements; just the evaluation has to be something boolean and not just an integer like `if number`` - error as sum is i32
    **/
    if sum > 3 {
       println!("Sum is greater than 3"); 
    }
    // in expression
    let condition = true;
    let number = if condition { 5} else { 6 };

    // 1. Loop only break;
    loop {
        println!{"Looping"};
        break;
    }
    // adding a counter
    let mut counter = 0;
    let result = loop {
        counter +=1;
        if counter == 10 {
            break counter; // returns counter after breaking
        }
    }; // result ; 
    println!("{}",result);

    // while loop
    let mut number = 3;
    while number !=0 {
        println!("{}", number);
        number -= 1;
    }

    // for loop; when looping over a collection
    let a = [10, 20, 30, 40, 50];
    for element in a.iter() {
        println!("the value is {}", element);
    }

    for number in 1..4 {
        println!("{}!", number)
    }

}

fn my_function(x: i32, y: i32) -> i32 {
    // You have to mention the return type of the function -> i32 and paramters should have their return types as well.
    // snake case convention for naming function- all lower case and use _ for space
    println!("The value of x is {}", x); 
    println!("The value of y is {}", y);
    x + y   // The last statement of the function is automatically returned and should not have ; 
}