#!/usr/bin/env python3
"""
Simple password storage and validation program.
Chapter 9 exercise: remember a password only, true heart.
"""

def store_password():
    """Store a password for later validation."""
    password = "trueheart"
    return password

def verify_password(input_password, stored_password):
    """Verify if the input password matches the stored password."""
    return input_password == stored_password

def main():
    """Main program to demonstrate password storage and verification."""
    # Store the password
    stored_pwd = store_password()
    print("Password has been stored.")
    
    # Prompt user to enter password
    user_input = input("Enter password to verify: ")
    
    # Verify the password
    if verify_password(user_input, stored_pwd):
        print("Access granted! Password is correct.")
    else:
        print("Access denied! Password is incorrect.")

if __name__ == "__main__":
    main()
