/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // Check if current position exists and left movement is allowed
        if (!_mazeMap.ContainsKey((_currX, _currY)) || !_mazeMap[(_currX, _currY)][0])
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Check if moving left would go outside the maze boundaries
        if (_currX - 1 < 1)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        _currX--;
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // Check if current position exists and right movement is allowed
        if (!_mazeMap.ContainsKey((_currX, _currY)) || !_mazeMap[(_currX, _currY)][1])
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Check if moving right would go outside the maze boundaries
        if (_currX + 1 > 6)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        _currX++;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // Check if current position exists and up movement is allowed
        if (!_mazeMap.ContainsKey((_currX, _currY)) || !_mazeMap[(_currX, _currY)][2])
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Check if moving up would go outside the maze boundaries
        if (_currY - 1 < 1)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        _currY--;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // Check if current position exists and down movement is allowed
        if (!_mazeMap.ContainsKey((_currX, _currY)) || !_mazeMap[(_currX, _currY)][3])
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Check if moving down would go outside the maze boundaries
        if (_currY + 1 > 6)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        _currY++;
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}