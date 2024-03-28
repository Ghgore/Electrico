namespace Nodes;

public class LEDNode : INode {
    public string Color { get; set; }

    public int[] Coords { get; set; }

    public INode? Prev { get; set; }

    public INode? Next { get; set; }

    public LEDNode(string color, int[] coords) {
        Color = color;
        Coords = coords;
    }

    public INode? LogicalPrev() {
        return Prev ?? null;
    }

    public INode? LogicalNext() {
        return Next ?? null;
    }
}