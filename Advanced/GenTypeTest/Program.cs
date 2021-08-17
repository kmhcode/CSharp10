using static Support;

var a = new SimpleStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
PopPrint(a);
var b = new SimpleStack<Interval>();
b.Push(new Interval(3, 41));
b.Push(new Interval(5, 32));
b.Push(new Interval(8, 23));
b.Push(new Interval(6, 14));
PopPrint(b);

