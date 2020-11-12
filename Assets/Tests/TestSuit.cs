using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestSuit {

    [Test]
    public void GameObjectTest()
    {
        //Arrange
        var gameObject = new GameObject();
 
        //Act
        //Try to rename the GameObject
        var newGameObjectName = "My game object";
        gameObject.name = newGameObjectName;
 
        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, gameObject.name);
    }

    [Test]
    public void CatchingErrors()
    {

    GameObject gameObject = new GameObject("test");

    Assert.Throws<MissingComponentException>(
        () => gameObject.GetComponent<Rigidbody>().velocity = Vector3.one);
    }

    [Test]
    public void LogAssertTest()
    {
    //Expect a regular log message
    LogAssert.Expect(LogType.Log, "Log message");
    //A log message is expected so without the following line
    //the test would fail
    Debug.Log("Log message");
    //An error log is printed
    Debug.LogError("Error message");
    //Without expecting an error log, the test would fail
    LogAssert.Expect(LogType.Error, "Error message");
    }
    
    [Test]
    [UnityPlatform (RuntimePlatform.WindowsEditor)]
    public void RuntimePlatformTest()
    {
    Assert.AreEqual(Application.platform, RuntimePlatform.WindowsEditor);
    }
}
