using Nodes;

BatteryNode first = new(9, new int[] {0, 0});
ResistorNode second = new(300, new int[] {1, 0});
LEDNode third = new("White", new int[] {1, 1});
WireNode firstToSecond = new(1, new int[] {0, 0}, new int[] {1, 0}, first, second);
first.Next = firstToSecond;
second.Prev = firstToSecond;
WireNode secondToThird = new(1, second.Coords, third.Coords, second, third);
second.Next = secondToThird;
third.Prev = secondToThird;
WireNode thirdToFirst = new(1, third.Coords, first.Coords, third, first);
third.Next = thirdToFirst;
first.Prev = thirdToFirst;

INode? start = first;
double totalResistance = 0;
for (INode? current = start.LogicalNext(); current != start; current = current.LogicalNext()) {
    if (current is ResistorNode) {
        totalResistance += ((ResistorNode) current).Resistance;
    } else if (current is WireNode) {
        totalResistance += ((WireNode) current).Resistance;
    }
}

Console.WriteLine("Resistance: " + totalResistance);