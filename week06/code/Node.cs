public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1: Only insert unique values
        if (value == Data)
        {
            return; // Do not insert duplicates
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Problem 2: Recursive search in BST
        if (value == Data)
            return true;
        if (value < Data)
            return Left is not null && Left.Contains(value);
        else
            return Right is not null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // Problem 4: Height of tree = 1 + max(height(left), height(right))
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}