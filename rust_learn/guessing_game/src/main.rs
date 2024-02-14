use std::io;
use std::cmp::Ordering; // Comparison between two values
use rand::Rng;
use colored::*;

fn main() {
    println!("Guess the number!");
    
    let secret_number = rand::thread_rng().gen_range(1, 101);

    println!("The secret number is {}", secret_number);
    
    loop {
        println!("Please input your guess.");
    
        let mut guess = String::new();
        io::stdin()
            .read_line(&mut guess)
            .expect("Failed to read line");

        // trim will remore any white spaces, parse have to return the parsed value in u32
        // Adding `match` ok if num else contiue the loop, as when giving error the main.rs is panicking
        let guess: u32 = match guess.trim().parse(){
            Ok(num) => num,
            Err(_) => continue,
        }; 
        
        println!("You guess {}", guess);
    
        match guess.cmp(&secret_number){
            Ordering::Less => println!("{}", "Too small!".red()),
            Ordering::Greater => println!("{}", "Too big!".red()),
            Ordering::Equal =>{ 
                println!("{}", "You win!".green());
                break;
            }
        }
    }
}
