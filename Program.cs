using ConsoleApp8;


CustomList<int> list = new CustomList<int>();



list.AddLast(1);
list.AddLast(234);
list.AddLast(634);
list.AddAt(2, 5);
list.AddLast(514);
list.AddLast(-31);
CustomStack<int> stack = new CustomStack<int>(list.count);
Console.WriteLine("List: ");
for(int i = 0; i < list.count; i ++)
{
    Console.WriteLine(list.GetAt(i));
}
NumManager.MoveNumbers(ref list, ref stack);
Console.WriteLine("\n Stack: ");
while(stack.count > 0)
{
    Console.WriteLine(stack.Pop());
}





