using System.Xml.Schema;
using static System.Console;
class Program
{
    ConsoleColor FG_DEFAULT_COLOR = ConsoleColor.White;
    ConsoleColor BG_DEFAULT_COLOR = ConsoleColor.Black;

    ConsoleColor FG_NARRATOR_COLOR = ConsoleColor.White;
    ConsoleColor BG_NARRATOR_COLOR = ConsoleColor.Black;

    ConsoleColor FG_USER_COLOR = ConsoleColor.Gray;
    ConsoleColor BG_USER_COLOR = ConsoleColor.Black;

    ConsoleColor FG_HIGHLIGHT_COLOR = ConsoleColor.Black;
    ConsoleColor BG_HIGHLIGHT_COLOR = ConsoleColor.White;
    class Inventory
    {
        Item[] slots = new Item[100];
        int max_stack;
        
        Inventory(int _max_stack)
        {
            max_stack = _max_stack;
        }

        int TotalStack()
        {
            int total_stack = 0;
            foreach (Item item in slots)
            {
                total_stack += item.stack;
            }
            return total_stack;
        }
        void addItem(Item item)
        {
            if(TotalStack() + item.stack > max_stack)
            {

            }
        }
    }
    public class Item
    {
        public string name, type;
        public int stack = 1;
        public float fraction = 1, integrity = 1;
        public bool isStack = false;
        public string[] effects;

        Item(string _name, string _type)
        {
            name = _name;
            type = _type;
        }

        Item(string _name, string _type, float _integrity)
        {
            name = _name;
            type = _type;
            integrity = _integrity;
        }

        Item(string _name, string _type, int _stack)
        {
            name = _name;
            type = _type;
            stack = _stack;
            isStack = true;
        }

        Item(string _name, string _type, int _stack, float _fraction)
        {
            name = _name;
            type = _type;
            stack = _stack;
            isStack = true;
            fraction = _fraction;
        }
        
    }
    public class Entity
    {
        string name;
        float hp, mp, xp;
        int lvl;
        
        Entity(string _name, float _hp, float _mp, float _xp, int _lvl)
        {
            name = _name;
            hp = _hp;
            mp = _mp;
            xp = _xp;
            lvl = _lvl;
        }

        public void _xp(float _xp)
        {
            xp += _xp;
        }
        public void _lvl(int _lvl)
        {
            lvl += _lvl;
        }
    }
    public static void Main(string[] args)
    {

    }
}
