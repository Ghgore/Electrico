namespace Nodes;

public interface INode {
    INode? LogicalNext();

    INode? LogicalPrev();

    
}