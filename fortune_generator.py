"""
Fortune Generator - A hopeful message generator for good fortune
"""
import random
from datetime import datetime


class FortuneGenerator:
    """Generate hopeful and positive fortune messages."""
    
    FORTUNES = [
        "Your future is bright and filled with endless possibilities!",
        "Good fortune follows those who believe in themselves.",
        "Every new day brings a chance for wonderful opportunities.",
        "Your positive energy will attract amazing things.",
        "Success and happiness are on their way to you.",
        "The universe is conspiring in your favor.",
        "Your dreams are closer than you think.",
        "Hope is the foundation of all great achievements.",
        "Today marks the beginning of something wonderful.",
        "Your perseverance will lead to tremendous success.",
        "Joy and prosperity are heading your direction.",
        "Believe in yourself, and magic will happen.",
        "Your hard work will soon bear beautiful fruit.",
        "Good things come to those who stay hopeful.",
        "The best is yet to come in your journey.",
        "Your kindness will return to you multiplied.",
        "A fortunate path lies ahead of you.",
        "Your optimism is your greatest strength.",
        "New beginnings bring extraordinary blessings.",
        "Your courage will open doors to success."
    ]
    
    AFFIRMATIONS = [
        "I am capable of achieving great things.",
        "I choose hope over fear.",
        "I attract positive energy and good fortune.",
        "I am worthy of success and happiness.",
        "I embrace new opportunities with confidence.",
        "I am grateful for all the blessings in my life.",
        "I trust in the journey ahead.",
        "I am creating my own fortunate future.",
        "I radiate positivity and hope.",
        "I am resilient and strong."
    ]
    
    def get_fortune(self):
        """Get a random fortune message."""
        return random.choice(self.FORTUNES)
    
    def get_affirmation(self):
        """Get a random affirmation."""
        return random.choice(self.AFFIRMATIONS)
    
    def get_daily_message(self):
        """Get a complete daily hopeful message."""
        fortune = self.get_fortune()
        affirmation = self.get_affirmation()
        date_str = datetime.now().strftime("%B %d, %Y")
        
        message = f"""
╔════════════════════════════════════════════════════════════╗
║         🌟  HOPEFUL FORTUNE FOR {date_str}  🌟         ║
╚════════════════════════════════════════════════════════════╝

🔮 Your Fortune:
   {fortune}

💫 Today's Affirmation:
   {affirmation}

✨ Remember: Every day is a new opportunity for hope and growth!
"""
        return message
