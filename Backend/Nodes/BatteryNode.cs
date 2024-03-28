namespace Nodes;

public class BatteryNode : INode {
    public double Voltage { get; set; }

    public int[] Coords { get; set; }

    public INode? Prev { get; set; }

    public INode? Next { get; set; }

    public BatteryNode(double voltage, int[] coords) {
        Voltage = voltage;
        Coords = coords;
    }

    public INode? LogicalPrev() {
        return Prev ?? null;
    }

    public INode? LogicalNext() {
        return Next ?? null;
    }
}