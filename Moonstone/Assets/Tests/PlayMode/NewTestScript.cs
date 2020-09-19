using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void TestPlayerTakingDamage()
        {
            var testObj = new GameObject();
            var myComponent = testObj.AddComponent(typeof(GameHandler)) as GameHandler;

            // var player = new Player();

            myComponent.PlayerDamage(1);

            Assert.AreEqual(99, myComponent.PlayerHealth());
        }
    }
}
