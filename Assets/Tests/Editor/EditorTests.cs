using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditorTests
{



    [Test]
    [Category("Fast")]
    public void Fast_EditModeTest()
    {
        Console.WriteLine("Hello world, from fast test!");
        var a = 2;
        var b = 2;
        var c = a + b;
        Assert.AreEqual(expected: 4, actual: c);
    }

    [Test]
    [Category("Slow")]
    public void Slow_EditModeTest()
    {
        Console.WriteLine("Hello world, from slow test!");
        var a = 2;
        var b = 2;
        var c = a + b;
        Assert.AreEqual(expected: 4, actual: c);
    }


    [Test]
    [Category("Slow"), Category("MX908")]
    public void Slow_MX908_EditModeTest()
    {
        Console.WriteLine("Hello world, from slow test!");
        var a = 2;
        var b = 2;
        var c = a + b;
        Assert.AreEqual(expected: 4, actual: c);
    }

    [Test]
    [Category("Fast"), Category("MX908")]
    public void Fast_MX908_EditModeTest()
    {
        Console.WriteLine("Hello world, from slow test!");
        var a = 2;
        var b = 2;
        var c = a + b;
        Assert.AreEqual(expected: 4, actual: c);
    }

}
