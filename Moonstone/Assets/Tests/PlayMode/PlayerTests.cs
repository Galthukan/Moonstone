using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode
{
    public class PlayerTests
    {
        [Test]
        public void TestPlayerTakingDamage()
        {
            var testObj = new GameObject();
            var myComponent = testObj.AddComponent(typeof(PlayerHandler)) as PlayerHandler;
            
            myComponent.PlayerHealth.Damage(1);

            Assert.AreEqual(99, myComponent.PlayerHealth.Health);
        }
    }
}