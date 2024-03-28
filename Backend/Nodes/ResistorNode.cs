namespace Nodes;

public class ResistorNode : INode {
    public double Resistance { get; set; }
    public int[] Coords { get; set; }

    public INode? Prev { get; set; }

    public INode? Next { get; set; }

    public ResistorNode(double resistance, int[] coords) {
        Resistance = resistance;
        Coords = coords;
    }

    public INode? LogicalPrev() {
        return Prev ?? null;
    }

    public INode? LogicalNext() {
        return Next ?? null;
    }
}