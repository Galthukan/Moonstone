using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEngine;

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
        
        [Test]
        public void TestPlayerHealthBelowZero()
        {
            var testObj = new GameObject();
            var myComponent = testObj.AddComponent(typeof(PlayerHandler)) as PlayerHandler;
            
            myComponent.PlayerHealth.Damage(101);

            Assert.AreEqual(0, myComponent.PlayerHealth.Health);
            TestContext.WriteLine("Health: " + myComponent.PlayerHealth.Health);
        }
    }
}