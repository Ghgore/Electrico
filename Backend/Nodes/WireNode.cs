namespace Nodes;

public class WireNode : INode {
    public double Resistance { get; set; }

    public int[] StartCoords { get; set; }

    public int[] FinishCoords { get; set; }

    public INode? Prev { get; set; }

    public INode? Next { get; set; }

    public WireNode(double resistance, int[] startCoords, int[] finishCoords, INode prev, INode next) {
        Resistance = resistance;
        StartCoords = startCoords;
        FinishCoords = finishCoords;
        Prev = prev;
        Next = next;
    }

    public INode? LogicalPrev() {
        return Prev ?? null;
    }

    public INode? LogicalNext() {
        return Next ?? null;
    }
}