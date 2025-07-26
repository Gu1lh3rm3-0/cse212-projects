using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priority1 = new PriorityItem("60", 6);
        var priority2 = new PriorityItem("40", 4);
        var priority3 = new PriorityItem("20", 2);

        PriorityItem[] priorities = [priority1, priority2, priority3];

        var _newQueue = new PriorityQueue();
        _newQueue.Enqueue(priority1.Value, priority1.Priority);
        _newQueue.Enqueue(priority2.Value, priority2.Priority);
        _newQueue.Enqueue(priority3.Value, priority3.Priority);

        int i = 0;

        if (priorities.Contains(priority1) && priorities.Contains(priority2) && priorities.Contains(priority3))
        {
            Assert.AreEqual(priorities[i].Value, priority1.Value);
        }

    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown. 
    // Expected Result: "No one in the queue."
    // Defect(s) Found: No defects found
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }

        catch (InvalidOperationException e)
        {
            Assert.AreEqual("No one in the queue.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}