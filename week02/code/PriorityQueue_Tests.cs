using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue all.
    // Expected Result: Items are dequeued in order of highest to lowest priority.
    // Defect(s) Found: Assert.AreEqual failed. Expected:<C>. Actual:<B>. The queue does not correctly identify the highest priority item; it may be scanning in the wrong direction or not handling priorities properly.
    public void TestPriorityQueue_DequeueHighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);
        Assert.AreEqual("B", pq.Dequeue()); // Highest priority
        Assert.AreEqual("C", pq.Dequeue()); // Next highest
        Assert.AreEqual("A", pq.Dequeue()); // Last
    }

    [TestMethod]
    // Scenario: Enqueue items with the same highest priority, check FIFO order for ties.
    // Expected Result: The first enqueued item with the highest priority is dequeued first.
    // Defect(s) Found: Assert.AreEqual failed. Expected:<B>. Actual:<C>. The queue does not follow FIFO order for items with the same highest priority; it removes the last one instead of the first.
    public void TestPriorityQueue_TieBreakerFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);
        pq.Enqueue("D", 1);
        Assert.AreEqual("B", pq.Dequeue()); // B and C have highest, B first
        Assert.AreEqual("C", pq.Dequeue()); // Then C
        Assert.AreEqual("A", pq.Dequeue()); // Then A
        Assert.AreEqual("D", pq.Dequeue()); // Then D
    }

    [TestMethod]
    // Scenario: Enqueue and dequeue a single item.
    // Expected Result: The single item is returned.
    // Defect(s) Found: 
    public void TestPriorityQueue_SingleItem()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 10);
        Assert.AreEqual("X", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Exception is thrown with the correct message.
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var pq = new PriorityQueue();
        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception: {e.GetType()} {e.Message}");
        }
    }

    // Add more test cases as needed below.
}