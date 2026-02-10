#!/usr/bin/env python3
"""
Main application for the Hopeful Fortune Generator
A project that brings hope and positive messages to brighten your day
"""
import sys
from fortune_generator import FortuneGenerator


def main():
    """Main entry point for the hopeful fortune application."""
    print("\n" + "="*60)
    print("  Welcome to the Hopeful Fortune Generator!")
    print("  Building hope and good fortune, one message at a time")
    print("="*60 + "\n")
    
    generator = FortuneGenerator()
    
    if len(sys.argv) > 1:
        command = sys.argv[1].lower()
        
        if command == "fortune":
            print("🔮 Your Fortune:")
            print(f"   {generator.get_fortune()}\n")
        elif command == "affirmation":
            print("💫 Your Affirmation:")
            print(f"   {generator.get_affirmation()}\n")
        elif command == "daily":
            print(generator.get_daily_message())
        else:
            print(f"Unknown command: {command}")
            print_usage()
    else:
        # Default: show daily message
        print(generator.get_daily_message())


def print_usage():
    """Print usage information."""
    usage = """
Usage:
  python main.py              - Get your daily hopeful message
  python main.py fortune      - Get a fortune message
  python main.py affirmation  - Get an affirmation
  python main.py daily        - Get a complete daily message
"""
    print(usage)


if __name__ == "__main__":
    main()
